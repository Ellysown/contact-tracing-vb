Public Class form1
    Private Sub sub1_Click(sender As Object, e As EventArgs) Handles sub1.Click
        Dim personName As System.IO.StreamWriter
        personName = My.Computer.FileSystem.OpenTextFileWriter("D:\School chuchu\ELECS 3\RegisteredPerson.txt", True)
        personName.WriteLine(namebx.Text)

    End Sub
End Class
