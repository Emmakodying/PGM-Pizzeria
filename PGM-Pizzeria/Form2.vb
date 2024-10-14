Public Class Form2
    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click

        If (TextBoxusername.Text = "Manager" And TextBoxpassword.Text = "Manager123") Then

            Labelusername.Hide()
            TextBoxusername.Hide()
            Labelpassword.Hide()
            TextBoxpassword.Hide()
            Labeltotalsale.Show()
            TextBoxtotalsale.Show()
            TextBoxtotalsale.Text = FormatCurrency(Form1.totalsale)
            Buttonlogin.Hide()

        End If


    End Sub
End Class