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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelStage = New System.Windows.Forms.Panel()
        Me.LabelStage1 = New System.Windows.Forms.Label()
        Me.LabelStage2 = New System.Windows.Forms.Label()
        Me.LabelStage3 = New System.Windows.Forms.Label()
        Me.TimerPanel = New System.Windows.Forms.Panel()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.PropPanel = New System.Windows.Forms.Panel()
        Me.LabelProp = New System.Windows.Forms.Label()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.AltLabel = New System.Windows.Forms.Label()
        Me.PitchLabel = New System.Windows.Forms.Label()
        Me.YawLabel = New System.Windows.Forms.Label()
        Me.RollLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)

        ' Настройка элементов (пример)
        Me.Timer1.Interval = 1000

        ' Добавление контролов и прочее здесь, если нужно

    End Sub
End Class
