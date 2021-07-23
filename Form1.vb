Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '原檔案名稱範例: 01000036.img.xml
        Dim FoundFilePath As String = T1.Text ' 輸入需要搜尋檔案名稱的母資料夾
        Dim textwrite As String = t2.Text '需要寫入的txt檔案
        Dim DirInfo As IO.DirectoryInfo 'FileIO 需要使用、用於列舉檔案與資料夾
        Dim short1, fuckyoujustprint
        DirInfo = New IO.DirectoryInfo(FoundFilePath) 'IO 指定位置
        For Each file In DirInfo.GetFiles("*.xml", IO.SearchOption.AllDirectories) '*.xml 指搜尋副檔名為.xml檔案 可自行更改附檔名
            short1 = Split(file.Name, ".img.xml") '上列程式碼執行完會出現檔名與副檔名，這裡採用字串方式分割了".img.xml"文字
            fuckyoujustprint = Strings.Right(short1(0), 7) 'split後會產生陣列，1為上述".img.xml"，0則是分割出來的其他字串
            '此處需求為從右方數7文字 輸出 "1000036"
            fuckyoujustprint = fuckyoujustprint & vbCrLf
            My.Computer.FileSystem.WriteAllText(
                textwrite, fuckyoujustprint, True)
        Next file
        MsgBox("done")
    End Sub
End Class
