<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCar
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
        Me.lblCarName = New System.Windows.Forms.Label()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.lblCarColor = New System.Windows.Forms.Label()
        Me.txtCarColor = New System.Windows.Forms.TextBox()
        Me.lblCarDoors = New System.Windows.Forms.Label()
        Me.numerDoors = New System.Windows.Forms.NumericUpDown()
        Me.lblCarHorsePower = New System.Windows.Forms.Label()
        Me.txtCarHorsePower = New System.Windows.Forms.TextBox()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.numerDoors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCarName
        '
        Me.lblCarName.AutoSize = True
        Me.lblCarName.Location = New System.Drawing.Point(12, 20)
        Me.lblCarName.Name = "lblCarName"
        Me.lblCarName.Size = New System.Drawing.Size(77, 15)
        Me.lblCarName.TabIndex = 0
        Me.lblCarName.Text = "Name of Car:"
        '
        'txtCarName
        '
        Me.txtCarName.Location = New System.Drawing.Point(12, 38)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(248, 23)
        Me.txtCarName.TabIndex = 1
        '
        'lblCarColor
        '
        Me.lblCarColor.AutoSize = True
        Me.lblCarColor.Location = New System.Drawing.Point(12, 77)
        Me.lblCarColor.Name = "lblCarColor"
        Me.lblCarColor.Size = New System.Drawing.Size(74, 15)
        Me.lblCarColor.TabIndex = 2
        Me.lblCarColor.Text = "Color of Car:"
        '
        'txtCarColor
        '
        Me.txtCarColor.Location = New System.Drawing.Point(12, 95)
        Me.txtCarColor.Name = "txtCarColor"
        Me.txtCarColor.Size = New System.Drawing.Size(248, 23)
        Me.txtCarColor.TabIndex = 3
        '
        'lblCarDoors
        '
        Me.lblCarDoors.AutoSize = True
        Me.lblCarDoors.Location = New System.Drawing.Point(12, 130)
        Me.lblCarDoors.Name = "lblCarDoors"
        Me.lblCarDoors.Size = New System.Drawing.Size(101, 15)
        Me.lblCarDoors.TabIndex = 4
        Me.lblCarDoors.Text = "Number of doors:"
        '
        'numerDoors
        '
        Me.numerDoors.Location = New System.Drawing.Point(12, 148)
        Me.numerDoors.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numerDoors.Name = "numerDoors"
        Me.numerDoors.Size = New System.Drawing.Size(120, 23)
        Me.numerDoors.TabIndex = 5
        '
        'lblCarHorsePower
        '
        Me.lblCarHorsePower.AutoSize = True
        Me.lblCarHorsePower.Location = New System.Drawing.Point(12, 183)
        Me.lblCarHorsePower.Name = "lblCarHorsePower"
        Me.lblCarHorsePower.Size = New System.Drawing.Size(77, 15)
        Me.lblCarHorsePower.TabIndex = 6
        Me.lblCarHorsePower.Text = "Horse Power:"
        '
        'txtCarHorsePower
        '
        Me.txtCarHorsePower.Location = New System.Drawing.Point(12, 201)
        Me.txtCarHorsePower.Name = "txtCarHorsePower"
        Me.txtCarHorsePower.Size = New System.Drawing.Size(248, 23)
        Me.txtCarHorsePower.TabIndex = 7
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(12, 268)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(120, 23)
        Me.btnAddCar.TabIndex = 8
        Me.btnAddCar.Text = "Add Car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(138, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 303)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.txtCarHorsePower)
        Me.Controls.Add(Me.lblCarHorsePower)
        Me.Controls.Add(Me.numerDoors)
        Me.Controls.Add(Me.lblCarDoors)
        Me.Controls.Add(Me.txtCarColor)
        Me.Controls.Add(Me.lblCarColor)
        Me.Controls.Add(Me.txtCarName)
        Me.Controls.Add(Me.lblCarName)
        Me.Name = "NewCar"
        Me.Text = "NewCar"
        CType(Me.numerDoors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCarName As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents lblCarColor As Label
    Friend WithEvents txtCarColor As TextBox
    Friend WithEvents lblCarDoors As Label
    Friend WithEvents numerDoors As NumericUpDown
    Friend WithEvents lblCarHorsePower As Label
    Friend WithEvents txtCarHorsePower As TextBox
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnCancel As Button
End Class
