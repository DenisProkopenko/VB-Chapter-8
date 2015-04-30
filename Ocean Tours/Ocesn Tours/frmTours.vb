'Program Name:  Ocean Tour Trip Selection
'Designer:      Denis Prokopenko
'Date:          11/13/2013
'Purpose:       The ocean tours trip selection determines the cost f the ocean tours available
'               and calculate the cost of the selected tour.

Option Strict On

Public Class frmTours

    Private _intTwoHours As Integer = 2
    Private _intThreeHours As Integer = 3
    Private _intFourHours As Integer = 4
    Private _intEightHours As Integer = 8
    Private _strDeepSeaFishing As String = "Deep Sea Fishing"
    Private _strKayaking As String = "Kayaking"
    Private _strScuba As String = "Scuba Diving"
    Private _strSnorkeling As String = "Snorkeling"
    Private _strGlassBottomBoat As String = "Glass Bottom Boat"
    Private _strParasailing As String = "Parasailing"

    Private Sub cboIsland_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIsland.SelectedIndexChanged, cboIsland.SelectedIndexChanged

        Dim intIsland As Integer

        intIsland = Me.cboIsland.SelectedIndex
        lstTours.Items.Clear()
        Select Case intIsland
            Case 0
                ArubaTours()
            Case 1
                JamaicaTours()
            Case 2
                KeyWestTours()
        End Select

        lblParty.Visible = True
        lblSelect.Visible = True
        lblTourType.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True

        lblTourType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""

        lstTours.Visible = True

        btnFindCost.Visible = True
        btnClear.Visible = True

        txtNumberInParty.Visible = True
        txtNumberInParty.Clear()
        txtNumberInParty.Focus()

    End Sub

    Private Sub ArubaTours()

        lstTours.Items.Add(_strDeepSeaFishing)
        lstTours.Items.Add(_strKayaking)
        lstTours.Items.Add(_strScuba)
        lstTours.Items.Add(_strSnorkeling)

    End Sub

    Private Sub JamaicaTours()

        lstTours.Items.Add(_strGlassBottomBoat)
        lstTours.Items.Add(_strParasailing)
        lstTours.Items.Add(_strSnorkeling)

    End Sub

    Private Sub KeyWestTours()

        lstTours.Items.Add(_strDeepSeaFishing)
        lstTours.Items.Add(_strGlassBottomBoat)
        lstTours.Items.Add(_strScuba)
        lstTours.Items.Add(_strSnorkeling)

    End Sub

    Private Function ValidateNuberInParty() As Boolean

        Dim intPartyNumber As Integer
        Dim blnValidilityCheck As Boolean = False

        Try
            intPartyNumber = Convert.ToInt32(txtNumberInParty.Text)
            If intPartyNumber > 0 And intPartyNumber < 100 Then
                blnValidilityCheck = True
            Else
                MsgBox("Please enter the number of people in your party (1-99)", , "Error")
                txtNumberInParty.Focus()
                txtNumberInParty.Clear()
            End If
        Catch Exception As FormatException
            MsgBox("Please enter the number of people in your party (1-99)", , "Error")
            txtNumberInParty.Focus()
            txtNumberInParty.Clear()
        Catch Exception As OverflowException
            MsgBox("Please enter the number of people in your party (1-99)", , "Error")
            txtNumberInParty.Focus()
            txtNumberInParty.Clear()
        Catch Exception As SystemException
            MsgBox("Please enter the number of people in your party (1-99)", , "Error")
            txtNumberInParty.Focus()
            txtNumberInParty.Clear()
        End Try

        Return blnValidilityCheck

    End Function

    Private Function ValidateTourSelection(ByRef blnTour As Boolean, ByRef strTour As String) As Integer

        Dim intOceanTour As Integer
        Try
            intOceanTour = Convert.ToInt32(lstTours.SelectedIndex)
            strTour = lstTours.SelectedItem.ToString
            blnTour = True
        Catch Exception As SystemException
            MsgBox("Please Select an Ocean Tour", , "Error")
            blnTour = False
        End Try

        Return intOceanTour

    End Function

    Private Function ArubiaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTotalCost As Decimal
        Dim decFinalCost As Decimal
        Dim decArubaDeepSeaCost As Decimal = 199D
        Dim decArubaKayakingCost As Decimal = 89D
        Dim decArubaScubaCost As Decimal = 119D
        Dim decArubaSnorkelingCost As Decimal = 89D

        Select Case intTourSelection
            Case 0
                decTotalCost = decArubaDeepSeaCost
                intTourLength = _intEightHours
            Case 1
                decTotalCost = decArubaKayakingCost
                intTourLength = _intTwoHours
            Case 2
                decTotalCost = decArubaScubaCost
                intTourLength = _intThreeHours
            Case 3
                decTotalCost = decArubaSnorkelingCost
                intTourLength = _intFourHours
        End Select

        decFinalCost = decTotalCost * intGroupSize
        Return decFinalCost

    End Function

    Private Function JamaicaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decJamaicaGlassBottomBoatCost As Decimal = 39D
        Dim decJamaicaParasailingCost As Decimal = 119
        Dim decJamaicaSnorkelingCost As Decimal = 59D

        Select Case intTourSelection
            Case 0
                decTourCost = decJamaicaGlassBottomBoatCost
                intTourLength = _intTwoHours
            Case 1
                decTourCost = decJamaicaParasailingCost
                intTourLength = _intTwoHours
            Case 2
                decTourCost = decJamaicaSnorkelingCost
                intTourLength = _intThreeHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost

    End Function

    Private Function KeyWestFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decKeyWestDeepSeaCost As Decimal = 89D
        Dim decKeyWestGlassBottomBoatCost As Decimal = 29D
        Dim decKeyWestScubaCost As Decimal = 119D
        Dim decKeyWestSnorkelingCost As Decimal = 59D

        Select Case intTourSelection
            Case 0
                decTourCost = decKeyWestDeepSeaCost
                intTourLength = _intFourHours
            Case 1
                decTourCost = decKeyWestGlassBottomBoatCost
                intTourLength = _intTwoHours
            Case 2
                decTourCost = decKeyWestScubaCost
                intTourLength = _intThreeHours
            Case 3
                decTourCost = decKeyWestSnorkelingCost
                intTourLength = _intThreeHours
        End Select

        decFinalCost = decTourCost * intGroupSize

        Return decFinalCost

    End Function


    Private Sub btnFindCost_Click(sender As System.Object, e As System.EventArgs) Handles btnFindCost.Click

        Dim intGroupSize As Integer
        Dim blnNumberInPartyIsValid As Boolean = False
        Dim blnTourIsSelected As Boolean = False
        Dim intTourChoice As Integer
        Dim strSelectedTour As String = ""
        Dim intIslandChoice As Integer
        Dim intLengthOfTour As Integer = 0
        Dim decTotal As Decimal

        blnNumberInPartyIsValid = ValidateNuberInParty()

        intTourChoice = ValidateTourSelection(blnTourIsSelected, strSelectedTour)

        If (blnNumberInPartyIsValid And blnTourIsSelected) Then
            intGroupSize = Convert.ToInt32(txtNumberInParty.Text)
            intIslandChoice = Me.cboIsland.SelectedIndex

            Select Case intIslandChoice
                Case 0
                    decTotal = ArubiaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 1
                    decTotal = JamaicaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 2
                    decTotal = KeyWestFindCost(intTourChoice, intGroupSize, intLengthOfTour)
            End Select

            lblTourType.Text = "Tour: " & strSelectedTour
            lblCost.Text = "Cost: " & decTotal.ToString("C")
            lblLength.Text = "Length: " & intLengthOfTour.ToString() & " Hours"
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        cboIsland.Text = "Select Island Location"
        txtNumberInParty.Clear()
        lstTours.Items.Clear()
        lblTourType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        lblParty.Visible = False
        txtNumberInParty.Visible = False
        lblSelect.Visible = False
        lstTours.Visible = False
        btnFindCost.Visible = False
        btnClear.Visible = False
        lblTourType.Visible = False
        lblCost.Visible = False
        lblLength.Visible = False

    End Sub
End Class
