<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxChunks = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumChunkNum = New System.Windows.Forms.NumericUpDown()
        Me.NumMaxX = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumMaxZ = New System.Windows.Forms.NumericUpDown()
        Me.NumMaxY = New System.Windows.Forms.NumericUpDown()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumMinZ = New System.Windows.Forms.NumericUpDown()
        Me.NumMinY = New System.Windows.Forms.NumericUpDown()
        Me.NumMinX = New System.Windows.Forms.NumericUpDown()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumChunkNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMaxX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumMaxZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMaxY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumMinZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMinX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ListBoxChunks
        '
        Me.ListBoxChunks.FormattingEnabled = True
        Me.ListBoxChunks.Location = New System.Drawing.Point(12, 27)
        Me.ListBoxChunks.Name = "ListBoxChunks"
        Me.ListBoxChunks.Size = New System.Drawing.Size(166, 134)
        Me.ListBoxChunks.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Chunk Number:"
        '
        'NumChunkNum
        '
        Me.NumChunkNum.Enabled = False
        Me.NumChunkNum.Location = New System.Drawing.Point(271, 27)
        Me.NumChunkNum.Name = "NumChunkNum"
        Me.NumChunkNum.Size = New System.Drawing.Size(107, 20)
        Me.NumChunkNum.TabIndex = 3
        '
        'NumMaxX
        '
        Me.NumMaxX.Enabled = False
        Me.NumMaxX.Location = New System.Drawing.Point(6, 19)
        Me.NumMaxX.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMaxX.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMaxX.Name = "NumMaxX"
        Me.NumMaxX.Size = New System.Drawing.Size(92, 20)
        Me.NumMaxX.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumMaxZ)
        Me.GroupBox1.Controls.Add(Me.NumMaxY)
        Me.GroupBox1.Controls.Add(Me.NumMaxX)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maximum (X, Y, Z)"
        '
        'NumMaxZ
        '
        Me.NumMaxZ.Enabled = False
        Me.NumMaxZ.Location = New System.Drawing.Point(200, 19)
        Me.NumMaxZ.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMaxZ.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMaxZ.Name = "NumMaxZ"
        Me.NumMaxZ.Size = New System.Drawing.Size(92, 20)
        Me.NumMaxZ.TabIndex = 6
        '
        'NumMaxY
        '
        Me.NumMaxY.Enabled = False
        Me.NumMaxY.Location = New System.Drawing.Point(102, 19)
        Me.NumMaxY.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMaxY.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMaxY.Name = "NumMaxY"
        Me.NumMaxY.Size = New System.Drawing.Size(92, 20)
        Me.NumMaxY.TabIndex = 5
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 167)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(80, 23)
        Me.ButtonAdd.TabIndex = 8
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(98, 167)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(80, 23)
        Me.ButtonRemove.TabIndex = 9
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumMinZ)
        Me.GroupBox2.Controls.Add(Me.NumMinY)
        Me.GroupBox2.Controls.Add(Me.NumMinX)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 49)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minimum (X, Y, Z)"
        '
        'NumMinZ
        '
        Me.NumMinZ.Enabled = False
        Me.NumMinZ.Location = New System.Drawing.Point(202, 19)
        Me.NumMinZ.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMinZ.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMinZ.Name = "NumMinZ"
        Me.NumMinZ.Size = New System.Drawing.Size(92, 20)
        Me.NumMinZ.TabIndex = 6
        '
        'NumMinY
        '
        Me.NumMinY.Enabled = False
        Me.NumMinY.Location = New System.Drawing.Point(104, 19)
        Me.NumMinY.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMinY.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMinY.Name = "NumMinY"
        Me.NumMinY.Size = New System.Drawing.Size(92, 20)
        Me.NumMinY.TabIndex = 5
        '
        'NumMinX
        '
        Me.NumMinX.Enabled = False
        Me.NumMinX.Location = New System.Drawing.Point(6, 19)
        Me.NumMinX.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumMinX.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.NumMinX.Name = "NumMinX"
        Me.NumMinX.Size = New System.Drawing.Size(92, 20)
        Me.NumMinX.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Sonic Heroes BLK files (*.bin)|*.bin"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Sonic Heroes BLK files (*.bin)|*.bin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 198)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumChunkNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxChunks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Heroes BLK Visibility Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumChunkNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMaxX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumMaxZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMaxY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumMinZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMinY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMinX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxChunks As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumChunkNum As NumericUpDown
    Friend WithEvents NumMaxX As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents NumMaxZ As NumericUpDown
    Friend WithEvents NumMaxY As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumMinZ As NumericUpDown
    Friend WithEvents NumMinY As NumericUpDown
    Friend WithEvents NumMinX As NumericUpDown
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
