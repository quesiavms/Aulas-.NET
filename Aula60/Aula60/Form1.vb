Public Class Form1
    Private Sub btn_texto_Click(sender As Object, e As EventArgs) Handles btn_texto.Click
        String txt;
        txt = tb_texto.Text;
        lb_texto.Text = txt;
    End Sub
End Class
