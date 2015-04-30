'Program Name:  Comparing Fuel Costs
'Designer:      Denis Prokopenko
'Date:          11/13/2013
'Purpose:       The ocean tours trip selection allows the user to  compare the costs of an
'               SUV and a Compact car, and see the results.
Option Strict On
Public Class frmCompareFuelCost


    Private Sub btnCompare_Click(sender As System.Object, e As System.EventArgs) Handles btnCompare.Click

        Dim strCostPerGallon As String
        Dim decCostPerGallon As Decimal

        Dim strSUVMPG As String
        Dim decSUVMPG As Decimal

        Dim decSUVGasCost As Decimal

        Dim strMilesTraveled As String
        Dim intMilesTraveled As Integer

        Dim intYears As Integer

        Dim strCompactMPG As String
        Dim decCompactMPG As Decimal
        Dim decCompactGasCost As Decimal

        Dim decDifference As Decimal

        Dim _One As Integer = 1I
        Dim _Two As Integer = 2I
        Dim _Three As Integer = 3I
        Dim _Four As Integer = 4I
        Dim _Five As Integer = 5I
        Dim _Six As Integer = 6I
        Dim _Seven As Integer = 7I
        Dim _Eight As Integer = 8I
        Dim _Nine As Integer = 9I
        Dim _Ten As Integer = 10I

        strCostPerGallon = txtCostPerGallon.Text

        If IsNumeric(txtCostPerGallon.Text) Then
            decCostPerGallon = Convert.ToDecimal(strCostPerGallon)
            If decCostPerGallon = 0 Then
                MsgBox("Please use a number greater than zero, 1.00 to 99.99", , "Cost Per Gallon Error")
                txtCostPerGallon.Clear()
                If decCostPerGallon < 0 Then
                    MsgBox("Please use a posetive cost price for the Gas", , "Cost Per Gallon Error")
                    txtCostPerGallon.Clear()
                End If
            End If
        Else
            MsgBox("Please enter a Numeric number for the cost of Gas, Example: 1.00 to 99.99", , "Cost Per Gallon Error")
            txtCostPerGallon.Clear()
        End If


        strSUVMPG = txtSUVMPG.Text

        If IsNumeric(txtSUVMPG.Text) Then
            decSUVMPG = Convert.ToDecimal(strSUVMPG)
            If decSUVMPG = 0 Then
                MsgBox("Please use a number greater than zero, 1.00 to 99.99", , "SUV MPG Error")
                txtSUVMPG.Clear()
                If decSUVMPG < 0 Then
                    MsgBox("Please use a posetive Number", , "SUV MPG Error")
                    txtSUVMPG.Clear()
                End If
            End If
        Else
            MsgBox("Please enter a Numeric number for SUV MPG: 1.00 to 99.99", , "SUV MPG Error")
            txtSUVMPG.Clear()
        End If

        strMilesTraveled = txtMilesTraveled.Text

        If IsNumeric(txtMilesTraveled.Text) Then
            intMilesTraveled = Convert.ToInt32(strMilesTraveled)
            If intMilesTraveled = 0 Then
                MsgBox("Please use a number greater than zero, 1 to 999,999", , "Miles Traveled Error")
                txtMilesTraveled.Clear()
                If intMilesTraveled < 0 Then
                    MsgBox("Please use a posetive Number", , "Miles Traveled Error")
                    txtMilesTraveled.Clear()
                End If
            End If
        Else
            MsgBox("Please enter a Numeric number for SUV MPG: 1 to 999,999", , "Miles Traveled Error")
            txtMilesTraveled.Clear()
        End If

        intYears = Me.cboYears.SelectedIndex

        Select Case intYears
            Case 0
                intYears = _One
            Case 1
                intYears = _Two
            Case 2
                intYears = _Three
            Case 3
                intYears = _Four
            Case 4
                intYears = _Five
            Case 5
                intYears = _Six
            Case 6
                intYears = _Seven
            Case 7
                intYears = _Eight
            Case 8
                intYears = _Nine
            Case 9
                intYears = _Ten
        End Select

        If intYears < 0 Then
            MsgBox("Please select years you had your vehicle", , "Years fo Vehicle Ownership Error")
        End If

        If (intMilesTraveled > 0 And intYears > 0 And decSUVMPG > 0 And decCostPerGallon > 0) Then
            decSUVGasCost = (((intMilesTraveled * intYears) / decSUVMPG) * decCostPerGallon)
        Else
            MsgBox("Please Check your Numbers and try again", MsgBoxStyle.Exclamation, "Error")
        End If

        lblSUV.Text = decSUVGasCost.ToString("C")

        strCompactMPG = txtCompactMPG.Text

        If IsNumeric(txtCompactMPG.Text) Then
            decCompactMPG = Convert.ToDecimal(strCompactMPG)
            If decCompactMPG = 0 Then
                MsgBox("Please use a number greater than zero, 1.00 to 99.99", , "Compact Car MPG Error")
                txtCompactMPG.Clear()
                If decCompactMPG < 0 Then
                    MsgBox("Please use a posetive Number", , "Compact Car MPG Error")
                    txtCompactMPG.Clear()
                End If
            End If
        Else
            MsgBox("Please enter a Numeric number for SUV MPG: 1.00 to 99.99", , "Compact Car MPG Error")
            txtCompactMPG.Clear()
        End If

        If (intMilesTraveled > 0 And intYears > 0 And decCompactMPG > 0 And decCostPerGallon > 0) Then
            decCompactGasCost = (((intMilesTraveled * intYears) / decCompactMPG) * decCostPerGallon)
        Else
            MsgBox("Please Check your Numbers and try again", MsgBoxStyle.Exclamation, "Error")
        End If

        lblCompact.Text = decCompactGasCost.ToString("C")

        If (decCompactGasCost < decSUVGasCost) Then
            decDifference = decSUVGasCost - decCompactGasCost
        ElseIf (decCompactGasCost > decSUVGasCost) Then
            decDifference = decCompactGasCost - decSUVGasCost
        End If

        lblDifference.Text = decDifference.ToString("C")

    End Sub

    Private Sub CompareLifeOfVehicleCostToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompareLifeOfVehicleCostToolStripMenuItem.Click
        btnCompare_Click(Nothing, e)
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearFormToolStripMenuItem.Click

        txtCompactMPG.Clear()
        txtCostPerGallon.Clear()
        txtMilesTraveled.Clear()
        txtSUVMPG.Clear()
        lblCompact.Text = ""
        lblSUV.Text = ""
        lblDifference.Text = ""
        cboYears.Text = "Select One"
        txtCostPerGallon.Focus()

    End Sub

    Private Sub frmCompareFuelCost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtCompactMPG.Clear()
        txtCostPerGallon.Clear()
        txtMilesTraveled.Clear()
        txtSUVMPG.Clear()
        lblCompact.Text = ""
        lblSUV.Text = ""
        lblDifference.Text = ""
        cboYears.Text = "Select One"
        txtCostPerGallon.Focus()

        Threading.Thread.Sleep(5000)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()

    End Sub
End Class
