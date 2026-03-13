Imports System
Imports System.Windows.Forms
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Событие загрузки формы
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    ' Событие закрытия формы
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
    End Sub

    ' Событие тика таймера
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTimer.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    ' Обработка нажатий клавиш
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        ' Добавьте обработку клавиш здесь
    End Sub
End Class
