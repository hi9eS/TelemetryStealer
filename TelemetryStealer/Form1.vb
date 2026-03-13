Imports System.IO
Imports System.Drawing

Public Class Form1
    Private WithEvents UpdateTimer As New Timer()
    Private rocket As Bitmap
    Private theAngle As Integer
    Private propellant As Integer = 3
    Private countdownStart As DateTime
    Private countdownSec As Integer = 30
    Private countdownActive As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Инициализация HUD графики
        rocket = My.Resources.arrow ' берем из ресурсов
        rocket.SetResolution(96.0F, 96.0F)

        ' Таймер обновления HUD
        UpdateTimer.Interval = 80
        UpdateTimer.Start()

        ' Запуск внешней программы (Telemetry Receiver)
        Process.Start("recsilent.exe")

        ' Начальный вид панелей
        TimerLabel.Font = My.Resources.LabelTimer_Font
        TimerLabel.ForeColor = My.Resources.LabelTimer_ForeColor
        PropLabel.Font = My.Resources.LabelProp_Font
        PropLabel.ForeColor = My.Resources.LabelProp_ForeColor

        Stage1Label.Font = My.Resources.LabelStage1_Font
        Stage1Label.ForeColor = My.Resources.LabelStage1_ForeColor
        Stage2Label.Font = My.Resources.LabelStage2_Font
        Stage2Label.ForeColor = My.Resources.LabelStage2_ForeColor
        Stage3Label.Font = My.Resources.LabelStage3_Font
        Stage3Label.ForeColor = My.Resources.LabelStage3_ForeColor
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each p As Process In Process.GetProcessesByName("recsilent")
            p.Kill()
        Next
    End Sub

    Private Sub UpdateHUD(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        ' --------------------------
        ' Считываем значения из текстовых файлов
        ' --------------------------
        AltLabel.Text = File.ReadAllText("rec\2.txt")
        SpeedLabel.Text = File.ReadAllText("rec\1.txt")
        ApLabel.Text = File.ReadAllText("rec\3.txt") & " - " & File.ReadAllText("rec\5.txt")
        PeLabel.Text = File.ReadAllText("rec\4.txt")
        PiLabel.Text = File.ReadAllText("rec\8.txt") & "°"
        MaLabel.Text = File.ReadAllText("rec\7.txt")
        FuLabel.Text = File.ReadAllText("rec\6.txt")
        RollLabel.Text = File.ReadAllText("rec\10.txt") & "°"
        YaLabel.Text = File.ReadAllText("rec\9.txt") & "°"

        ' --------------------------
        ' Обновление стрелки ракеты
        ' --------------------------
        theAngle = Convert.ToInt32(File.ReadAllText("rec\8.txt"))
        PanelArrow.Refresh()
        Using g As Graphics = PanelArrow.CreateGraphics()
            g.Clear(Color.Transparent)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.TranslateTransform(PanelArrow.Width / 2, PanelArrow.Height / 2)
            g.RotateTransform(0 - theAngle + 90)
            g.DrawImage(rocket, -rocket.Width / 2, -rocket.Height / 2)
        End Using

        ' --------------------------
        ' Обновление таймера отсчета
        ' --------------------------
        If countdownActive Then
            Dim elapsed = (DateTime.Now - countdownStart).TotalSeconds
            Dim remaining = countdownSec - elapsed
            TimerLabel.Text = FormatTimer(remaining)
            If remaining <= 0 Then countdownActive = False
        End If

        ' --------------------------
        ' Пропеллент (нажатием клавиши "-" можно менять)
        ' --------------------------
        PropLabel.Text = $"{propellant}/3"
    End Sub

    ' --------------------------
    ' Форматирование таймера в T-00:00:30
    ' --------------------------
    Private Function FormatTimer(seconds As Double) As String
        Dim absSec = Math.Abs(seconds)
        Dim h = 0
        Dim m = Math.Floor(absSec / 60)
        Dim s = absSec Mod 60
        Dim sign = If(seconds > 0, "T-", "T+")
        Return $"{sign} {h:00}:{m:00}:{s:00}"
    End Function

    ' --------------------------
    ' Клавиши управления
    ' --------------------------
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Add Then ' запуск отсчета
            countdownActive = True
            countdownStart = DateTime.Now
        ElseIf e.KeyCode = Keys.Subtract Then ' смена пропеллента
            propellant = (propellant - 1 + 4) Mod 4
        ElseIf e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Then ' сброс таймера
            countdownActive = False
            TimerLabel.Text = "T- 00:00:30"
        ElseIf e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9 Then
            SetStage(e.KeyCode - Keys.D0)
        End If
    End Sub

    Private Sub SetStage(n As Integer)
        Stage1Label.BackColor = If(n = 1, Color.Cyan, Color.Transparent)
        Stage2Label.BackColor = If(n = 2, Color.Cyan, Color.Transparent)
        Stage3Label.BackColor = If(n = 3, Color.Cyan, Color.Transparent)
    End Sub
End Class
