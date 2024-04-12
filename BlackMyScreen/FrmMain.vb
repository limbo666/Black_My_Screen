Imports System.Reflection.Emit
Imports System.Windows.Forms
Public Class FrmMain
    Dim RandomTime As Integer = 3
    Dim StayOnTop As Boolean = False
    Dim DisplayRandomText As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = GetSetting("Black My Screen", "Settings", "Top", 100)
        Me.Left = GetSetting("Black My Screen", "Settings", "Left", 100)
        StayOnTop = GetSetting("Black My Screen", "Settings", "StayOnTop", False)
        DisplayRandomText = GetSetting("Black My Screen", "Settings", "DisplayRandomText", False)
        Dim screen As Screen = Screen.PrimaryScreen
        Dim resolution As Size = screen.Bounds.Size
        Call Form1_DoubleClick(Nothing, Nothing)

        If StayOnTop = True Then
            Me.TopMost = True
            Dim myFont As New Font(StayOnTopToolStripMenuItem.Font, FontStyle.Regular)

            StayOnTopToolStripMenuItem.Font = myFont
        Else
            Me.TopMost = False
            Dim myFont As New Font(StayOnTopToolStripMenuItem.Font, FontStyle.Strikeout)
            StayOnTopToolStripMenuItem.Font = myFont
        End If

        Timer1.Enabled = True

        If DisplayRandomText = True Then
            lblRandom.Visible = True
            Dim myFont As New Font(DisplayPopTextToolStripMenuItem.Font, FontStyle.Regular)
            DisplayPopTextToolStripMenuItem.Font = myFont
            Timer2.Enabled = True
        Else
            lblRandom.Visible = False
            Dim myFont As New Font(DisplayPopTextToolStripMenuItem.Font, FontStyle.Strikeout)
            DisplayPopTextToolStripMenuItem.Font = myFont
            Timer2.Enabled = False
        End If

    End Sub


    ' Variables to store mouse position during drag
    Private isDragging As Boolean = False
    Private startPoint As New Point(0, 0)

    ' Handle the MouseDown event to start the drag
    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Handle the MouseMove event to move the form during drag
    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
            Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    ' Handle the MouseUp event to end the drag
    Private Sub MainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        ' Find the screen that the form is on
        Dim screen As Screen = Screen.FromControl(Me)

        ' Get the top-left coordinates of the screen
        Dim screenTopLeft As Point = screen.Bounds.Location



        '    Dim screen As Screen = Screen.PrimaryScreen
        Dim resolution As Size = screen.Bounds.Size
        Me.Size = resolution
        Me.Top = screenTopLeft.Y
        Me.Left = screenTopLeft.X
        lblTitle.Visible = False

        If ReturnRandomPopup = True Then
            ReturnRandomPopup = False
            Timer2.Enabled = True

        End If

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        ' Find the screen that the form is on
        '    Dim screen As Screen = Screen.FromControl(Me)

        ' Get the top-left coordinates of the screen
        '   Dim screenTopLeft As Point = screen.Bounds.Location

        ' Display the coordinates (replace this with your actual usage)
        '     MessageBox.Show($"Top: {screenTopLeft.Y}, Left: {screenTopLeft.X}", "Screen Coordinates", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSetting("Black My Screen", "Settings", "Top", Me.Top)
        SaveSetting("Black My Screen", "Settings", "Left", Me.Left)
        SaveSetting("Black My Screen", "Settings", "StayOnTop", StayOnTop)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'MsgBox("Simple controls by HandWaterPump")
        If Me.TopMost = True Then
            Me.TopMost = False
            FrmAbout.TopMost = True
            ReturnToTopmost = True

        End If

        FrmAbout.Show()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub StayOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StayOnTopToolStripMenuItem.Click

        If StayOnTop = True Then
            StayOnTop = False
            ' Assuming you have a Label control named "myLabel"
            Dim myFont As New Font(StayOnTopToolStripMenuItem.Font, FontStyle.Strikeout)
            StayOnTopToolStripMenuItem.Font = myFont

        Else
            StayOnTop = True
            Dim myFont As New Font(StayOnTopToolStripMenuItem.Font, FontStyle.Regular)
            StayOnTopToolStripMenuItem.Font = myFont
        End If


        If StayOnTop = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Label2.Visible = False


        Timer1.Enabled = False

    End Sub

    Private Sub ShowTipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowTipsToolStripMenuItem.Click
        Timer1.Enabled = True
        Label1.Visible = True
        Label2.Visible = True
    End Sub


    Private Sub SetLabelAtRandomPosition()
        ' Create a random number generator
        Dim random As New Random()

        ' Set the maximum X and Y coordinates for the label's position
        Dim maxX As Integer = Me.ClientSize.Width - lblRandom.Width
        Dim maxY As Integer = Me.ClientSize.Height - lblRandom.Height

        ' Generate random X and Y coordinates within the form's boundaries
        Dim randomX As Integer = random.Next(0, maxX)
        Dim randomY As Integer = random.Next(0, maxY)

        ' Set the label's location using the random coordinates
        lblRandom.Location = New Point(randomX, randomY)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RandomTime = RandomTime - 1
        If RandomTime = 0 Then
            RandomTime = 3
            SetLabelAtRandomPosition()

        End If
    End Sub

    Private Sub DisplayPopTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayPopTextToolStripMenuItem.Click
        If DisplayRandomText = True Then
            DisplayRandomText = False
            Timer1.Enabled = False
            lblRandom.Visible = False
            Dim myFont As New Font(DisplayPopTextToolStripMenuItem.Font, FontStyle.Strikeout)
            DisplayPopTextToolStripMenuItem.Font = myFont
        Else
            DisplayRandomText = True
            Timer2.Enabled = True
            lblRandom.Visible = True
            Dim myFont As New Font(DisplayPopTextToolStripMenuItem.Font, FontStyle.Regular)
            DisplayPopTextToolStripMenuItem.Font = myFont
        End If

    End Sub

    Private Sub MakeWindowTinyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeWindowTinyToolStripMenuItem.Click
        Me.Height = 64
        Me.Width = 64
        lblTitle.Visible = True
        If Timer2.Enabled = True Then
            Timer2.Enabled = False
            ReturnRandomPopup = True

        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        Call Form1_DoubleClick(Nothing, Nothing)
    End Sub


    ''' Handle the MouseDown event for lblTitle to start the drag
    ''Private Sub lblTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown
    ''    If e.Button = MouseButtons.Left Then
    ''        ' Cancel the default action for the MouseDown event
    ''        CType(sender, Control).Capture = False

    ''        isDragging = True
    ''        startPoint = New Point(e.X, e.Y)
    ''    End If
    ''End Sub

    ''' Handle the MouseMove event to move the form during drag
    ''Private Sub lblTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseMove
    ''    If isDragging Then
    ''        Dim p As Point = Me.PointToScreen(New Point(e.X, e.Y))
    ''        Me.Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
    ''    End If
    ''End Sub

    ''' Handle the MouseUp event to end the drag
    ''Private Sub lblTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseUp
    ''    If e.Button = MouseButtons.Left Then
    ''        isDragging = False
    ''    End If
    ''End Sub
End Class
