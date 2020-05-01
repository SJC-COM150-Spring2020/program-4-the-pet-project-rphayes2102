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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lblPoint1 = New System.Windows.Forms.Label()
        Me.lblPoint2 = New System.Windows.Forms.Label()
        Me.lblPoint3 = New System.Windows.Forms.Label()
        Me.lblPoint4 = New System.Windows.Forms.Label()
        Me.LblDog = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblBird = New System.Windows.Forms.Label()
        Me.lblFish = New System.Windows.Forms.Label()
        Me.lstout = New System.Windows.Forms.ListBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picFish = New System.Windows.Forms.PictureBox()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Teal
        Me.btnStart.Location = New System.Drawing.Point(51, 39)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(117, 30)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Voting"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.Teal
        Me.txt1.Location = New System.Drawing.Point(39, 104)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 26)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.Teal
        Me.txt2.Location = New System.Drawing.Point(39, 159)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 26)
        Me.txt2.TabIndex = 2
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.Color.Teal
        Me.txt3.Location = New System.Drawing.Point(39, 213)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 26)
        Me.txt3.TabIndex = 3
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.Color.Teal
        Me.txt4.Location = New System.Drawing.Point(39, 266)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 26)
        Me.txt4.TabIndex = 4
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.ForeColor = System.Drawing.Color.Teal
        Me.btnFinish.Location = New System.Drawing.Point(277, 39)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(105, 30)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "Finish "
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblPoint1
        '
        Me.lblPoint1.AutoSize = True
        Me.lblPoint1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint1.ForeColor = System.Drawing.Color.Teal
        Me.lblPoint1.Location = New System.Drawing.Point(323, 113)
        Me.lblPoint1.Name = "lblPoint1"
        Me.lblPoint1.Size = New System.Drawing.Size(16, 16)
        Me.lblPoint1.TabIndex = 6
        Me.lblPoint1.Text = "0"
        '
        'lblPoint2
        '
        Me.lblPoint2.AutoSize = True
        Me.lblPoint2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint2.ForeColor = System.Drawing.Color.Teal
        Me.lblPoint2.Location = New System.Drawing.Point(323, 159)
        Me.lblPoint2.Name = "lblPoint2"
        Me.lblPoint2.Size = New System.Drawing.Size(16, 16)
        Me.lblPoint2.TabIndex = 7
        Me.lblPoint2.Text = "0"
        '
        'lblPoint3
        '
        Me.lblPoint3.AutoSize = True
        Me.lblPoint3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint3.ForeColor = System.Drawing.Color.Teal
        Me.lblPoint3.Location = New System.Drawing.Point(323, 213)
        Me.lblPoint3.Name = "lblPoint3"
        Me.lblPoint3.Size = New System.Drawing.Size(16, 16)
        Me.lblPoint3.TabIndex = 8
        Me.lblPoint3.Text = "0"
        '
        'lblPoint4
        '
        Me.lblPoint4.AutoSize = True
        Me.lblPoint4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint4.ForeColor = System.Drawing.Color.Teal
        Me.lblPoint4.Location = New System.Drawing.Point(323, 266)
        Me.lblPoint4.Name = "lblPoint4"
        Me.lblPoint4.Size = New System.Drawing.Size(16, 16)
        Me.lblPoint4.TabIndex = 9
        Me.lblPoint4.Text = "0"
        '
        'LblDog
        '
        Me.LblDog.AutoSize = True
        Me.LblDog.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDog.ForeColor = System.Drawing.Color.Teal
        Me.LblDog.Location = New System.Drawing.Point(198, 116)
        Me.LblDog.Name = "LblDog"
        Me.LblDog.Size = New System.Drawing.Size(36, 16)
        Me.LblDog.TabIndex = 10
        Me.LblDog.Text = "Dog"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.ForeColor = System.Drawing.Color.Teal
        Me.lblCat.Location = New System.Drawing.Point(201, 171)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(30, 16)
        Me.lblCat.TabIndex = 11
        Me.lblCat.Text = "Cat"
        '
        'lblBird
        '
        Me.lblBird.AutoSize = True
        Me.lblBird.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBird.ForeColor = System.Drawing.Color.Teal
        Me.lblBird.Location = New System.Drawing.Point(198, 218)
        Me.lblBird.Name = "lblBird"
        Me.lblBird.Size = New System.Drawing.Size(36, 16)
        Me.lblBird.TabIndex = 12
        Me.lblBird.Text = "Bird"
        '
        'lblFish
        '
        Me.lblFish.AutoSize = True
        Me.lblFish.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFish.ForeColor = System.Drawing.Color.Teal
        Me.lblFish.Location = New System.Drawing.Point(204, 266)
        Me.lblFish.Name = "lblFish"
        Me.lblFish.Size = New System.Drawing.Size(35, 16)
        Me.lblFish.TabIndex = 13
        Me.lblFish.Text = "Fish"
        '
        'lstout
        '
        Me.lstout.FormattingEnabled = True
        Me.lstout.Location = New System.Drawing.Point(154, 293)
        Me.lstout.Name = "lstout"
        Me.lstout.Size = New System.Drawing.Size(238, 186)
        Me.lstout.TabIndex = 14
        '
        'picBird
        '
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(438, 12)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(125, 136)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird.TabIndex = 15
        Me.picBird.TabStop = False
        Me.picBird.Visible = False
        '
        'picDog
        '
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(620, 12)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(104, 136)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 16
        Me.picDog.TabStop = False
        Me.picDog.Visible = False
        '
        'picCat
        '
        Me.picCat.Image = CType(resources.GetObject("picCat.Image"), System.Drawing.Image)
        Me.picCat.Location = New System.Drawing.Point(438, 171)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(125, 137)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCat.TabIndex = 17
        Me.picCat.TabStop = False
        Me.picCat.Visible = False
        '
        'picFish
        '
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(620, 171)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(104, 137)
        Me.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFish.TabIndex = 18
        Me.picFish.TabStop = False
        Me.picFish.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 497)
        Me.Controls.Add(Me.picFish)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.lstout)
        Me.Controls.Add(Me.lblFish)
        Me.Controls.Add(Me.lblBird)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.LblDog)
        Me.Controls.Add(Me.lblPoint4)
        Me.Controls.Add(Me.lblPoint3)
        Me.Controls.Add(Me.lblPoint2)
        Me.Controls.Add(Me.lblPoint1)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents lblPoint1 As Label
    Friend WithEvents lblPoint2 As Label
    Friend WithEvents lblPoint3 As Label
    Friend WithEvents lblPoint4 As Label
    Friend WithEvents LblDog As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents lblBird As Label
    Friend WithEvents lblFish As Label
    Friend WithEvents lstout As ListBox
    Friend WithEvents picBird As PictureBox
    Friend WithEvents picDog As PictureBox
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picFish As PictureBox
End Class
