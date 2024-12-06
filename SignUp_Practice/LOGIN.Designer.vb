<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Email = New TextBox()
        Label3 = New Label()
        TextBox_Password = New TextBox()
        Button_Signin = New Button()
        CheckBox1 = New CheckBox()
        Panel1 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 52)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 16)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' TextBox_Email
        ' 
        TextBox_Email.Font = New Font("Arial Narrow", 15.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Email.Location = New Point(39, 194)
        TextBox_Email.Name = "TextBox_Email"
        TextBox_Email.Size = New Size(329, 30)
        TextBox_Email.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 16)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.BackColor = Color.White
        TextBox_Password.Font = New Font("Arial Narrow", 15.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Password.Location = New Point(39, 275)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.Size = New Size(329, 30)
        TextBox_Password.TabIndex = 6
        ' 
        ' Button_Signin
        ' 
        Button_Signin.BackColor = Color.SteelBlue
        Button_Signin.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Signin.ForeColor = Color.Transparent
        Button_Signin.Location = New Point(39, 479)
        Button_Signin.Name = "Button_Signin"
        Button_Signin.Size = New Size(329, 43)
        Button_Signin.TabIndex = 8
        Button_Signin.Text = "SIGN IN"
        Button_Signin.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(39, 311)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button_Signin)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox_Email)
        Panel1.Controls.Add(TextBox_Password)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(251, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 624)
        Panel1.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(91, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(226, 17)
        Label6.TabIndex = 12
        Label6.Text = "Sign in with your email and password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(39, 525)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 10
        Label4.Text = "Forgot password?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(653, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(331, 624)
        Panel2.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_no_bg
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(98, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 144)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gainsboro
        Button3.Font = New Font("Arial Black", 12.0F, FontStyle.Bold)
        Button3.ForeColor = Color.SteelBlue
        Button3.Location = New Point(24, 344)
        Button3.Name = "Button3"
        Button3.Size = New Size(285, 43)
        Button3.TabIndex = 14
        Button3.Text = "CREATE ACCOUNT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Gainsboro
        Label8.Location = New Point(60, 275)
        Label8.Name = "Label8"
        Label8.Size = New Size(209, 21)
        Label8.TabIndex = 13
        Label8.Text = "Create your account for free!"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Gainsboro
        Label7.Location = New Point(46, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(244, 52)
        Label7.TabIndex = 1
        Label7.Text = "WELCOME!"
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        BackgroundImage = My.Resources.Resources.abstract_textured_backgound
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1235, 695)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LOGIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button_Signin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
