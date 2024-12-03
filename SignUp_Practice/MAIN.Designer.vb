Public Class MAIN
    Private activeButton As Button = Nothing
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default panel visibility - hide all panels
        TrackerPanel.Visible = False
        AllocationPanel.Visible = False
        GoalsPanel.Visible = False
        TransparencyPanel.Visible = False

        SetButtonTransparency()
    End Sub

    ' TrackerButton click event
    Private Sub TrackerButton_Click(sender As Object, e As EventArgs) Handles TrackerButton.Click
        ' Hide all panels
        HideAllPanels()

        ' Show the TrackerPanel
        TrackerPanel.Visible = True

        ' Set TrackerButton as the active button
        SetActiveButton(TrackerButton)
    End Sub

    ' AllocationButton click event
    Private Sub AllocationButton_Click(sender As Object, e As EventArgs) Handles AllocationButton.Click
        ' Hide all panels
        HideAllPanels()

        ' Show the AllocationPanel
        AllocationPanel.Visible = True

        ' Set AllocationButton as the active button
        SetActiveButton(AllocationButton)
    End Sub

    ' GoalsButton click event
    Private Sub GoalsButton_Click(sender As Object, e As EventArgs) Handles GoalsButton.Click
        ' Hide all panels
        HideAllPanels()

        ' Show the GoalsPanel
        GoalsPanel.Visible = True

        ' Set GoalsButton as the active button
        SetActiveButton(GoalsButton)
    End Sub

    ' TransparencyButton click event
    Private Sub TransparencyButton_Click(sender As Object, e As EventArgs) Handles TransparencyButton.Click
        ' Hide all panels
        HideAllPanels()

        ' Show the TransparencyPanel
        TransparencyPanel.Visible = True

        ' Set TransparencyButton as the active button
        SetActiveButton(TransparencyButton)
    End Sub

    ' Method to hide all panels
    Private Sub HideAllPanels()
        TrackerPanel.Visible = False
        AllocationPanel.Visible = False
        GoalsPanel.Visible = False
        TransparencyPanel.Visible = False
    End Sub

    ' Method to set the active button and change colors
    Private Sub SetActiveButton(button As Button)
        ' If there is a previous active button, reset its color
        If activeButton IsNot Nothing Then
            activeButton.BackColor = Color.Transparent ' Make background transparent for previous active button
        End If

        ' Set the new active button color
        button.BackColor = Color.LightBlue ' Active button color

        ' Set the new active button reference
        activeButton = button
    End Sub

    ' Method to set all buttons to transparent background
    Private Sub SetButtonTransparency()
        TrackerButton.BackColor = Color.Transparent
        AllocationButton.BackColor = Color.Transparent
        GoalsButton.BackColor = Color.Transparent
        TransparencyButton.BackColor = Color.Transparent
    End Sub

    ' MouseDown event for all buttons to change background color when clicked
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackerButton.MouseDown, AllocationButton.MouseDown, GoalsButton.MouseDown, TransparencyButton.MouseDown
        ' Change the background color on mouse down
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.LightSkyBlue ' Or any color you prefer for clicked state
    End Sub

    ' MouseUp event for all buttons to revert color back after mouse release
    Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackerButton.MouseUp, AllocationButton.MouseUp, GoalsButton.MouseUp, TransparencyButton.MouseUp
        ' If the button is active, keep the active color, else reset to transparent
        Dim button As Button = CType(sender, Button)

        If button IsNot activeButton Then
            button.BackColor = Color.Transparent ' Make background transparent for non-active buttons
        End If
    End Sub

End Class
