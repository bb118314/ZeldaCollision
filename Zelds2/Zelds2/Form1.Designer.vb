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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.player = New System.Windows.Forms.PictureBox()
        Me.obdticle = New System.Windows.Forms.PictureBox()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obdticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Image = CType(resources.GetObject("player.Image"), System.Drawing.Image)
        Me.player.Location = New System.Drawing.Point(158, 337)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(91, 88)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'obdticle
        '
        Me.obdticle.Image = CType(resources.GetObject("obdticle.Image"), System.Drawing.Image)
        Me.obdticle.Location = New System.Drawing.Point(121, 102)
        Me.obdticle.Name = "obdticle"
        Me.obdticle.Size = New System.Drawing.Size(323, 219)
        Me.obdticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.obdticle.TabIndex = 1
        Me.obdticle.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 448)
        Me.Controls.Add(Me.obdticle)
        Me.Controls.Add(Me.player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obdticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents obdticle As System.Windows.Forms.PictureBox

End Class
