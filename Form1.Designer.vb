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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.CheckBoxOverlay = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHotkeys = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.NumericUpDownX = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownY = New System.Windows.Forms.NumericUpDown()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxEnabled = New System.Windows.Forms.CheckBox()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelMs = New System.Windows.Forms.Label()
        Me.NumericUpDownSize = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerDoStuff = New System.ComponentModel.BackgroundWorker()
        Me.TimerMsTick = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxCenterX = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCenterY = New System.Windows.Forms.CheckBox()
        Me.CheckBoxInvert = New System.Windows.Forms.CheckBox()
        Me.ButtonRestart = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(12, 12)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(56, 23)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(74, 12)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(41, 23)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'CheckBoxOverlay
        '
        Me.CheckBoxOverlay.AutoSize = True
        Me.CheckBoxOverlay.Checked = True
        Me.CheckBoxOverlay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxOverlay.Location = New System.Drawing.Point(178, 16)
        Me.CheckBoxOverlay.Name = "CheckBoxOverlay"
        Me.CheckBoxOverlay.Size = New System.Drawing.Size(95, 17)
        Me.CheckBoxOverlay.TabIndex = 2
        Me.CheckBoxOverlay.Text = "Overlay Active"
        Me.CheckBoxOverlay.UseVisualStyleBackColor = True
        '
        'CheckBoxHotkeys
        '
        Me.CheckBoxHotkeys.AutoSize = True
        Me.CheckBoxHotkeys.Checked = True
        Me.CheckBoxHotkeys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxHotkeys.Location = New System.Drawing.Point(279, 16)
        Me.CheckBoxHotkeys.Name = "CheckBoxHotkeys"
        Me.CheckBoxHotkeys.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxHotkeys.TabIndex = 3
        Me.CheckBoxHotkeys.Text = "Enable Hotkeys"
        Me.CheckBoxHotkeys.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 52)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "F5 - Start/Pause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F6 - Restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F7 - Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F8 - Toggle Overlay"
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Location = New System.Drawing.Point(301, 39)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(75, 75)
        Me.ButtonAbout.TabIndex = 5
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'NumericUpDownX
        '
        Me.NumericUpDownX.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownX.Location = New System.Drawing.Point(230, 42)
        Me.NumericUpDownX.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownX.Name = "NumericUpDownX"
        Me.NumericUpDownX.Size = New System.Drawing.Size(65, 20)
        Me.NumericUpDownX.TabIndex = 6
        '
        'NumericUpDownY
        '
        Me.NumericUpDownY.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownY.Location = New System.Drawing.Point(229, 68)
        Me.NumericUpDownY.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownY.Name = "NumericUpDownY"
        Me.NumericUpDownY.Size = New System.Drawing.Size(66, 20)
        Me.NumericUpDownY.TabIndex = 7
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(190, 44)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(35, 13)
        Me.LabelX.TabIndex = 8
        Me.LabelX.Text = "X Pos"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.Location = New System.Drawing.Point(190, 70)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(35, 13)
        Me.LabelY.TabIndex = 9
        Me.LabelY.Text = "Y Pos"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'CheckBoxEnabled
        '
        Me.CheckBoxEnabled.Enabled = False
        Me.CheckBoxEnabled.Location = New System.Drawing.Point(-10, -10)
        Me.CheckBoxEnabled.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxEnabled.Name = "CheckBoxEnabled"
        Me.CheckBoxEnabled.Size = New System.Drawing.Size(0, 0)
        Me.CheckBoxEnabled.TabIndex = 10
        Me.CheckBoxEnabled.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.Location = New System.Drawing.Point(12, 101)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(33, 13)
        Me.LabelTime.TabIndex = 11
        Me.LabelTime.Text = "Time:"
        '
        'LabelMs
        '
        Me.LabelMs.AutoSize = True
        Me.LabelMs.Location = New System.Drawing.Point(42, 101)
        Me.LabelMs.Name = "LabelMs"
        Me.LabelMs.Size = New System.Drawing.Size(13, 13)
        Me.LabelMs.TabIndex = 12
        Me.LabelMs.Text = "0"
        '
        'NumericUpDownSize
        '
        Me.NumericUpDownSize.Location = New System.Drawing.Point(229, 94)
        Me.NumericUpDownSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownSize.Name = "NumericUpDownSize"
        Me.NumericUpDownSize.Size = New System.Drawing.Size(66, 20)
        Me.NumericUpDownSize.TabIndex = 13
        Me.NumericUpDownSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Size"
        '
        'BackgroundWorkerDoStuff
        '
        Me.BackgroundWorkerDoStuff.WorkerSupportsCancellation = True
        '
        'TimerMsTick
        '
        Me.TimerMsTick.Interval = 1
        '
        'CheckBoxCenterX
        '
        Me.CheckBoxCenterX.AutoSize = True
        Me.CheckBoxCenterX.Checked = True
        Me.CheckBoxCenterX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCenterX.Location = New System.Drawing.Point(135, 43)
        Me.CheckBoxCenterX.Name = "CheckBoxCenterX"
        Me.CheckBoxCenterX.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxCenterX.TabIndex = 15
        Me.CheckBoxCenterX.Text = "Center"
        Me.CheckBoxCenterX.UseVisualStyleBackColor = True
        '
        'CheckBoxCenterY
        '
        Me.CheckBoxCenterY.AutoSize = True
        Me.CheckBoxCenterY.Location = New System.Drawing.Point(135, 69)
        Me.CheckBoxCenterY.Name = "CheckBoxCenterY"
        Me.CheckBoxCenterY.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxCenterY.TabIndex = 16
        Me.CheckBoxCenterY.Text = "Center"
        Me.CheckBoxCenterY.UseVisualStyleBackColor = True
        '
        'CheckBoxInvert
        '
        Me.CheckBoxInvert.AutoSize = True
        Me.CheckBoxInvert.Location = New System.Drawing.Point(135, 92)
        Me.CheckBoxInvert.Name = "CheckBoxInvert"
        Me.CheckBoxInvert.Size = New System.Drawing.Size(53, 17)
        Me.CheckBoxInvert.TabIndex = 17
        Me.CheckBoxInvert.Text = "Invert"
        Me.CheckBoxInvert.UseVisualStyleBackColor = True
        '
        'ButtonRestart
        '
        Me.ButtonRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonRestart.Location = New System.Drawing.Point(121, 12)
        Me.ButtonRestart.Name = "ButtonRestart"
        Me.ButtonRestart.Size = New System.Drawing.Size(51, 23)
        Me.ButtonRestart.TabIndex = 18
        Me.ButtonRestart.Text = "Restart"
        Me.ButtonRestart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 123)
        Me.Controls.Add(Me.ButtonRestart)
        Me.Controls.Add(Me.CheckBoxInvert)
        Me.Controls.Add(Me.CheckBoxCenterY)
        Me.Controls.Add(Me.CheckBoxCenterX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownSize)
        Me.Controls.Add(Me.LabelMs)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.CheckBoxEnabled)
        Me.Controls.Add(Me.LabelY)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.NumericUpDownY)
        Me.Controls.Add(Me.NumericUpDownX)
        Me.Controls.Add(Me.ButtonAbout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxHotkeys)
        Me.Controls.Add(Me.CheckBoxOverlay)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pepsi's Stop Watch"
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents CheckBoxOverlay As CheckBox
    Friend WithEvents CheckBoxHotkeys As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAbout As Button
    Friend WithEvents NumericUpDownX As NumericUpDown
    Friend WithEvents NumericUpDownY As NumericUpDown
    Friend WithEvents LabelX As Label
    Friend WithEvents LabelY As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBoxEnabled As CheckBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelMs As Label
    Friend WithEvents NumericUpDownSize As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorkerDoStuff As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerMsTick As Timer
    Friend WithEvents CheckBoxCenterX As CheckBox
    Friend WithEvents CheckBoxCenterY As CheckBox
    Friend WithEvents CheckBoxInvert As CheckBox
    Friend WithEvents ButtonRestart As Button
End Class
