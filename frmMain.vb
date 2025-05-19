Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class frmMain
    Public Const CAD_FOLDER_NOT_SET As String = "OpenSCAD folder not set, Please run setup."
    Private p_OutPath = ""
    Private p_ModelsPath = ""
    Private p_paramSetName = ""
    Private p_paramSetFile = ""
    Private p_paramSetFileTMP = ""
    Private p_CADfile = ""


    '--- How to write to FreeCAD spreedsheet-param files.
    'https://stackoverflow.com/questions/60687834/how-to-update-spreadsheet-values-using-freecad-python-module
    '---- is this still valid in the new FreeCAD version 1? ******************


    '===========================================================================


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWarning.Visible = False
        misc.FirstRun()

        cboModels.DisplayMember = "Text"
        LoadModels()
        CheckSCadPath()

        chkPrompt.Checked = My.Settings.prompt4savepath
        chkOpen.Checked = My.Settings.openInSlicer
        Me.Text = Me.Text & String.Format("  - V{0}", My.Application.Info.Version.ToString).TrimEnd("0").TrimEnd(".")

    End Sub

    Private Sub CheckSCadPath()
        lblWarning.Visible = String.IsNullOrEmpty(My.Settings.scadfolder)
    End Sub
    Private Sub BuildPropertyGrid()

        DataGridView1.Rows.Clear()
        picBoxStyle.Image = Image.FromFile(Path.Combine(cboModels.SelectedItem.ppath, cboModels.SelectedItem.pfile))
        Dim propFile = Path.Combine(cboModels.SelectedItem.ppath, "properties.txt")
        p_ModelsPath = cboModels.SelectedItem.ppath

        Dim txt = File.ReadAllText(propFile)
        Dim lines() As String = txt.Split(vbCrLf)
        For x As Integer = 0 To lines.Length - 1
            If lines(x).EndsWith("######") Then

                '--- CAD model - set info
                '--- Universal Box,ubox1.scad,ubox1.json,ubox1,ubox1.jpg
                Dim dt() As String = lines(x + 1).Split(",")
                p_CADfile = dt(1)
                p_paramSetFile = dt(2)
                p_paramSetName = dt(3)

                '--- start of data: '!WTHICK!,Wall Thickness,2
                For y As Integer = (x + 2) To lines.Length - 1
                    dt = lines(y).Split(",")
                    If dt.Length < 2 Then Exit For '--- EOF
                    Dim ndx = DataGridView1.Rows.Add()
                    Dim newrow = DataGridView1.Rows(ndx)
                    newrow.Cells(0).Value = dt(0)
                    newrow.Cells(1).Value = dt(1)
                    newrow.Cells(2).Value = dt(2)
                Next

            End If

        Next

    End Sub

    Private Sub cboModels_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboModels.SelectedValueChanged
        BuildPropertyGrid()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim SetSavePath As Boolean = False

        If Directory.Exists(My.Settings.scadfolder) = False Then
            MsgBox(CAD_FOLDER_NOT_SET)
            Return
        End If

        '--- files and paths
        p_OutPath = My.Settings.savefolder
        If Not Directory.Exists(p_OutPath) Then
            SetSavePath = True
        End If

        '--- substitute the properties
        Dim txt = ReplaceVars(File.ReadAllText(Path.Combine(p_ModelsPath, p_paramSetFile)))

        Dim stlfile As String = Path.Combine(p_OutPath, p_CADfile.Replace(".scad", ".stl"))
        If chkPrompt.Checked Or SetSavePath = True Then
            Dim dialog = New FolderBrowserDialog()
            dialog.SelectedPath = My.Settings.savefolder
            If DialogResult.OK = dialog.ShowDialog() Then
                stlfile = Path.Combine(dialog.SelectedPath, Path.GetFileName(stlfile))
                My.Settings.savefolder = dialog.SelectedPath
                My.Settings.Save()
            Else
                Return
            End If
        End If

        '--- JSON file with updated properties
        Dim newParamOutFile = Path.Combine(Path.GetTempPath, p_paramSetFile)
        misc.SafeKill(newParamOutFile)

        '--- create new JSON param file
        File.WriteAllText(newParamOutFile, txt)

        '--- shell to CAD and let it do the work
        Dim retVal = ShellAndWait(newParamOutFile, stlfile)

        If retVal <> 0 Then
            MsgBox("OOPS! Something went wrong. Exit Code = " & CInt(retVal) & vbCrLf & "A selected path with 'OneDrive' in it has been know to cause issues")
        Else
            If chkOpen.Checked Then
                misc.OpenInSlicer(stlfile)
            Else
                MsgBox("All done! (I hope)" & vbCrLf & stlfile)
            End If

        End If

        misc.SafeKill(newParamOutFile)

    End Sub

    Private Function ReplaceVars(txt As String) As String
        Dim findMe, replaceMe As String
        For x = 0 To DataGridView1.Rows.Count - 1
            Dim r = DataGridView1.Rows(x)
            findMe = misc.StripAllLineFeedChars(r.Cells(0).Value)
            replaceMe = r.Cells(2).Value
            txt = txt.Replace(findMe, replaceMe)
        Next
        Return txt
    End Function


    Private Function ShellAndWait(ByVal ParamOutfile As String, ByVal stlfile As String) As Boolean

        Dim cadfile As String = Path.Combine(p_ModelsPath, p_CADfile)
        Dim batFile As String = ParamOutfile.Replace(".json", ".bat")

        misc.SafeKill(stlfile)

        '--- The --info param was causing the BAT file to fail.  
        '--- Worked at one time...
        'Dim txt = "openscad.exe " &
        'CStr("--info -o @" & stlfile & "@ -p @" & ParamOutfile & "@ -P " & p_paramSetName & " @" & cadfile & "@").Replace("@", Chr(34))

        Dim txt = "openscad.exe " &
            CStr("-o @" & stlfile & "@ -p @" & ParamOutfile & "@ -P " & p_paramSetName & " @" & cadfile & "@").Replace("@", Chr(34))

        If Debugger.IsAttached OrElse My.Settings.debug Then
            File.WriteAllText(batFile, txt & vbCrLf & "pause")
        Else
            File.WriteAllText(batFile, txt)
        End If

        Dim cad As New Process
        Dim cadinfo As New ProcessStartInfo With {
            .FileName = batFile,
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal,
            .CreateNoWindow = False,
            .WorkingDirectory = My.Settings.scadfolder
        }

        '--- call the CAD executable
        cad.StartInfo = cadinfo
        cad.Start()
        cad.WaitForExit()

        misc.SafeKill(batFile)
        misc.SafeKill(ParamOutfile)
        Return cad.ExitCode

    End Function


    Private Sub LoadModels()

        '--- get model folders and load cbo
        Dim basePath = Path.Combine(Application.StartupPath, "CadModels")
        Dim result = Directory.EnumerateDirectories(basePath, "*", System.IO.SearchOption.AllDirectories)
        For Each p As String In result
            Dim fname = Path.Combine(p, "properties.txt")
            If File.Exists(fname) Then
                Dim s As Tuple(Of String, String, String) = Parse4Cbo(fname)
                cboModels.Items.Add(New With {.Text = s.Item1, .ppath = s.Item2, .pfile = s.Item3})
            End If
        Next
        cboModels.SelectedIndex = 0

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        misc.ShowAboutModel(p_ModelsPath)
    End Sub

    Private Sub btnOpenInCad_Click(sender As Object, e As EventArgs) Handles btnOpenInCad.Click
        misc.OpenInSCAD(Path.Combine(p_ModelsPath, p_CADfile), My.Settings.scadfolder)
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        frmSetup.ShowDialog()
        CheckSCadPath()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAboutBox1.ShowDialog()
    End Sub

    Private Sub chkOpen_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpen.CheckedChanged
        My.Settings.openInSlicer = chkOpen.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkPrompt_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrompt.CheckedChanged
        My.Settings.prompt4savepath = chkPrompt.Checked
        My.Settings.Save()
    End Sub


End Class
