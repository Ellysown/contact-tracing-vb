Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class form1
    Dim cameradisplay As VideoCaptureDevice
    Dim cam As Bitmap
    Private Sub sub1_Click(sender As Object, e As EventArgs) Handles sub1.Click
        Dim personName As System.IO.StreamWriter
        Dim fullname As String = namebx.Text
        If System.IO.File.Exists("D:\School chuchu\ELECS 3\" + fullname + ".txt") Then
            System.IO.File.Delete("D:\School chuchu\ELECS 3\" + fullname + ".txt")
        End If
        personName = My.Computer.FileSystem.OpenTextFileWriter("D:\School chuchu\ELECS 3\" + fullname + ".txt", True)
        personName.WriteLine("Full Name: " + namebx.Text)
        personName.WriteLine("Contact Number: " + contactbx.Text)
        personName.WriteLine("Address: " + addbx.Text)
        personName.WriteLine("E-Mail Address: " + emailbx.Text)
        personName.WriteLine("Gender: " + genderbx.Text)
        personName.Close()
        MessageBox.Show("Salamat sa pagtangkilik.")

    End Sub

    Private Sub cambtn_Click(sender As Object, e As EventArgs) Handles cambtn.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If camera.ShowDialog() = DialogResult.OK Then
            cameradisplay = camera.VideoDevice
            AddHandler cameradisplay.NewFrame, New NewFrameEventHandler(AddressOf camdisplay)
            cameradisplay.Start()
        End If
    End Sub

    Private Sub camdisplay(sender As Object, eventArgs As NewFrameEventArgs)
        cam = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picbx.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
End Class
