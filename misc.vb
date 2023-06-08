Imports System.IO
Imports System.Reflection
Imports System.Security.Policy

Module misc

    Public Sub FirstRun()
        '--- make sure we have a save to path
        If String.IsNullOrEmpty(My.Settings.savefolder) Then
            My.Settings.savefolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            My.Settings.Save()
        End If
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
            .Arguments = Chr(34) & Model & Chr(34),
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal,
            .WorkingDirectory = Chr(34) & CadPath & Chr(34)
        }

        prg.StartInfo = prginfo
        prg.Start()

    End Sub


    Public Sub OpenInSlicer(ByVal modelSTL As String)

        If Not File.Exists(modelSTL) Then
            MsgBox("Whoops! STL file does not exist.")
            Return
        End If

        Dim prg As New Process
        Dim prginfo As New ProcessStartInfo With {
            .FileName = Chr(34) & My.Settings.slicerEXE & Chr(34),
            .Arguments = Chr(34) & modelSTL & Chr(34),
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }

        prg.StartInfo = prginfo
        prg.Start()

    End Sub

End Module





