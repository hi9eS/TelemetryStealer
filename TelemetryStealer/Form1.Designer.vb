<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PanelStage As Panel
    Friend WithEvents LabelStage1 As Label
    Friend WithEvents LabelStage2 As Label
    Friend WithEvents LabelStage3 As Label
    Friend WithEvents TimerPanel As Panel
    Friend WithEvents LabelTimer As Label
    Friend WithEvents PropPanel As Panel
    Friend WithEvents LabelProp As Label
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents AltLabel As Label
    Friend WithEvents PitchLabel As Label
    Friend WithEvents YawLabel As Label
    Friend WithEvents RollLabel As Label
    Friend WithEvents TabPage2 As TabPage

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.PanelStage = New Panel()
        Me.LabelStage1 = New Label()
        Me.LabelStage2 = New Label()
        Me.LabelStage3 = New Label()
        Me.TimerPanel = New Panel()
        Me.LabelTimer = New Label()
        Me.PropPanel = New Panel()
        Me.LabelProp = New Label()
        Me.SpeedLabel = New Label()
        Me.AltLabel = New Label()
        Me.PitchLabel = New Label()
        Me.YawLabel = New Label()
        Me.RollLabel = New Label()
        Me.TabPage2 = New TabPage()
        Me.Timer1 = New Timer(Me.components)

        ' Настройки формы
        Me.SuspendLayout()
        Me.ClientSize = New Size(800, 600)
        Me.Text = "Telemetry Stealer"

        ' Добавляем TabControl
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = DockStyle.Fill

        ' Настройка TabPage1
        Me.TabPage1.Controls.Add(Me.PanelStage)
        Me.TabPage1.Controls.Add(Me.TimerPanel)
        Me.TabPage1.Controls.Add(Me.PropPanel)

        ' Настройка LabelStage
        Me.LabelStage1.ForeColor = Color.Cyan
        Me.LabelStage1.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        Me.LabelStage2.ForeColor = Color.Cyan
        Me.LabelStage2.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        Me.LabelStage3.ForeColor = Color.Cyan
        Me.LabelStage3.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)

        ' Настройка LabelTimer
        Me.LabelTimer.ForeColor = Color.Cyan
        Me.LabelTimer.Font = New Font("Segoe UI Semibold", 26, FontStyle.Bold)

        ' Настройка LabelProp
        Me.LabelProp.ForeColor = Color.Cyan
        Me.LabelProp.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)

        ' Настройка остальных Label
        Dim labels() As Label = {SpeedLabel, AltLabel, PitchLabel, YawLabel, RollLabel}
        For Each lbl In labels
            lbl.ForeColor = Color.Cyan
            lbl.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
        Next

        ' Добавляем элементы на форму
        Me.TabPage1.Controls.AddRange({LabelStage1, LabelStage2, LabelStage3, LabelTimer, LabelProp, SpeedLabel, AltLabel, PitchLabel, YawLabel, RollLabel})
        Me.Controls.Add(Me.TabControl1)

        Me.ResumeLayout(False)
    End Sub
End Class
