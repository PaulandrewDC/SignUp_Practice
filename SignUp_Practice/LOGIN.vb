Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class LOGIN

    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub TextBox_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Trigger the SignIn button click event when Enter is pressed in the email field
            SignInButton_Click(sender, e)
        End If
    End Sub

    ' This is the key press event handler for the password field
    Private Sub TextBox_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Trigger the SignIn button click event when Enter is pressed in the password field
            SignInButton_Click(sender, e)
        End If
    End Sub


    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles Button_Signin.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=finalprojectdb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from finalprojectdb.account_details where Email='" & TextBox_Email.Text & "' and Password= '" & TextBox_Password.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim main As New MAIN
                main.Show()
                Me.Hide()


            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Incorrect Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim signup As New SIGNUP
        signup.Show()
        Me.Hide()
    End Sub


    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Password.PasswordChar = "*"
    End Sub

    Private Sub CheckBoxShowPassword_ShowPassword(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            TextBox_Password.PasswordChar = ""
        Else
            TextBox_Password.PasswordChar = "*"
        End If
    End Sub


    Private Sub ForgotPass_Click(sender As Object, e As EventArgs) Handles Label4.Click

        ' EMPTY

    End Sub




End Class





' Private Sub Button_SignUp(sender As Object, e As EventArgs) Handles Button2.Click
'    Dim main As New MAIN


'    If TextBox1.Text = Email And TextBox2.Text = Password Then

'        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        main.ShowDialog()
'        Close()
'    Else
'        MessageBox.Show("Incorrect Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    End If
' End Sub

' =============================================================================================================================================



'Private Sub Button_SignUp(sender As Object, e As EventArgs) Handles Button2.Click
'Dim main As New MAIN

' Check if both Email and Password is Empty
'If String.IsNullOrEmpty(TextBox1.Text) And String.IsNullOrEmpty(TextBox2.Text) Then
'MessageBox.Show("Please enter both Email and Password.", "Input Required", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning)

'ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
' If only the Email is empty
'Dim result As DialogResult = MessageBox.Show("Please enter an Email.", "Email Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

' Clear both fields if user clicks "Retry"
'If result = DialogResult.Retry Then
'TextBox1.Clear()
'TextBox2.Clear()
'End If

'ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
' If only the Password is empty
'Dim result As DialogResult = MessageBox.Show("Please enter a Password.", "Password Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

' Clear both fields if user clicks "Retry"
'If result = DialogResult.Retry Then
'TextBox1.Clear()
'TextBox2.Clear()
'End If

'ElseIf TextBox1.Text = Email And TextBox2.Text = Password Then
' If both email and password are correct
'MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'main.ShowDialog()
'Close()

'Else
' If email or password is incorrect
'MessageBox.Show("Incorrect Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
'End If
'End Sub


