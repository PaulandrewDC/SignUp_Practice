Imports System.Windows.Forms.VisualStyles

Public Class MAIN
    Private activeButton As Button = Nothing

    ' Button2 click event (Logout confirmation)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Dim login As New LOGIN
            login.Show()
            Me.Hide()
            Me.Close()
        End If
    End Sub

    ' Form Load event
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
        ' Reset previous active button color
        If activeButton IsNot Nothing Then
            activeButton.BackColor = Color.Transparent
        End If

        ' Set the new active button color
        button.BackColor = Color.LightBlue
        activeButton = button
    End Sub

    ' Method to set all buttons to transparent background
    Private Sub SetButtonTransparency()
        TrackerButton.BackColor = Color.Transparent
        AllocationButton.BackColor = Color.Transparent
        GoalsButton.BackColor = Color.Transparent
        TransparencyButton.BackColor = Color.Transparent
    End Sub

    ' MouseDown event for all buttons
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackerButton.MouseDown, AllocationButton.MouseDown, GoalsButton.MouseDown, TransparencyButton.MouseDown
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.LightSkyBlue ' Clicked state color
    End Sub

    ' MouseUp event for all buttons
    Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackerButton.MouseUp, AllocationButton.MouseUp, GoalsButton.MouseUp, TransparencyButton.MouseUp
        Dim button As Button = CType(sender, Button)

        ' Reset color for non-active buttons
        If button IsNot activeButton Then
            button.BackColor = Color.Transparent
        End If
    End Sub

    ' Transactions logic
    Private Transactions As New List(Of Transaction)()

    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click
        ' Input Validation
        If String.IsNullOrWhiteSpace(txtAmount.Text) OrElse
           Not Decimal.TryParse(txtAmount.Text, Nothing) Then
            MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmbType.SelectedIndex = -1 OrElse cmbCategory.SelectedIndex = -1 OrElse cmbPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select all dropdown fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create and Add Transaction
        Dim newTransaction As New Transaction() With {
            .Amount = Decimal.Parse(txtAmount.Text),
            .TransactionDate = dtpDate.Value,
            .Type = cmbType.SelectedItem.ToString(),
            .Category = cmbCategory.SelectedItem.ToString(),
            .PaymentMethod = cmbPaymentMethod.SelectedItem.ToString()
        }

        Transactions.Add(newTransaction)
        UpdateTransactionGrid()
        ClearInputFields()
    End Sub

    Private Sub UpdateTransactionGrid()
        dgvTransactions.DataSource = Nothing
        dgvTransactions.DataSource = Transactions
    End Sub

    Private Sub ClearInputFields()
        txtAmount.Clear()
        cmbType.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        cmbPaymentMethod.SelectedIndex = -1
        dtpDate.Value = Date.Now
    End Sub

    ' Form Load event to initialize transactions
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTransactions.AutoGenerateColumns = True
        dtpDate.Value = Date.Now
    End Sub
End Class
