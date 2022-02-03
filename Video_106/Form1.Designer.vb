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
        Me.SuspendLayout()
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(12, 30)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(150, 23)
        Me.btnName.TabIndex = 0
        Me.btnName.Text = "Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(12, 59)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(150, 23)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(12, 120)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(150, 23)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 176)
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
End Class
