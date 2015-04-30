<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTours
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTourType = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindCost = New System.Windows.Forms.Button()
        Me.lstTours = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtNumberInParty = New System.Windows.Forms.TextBox()
        Me.lblParty = New System.Windows.Forms.Label()
        Me.cboIsland = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ocean
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 515)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblTourType)
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindCost)
        Me.Panel1.Controls.Add(Me.lstTours)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtNumberInParty)
        Me.Panel1.Controls.Add(Me.lblParty)
        Me.Panel1.Controls.Add(Me.cboIsland)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(321, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 515)
        Me.Panel1.TabIndex = 1
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(165, 433)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(108, 18)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "XXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'lblTourType
        '
        Me.lblTourType.AutoSize = True
        Me.lblTourType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourType.Location = New System.Drawing.Point(165, 403)
        Me.lblTourType.Name = "lblTourType"
        Me.lblTourType.Size = New System.Drawing.Size(108, 18)
        Me.lblTourType.TabIndex = 9
        Me.lblTourType.Text = "XXXXXXXXXX"
        Me.lblTourType.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(165, 464)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(108, 18)
        Me.lblLength.TabIndex = 8
        Me.lblLength.Text = "XXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(245, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnFindCost
        '
        Me.btnFindCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCost.Location = New System.Drawing.Point(74, 357)
        Me.btnFindCost.Name = "btnFindCost"
        Me.btnFindCost.Size = New System.Drawing.Size(125, 31)
        Me.btnFindCost.TabIndex = 6
        Me.btnFindCost.Text = "Find Tour Cost"
        Me.btnFindCost.UseVisualStyleBackColor = True
        Me.btnFindCost.Visible = False
        '
        'lstTours
        '
        Me.lstTours.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTours.FormattingEnabled = True
        Me.lstTours.ItemHeight = 18
        Me.lstTours.Location = New System.Drawing.Point(126, 197)
        Me.lstTours.Name = "lstTours"
        Me.lstTours.Size = New System.Drawing.Size(187, 130)
        Me.lstTours.TabIndex = 5
        Me.lstTours.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(151, 165)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(136, 18)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Ocean Tour:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSelect.Visible = False
        '
        'txtNumberInParty
        '
        Me.txtNumberInParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberInParty.Location = New System.Drawing.Point(265, 120)
        Me.txtNumberInParty.Name = "txtNumberInParty"
        Me.txtNumberInParty.Size = New System.Drawing.Size(33, 24)
        Me.txtNumberInParty.TabIndex = 3
        Me.txtNumberInParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumberInParty.Visible = False
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParty.Location = New System.Drawing.Point(141, 123)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(118, 18)
        Me.lblParty.TabIndex = 2
        Me.lblParty.Text = "Number in Party:"
        Me.lblParty.Visible = False
        '
        'cboIsland
        '
        Me.cboIsland.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIsland.FormattingEnabled = True
        Me.cboIsland.Items.AddRange(New Object() {"Aruba", "Jamaica", "Key West"})
        Me.cboIsland.Location = New System.Drawing.Point(134, 68)
        Me.cboIsland.Name = "cboIsland"
        Me.cboIsland.Size = New System.Drawing.Size(171, 26)
        Me.cboIsland.TabIndex = 1
        Me.cboIsland.Text = "Select Island Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ocean Tours Information"
        '
        'frmTours
        '
        Me.AcceptButton = Me.btnFindCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(760, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTours"
        Me.Text = "Information on Available Tours"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblTourType As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFindCost As System.Windows.Forms.Button
    Friend WithEvents lstTours As System.Windows.Forms.ListBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents txtNumberInParty As System.Windows.Forms.TextBox
    Friend WithEvents lblParty As System.Windows.Forms.Label
    Friend WithEvents cboIsland As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
