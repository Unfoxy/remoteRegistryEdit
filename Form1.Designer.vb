<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbPcName = New System.Windows.Forms.TextBox()
        Me.lbPcName = New System.Windows.Forms.Label()
        Me.buChangeRegistry = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPcName
        '
        Me.tbPcName.Location = New System.Drawing.Point(84, 26)
        Me.tbPcName.Name = "tbPcName"
        Me.tbPcName.Size = New System.Drawing.Size(132, 20)
        Me.tbPcName.TabIndex = 0
        '
        'lbPcName
        '
        Me.lbPcName.AutoSize = True
        Me.lbPcName.Location = New System.Drawing.Point(23, 26)
        Me.lbPcName.Name = "lbPcName"
        Me.lbPcName.Size = New System.Drawing.Size(55, 13)
        Me.lbPcName.TabIndex = 1
        Me.lbPcName.Text = "PC Name:"
        '
        'buChangeRegistry
        '
        Me.buChangeRegistry.Location = New System.Drawing.Point(235, 26)
        Me.buChangeRegistry.Name = "buChangeRegistry"
        Me.buChangeRegistry.Size = New System.Drawing.Size(122, 23)
        Me.buChangeRegistry.TabIndex = 2
        Me.buChangeRegistry.Text = "Change Registry"
        Me.buChangeRegistry.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 81)
        Me.Controls.Add(Me.buChangeRegistry)
        Me.Controls.Add(Me.lbPcName)
        Me.Controls.Add(Me.tbPcName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPcName As TextBox
    Friend WithEvents lbPcName As Label
    Friend WithEvents buChangeRegistry As Button
End Class
