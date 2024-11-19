Public Class MAIN

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Dim login As New LOGIN

            login.Show()
            Me.Hide()
            Me.Close()


        Else

        End If
    End Sub

End Class
