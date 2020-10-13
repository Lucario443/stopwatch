Imports System.Runtime.InteropServices

Public Class FormTimer
    <DllImport("user32.dll")>
    Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As UInteger) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As UInteger
    End Function
    Private Sub FormTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetWindowLong(Handle, -20, GetWindowLong(Handle, -20) Or &H80000 Or &H20)
        DoubleBuffered = True
    End Sub

    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        LabelTime.Font = New Font(Font.FontFamily, Form1.NumericUpDownSize.Value, FontStyle.Regular)
        If Form1.CheckBoxCenterX.Checked Then
            LabelTime.AutoSize = False
            LabelTime.TextAlign = ContentAlignment.MiddleCenter
            LabelTime.RightToLeft = RightToLeft.Yes
            If Form1.CheckBoxInvert.Checked Then
                LabelTime.Dock = DockStyle.Bottom
            Else
                LabelTime.Dock = DockStyle.Top
            End If
        ElseIf Form1.CheckBoxCenterY.Checked Then
            LabelTime.AutoSize = False
            If Form1.CheckBoxInvert.Checked Then
                LabelTime.TextAlign = ContentAlignment.MiddleRight
                LabelTime.Dock = DockStyle.Right
            Else
                LabelTime.TextAlign = ContentAlignment.MiddleLeft
                LabelTime.Dock = DockStyle.Left
            End If
        Else
            LabelTime.Dock = DockStyle.None
            LabelTime.RightToLeft = RightToLeft.No
            LabelTime.TextAlign = ContentAlignment.MiddleCenter
            LabelTime.AutoSize = True
            LabelTime.Location = New Point(Form1.NumericUpDownX.Value, Form1.NumericUpDownY.Value)
        End If
    End Sub

    Private Sub TimerTick_Tick(sender As Object, e As EventArgs) Handles TimerTick.Tick
        LabelTime.Text = Form1.LabelMs.Text
    End Sub

End Class