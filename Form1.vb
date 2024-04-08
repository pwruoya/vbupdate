Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim list1 As ListViewItem
        list1 = Me.ListView1.Items.Add(Me.TextBox1.Text)
        list1.SubItems.Add(Me.TextBox2.Text)
        list1.SubItems.Add(Me.TextBox3.Text)
        list1.SubItems.Add(Me.TextBox4.Text)
        list1.SubItems.Add(Me.TextBox5.Text)
        clear()
    End Sub
    Public Function clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
End Class
