<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftingArraysForm
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
        Me.PlotButton = New System.Windows.Forms.Button()
        Me.GraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlotButton
        '
        Me.PlotButton.Location = New System.Drawing.Point(315, 389)
        Me.PlotButton.Name = "PlotButton"
        Me.PlotButton.Size = New System.Drawing.Size(215, 55)
        Me.PlotButton.TabIndex = 0
        Me.PlotButton.Text = "&Plot"
        Me.PlotButton.UseVisualStyleBackColor = True
        '
        'GraphPictureBox
        '
        Me.GraphPictureBox.Location = New System.Drawing.Point(15, 17)
        Me.GraphPictureBox.Name = "GraphPictureBox"
        Me.GraphPictureBox.Size = New System.Drawing.Size(778, 366)
        Me.GraphPictureBox.TabIndex = 1
        Me.GraphPictureBox.TabStop = False
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(550, 389)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(215, 55)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "E&xit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ShiftingArraysForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.GraphPictureBox)
        Me.Controls.Add(Me.PlotButton)
        Me.Name = "ShiftingArraysForm"
        Me.Text = "Form1"
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlotButton As Button
    Friend WithEvents GraphPictureBox As PictureBox
    Friend WithEvents QuitButton As Button
End Class
