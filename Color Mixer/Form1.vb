Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "RED" Then
            Label1.Text = ("RED")
            Label1.ForeColor = Color.Red
            PictureBox1.BackColor = Color.Red
        ElseIf ComboBox1.SelectedItem = "GREEN" Then
            Label1.Text = ("GREEN")
            Label1.ForeColor = Color.Green
            PictureBox1.BackColor = Color.Green
        ElseIf ComboBox1.SelectedItem = "BLUE" Then
            Label1.Text = ("RED")
            Label1.ForeColor = Color.Blue
            PictureBox1.BackColor = Color.Blue
        ElseIf ComboBox1.SelectedItem = "NOTHING" Then
            Label1.Text = ("NOTHING")
            Label1.ForeColor = Color.SaddleBrown
            PictureBox1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "RED" Then
            Label3.Text = ("RED")
            Label3.ForeColor = Color.Red
            PictureBox3.BackColor = Color.Red
        ElseIf ComboBox2.SelectedItem = "GREEN" Then
            Label3.Text = ("GREEN")
            Label3.ForeColor = Color.Green
            PictureBox3.BackColor = Color.Green
        ElseIf ComboBox2.SelectedItem = "BLUE" Then
            Label3.Text = ("BLUE")
            Label3.ForeColor = Color.Blue
            PictureBox3.BackColor = Color.Blue
        ElseIf ComboBox2.SelectedItem = "NOTHING" Then
            Label3.Text = ("NOTHING")
            Label3.ForeColor = Color.SaddleBrown
            PictureBox3.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.Text = "RED" And ComboBox2.Text = "BLUE") Or
           (ComboBox1.Text = "BLUE" And ComboBox2.Text = "RED") Then
            PictureBox2.BackColor = Color.Magenta
        ElseIf (ComboBox1.Text = "BLUE" And ComboBox2.Text = "GREEN") Or
                (ComboBox1.Text = "GREEN" And ComboBox2.Text = "BLUE") Then
            PictureBox2.BackColor = Color.Turquoise
        ElseIf (ComboBox1.Text = "GREEN" And ComboBox2.Text = "RED") Or
                (ComboBox1.Text = "RED" And ComboBox2.Text = "GREEN") Then
            PictureBox2.BackColor = Color.Yellow
        ElseIf (ComboBox1.Text = "RED" And ComboBox2.Text = "RED") Then
            PictureBox2.BackColor = Color.Red
        ElseIf (ComboBox1.Text = "GREEN" And ComboBox2.Text = "GREEN") Then
            PictureBox2.BackColor = Color.Green
        ElseIf (ComboBox1.Text = "BLUE" And ComboBox2.Text = "BLUE") Then
            PictureBox2.BackColor = Color.Blue
        ElseIf (ComboBox1.Text = "GREEN" And ComboBox2.SelectedItem = "NOTHING") Or
                (ComboBox1.SelectedItem = "NOTHING" And ComboBox2.Text = "GREEN") Then
            PictureBox2.BackColor = Color.Green
        ElseIf (ComboBox1.Text = "RED" And ComboBox2.SelectedItem = "NOTHING") Or
                (ComboBox1.SelectedItem = "NOTHING" And ComboBox2.Text = "RED") Then
            PictureBox2.BackColor = Color.Red
        ElseIf (ComboBox1.Text = "BLUE" And ComboBox2.SelectedItem = "NOTHING") Or
                (ComboBox1.SelectedItem = "NOTHING" And ComboBox2.Text = "BLUE") Then
            PictureBox2.BackColor = Color.Blue
        ElseIf (ComboBox1.SelectedItem = "NOTHING" And ComboBox2.SelectedItem = "NOTHING") Then
            PictureBox2.BackColor = Color.Transparent
        End If
    End Sub
End Class
