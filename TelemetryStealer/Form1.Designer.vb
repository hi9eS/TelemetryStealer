Imports System
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
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

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New TabControl()
        Me.TabPage1 = New TabPage()
        Me.TabPage2 = New TabPage()
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
        Me.Timer1 = New Timer(Me.components)

        ' Настройка формы
        Me.SuspendLayout()
        Me.ClientSize = New Size(800, 600)
        Me.Text = "Telemetry Stealer"

        ' TabControl
        Me.TabControl1.Dock = DockStyle.Fill
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)

        ' TabPage1
        Me.TabPage1.Controls.AddRange({PanelStage, TimerPanel, PropPanel})
        Me.TabPage2.Text = "Tab 2"

        ' PanelStage
        Me.PanelStage.Controls.AddRange({LabelStage1, LabelStage2, LabelStage3})

        ' TimerPanel
        Me.TimerPanel.Controls.Add(LabelTimer)

        ' PropPanel
        Me.PropPanel.Controls.AddRange({LabelProp, SpeedLabel, AltLabel, PitchLabel, YawLabel, RollLabel})

        ' Labels default
        Dim labels() As Label = {LabelStage1, LabelStage2, LabelStage3, LabelTimer, LabelProp, SpeedLabel, AltLabel, PitchLabel, YawLabel, RollLabel}
        For Each lbl In labels
            lbl.ForeColor = Color.Cyan
            lbl.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
        Next

        ' Добавляем TabControl на форму
        Me.Controls.Add(TabControl1)
        Me.ResumeLayout(False)
    End Sub
End Class
