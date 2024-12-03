<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        CB_confirmpass = New CheckBox()
        CB_pass = New CheckBox()
        Label10 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        TextBox_fname = New TextBox()
        TextBox_lname = New TextBox()
        TextBox_pass = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        TextBox_emailadd = New TextBox()
        TextBox_confirmpass = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.Controls.Add(CB_confirmpass)
        Panel1.Controls.Add(CB_pass)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox_fname)
        Panel1.Controls.Add(TextBox_lname)
        Panel1.Controls.Add(TextBox_pass)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox_emailadd)
        Panel1.Controls.Add(TextBox_confirmpass)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(251, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 624)
        Panel1.TabIndex = 11
        ' 
        ' CB_confirmpass
        ' 
        CB_confirmpass.AutoSize = True
        CB_confirmpass.Location = New Point(39, 470)
        CB_confirmpass.Name = "CB_confirmpass"
        CB_confirmpass.Size = New Size(108, 19)
        CB_confirmpass.TabIndex = 20
        CB_confirmpass.Text = "Show Password"
        CB_confirmpass.UseVisualStyleBackColor = True
        ' 
        ' CB_pass
        ' 
        CB_pass.AutoSize = True
        CB_pass.Location = New Point(39, 393)
        CB_pass.Name = "CB_pass"
        CB_pass.Size = New Size(108, 19)
        CB_pass.TabIndex = 19
        CB_pass.Text = "Show Password"
        CB_pass.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(39, 201)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 16)
        Label10.TabIndex = 18
        Label10.Text = "Last Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(39, 131)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 16)
        Label9.TabIndex = 17
        Label9.Text = "First Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 341)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 16)
        Label4.TabIndex = 16
        Label4.Text = "Password"
        ' 
        ' TextBox_fname
        ' 
        TextBox_fname.BackColor = Color.White
        TextBox_fname.Font = New Font("Arial Narrow", 15F)
        TextBox_fname.Location = New Point(39, 150)
        TextBox_fname.Name = "TextBox_fname"
        TextBox_fname.Size = New Size(329, 30)
        TextBox_fname.TabIndex = 15
        ' 
        ' TextBox_lname
        ' 
        TextBox_lname.BackColor = Color.White
        TextBox_lname.Font = New Font("Arial Narrow", 15F)
        TextBox_lname.Location = New Point(39, 220)
        TextBox_lname.Name = "TextBox_lname"
        TextBox_lname.Size = New Size(323, 30)
        TextBox_lname.TabIndex = 14
        ' 
        ' TextBox_pass
        ' 
        TextBox_pass.BackColor = Color.White
        TextBox_pass.Font = New Font("Arial Narrow", 15F)
        TextBox_pass.Location = New Point(39, 360)
        TextBox_pass.Name = "TextBox_pass"
        TextBox_pass.Size = New Size(329, 30)
        TextBox_pass.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(77, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 20)
        Label6.TabIndex = 12
        Label6.Text = "Enter your details to create account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 27.75F, FontStyle.Bold)
        Label1.Location = New Point(102, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 52)
        Label1.TabIndex = 1
        Label1.Text = "SIGN UP"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(39, 495)
        Button2.Name = "Button2"
        Button2.Size = New Size(329, 43)
        Button2.TabIndex = 8
        Button2.Text = "SIGN UP"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 16)
        Label2.TabIndex = 2
        Label2.Text = "Email Address"
        ' 
        ' TextBox_emailadd
        ' 
        TextBox_emailadd.BackColor = Color.White
        TextBox_emailadd.Font = New Font("Arial Narrow", 15F)
        TextBox_emailadd.ForeColor = SystemColors.WindowText
        TextBox_emailadd.Location = New Point(39, 290)
        TextBox_emailadd.Name = "TextBox_emailadd"
        TextBox_emailadd.Size = New Size(329, 30)
        TextBox_emailadd.TabIndex = 4
        ' 
        ' TextBox_confirmpass
        ' 
        TextBox_confirmpass.BackColor = Color.White
        TextBox_confirmpass.Font = New Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_confirmpass.Location = New Point(39, 439)
        TextBox_confirmpass.Name = "TextBox_confirmpass"
        TextBox_confirmpass.Size = New Size(329, 30)
        TextBox_confirmpass.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 420)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 16)
        Label3.TabIndex = 5
        Label3.Text = "Confirm Password"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(653, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(331, 624)
        Panel2.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_no_bg
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(104, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 114)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gainsboro
        Button3.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.SteelBlue
        Button3.Location = New Point(24, 344)
        Button3.Name = "Button3"
        Button3.Size = New Size(285, 43)
        Button3.TabIndex = 17
        Button3.Text = "LOGIN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Gainsboro
        Label7.Location = New Point(46, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(244, 52)
        Label7.TabIndex = 15
        Label7.Text = "WELCOME!"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Gainsboro
        Label8.Location = New Point(78, 272)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 21)
        Label8.TabIndex = 14
        Label8.Text = "Already have a account?"
        ' 
        ' SIGNUP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.GhostWhite
        BackgroundImage = My.Resources.Resources.abstract_textured_backgound
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1235, 695)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SIGNUP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign up"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_emailadd As TextBox
    Friend WithEvents TextBox_confirmpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox_fname As TextBox
    Friend WithEvents TextBox_lname As TextBox
    Friend WithEvents TextBox_pass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_confirmpass As CheckBox
    Friend WithEvents CB_pass As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
