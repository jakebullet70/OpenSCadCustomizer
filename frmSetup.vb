Imports System.IO
Public Class frmSetup

    Private m_SaveFolder, m_CadFolder, m_SlicerEXE As String

    Private Sub frmSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtSaveFolder.Text = My.Settings.savefolder
        txtCadFolder.Text = My.Settings.scadfolder
        txtSlicerEXE.Text = My.Settings.slicerEXE
        m_CadFolder = txtCadFolder.Text
        m_SaveFolder = txtSaveFolder.Text
        m_SlicerEXE = txtSaveFolder.Text
    End Sub

    Private Sub btnPath2_Click(sender As Object, e As EventArgs) Handles btnPath2.Click

        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = My.Settings.savefolder
        If Directory.Exists(dialog.SelectedPath) = False Then
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        End If
        If DialogResult.OK = dialog.ShowDialog() Then
            txtSaveFolder.Text = dialog.SelectedPath
            m_SaveFolder = txtSaveFolder.Text
        End If

    End Sub

    Private Sub btnPathSCad_Click(sender As Object, e As EventArgs) Handles btnPathSCad.Click

        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = My.Settings.scadfolder
        If Directory.Exists(dialog.SelectedPath) = False Then
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        End If
        If DialogResult.OK = dialog.ShowDialog() Then
            txtCadFolder.Text = dialog.SelectedPath
            m_CadFolder = txtCadFolder.Text
        End If

    End Sub

    Private Sub btnPathSlicer_Click(sender As Object, e As EventArgs) Handles btnPathSlicer.Click

        Using fold As New OpenFileDialog
            fold.Filter = "exe files (*.exe)|*.exe"
            fold.Title = "Select Slicer exe file"
            If fold.ShowDialog() = Windows.Forms.DialogResult.OK Then
                fold.RestoreDirectory = True
                txtSlicerEXE.Text = fold.FileName
                m_SlicerEXE = txtSlicerEXE.Text
            End If
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.savefolder = m_SaveFolder
        My.Settings.slicerEXE = m_SlicerEXE
        My.Settings.scadfolder = m_CadFolder
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        misc.OpenUrlLink("https://openscad.org/downloads.html")
    End Sub

    Private Sub txtCadFolder_Leave(sender As Object, e As EventArgs) Handles txtCadFolder.Leave
        m_CadFolder = txtCadFolder.Text
    End Sub

    Private Sub txtSaveFolder_Leave(sender As Object, e As EventArgs) Handles txtSaveFolder.Leave
        m_SaveFolder = txtSaveFolder.Text
    End Sub

    Private Sub txtSlicerEXE_Leave(sender As Object, e As EventArgs) Handles txtSlicerEXE.Leave
        m_SlicerEXE = txtSlicerEXE.Text
    End Sub
End Class