Imports System.IO


'│ Author       : suXjung
'│ Name         : Base64 Converter
'│ Tel          : @sujung02 

'This program Is distributed For educational purposes only.



Public Class Form1
    Dim title As String = "Base64 Converter"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 0.8923165165
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.85
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*"
        OpenFileDialog.FilterIndex = 1
        With OpenFileDialog
            .Title = "Select Exe File | Base64 Converter"
            .ShowDialog()
        End With
        TextBox1.Text = OpenFileDialog.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(Me.TextBox1.Text) Then
            Button3.Enabled = False
            MessageBox.Show("Please select a file", title, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If MessageBox.Show("Reverse String?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                RichTextBox1.Text = StrReverse(Convert.ToBase64String(File.ReadAllBytes(Me.TextBox1.Text)))
            Else
                RichTextBox1.Text = Convert.ToBase64String(File.ReadAllBytes(Me.TextBox1.Text))
            End If
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
        MessageBox.Show("Copied", title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Made by sujung" & vbCrLf & "Tel : @sujung02", title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
