'Program Name:  
'Designer:      Denis Prokopenko
'
'
'
'

Option Strict On
Public Class frmRecycling

    Const _PricePerPound As Decimal = 0.75D
    Const _CansPerPound As Decimal = 24D

    Private Sub cboSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim intSelect As Integer

        intSelect = Me.cboSelect.SelectedIndex

        Select Case intSelect
            Case 0
                TargetGoal()
            Case 1
                FindAmount()
        End Select
    End Sub

    Private Sub TargetGoal()
        lblTargetGoal.Visible = True
        lblTargetGoal.Text = "Target Goal Amount"
        lblResults.Visible = True
        lblResults.Visible = False
        txtText.Visible = True
        txtText.Clear()
        btnFindTarget.Visible = True
        btnFindAmount.Visible = False
        btnClear.Visible = True

    End Sub

    Private Sub FindAmount()
        lblTargetGoal.Visible = True
        lblTargetGoal.Text = "Cans Collected"
        lblResults.Visible = True
        lblResults.Visible = False
        txtText.Visible = True
        txtText.Clear()
        btnFindTarget.Visible = False
        btnFindAmount.Visible = True
        btnClear.Visible = True
    End Sub

    Private Sub btnFindTarget_Click(sender As System.Object, e As System.EventArgs) Handles btnFindTarget.Click

        Dim strText As String
        Dim intText As Integer
        Dim intTotal As Decimal

        strText = txtText.Text
        If IsNumeric(txtText.Text) Then
            intText = Convert.ToInt32(strText)
            If intText < 0 Then
                MsgBox("Please enter a posetive number of $ for your Target Goal Amount", , "Target Goal Amount Error")
                lblResults.Visible = False
                txtText.Clear()
            Else
                lblResults.Visible = True
            End If
        Else
            MsgBox("Please enter a $ amount for your Target Goal Amount", , "Target Goal Amount Error")
            lblResults.Visible = False
            txtText.Clear()
        End If

        intTotal = (intText * _CansPerPound) / _PricePerPound

        lblResults.Text = intTotal.ToString("N0") & " Cans needed to be collected to reach your goal."
    End Sub

    Private Sub btnFindAmount_Click(sender As System.Object, e As System.EventArgs) Handles btnFindAmount.Click
        Dim strText As String
        Dim intText As Integer
        Dim decTotal As Decimal
        strText = txtText.Text
        If IsNumeric(txtText.Text) Then
            intText = Convert.ToInt32(strText)
            If intText < 0 Then
                MsgBox("Please enter a posetive number of Cans Collected", , "Cans Collected Error")
                lblResults.Visible = False
                txtText.Clear()
            Else
                lblResults.Visible = True
            End If
        Else
            MsgBox("Please enter a Numeric number of Cans Collected, and without special characters (, . $ &)", , "Cans Collected Error")
            lblResults.Visible = False
            txtText.Clear()
        End If

        decTotal = (intText / _CansPerPound) * _PricePerPound

        lblResults.Text = decTotal.ToString("C") & " Will be earned by collecting " & strText & " cans for recycling"
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        Dim strText As String
        Dim intText As Integer
        Dim decText As Decimal

        strText = txtText.Text
        If IsNumeric(txtText.Text) Then
            intText = Convert.ToInt32(txtText.Text)
            decText = Convert.ToDecimal(txtText.Text)
        End If
        If btnFindTarget.Visible = True Then
            btnFindTarget_Click(Nothing, e)
            If decText < 0 Then
                MsgBox("Please enter a $ amount for your Target Goal Amount", , "Target Goal Amount Error")
                lblResults.Visible = False
            End If
        ElseIf btnFindAmount.Visible = True Then
            btnFindAmount_Click(Nothing, e)
            If intText < 0 Then
                MsgBox("Please enter a Numeric number of Cans Collected, and without any special characters (, . $ &)", , "Cans Collected Error")
                lblResults.Visible = False
            End If
        Else
            MsgBox("First, please select your recycling need, then try again", , "Select Your Recycling Need Error")
            lblResults.Visible = False
            txtText.Visible = False
            btnFindTarget.Visible = False
            btnFindAmount.Visible = False
        End If

    End Sub

    Private Sub frmRecycling_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblTargetGoal.Text = ""
        cboSelect.Text = "Select Your Recycling Need"
        lblTargetGoal.Visible = False
        txtText.Clear()
        txtText.Visible = False
        btnClear.Visible = False
        btnFindAmount.Visible = False
        btnFindTarget.Visible = False

        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        lblTargetGoal.Text = ""
        cboSelect.Text = "Select Your Recycling Need"
        lblTargetGoal.Visible = False
        txtText.Clear()
        txtText.Visible = False
        btnClear.Visible = False
        btnFindAmount.Visible = False
        btnFindTarget.Visible = False

    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearFormToolStripMenuItem.Click

        btnClear_Click(Nothing, e)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()

    End Sub
End Class
