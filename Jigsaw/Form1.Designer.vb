<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.hiddenRightBottom = New System.Windows.Forms.Panel()
        Me.hiddenRightTop = New System.Windows.Forms.Panel()
        Me.hiddenLeftBottom = New System.Windows.Forms.Panel()
        Me.hiddenLeftTop = New System.Windows.Forms.Panel()
        Me.steps = New System.Windows.Forms.Label()
        Me.Label_steps = New System.Windows.Forms.Label()
        Me.Label_points = New System.Windows.Forms.Label()
        Me.points = New System.Windows.Forms.Label()
        Me.sampleSecond = New System.Windows.Forms.Panel()
        Me.secondMiddle = New System.Windows.Forms.Panel()
        Me.secondRightBottom = New System.Windows.Forms.Panel()
        Me.secondLeftTop = New System.Windows.Forms.Panel()
        Me.secondRightTop = New System.Windows.Forms.Panel()
        Me.secondLeftBottom = New System.Windows.Forms.Panel()
        Me.sampleFirst = New System.Windows.Forms.Panel()
        Me.firstMiddle = New System.Windows.Forms.Panel()
        Me.firstLeftTop = New System.Windows.Forms.Panel()
        Me.firstLeftBottom = New System.Windows.Forms.Panel()
        Me.firstRightTop = New System.Windows.Forms.Panel()
        Me.firstRightBottom = New System.Windows.Forms.Panel()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.startPB = New System.Windows.Forms.PictureBox()
        Me.mainBoard = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.sampleSecond.SuspendLayout()
        Me.sampleFirst.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        CType(Me.startPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBottom, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 810)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.hiddenRightBottom)
        Me.PanelTop.Controls.Add(Me.hiddenRightTop)
        Me.PanelTop.Controls.Add(Me.hiddenLeftBottom)
        Me.PanelTop.Controls.Add(Me.hiddenLeftTop)
        Me.PanelTop.Controls.Add(Me.steps)
        Me.PanelTop.Controls.Add(Me.Label_steps)
        Me.PanelTop.Controls.Add(Me.Label_points)
        Me.PanelTop.Controls.Add(Me.points)
        Me.PanelTop.Controls.Add(Me.sampleSecond)
        Me.PanelTop.Controls.Add(Me.sampleFirst)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTop.Location = New System.Drawing.Point(3, 3)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(710, 186)
        Me.PanelTop.TabIndex = 0
        '
        'hiddenRightBottom
        '
        Me.hiddenRightBottom.BackColor = System.Drawing.Color.Transparent
        Me.hiddenRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hiddenRightBottom.Location = New System.Drawing.Point(703, 95)
        Me.hiddenRightBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.hiddenRightBottom.Name = "hiddenRightBottom"
        Me.hiddenRightBottom.Size = New System.Drawing.Size(66, 61)
        Me.hiddenRightBottom.TabIndex = 57
        Me.hiddenRightBottom.Visible = False
        '
        'hiddenRightTop
        '
        Me.hiddenRightTop.BackColor = System.Drawing.Color.Transparent
        Me.hiddenRightTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hiddenRightTop.Location = New System.Drawing.Point(703, 34)
        Me.hiddenRightTop.Margin = New System.Windows.Forms.Padding(4)
        Me.hiddenRightTop.Name = "hiddenRightTop"
        Me.hiddenRightTop.Size = New System.Drawing.Size(66, 61)
        Me.hiddenRightTop.TabIndex = 56
        Me.hiddenRightTop.Visible = False
        '
        'hiddenLeftBottom
        '
        Me.hiddenLeftBottom.BackColor = System.Drawing.Color.Transparent
        Me.hiddenLeftBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hiddenLeftBottom.Location = New System.Drawing.Point(665, 95)
        Me.hiddenLeftBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.hiddenLeftBottom.Name = "hiddenLeftBottom"
        Me.hiddenLeftBottom.Size = New System.Drawing.Size(66, 61)
        Me.hiddenLeftBottom.TabIndex = 55
        Me.hiddenLeftBottom.Visible = False
        '
        'hiddenLeftTop
        '
        Me.hiddenLeftTop.BackColor = System.Drawing.Color.Transparent
        Me.hiddenLeftTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hiddenLeftTop.Location = New System.Drawing.Point(665, 34)
        Me.hiddenLeftTop.Margin = New System.Windows.Forms.Padding(4)
        Me.hiddenLeftTop.Name = "hiddenLeftTop"
        Me.hiddenLeftTop.Size = New System.Drawing.Size(66, 61)
        Me.hiddenLeftTop.TabIndex = 54
        Me.hiddenLeftTop.Visible = False
        '
        'steps
        '
        Me.steps.BackColor = System.Drawing.Color.Transparent
        Me.steps.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.steps.ForeColor = System.Drawing.Color.Black
        Me.steps.Location = New System.Drawing.Point(135, 76)
        Me.steps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.steps.Name = "steps"
        Me.steps.Size = New System.Drawing.Size(121, 81)
        Me.steps.TabIndex = 52
        Me.steps.Text = "0"
        Me.steps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_steps
        '
        Me.Label_steps.BackColor = System.Drawing.Color.Transparent
        Me.Label_steps.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_steps.ForeColor = System.Drawing.Color.Black
        Me.Label_steps.Location = New System.Drawing.Point(10, 76)
        Me.Label_steps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_steps.Name = "Label_steps"
        Me.Label_steps.Size = New System.Drawing.Size(127, 81)
        Me.Label_steps.TabIndex = 51
        Me.Label_steps.Text = "Krok:"
        Me.Label_steps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_points
        '
        Me.Label_points.BackColor = System.Drawing.Color.Transparent
        Me.Label_points.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_points.ForeColor = System.Drawing.Color.Black
        Me.Label_points.Location = New System.Drawing.Point(13, 14)
        Me.Label_points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_points.Name = "Label_points"
        Me.Label_points.Size = New System.Drawing.Size(127, 81)
        Me.Label_points.TabIndex = 50
        Me.Label_points.Text = "Punkty:"
        Me.Label_points.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'points
        '
        Me.points.BackColor = System.Drawing.Color.Transparent
        Me.points.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.points.ForeColor = System.Drawing.Color.Red
        Me.points.Location = New System.Drawing.Point(136, 14)
        Me.points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(121, 81)
        Me.points.TabIndex = 49
        Me.points.Text = "0"
        Me.points.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sampleSecond
        '
        Me.sampleSecond.BackColor = System.Drawing.Color.White
        Me.sampleSecond.Controls.Add(Me.secondMiddle)
        Me.sampleSecond.Controls.Add(Me.secondRightBottom)
        Me.sampleSecond.Controls.Add(Me.secondLeftTop)
        Me.sampleSecond.Controls.Add(Me.secondRightTop)
        Me.sampleSecond.Controls.Add(Me.secondLeftBottom)
        Me.sampleSecond.Location = New System.Drawing.Point(494, 25)
        Me.sampleSecond.Margin = New System.Windows.Forms.Padding(4)
        Me.sampleSecond.Name = "sampleSecond"
        Me.sampleSecond.Size = New System.Drawing.Size(153, 142)
        Me.sampleSecond.TabIndex = 47
        '
        'secondMiddle
        '
        Me.secondMiddle.BackColor = System.Drawing.Color.Black
        Me.secondMiddle.Location = New System.Drawing.Point(69, 64)
        Me.secondMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.secondMiddle.Name = "secondMiddle"
        Me.secondMiddle.Size = New System.Drawing.Size(13, 12)
        Me.secondMiddle.TabIndex = 39
        '
        'secondRightBottom
        '
        Me.secondRightBottom.BackColor = System.Drawing.Color.White
        Me.secondRightBottom.Location = New System.Drawing.Point(76, 70)
        Me.secondRightBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.secondRightBottom.Name = "secondRightBottom"
        Me.secondRightBottom.Size = New System.Drawing.Size(67, 62)
        Me.secondRightBottom.TabIndex = 38
        '
        'secondLeftTop
        '
        Me.secondLeftTop.BackColor = System.Drawing.Color.White
        Me.secondLeftTop.Location = New System.Drawing.Point(9, 9)
        Me.secondLeftTop.Margin = New System.Windows.Forms.Padding(4)
        Me.secondLeftTop.Name = "secondLeftTop"
        Me.secondLeftTop.Size = New System.Drawing.Size(67, 62)
        Me.secondLeftTop.TabIndex = 35
        '
        'secondRightTop
        '
        Me.secondRightTop.BackColor = System.Drawing.Color.White
        Me.secondRightTop.Location = New System.Drawing.Point(76, 9)
        Me.secondRightTop.Margin = New System.Windows.Forms.Padding(4)
        Me.secondRightTop.Name = "secondRightTop"
        Me.secondRightTop.Size = New System.Drawing.Size(67, 62)
        Me.secondRightTop.TabIndex = 37
        '
        'secondLeftBottom
        '
        Me.secondLeftBottom.BackColor = System.Drawing.Color.White
        Me.secondLeftBottom.Location = New System.Drawing.Point(9, 70)
        Me.secondLeftBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.secondLeftBottom.Name = "secondLeftBottom"
        Me.secondLeftBottom.Size = New System.Drawing.Size(67, 62)
        Me.secondLeftBottom.TabIndex = 36
        '
        'sampleFirst
        '
        Me.sampleFirst.BackColor = System.Drawing.Color.White
        Me.sampleFirst.Controls.Add(Me.firstMiddle)
        Me.sampleFirst.Controls.Add(Me.firstLeftTop)
        Me.sampleFirst.Controls.Add(Me.firstLeftBottom)
        Me.sampleFirst.Controls.Add(Me.firstRightTop)
        Me.sampleFirst.Controls.Add(Me.firstRightBottom)
        Me.sampleFirst.Location = New System.Drawing.Point(320, 25)
        Me.sampleFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.sampleFirst.Name = "sampleFirst"
        Me.sampleFirst.Size = New System.Drawing.Size(153, 142)
        Me.sampleFirst.TabIndex = 48
        '
        'firstMiddle
        '
        Me.firstMiddle.BackColor = System.Drawing.Color.Black
        Me.firstMiddle.Location = New System.Drawing.Point(69, 64)
        Me.firstMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.firstMiddle.Name = "firstMiddle"
        Me.firstMiddle.Size = New System.Drawing.Size(13, 12)
        Me.firstMiddle.TabIndex = 32
        '
        'firstLeftTop
        '
        Me.firstLeftTop.BackColor = System.Drawing.Color.White
        Me.firstLeftTop.Location = New System.Drawing.Point(9, 9)
        Me.firstLeftTop.Margin = New System.Windows.Forms.Padding(4)
        Me.firstLeftTop.Name = "firstLeftTop"
        Me.firstLeftTop.Size = New System.Drawing.Size(67, 62)
        Me.firstLeftTop.TabIndex = 27
        '
        'firstLeftBottom
        '
        Me.firstLeftBottom.BackColor = System.Drawing.Color.White
        Me.firstLeftBottom.Location = New System.Drawing.Point(9, 70)
        Me.firstLeftBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.firstLeftBottom.Name = "firstLeftBottom"
        Me.firstLeftBottom.Size = New System.Drawing.Size(67, 62)
        Me.firstLeftBottom.TabIndex = 28
        '
        'firstRightTop
        '
        Me.firstRightTop.BackColor = System.Drawing.Color.White
        Me.firstRightTop.Location = New System.Drawing.Point(76, 9)
        Me.firstRightTop.Margin = New System.Windows.Forms.Padding(4)
        Me.firstRightTop.Name = "firstRightTop"
        Me.firstRightTop.Size = New System.Drawing.Size(67, 62)
        Me.firstRightTop.TabIndex = 29
        '
        'firstRightBottom
        '
        Me.firstRightBottom.BackColor = System.Drawing.Color.White
        Me.firstRightBottom.Location = New System.Drawing.Point(76, 70)
        Me.firstRightBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.firstRightBottom.Name = "firstRightBottom"
        Me.firstRightBottom.Size = New System.Drawing.Size(67, 62)
        Me.firstRightBottom.TabIndex = 30
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.startPB)
        Me.PanelBottom.Controls.Add(Me.mainBoard)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBottom.Location = New System.Drawing.Point(3, 195)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(710, 578)
        Me.PanelBottom.TabIndex = 1
        '
        'startPB
        '
        Me.startPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startPB.Image = Global.Jigsaw.My.Resources.Resources._6508f549b984386
        Me.startPB.Location = New System.Drawing.Point(169, 340)
        Me.startPB.Name = "startPB"
        Me.startPB.Size = New System.Drawing.Size(330, 132)
        Me.startPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.startPB.TabIndex = 0
        Me.startPB.TabStop = False
        '
        'mainBoard
        '
        Me.mainBoard.BackColor = System.Drawing.Color.White
        Me.mainBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mainBoard.Location = New System.Drawing.Point(111, 19)
        Me.mainBoard.Name = "mainBoard"
        Me.mainBoard.Size = New System.Drawing.Size(465, 453)
        Me.mainBoard.TabIndex = 55
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 776)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(249, 25)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://visualmonsters.cba.pl"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 810)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JigSaw"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.sampleSecond.ResumeLayout(False)
        Me.sampleFirst.ResumeLayout(False)
        Me.PanelBottom.ResumeLayout(False)
        CType(Me.startPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents steps As Label
    Friend WithEvents Label_steps As Label
    Friend WithEvents Label_points As Label
    Friend WithEvents points As Label
    Friend WithEvents sampleSecond As Panel
    Friend WithEvents secondMiddle As Panel
    Friend WithEvents secondRightBottom As Panel
    Friend WithEvents secondLeftTop As Panel
    Friend WithEvents secondRightTop As Panel
    Friend WithEvents secondLeftBottom As Panel
    Friend WithEvents sampleFirst As Panel
    Friend WithEvents firstMiddle As Panel
    Friend WithEvents firstLeftTop As Panel
    Friend WithEvents firstLeftBottom As Panel
    Friend WithEvents firstRightTop As Panel
    Friend WithEvents firstRightBottom As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents hiddenRightBottom As Panel
    Friend WithEvents hiddenRightTop As Panel
    Friend WithEvents hiddenLeftBottom As Panel
    Friend WithEvents hiddenLeftTop As Panel
    Friend WithEvents mainBoard As Panel
    Friend WithEvents startPB As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
