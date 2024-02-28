Imports System.IO
Imports System.Reflection
Imports System.Security.Policy

Module misc
    Private Const QUOTE As String = Chr(34)

    Public Sub FirstRun()

        '--- FORCE a the user to pick a output path on 1st run
        '--- This is part of the OneDrive BUG

        '---------------------------------------------------------------------------
        '--- on my machine OneDrive is not installed BUT!!!!
        '--- Environment.SpecialFolder is returning OneDrive paths
        '---------------------------------------------------------------------------

        '--- This workind fine for a long time, One of the Win 10 updates broke it

        ''--- make sure we have a save to path
        'My.Settings.savefolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        'If String.IsNullOrEmpty(My.Settings.savefolder) Then
        '    My.Settings.savefolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        '    My.Settings.Save()
        'End If

    End Sub

    Public Sub SafeKill(fname As String)
        Try
            If File.Exists(fname) Then
                File.Delete(fname)
            End If
        Catch ex As Exception '--- do nothing
        End Try

    End Sub

    Public Function StripAllLineFeedChars(s As String) As String
        Return s.Replace(vbCrLf, "").Replace(vbLf, "").Replace(vbCr, "")
    End Function

    Public Sub ShowAboutModel(ModelsPath As String)

        Dim url As String
        Try
            url = misc.StripAllLineFeedChars(File.ReadAllText(Path.Combine(ModelsPath, "URL.txt")))
        Catch ex As Exception
            MsgBox("Missing or problem with the URL about text file.")
            Return
        End Try

        OpenUrlLink(url)

    End Sub

    Public Sub OpenUrlLink(url As String)

        '--- shell to model URL
        Dim prg As New Process
        Dim prginfo As New ProcessStartInfo With {
            .FileName = url,
            .Arguments = "",
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }

        prg.StartInfo = prginfo
        prg.Start()
    End Sub


    Public Function Parse4Cbo(f As String) As Tuple(Of String, String, String)
        Dim desc = "", fpath = "", picFile = ""
        Dim txt = File.ReadAllText(f)
        Dim lines() As String = txt.Split(vbCrLf)
        For x As Integer = 0 To lines.Length - 1
            If lines(x).EndsWith("######") Then
                '--- start of data: 'Simple Box,sbox1.scad,sbox1.json,sbox1,sbox1.jpg
                Dim dt() As String = lines(x + 1).Split(",")
                desc = misc.StripAllLineFeedChars(dt(0))
                fpath = Path.GetDirectoryName(f)
                picFile = dt(4)
                Exit For
            End If
        Next
        Return New Tuple(Of String, String, String)(desc, fpath, picFile)
    End Function


    Public Sub OpenInSCAD(Model As String, CadPath As String)

        If String.IsNullOrEmpty(My.Settings.scadfolder) Then
            MsgBox(frmMain.CAD_FOLDER_NOT_SET)
            Return
        End If

        Dim prg As New Process
        Dim prginfo As New ProcessStartInfo With {
            .FileName = "openscad.exe",
            .Arguments = "--autocenter --viewall " & QUOTE & Model & QUOTE,
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal,
            .WorkingDirectory = CadPath
        }

        prg.StartInfo = prginfo
        prg.Start()

    End Sub


    Public Sub OpenInSlicer(ByVal modelSTL As String)

        If Not File.Exists(modelSTL) Then
            MsgBox("Whoops! STL file does not exist." & vbCrLf & "Try again using 'Prompt for save path'")
            Return
        End If

        If String.IsNullOrEmpty(My.Settings.slicerEXE) Then
            MsgBox("Slicer path / exe not set. Please run setup.")
            Return
        End If

        Dim prg As New Process
        Dim prginfo As New ProcessStartInfo With {
            .FileName = QUOTE & My.Settings.slicerEXE & QUOTE,
            .Arguments = QUOTE & modelSTL & QUOTE,
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }

        prg.StartInfo = prginfo
        prg.Start()

    End Sub

End Module





