<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loja
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loja))
        Me.Fusha = New System.Windows.Forms.PictureBox()
        Me.Timeri = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NdalNis = New System.Windows.Forms.Label()
        Me.mbylle = New System.Windows.Forms.Label()
        Me.newGame = New System.Windows.Forms.Label()
        Me.piket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Fusha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fusha
        '
        Me.Fusha.BackgroundImage = Global.Snake_V1._0.My.Resources.Resources.SnakeBG
        Me.Fusha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fusha.Location = New System.Drawing.Point(13, 13)
        Me.Fusha.Name = "Fusha"
        Me.Fusha.Size = New System.Drawing.Size(420, 436)
        Me.Fusha.TabIndex = 0
        Me.Fusha.TabStop = False
        '
        'Timeri
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NdalNis)
        Me.Panel1.Controls.Add(Me.mbylle)
        Me.Panel1.Controls.Add(Me.newGame)
        Me.Panel1.Controls.Add(Me.piket)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(439, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 436)
        Me.Panel1.TabIndex = 2
        '
        'NdalNis
        '
        Me.NdalNis.AutoSize = True
        Me.NdalNis.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.NdalNis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NdalNis.Location = New System.Drawing.Point(26, 160)
        Me.NdalNis.Name = "NdalNis"
        Me.NdalNis.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.NdalNis.Size = New System.Drawing.Size(145, 45)
        Me.NdalNis.TabIndex = 4
        Me.NdalNis.Text = "Pause!"
        '
        'mbylle
        '
        Me.mbylle.AutoSize = True
        Me.mbylle.BackColor = System.Drawing.Color.Sienna
        Me.mbylle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mbylle.Location = New System.Drawing.Point(22, 330)
        Me.mbylle.Name = "mbylle"
        Me.mbylle.Padding = New System.Windows.Forms.Padding(10)
        Me.mbylle.Size = New System.Drawing.Size(153, 45)
        Me.mbylle.TabIndex = 3
        Me.mbylle.Text = "Mbyll Lojen"
        '
        'newGame
        '
        Me.newGame.AutoSize = True
        Me.newGame.BackColor = System.Drawing.Color.SeaGreen
        Me.newGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGame.Location = New System.Drawing.Point(22, 266)
        Me.newGame.Name = "newGame"
        Me.newGame.Padding = New System.Windows.Forms.Padding(13)
        Me.newGame.Size = New System.Drawing.Size(153, 51)
        Me.newGame.TabIndex = 2
        Me.newGame.Text = "Loje e Re !"
        '
        'piket
        '
        Me.piket.AutoSize = True
        Me.piket.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.piket.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piket.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.piket.Location = New System.Drawing.Point(130, 58)
        Me.piket.Name = "piket"
        Me.piket.Padding = New System.Windows.Forms.Padding(10)
        Me.piket.Size = New System.Drawing.Size(49, 47)
        Me.piket.TabIndex = 1
        Me.piket.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(19, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(134, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Piket:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2)
        Me.Label2.Size = New System.Drawing.Size(182, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "© Xhentiljana Nikolli"
        '
        'Loja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Fusha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(670, 500)
        Me.MinimumSize = New System.Drawing.Size(670, 500)
        Me.Name = "Loja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake v1.0"
        CType(Me.Fusha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fusha As System.Windows.Forms.PictureBox
    Friend WithEvents Timeri As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents piket As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newGame As System.Windows.Forms.Label
    Friend WithEvents mbylle As System.Windows.Forms.Label
    Friend WithEvents NdalNis As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
