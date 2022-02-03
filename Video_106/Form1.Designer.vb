<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnDoors = New System.Windows.Forms.Button()
        Me.btnAccelerate = New System.Windows.Forms.Button()
        Me.btnPowerWeight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(12, 12)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(150, 23)
        Me.btnName.TabIndex = 0
        Me.btnName.Text = "Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(12, 41)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(150, 23)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(12, 157)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(150, 23)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnDoors
        '
        Me.btnDoors.Location = New System.Drawing.Point(12, 70)
        Me.btnDoors.Name = "btnDoors"
        Me.btnDoors.Size = New System.Drawing.Size(150, 23)
        Me.btnDoors.TabIndex = 3
        Me.btnDoors.Text = "Doors"
        Me.btnDoors.UseVisualStyleBackColor = True
        '
        'btnAccelerate
        '
        Me.btnAccelerate.Location = New System.Drawing.Point(12, 99)
        Me.btnAccelerate.Name = "btnAccelerate"
        Me.btnAccelerate.Size = New System.Drawing.Size(150, 23)
        Me.btnAccelerate.TabIndex = 4
        Me.btnAccelerate.Text = "Accelerate"
        Me.btnAccelerate.UseVisualStyleBackColor = True
        '
        'btnPowerWeight
        '
        Me.btnPowerWeight.Location = New System.Drawing.Point(12, 128)
        Me.btnPowerWeight.Name = "btnPowerWeight"
        Me.btnPowerWeight.Size = New System.Drawing.Size(150, 23)
        Me.btnPowerWeight.TabIndex = 5
        Me.btnPowerWeight.Text = "Power/Weight"
        Me.btnPowerWeight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 204)
        Me.Controls.Add(Me.btnPowerWeight)
        Me.Controls.Add(Me.btnAccelerate)
        Me.Controls.Add(Me.btnDoors)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnName As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents btnDoors As Button
    Friend WithEvents btnAccelerate As Button
    Friend WithEvents btnPowerWeight As Button
End Class
