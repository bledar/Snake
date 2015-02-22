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
        Me.dbg = New System.Windows.Forms.Label()
        Me.piket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dbg)
        Me.Panel1.Controls.Add(Me.piket)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(439, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 436)
        Me.Panel1.TabIndex = 2
        '
        'dbg
        '
        Me.dbg.AutoSize = True
        Me.dbg.Location = New System.Drawing.Point(3, 411)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(13, 13)
        Me.dbg.TabIndex = 2
        Me.dbg.Text = "1"
        '
        'piket
        '
        Me.piket.AutoSize = True
        Me.piket.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.piket.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piket.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.piket.Location = New System.Drawing.Point(130, 70)
        Me.piket.Name = "piket"
        Me.piket.Size = New System.Drawing.Size(29, 27)
        Me.piket.TabIndex = 1
        Me.piket.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(22, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Piket:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(27, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Loje e Re !"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Button2.Location = New System.Drawing.Point(27, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Mbyll Lojen!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Loja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Fusha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loja"
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
    Friend WithEvents dbg As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
