Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FoundFilePath As String = T1.Text
        Dim textwrite As String = t2.Text
        Dim DirInfo As IO.DirectoryInfo
        Dim short1, fuckyoujustprint
        DirInfo = New IO.DirectoryInfo(FoundFilePath)
        For Each file In DirInfo.GetFiles("*.xml", IO.SearchOption.AllDirectories)
            short1 = Split(file.Name, ".img.xml")
            fuckyoujustprint = Strings.Right(short1(0), 7)
            fuckyoujustprint = fuckyoujustprint & vbCrLf
            My.Computer.FileSystem.WriteAllText(
                textwrite, fuckyoujustprint, True)
        Next file
        MsgBox("done")
    End Sub
End Class
