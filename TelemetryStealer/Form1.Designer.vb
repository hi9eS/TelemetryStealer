Imports System
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Form

    Private components As System.ComponentModel.IContainer
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
    Friend WithEvents Timer1 As Timer

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

        Me.Timer1.Interval = 1000
    End Sub
End Class
