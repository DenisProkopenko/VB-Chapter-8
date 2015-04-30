Option Strict On

Public Class frmBaseballTicketSales
    Const _SeasonBoxSeats As Decimal = 2500D
    Const _SeasonLowerDeck As Decimal = 1500D
    Const _SingleBoxSeats As Decimal = 55D
    Const _SingleLowerDeck As Decimal = 35D
    Const _SinglUperDeck As Decimal = 25D
    Const _SingleStandingRoomOnly As Decimal = 15D

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelect.SelectedIndexChanged

        Dim intTicketChoice As Integer

        lstSelect.Items.Clear()

        intTicketChoice = Me.cboSelect.SelectedIndex
        Select Case intTicketChoice
            Case 0
                lstSelect.Items.Add("Box Seats $2500")
                lstSelect.Items.Add("Lower Deck Seats $1500")
                txtTickets.Clear()
                lblTickets.Visible = True
                txtTickets.Visible = True
                lblSelect.Visible = True
                lblTotal.Visible = True
                lblTotal.Text = ""
                lstSelect.Visible = True
                btnComputeTickets.Visible = True
                btnComputeTickets1.Visible = False
                btnClear.Visible = True
            Case 1
                lstSelect.Items.Add("Box Seats $55")
                lstSelect.Items.Add("Lower Deck Seats $35")
                lstSelect.Items.Add("Upper Deck Seats $25")
                lstSelect.Items.Add("Standing Room Only $15")
                txtTickets.Clear()
                lblTickets.Visible = True
                txtTickets.Visible = True
                lblSelect.Visible = True
                lblTotal.Visible = True
                lblTotal.Text = ""
                lstSelect.Visible = True
                btnComputeTickets.Visible = False
                btnComputeTickets1.Visible = True
                btnClear.Visible = True
        End Select

    End Sub


    Private Sub btnComputeTickets_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeTickets.Click

        Dim intTicketChoices As Integer
        Dim decTotal As Decimal
        Dim intTickets As Integer
        Dim decSubTotal As Decimal
        Dim strSeat As String
        Dim intSeatSelection As Integer

        If IsNumeric(txtTickets.Text) Then
            intTickets = Convert.ToInt32(txtTickets.Text)
            If intTickets < 0 Then
                MsgBox("Please enter a Posetive Number of Tickets", , "Number of Tickets Error")
                lblTotal.Text = ""
                txtTickets.Clear()
            End If
        Else
            MsgBox("Please enter a numeric Number of Tickets", , "Number of Tickets Error")
            lblTotal.Text = ""
            txtTickets.Clear()
        End If

        intTicketChoices = Me.lstSelect.SelectedIndex
        Select Case intTicketChoices
            Case 0
                decSubTotal = _SeasonBoxSeats
            Case 1
                decSubTotal = _SeasonLowerDeck
        End Select

        Try
            intSeatSelection = Convert.ToInt32(lstSelect.SelectedIndex)
            strSeat = lstSelect.SelectedItem.ToString
        Catch Exception As SystemException
            MsgBox("Please Select a Seat Type", , "Error")
        End Try

        decTotal = decSubTotal * intTickets
        lblTotal.Text = "Total Cost Of Tickets Purchased: " & decTotal.ToString("C")

    End Sub

    Private Sub btnComputeTickets1_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeTickets1.Click

        Dim intTicketChoices As Integer
        Dim decTotal As Decimal
        Dim intTickets As Integer
        Dim decSubTotal As Decimal
        Dim intSeatSelection As Integer
        Dim strSeat As String

        If IsNumeric(txtTickets.Text) Then
            intTickets = Convert.ToInt32(txtTickets.Text)
            If intTickets < 0 Then
                MsgBox("Please enter a Posetive Number of Tickets", , "Number of Tickets Error")
                lblTotal.Text = ""
                txtTickets.Clear()
            End If
        Else
            MsgBox("Please enter a numeric Number of Tickets", , "Number of Tickets Error")
            lblTotal.Text = ""
            txtTickets.Clear()
        End If

        intTicketChoices = Me.lstSelect.SelectedIndex
        Select Case intTicketChoices
            Case 0
                decSubTotal = _SingleBoxSeats
            Case 1
                decSubTotal = _SingleLowerDeck
            Case 2
                decSubTotal = _SinglUperDeck
            Case 3
                decSubTotal = _SingleStandingRoomOnly
        End Select

        Try
            intSeatSelection = Convert.ToInt32(lstSelect.SelectedIndex)
            strSeat = lstSelect.SelectedItem.ToString
        Catch Exception As SystemException
            MsgBox("Please Select a Seat Type", , "Error")
        End Try

        decTotal = decSubTotal * intTickets
        lblTotal.Text = "Total Cost Of Tickets Purchased: " & decTotal.ToString("C")

    End Sub

    Private Sub ComputeTicketCostToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComputeTicketCostToolStripMenuItem.Click

        If btnComputeTickets.Visible = True Then
            btnComputeTickets_Click(Nothing, e)
        ElseIf btnComputeTickets1.Visible = True Then
            btnComputeTickets1_Click(Nothing, e)
        Else
            MsgBox("Please select Type of Tickets you wish to purchase", , "Type of Tickets Error")
        End If

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        lblTickets.Visible = False
        txtTickets.Visible = False
        lblSelect.Visible = False
        lstSelect.Items.Clear()
        lstSelect.Visible = False
        btnClear.Visible = False
        btnComputeTickets.Visible = False
        btnComputeTickets1.Visible = False
        lblTotal.Text = ""
        lblTotal.Visible = False

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        btnClear_Click(Nothing, e)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub frmBaseballTicketSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTickets.Visible = False
        txtTickets.Visible = False
        lblSelect.Visible = False
        lstSelect.Items.Clear()
        lstSelect.Visible = False
        btnClear.Visible = False
        btnComputeTickets.Visible = False
        btnComputeTickets1.Visible = False
        lblTotal.Text = ""
        lblTotal.Visible = False

        Threading.Thread.Sleep(4000)
    End Sub
End Class
