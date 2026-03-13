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

    ' TabControl
    Me.TabControl1.Alignment = TabAlignment.Left
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Location = New Point(0, 0)
    Me.TabControl1.Size = New Size(800, 480)
    Me.TabControl1.Multiline = True

    ' TabPage1 - Launch HUD
    Me.TabPage1.BackColor = Color.FromArgb(25, 25, 25) ' прозрачный тёмный
    Me.TabPage1.Controls.Add(Me.PanelStage)
    Me.TabPage1.Controls.Add(Me.TimerPanel)
    Me.TabPage1.Controls.Add(Me.PropPanel)
    Me.TabPage1.Controls.Add(Me.SpeedLabel)
    Me.TabPage1.Controls.Add(Me.AltLabel)
    Me.TabPage1.Controls.Add(Me.PitchLabel)
    Me.TabPage1.Controls.Add(Me.YawLabel)
    Me.TabPage1.Controls.Add(Me.RollLabel)

    ' PanelStage - этапы
    Me.PanelStage.BackColor = Color.FromArgb(100, 0, 45, 105)
    Me.PanelStage.Location = New Point(150, 10)
    Me.PanelStage.Size = New Size(500, 40)
    Me.PanelStage.BorderStyle = BorderStyle.FixedSingle
    Me.PanelStage.Controls.Add(Me.LabelStage1)
    Me.PanelStage.Controls.Add(Me.LabelStage2)
    Me.PanelStage.Controls.Add(Me.LabelStage3)

    ' Stage Labels
    Dim stages = {Me.LabelStage1, Me.LabelStage2, Me.LabelStage3}
    Dim names = {"STARTUP", "LIFTOFF", "MAX Q"}
    For i As Integer = 0 To 2
        stages(i).Text = names(i)
        stages(i).Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
        stages(i).ForeColor = Color.Cyan
        stages(i).Location = New Point(5 + i * 160, 5)
        stages(i).Size = New Size(150, 30)
        stages(i).TextAlign = ContentAlignment.MiddleCenter
        stages(i).BackColor = Color.FromArgb(80, 0, 70, 120)
    Next

    ' TimerPanel
    Me.TimerPanel.BackColor = Color.FromArgb(120, 0, 45, 105)
    Me.TimerPanel.Location = New Point(250, 70)
    Me.TimerPanel.Size = New Size(300, 60)
    Me.TimerPanel.BorderStyle = BorderStyle.FixedSingle
    Me.TimerPanel.Controls.Add(Me.LabelTimer)

    Me.LabelTimer.Font = New Font("Segoe UI Semibold", 26, FontStyle.Bold)
    Me.LabelTimer.ForeColor = Color.Cyan
    Me.LabelTimer.Location = New Point(0, 0)
    Me.LabelTimer.Size = New Size(300, 60)
    Me.LabelTimer.Text = "T- 00:00:30"
    Me.LabelTimer.TextAlign = ContentAlignment.MiddleCenter

    ' PropPanel - топливо
    Me.PropPanel.BackColor = Color.FromArgb(120, 0, 45, 105)
    Me.PropPanel.Location = New Point(600, 400)
    Me.PropPanel.Size = New Size(180, 50)
    Me.PropPanel.BorderStyle = BorderStyle.FixedSingle
    Me.PropPanel.Controls.Add(Me.LabelProp)

    Me.LabelProp.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.LabelProp.ForeColor = Color.Cyan
    Me.LabelProp.Location = New Point(10, 10)
    Me.LabelProp.Size = New Size(160, 30)
    Me.LabelProp.Text = "PROPELLANT 3/3"
    Me.LabelProp.TextAlign = ContentAlignment.MiddleCenter

    ' Speed, Alt, Pitch, Yaw, Roll Labels
    Me.SpeedLabel.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.SpeedLabel.ForeColor = Color.Cyan
    Me.SpeedLabel.Location = New Point(650, 50)
    Me.SpeedLabel.Size = New Size(120, 30)
    Me.SpeedLabel.Text = "0 m/s"

    Me.AltLabel.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.AltLabel.ForeColor = Color.Cyan
    Me.AltLabel.Location = New Point(650, 90)
    Me.AltLabel.Size = New Size(120, 30)
    Me.AltLabel.Text = "0 m"

    Me.PitchLabel.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.PitchLabel.ForeColor = Color.Cyan
    Me.PitchLabel.Location = New Point(50, 400)
    Me.PitchLabel.Size = New Size(120, 30)
    Me.PitchLabel.Text = "Pitch: 0º"

    Me.YawLabel.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.YawLabel.ForeColor = Color.Cyan
    Me.YawLabel.Location = New Point(50, 440)
    Me.YawLabel.Size = New Size(120, 30)
    Me.YawLabel.Text = "Yaw: 0º"

    Me.RollLabel.Font = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
    Me.RollLabel.ForeColor = Color.Cyan
    Me.RollLabel.Location = New Point(50, 480)
    Me.RollLabel.Size = New Size(120, 30)
    Me.RollLabel.Text = "Roll: 0º"

    ' Form1
    Me.ClientSize = New Size(800, 480)
    Me.Controls.Add(Me.TabControl1)
    Me.FormBorderStyle = FormBorderStyle.None
    Me.BackColor = Color.Black
    Me.Name = "Form1"
    Me.Text = "Telemetry HUD"
End Sub
