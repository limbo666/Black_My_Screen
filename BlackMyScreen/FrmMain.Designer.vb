<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowTipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StayOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPopTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MakeWindowTinyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ShowTipsToolStripMenuItem, Me.StayOnTopToolStripMenuItem, Me.DisplayPopTextToolStripMenuItem, Me.ToolStripMenuItem2, Me.MakeWindowTinyToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 148)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 6)
        '
        'ShowTipsToolStripMenuItem
        '
        Me.ShowTipsToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.ShowTipsToolStripMenuItem.Name = "ShowTipsToolStripMenuItem"
        Me.ShowTipsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ShowTipsToolStripMenuItem.Text = "Show Tips"
        '
        'StayOnTopToolStripMenuItem
        '
        Me.StayOnTopToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.StayOnTopToolStripMenuItem.Name = "StayOnTopToolStripMenuItem"
        Me.StayOnTopToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.StayOnTopToolStripMenuItem.Text = "Stay On Top"
        '
        'DisplayPopTextToolStripMenuItem
        '
        Me.DisplayPopTextToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.DisplayPopTextToolStripMenuItem.Name = "DisplayPopTextToolStripMenuItem"
        Me.DisplayPopTextToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DisplayPopTextToolStripMenuItem.Text = "Display Popup Text"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 6)
        '
        'MakeWindowTinyToolStripMenuItem
        '
        Me.MakeWindowTinyToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.MakeWindowTinyToolStripMenuItem.Name = "MakeWindowTinyToolStripMenuItem"
        Me.MakeWindowTinyToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MakeWindowTinyToolStripMenuItem.Text = "Make Window Tiny"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label1.Location = New System.Drawing.Point(75, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Right click for context menu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drag the form to move it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double click to cover e" &
    "ntire screen."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label2.Location = New System.Drawing.Point(75, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TIPS:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblRandom.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblRandom.Location = New System.Drawing.Point(75, 150)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(106, 16)
        Me.lblRandom.TabIndex = 3
        Me.lblRandom.Text = "Black my screen"
        Me.lblRandom.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.MediumOrchid
        Me.lblTitle.Location = New System.Drawing.Point(15, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(41, 39)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Black" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "My" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label3.Location = New System.Drawing.Point(75, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "BLACK MY SCREEN"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(458, 434)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StayOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShowTipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRandom As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents DisplayPopTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MakeWindowTinyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label3 As Label
End Class
