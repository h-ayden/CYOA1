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
        Me.lblStory = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStory
        '
        Me.lblStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.Location = New System.Drawing.Point(12, 39)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(257, 150)
        Me.lblStory.TabIndex = 0
        Me.lblStory.Text = "Label1"
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(308, 39)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(257, 150)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 1
        Me.picImage.TabStop = False
        '
        'btnOption1
        '
        Me.btnOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.Location = New System.Drawing.Point(12, 247)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(257, 44)
        Me.btnOption1.TabIndex = 2
        Me.btnOption1.Text = "Option1"
        Me.btnOption1.UseVisualStyleBackColor = True
        '
        'btnOption2
        '
        Me.btnOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.Location = New System.Drawing.Point(308, 247)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(257, 44)
        Me.btnOption2.TabIndex = 3
        Me.btnOption2.Text = "Option2"
        Me.btnOption2.UseVisualStyleBackColor = True
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(12, 393)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(49, 16)
        Me.lblMoney.TabIndex = 4
        Me.lblMoney.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 448)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.lblStory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStory As System.Windows.Forms.Label
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnOption1 As System.Windows.Forms.Button
    Friend WithEvents btnOption2 As System.Windows.Forms.Button
    Friend WithEvents lblMoney As System.Windows.Forms.Label

End Class
