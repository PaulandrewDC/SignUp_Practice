Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class SIGNUP
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_pass.PasswordChar = "*"
        TextBox_confirmpass.PasswordChar = "*"
    End Sub


    Private Sub Button_SignUp(sender As Object, e As EventArgs) Handles Button2.Click

        If String.IsNullOrWhiteSpace(TextBox_fname.Text) Or
           String.IsNullOrWhiteSpace(TextBox_lname.Text) Or
           String.IsNullOrWhiteSpace(TextBox_emailadd.Text) Or
           String.IsNullOrWhiteSpace(TextBox_pass.Text) Or
           String.IsNullOrWhiteSpace(TextBox_confirmpass.Text) Then
            MessageBox.Show("All fields are required. Please complete the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            If TextBox_pass.Text <> TextBox_confirmpass.Text Then
                MsgBox("Password does not match")
                Exit Sub
            End If


            MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=finalprojectdb"
        Dim READER As MySqlDataReader



        MySqlConn.Open()
            Dim Query As String
            Query = "insert into finalprojectdb.account_details (First_Name, Last_Name, Email, Password) values ('" & TextBox_fname.Text & "', '" & TextBox_lname.Text & "', '" & TextBox_emailadd.Text & "', '" & TextBox_pass.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader


            MessageBox.Show("Data Saved")
            MySqlConn.Close()
            Dim login As New LOGIN
            login.Show()
            Me.Hide()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim login As New LOGIN

        login.Show()
        Me.Hide()
        Me.Close()


    End Sub

    Private Sub CB_pass_CheckedChanged(sender As Object, e As EventArgs) Handles CB_pass.CheckedChanged
        If CB_pass.Checked Then
            TextBox_pass.PasswordChar = ""
        Else
            TextBox_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub CB_confirmpass_CheckedChanged(sender As Object, e As EventArgs) Handles CB_confirmpass.CheckedChanged
        If CB_confirmpass.Checked Then
            TextBox_confirmpass.PasswordChar = ""
        Else
            TextBox_confirmpass.PasswordChar = "*"

        End If
    End Sub
End Class