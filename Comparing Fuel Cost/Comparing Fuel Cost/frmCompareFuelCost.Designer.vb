<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareFuelCost
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.txtMilesTraveled = New System.Windows.Forms.TextBox()
        Me.cboYears = New System.Windows.Forms.ComboBox()
        Me.txtSUVMPG = New System.Windows.Forms.TextBox()
        Me.txtCompactMPG = New System.Windows.Forms.TextBox()
        Me.lblSUV = New System.Windows.Forms.Label()
        Me.lblCompact = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.CompareLifeOfVehicleCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompareLifeOfVehicleCostToolStripMenuItem, Me.ClearFormToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.gas_can_flask
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 294)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(275, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fuel Cost Per Gallon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(275, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Miles Traveled Per Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(275, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Years of Vehicle Ownership"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(275, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SUV MPG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(275, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Compact Car Car MPG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(307, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "SUV Gas Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(307, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Compact Gas Cost"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(307, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Difference in Cost"
        '
        'btnCompare
        '
        Me.btnCompare.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCompare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompare.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompare.Location = New System.Drawing.Point(278, 190)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(286, 36)
        Me.btnCompare.TabIndex = 10
        Me.btnCompare.Text = "Compare Life of Vehicle Cost"
        Me.btnCompare.UseVisualStyleBackColor = False
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerGallon.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtCostPerGallon.Location = New System.Drawing.Point(479, 26)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(105, 22)
        Me.txtCostPerGallon.TabIndex = 11
        '
        'txtMilesTraveled
        '
        Me.txtMilesTraveled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilesTraveled.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtMilesTraveled.Location = New System.Drawing.Point(479, 60)
        Me.txtMilesTraveled.Name = "txtMilesTraveled"
        Me.txtMilesTraveled.Size = New System.Drawing.Size(105, 22)
        Me.txtMilesTraveled.TabIndex = 12
        '
        'cboYears
        '
        Me.cboYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYears.ForeColor = System.Drawing.Color.OrangeRed
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboYears.Location = New System.Drawing.Point(479, 94)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(105, 24)
        Me.cboYears.TabIndex = 13
        Me.cboYears.Text = "Select One"
        '
        'txtSUVMPG
        '
        Me.txtSUVMPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSUVMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtSUVMPG.Location = New System.Drawing.Point(479, 128)
        Me.txtSUVMPG.Name = "txtSUVMPG"
        Me.txtSUVMPG.Size = New System.Drawing.Size(105, 22)
        Me.txtSUVMPG.TabIndex = 14
        '
        'txtCompactMPG
        '
        Me.txtCompactMPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompactMPG.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtCompactMPG.Location = New System.Drawing.Point(479, 162)
        Me.txtCompactMPG.Name = "txtCompactMPG"
        Me.txtCompactMPG.Size = New System.Drawing.Size(105, 22)
        Me.txtCompactMPG.TabIndex = 15
        '
        'lblSUV
        '
        Me.lblSUV.AutoSize = True
        Me.lblSUV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUV.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblSUV.Location = New System.Drawing.Point(466, 249)
        Me.lblSUV.Name = "lblSUV"
        Me.lblSUV.Size = New System.Drawing.Size(0, 16)
        Me.lblSUV.TabIndex = 16
        '
        'lblCompact
        '
        Me.lblCompact.AutoSize = True
        Me.lblCompact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompact.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCompact.Location = New System.Drawing.Point(466, 277)
        Me.lblCompact.Name = "lblCompact"
        Me.lblCompact.Size = New System.Drawing.Size(0, 16)
        Me.lblCompact.TabIndex = 17
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblDifference.Location = New System.Drawing.Point(466, 305)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(0, 16)
        Me.lblDifference.TabIndex = 18
        '
        'CompareLifeOfVehicleCostToolStripMenuItem
        '
        Me.CompareLifeOfVehicleCostToolStripMenuItem.Name = "CompareLifeOfVehicleCostToolStripMenuItem"
        Me.CompareLifeOfVehicleCostToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.CompareLifeOfVehicleCostToolStripMenuItem.Text = "Compare Life of Vehicle Cost"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ClearFormToolStripMenuItem.Text = "Clear Form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmCompareFuelCost
        '
        Me.AcceptButton = Me.btnCompare
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(596, 335)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblCompact)
        Me.Controls.Add(Me.lblSUV)
        Me.Controls.Add(Me.txtCompactMPG)
        Me.Controls.Add(Me.txtSUVMPG)
        Me.Controls.Add(Me.cboYears)
        Me.Controls.Add(Me.txtMilesTraveled)
        Me.Controls.Add(Me.txtCostPerGallon)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCompareFuelCost"
        Me.Text = "Comparing Fuel Mileage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents txtCostPerGallon As System.Windows.Forms.TextBox
    Friend WithEvents txtMilesTraveled As System.Windows.Forms.TextBox
    Friend WithEvents cboYears As System.Windows.Forms.ComboBox
    Friend WithEvents txtSUVMPG As System.Windows.Forms.TextBox
    Friend WithEvents txtCompactMPG As System.Windows.Forms.TextBox
    Friend WithEvents lblSUV As System.Windows.Forms.Label
    Friend WithEvents lblCompact As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents CompareLifeOfVehicleCostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
