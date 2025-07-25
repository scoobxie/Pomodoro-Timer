<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTimer = New Label()
        Start = New Button()
        Reset = New Button()
        timer1 = New Timer(components)
        TextBox1 = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = Color.Transparent
        lblTimer.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = Color.OliveDrab
        lblTimer.Location = New Point(248, 186)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(142, 65)
        lblTimer.TabIndex = 0
        lblTimer.Text = "25:00"
        ' 
        ' Start
        ' 
        Start.BackColor = Color.HotPink
        Start.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Start.ForeColor = Color.White
        Start.Location = New Point(142, 254)
        Start.Name = "Start"
        Start.Size = New Size(170, 34)
        Start.TabIndex = 1
        Start.Text = "Start"
        Start.UseVisualStyleBackColor = False
        ' 
        ' Reset
        ' 
        Reset.BackColor = Color.HotPink
        Reset.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Reset.ForeColor = Color.White
        Reset.Location = New Point(318, 254)
        Reset.Name = "Reset"
        Reset.Size = New Size(179, 34)
        Reset.TabIndex = 2
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = False
        ' 
        ' timer1
        ' 
        timer1.Interval = 1000
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Location = New Point(142, 294)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(355, 23)
        TextBox1.TabIndex = 3
        TextBox1.Text = "What would you like to accomplish?"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.HotPink
        Label1.Location = New Point(155, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 50)
        Label1.TabIndex = 4
        Label1.Text = "Pomodoro Timer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.scoob_shrek
        PictureBox1.Location = New Point(267, 86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 100)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(648, 373)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Reset)
        Controls.Add(Start)
        Controls.Add(lblTimer)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents Start As Button
    Friend WithEvents Reset As Button
    Friend WithEvents timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
