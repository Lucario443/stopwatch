' Pepsi Was Here
Imports System.Runtime.InteropServices
Public Class Form1
    Dim timer_enabled As Boolean = False
    Dim start_key_down As Boolean = False
    Dim clr_key_down As Boolean = False
    Dim ovly_key_down As Boolean = False
    Dim restart_key_down As Boolean = False
    ReadOnly timer As New Stopwatch

    Private Enum KeyStates
        None = 0
        Down = 1
        Toggled = 2
    End Enum

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetKeyState(ByVal keyCode As Integer) As Short
    End Function

    Private Shared Function GetKeyState(ByVal key As Keys) As KeyStates
        Dim keeStates = KeyStates.None
        Dim keyState As Integer = GetKeyState(CInt(key))
        If (keyState And 32768) = 32768 Then keeStates = keeStates Or KeyStates.Down
        If (keyState And 1) = 1 Then keeStates = keeStates Or KeyStates.Toggled
        Return keeStates
    End Function
    Public Shared Function IsKeyDown(ByVal key As Keys) As Boolean
        Return KeyStates.Down = (GetKeyState(key) And KeyStates.Down)
    End Function

    Private Sub UpdateTime()
        Dim t As TimeSpan = TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds)
        LabelMs.Text = String.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}",
            t.Hours,
            t.Minutes,
            t.Seconds,
            t.Milliseconds
        )
    End Sub

    Private Sub ButtonAbout_Click() Handles ButtonAbout.Click
        MessageBox.Show("I couldn't find any stop watches that suited my needs that was fully free, so I made one." + vbNewLine + "Enjoy.")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FormTimer.Visible = CheckBoxOverlay.Checked
        If CheckBoxHotkeys.Checked Then
            Dim down As Boolean = IsKeyDown(Keys.F5)
            If start_key_down And Not down Then
                ButtonStart_Click()
                start_key_down = False
            ElseIf down Then
                start_key_down = True
            End If
            down = IsKeyDown(Keys.F6)
            If restart_key_down And Not down Then
                ButtonClear_Click()
                restart_key_down = False
            ElseIf down Then
                restart_key_down = True
            End If
            down = IsKeyDown(Keys.F7)
            If clr_key_down And Not down Then
                ButtonRestart_Click()
                clr_key_down = False
            ElseIf down Then
                clr_key_down = True
            End If
            down = IsKeyDown(Keys.F8)
            If ovly_key_down And Not down Then
                CheckBoxOverlay.Checked = Not CheckBoxOverlay.Checked
                ovly_key_down = False
            ElseIf down Then
                ovly_key_down = True
            End If
        Else
            start_key_down = False
            clr_key_down = False
            ovly_key_down = False
        End If
        If timer_enabled And Not BackgroundWorkerDoStuff.IsBusy Then
            BackgroundWorkerDoStuff.RunWorkerAsync()
        Else
            BackgroundWorkerDoStuff.CancelAsync()
        End If
        UpdateTime()
        TimerMsTick.Enabled = timer_enabled
        NumericUpDownX.Enabled = Not CheckBoxCenterX.Checked
        NumericUpDownY.Enabled = Not CheckBoxCenterY.Checked
    End Sub

    Private Sub ButtonStart_Click() Handles ButtonStart.Click
        timer_enabled = Not timer_enabled
        If timer_enabled Then
            timer.Start()
            ButtonStart.Text = "Pause"
        Else
            timer.Stop()
            ButtonStart.Text = "Resume"
        End If
    End Sub

    Private Sub ButtonClear_Click() Handles ButtonClear.Click
        timer_enabled = False
        ButtonStart.Text = "Start"
        timer.Reset()
    End Sub

    Private Sub BackgroundWorkerDoStuff_DoWork() Handles BackgroundWorkerDoStuff.DoWork
        Try
            While True
                UpdateTime() 'LabelMs.Text = CStr(ctime)
            End While
        Catch
        End Try
    End Sub

    Private Sub TimerMsTick_Tick() Handles TimerMsTick.Tick
        UpdateTime()
        If timer_enabled Then
            TimerMsTick.Interval = 1
            ButtonStart.Text = "Pause"
        Else
            TimerMsTick.Interval = 50
            timer.Stop()
            ButtonStart.Text = "Resume"
        End If
    End Sub

    Private Sub CheckBoxCenterX_CheckedChanged() Handles CheckBoxCenterX.CheckedChanged
        If CheckBoxCenterX.Checked Then
            CheckBoxCenterY.Checked = False
            NumericUpDownX.Enabled = False
            NumericUpDownY.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxCenterY_CheckedChanged() Handles CheckBoxCenterY.CheckedChanged
        If CheckBoxCenterY.Checked Then
            CheckBoxCenterX.Checked = False
            NumericUpDownX.Enabled = False
            NumericUpDownY.Enabled = False
        End If
    End Sub

    Private Sub ButtonRestart_Click() Handles ButtonRestart.Click
        timer.Reset()
        timer_enabled = True
        timer.Start()
        ButtonStart.Text = "Pause"
    End Sub
End Class