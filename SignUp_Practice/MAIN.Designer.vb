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
        MainPanel = New Panel()
        SidePanel = New Panel()
        NavPanel = New Panel()
        TrackerButton = New Button()
        AllocationButton = New Button()
        GoalsButton = New Button()
        TransparencyButton = New Button()
        LogoPanel = New Panel()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        AllocationPanel = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        GoalsPanel = New Panel()
        TrackerPanel = New Panel()
        Label1 = New Label()
        TransparencyPanel = New Panel()
        Label4 = New Label()
        MainPanel.SuspendLayout()
        SidePanel.SuspendLayout()
        NavPanel.SuspendLayout()
        LogoPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        AllocationPanel.SuspendLayout()
        GoalsPanel.SuspendLayout()
        TrackerPanel.SuspendLayout()
        TransparencyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Lavender
        MainPanel.Controls.Add(SidePanel)
        MainPanel.Location = New Point(62, 36)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1264, 747)
        MainPanel.TabIndex = 11
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.SteelBlue
        SidePanel.Controls.Add(NavPanel)
        SidePanel.Controls.Add(LogoPanel)
        SidePanel.Controls.Add(Button2)
        SidePanel.Location = New Point(0, 0)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(296, 747)
        SidePanel.TabIndex = 10
        ' 
        ' NavPanel
        ' 
        NavPanel.Controls.Add(TrackerButton)
        NavPanel.Controls.Add(AllocationButton)
        NavPanel.Controls.Add(GoalsButton)
        NavPanel.Controls.Add(TransparencyButton)
        NavPanel.Location = New Point(2, 216)
        NavPanel.Name = "NavPanel"
        NavPanel.Size = New Size(294, 288)
        NavPanel.TabIndex = 20
        ' 
        ' TrackerButton
        ' 
        TrackerButton.FlatAppearance.BorderSize = 0
        TrackerButton.FlatStyle = FlatStyle.Flat
        TrackerButton.Location = New Point(0, 0)
        TrackerButton.Name = "TrackerButton"
        TrackerButton.Size = New Size(291, 72)
        TrackerButton.TabIndex = 0
        TrackerButton.Text = "I/E TRACKER"
        TrackerButton.UseVisualStyleBackColor = True
        ' 
        ' AllocationButton
        ' 
        AllocationButton.FlatAppearance.BorderSize = 0
        AllocationButton.FlatStyle = FlatStyle.Flat
        AllocationButton.Location = New Point(0, 71)
        AllocationButton.Name = "AllocationButton"
        AllocationButton.Size = New Size(291, 72)
        AllocationButton.TabIndex = 1
        AllocationButton.Text = "BUDGET ALLOCATION"
        AllocationButton.UseVisualStyleBackColor = True
        ' 
        ' GoalsButton
        ' 
        GoalsButton.FlatAppearance.BorderSize = 0
        GoalsButton.FlatStyle = FlatStyle.Flat
        GoalsButton.Location = New Point(0, 142)
        GoalsButton.Name = "GoalsButton"
        GoalsButton.Size = New Size(291, 72)
        GoalsButton.TabIndex = 2
        GoalsButton.Text = "BUDGET GOALS"
        GoalsButton.UseVisualStyleBackColor = True
        ' 
        ' TransparencyButton
        ' 
        TransparencyButton.FlatAppearance.BorderSize = 0
        TransparencyButton.FlatStyle = FlatStyle.Flat
        TransparencyButton.Location = New Point(0, 213)
        TransparencyButton.Name = "TransparencyButton"
        TransparencyButton.Size = New Size(291, 72)
        TransparencyButton.TabIndex = 3
        TransparencyButton.Text = "TRANSPARENCY"
        TransparencyButton.UseVisualStyleBackColor = True
        ' 
        ' LogoPanel
        ' 
        LogoPanel.Controls.Add(PictureBox1)
        LogoPanel.Location = New Point(0, 0)
        LogoPanel.Name = "LogoPanel"
        LogoPanel.Size = New Size(296, 216)
        LogoPanel.TabIndex = 20
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_no_bg
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(77, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 144)
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gainsboro
        Button2.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.SteelBlue
        Button2.Location = New Point(15, 673)
        Button2.Name = "Button2"
        Button2.Size = New Size(266, 35)
        Button2.TabIndex = 9
        Button2.Text = "SIGN OUT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' AllocationPanel
        ' 
        AllocationPanel.Controls.Add(Label2)
        AllocationPanel.Location = New Point(358, 37)
        AllocationPanel.Name = "AllocationPanel"
        AllocationPanel.Size = New Size(968, 748)
        AllocationPanel.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(347, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 30)
        Label2.TabIndex = 0
        Label2.Text = "allocation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(347, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 30)
        Label3.TabIndex = 0
        Label3.Text = "goals"
        ' 
        ' GoalsPanel
        ' 
        GoalsPanel.Controls.Add(Label3)
        GoalsPanel.Location = New Point(358, 37)
        GoalsPanel.Name = "GoalsPanel"
        GoalsPanel.Size = New Size(968, 748)
        GoalsPanel.TabIndex = 12
        ' 
        ' TrackerPanel
        ' 
        TrackerPanel.Controls.Add(Label1)
        TrackerPanel.Location = New Point(360, 36)
        TrackerPanel.Name = "TrackerPanel"
        TrackerPanel.Size = New Size(968, 748)
        TrackerPanel.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(347, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 30)
        Label1.TabIndex = 0
        Label1.Text = "tracker"
        ' 
        ' TransparencyPanel
        ' 
        TransparencyPanel.Controls.Add(Label4)
        TransparencyPanel.Location = New Point(358, 37)
        TransparencyPanel.Name = "TransparencyPanel"
        TransparencyPanel.Size = New Size(968, 748)
        TransparencyPanel.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(347, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 30)
        Label4.TabIndex = 0
        Label4.Text = "transparency"
        ' 
        ' MAIN
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrchid
        BackgroundImage = My.Resources.Resources.abstract_textured_backgound
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1414, 825)
        Controls.Add(TrackerPanel)
        Controls.Add(AllocationPanel)
        Controls.Add(GoalsPanel)
        Controls.Add(TransparencyPanel)
        Controls.Add(MainPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MAIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main_Menu"
        MainPanel.ResumeLayout(False)
        SidePanel.ResumeLayout(False)
        NavPanel.ResumeLayout(False)
        LogoPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        AllocationPanel.ResumeLayout(False)
        AllocationPanel.PerformLayout()
        GoalsPanel.ResumeLayout(False)
        GoalsPanel.PerformLayout()
        TrackerPanel.ResumeLayout(False)
        TrackerPanel.PerformLayout()
        TransparencyPanel.ResumeLayout(False)
        TransparencyPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents NavPanel As Panel
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents TrackerButton As Button
    Friend WithEvents GoalsButton As Button
    Friend WithEvents AllocationButton As Button
    Friend WithEvents TransparencyButton As Button
    Friend WithEvents AllocationPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GoalsPanel As Panel
    Friend WithEvents TrackerPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TransparencyPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
