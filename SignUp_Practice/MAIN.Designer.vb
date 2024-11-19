<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN
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
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(62, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1100, 624)
        Panel1.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrchid
        Button2.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(39, 479)
        Button2.Name = "Button2"
        Button2.Size = New Size(329, 43)
        Button2.TabIndex = 9
        Button2.Text = "SIGN OUT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' MAIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrchid
        BackgroundImage = My.Resources.Resources.porpol
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1414, 825)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MAIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main_Menu"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
