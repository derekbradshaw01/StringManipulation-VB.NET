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
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.OptionOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionEncrpyt = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionDecrypt = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrpContents = New System.Windows.Forms.GroupBox()
        Me.txtContents = New System.Windows.Forms.RichTextBox()
        Me.GrpCount = New System.Windows.Forms.GroupBox()
        Me.btnCountChars = New System.Windows.Forms.Button()
        Me.TxtNumChars = New System.Windows.Forms.RichTextBox()
        Me.lblNumChars = New System.Windows.Forms.Label()
        Me.btnCountWords = New System.Windows.Forms.Button()
        Me.txtNumWords = New System.Windows.Forms.RichTextBox()
        Me.lblNumWords = New System.Windows.Forms.Label()
        Me.GrpSearch = New System.Windows.Forms.GroupBox()
        Me.lvlANSINum = New System.Windows.Forms.Label()
        Me.txtAnsiNum = New System.Windows.Forms.RichTextBox()
        Me.txtStringIndex = New System.Windows.Forms.RichTextBox()
        Me.lblStringIndex = New System.Windows.Forms.Label()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnSearchWord = New System.Windows.Forms.Button()
        Me.txtSearchTerm = New System.Windows.Forms.RichTextBox()
        Me.lblSearchTerm = New System.Windows.Forms.Label()
        Me.GrpShift = New System.Windows.Forms.GroupBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.RichTextBox()
        Me.txtShifted = New System.Windows.Forms.RichTextBox()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mnu.SuspendLayout()
        Me.GrpContents.SuspendLayout()
        Me.GrpCount.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.GrpShift.SuspendLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnu
        '
        Me.mnu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionOpenFile, Me.OptionEncrpyt, Me.OptionDecrypt, Me.OptionExit})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(952, 24)
        Me.mnu.TabIndex = 0
        Me.mnu.Text = "MenuStrip1"
        '
        'OptionOpenFile
        '
        Me.OptionOpenFile.CheckOnClick = True
        Me.OptionOpenFile.Name = "OptionOpenFile"
        Me.OptionOpenFile.Size = New System.Drawing.Size(69, 20)
        Me.OptionOpenFile.Text = "Open File"
        '
        'OptionEncrpyt
        '
        Me.OptionEncrpyt.CheckOnClick = True
        Me.OptionEncrpyt.Name = "OptionEncrpyt"
        Me.OptionEncrpyt.Size = New System.Drawing.Size(43, 20)
        Me.OptionEncrpyt.Text = "Shift"
        '
        'OptionDecrypt
        '
        Me.OptionDecrypt.CheckOnClick = True
        Me.OptionDecrypt.Name = "OptionDecrypt"
        Me.OptionDecrypt.Size = New System.Drawing.Size(71, 20)
        Me.OptionDecrypt.Text = "Shift Back"
        '
        'OptionExit
        '
        Me.OptionExit.CheckOnClick = True
        Me.OptionExit.Name = "OptionExit"
        Me.OptionExit.Size = New System.Drawing.Size(38, 20)
        Me.OptionExit.Text = "Exit"
        '
        'GrpContents
        '
        Me.GrpContents.Controls.Add(Me.txtContents)
        Me.GrpContents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpContents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpContents.Location = New System.Drawing.Point(305, 36)
        Me.GrpContents.Name = "GrpContents"
        Me.GrpContents.Size = New System.Drawing.Size(635, 197)
        Me.GrpContents.TabIndex = 2
        Me.GrpContents.TabStop = False
        Me.GrpContents.Text = "Text File Contents"
        '
        'txtContents
        '
        Me.txtContents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtContents.Location = New System.Drawing.Point(6, 25)
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(623, 166)
        Me.txtContents.TabIndex = 0
        Me.txtContents.Text = ""
        '
        'GrpCount
        '
        Me.GrpCount.Controls.Add(Me.btnCountChars)
        Me.GrpCount.Controls.Add(Me.TxtNumChars)
        Me.GrpCount.Controls.Add(Me.lblNumChars)
        Me.GrpCount.Controls.Add(Me.btnCountWords)
        Me.GrpCount.Controls.Add(Me.txtNumWords)
        Me.GrpCount.Controls.Add(Me.lblNumWords)
        Me.GrpCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCount.Location = New System.Drawing.Point(12, 248)
        Me.GrpCount.Name = "GrpCount"
        Me.GrpCount.Size = New System.Drawing.Size(457, 149)
        Me.GrpCount.TabIndex = 3
        Me.GrpCount.TabStop = False
        Me.GrpCount.Text = "Count"
        '
        'btnCountChars
        '
        Me.btnCountChars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountChars.Location = New System.Drawing.Point(272, 101)
        Me.btnCountChars.Name = "btnCountChars"
        Me.btnCountChars.Size = New System.Drawing.Size(158, 29)
        Me.btnCountChars.TabIndex = 5
        Me.btnCountChars.Text = "Count Charachters"
        Me.btnCountChars.UseVisualStyleBackColor = True
        '
        'TxtNumChars
        '
        Me.TxtNumChars.Enabled = False
        Me.TxtNumChars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumChars.Location = New System.Drawing.Point(9, 101)
        Me.TxtNumChars.Name = "TxtNumChars"
        Me.TxtNumChars.Size = New System.Drawing.Size(240, 28)
        Me.TxtNumChars.TabIndex = 4
        Me.TxtNumChars.Text = ""
        '
        'lblNumChars
        '
        Me.lblNumChars.AutoSize = True
        Me.lblNumChars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumChars.Location = New System.Drawing.Point(6, 81)
        Me.lblNumChars.Name = "lblNumChars"
        Me.lblNumChars.Size = New System.Drawing.Size(166, 16)
        Me.lblNumChars.TabIndex = 3
        Me.lblNumChars.Text = "Number of Charachters"
        '
        'btnCountWords
        '
        Me.btnCountWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountWords.Location = New System.Drawing.Point(272, 42)
        Me.btnCountWords.Name = "btnCountWords"
        Me.btnCountWords.Size = New System.Drawing.Size(158, 29)
        Me.btnCountWords.TabIndex = 2
        Me.btnCountWords.Text = "Count Words"
        Me.btnCountWords.UseVisualStyleBackColor = True
        '
        'txtNumWords
        '
        Me.txtNumWords.Enabled = False
        Me.txtNumWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumWords.Location = New System.Drawing.Point(9, 42)
        Me.txtNumWords.Name = "txtNumWords"
        Me.txtNumWords.Size = New System.Drawing.Size(240, 28)
        Me.txtNumWords.TabIndex = 1
        Me.txtNumWords.Text = ""
        '
        'lblNumWords
        '
        Me.lblNumWords.AutoSize = True
        Me.lblNumWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumWords.Location = New System.Drawing.Point(6, 22)
        Me.lblNumWords.Name = "lblNumWords"
        Me.lblNumWords.Size = New System.Drawing.Size(128, 16)
        Me.lblNumWords.TabIndex = 0
        Me.lblNumWords.Text = "Number of Words"
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.lvlANSINum)
        Me.GrpSearch.Controls.Add(Me.txtAnsiNum)
        Me.GrpSearch.Controls.Add(Me.txtStringIndex)
        Me.GrpSearch.Controls.Add(Me.lblStringIndex)
        Me.GrpSearch.Controls.Add(Me.btnFindNext)
        Me.GrpSearch.Controls.Add(Me.btnSearchWord)
        Me.GrpSearch.Controls.Add(Me.txtSearchTerm)
        Me.GrpSearch.Controls.Add(Me.lblSearchTerm)
        Me.GrpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSearch.Location = New System.Drawing.Point(475, 248)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(465, 149)
        Me.GrpSearch.TabIndex = 4
        Me.GrpSearch.TabStop = False
        Me.GrpSearch.Text = "Search"
        '
        'lvlANSINum
        '
        Me.lvlANSINum.AutoSize = True
        Me.lvlANSINum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlANSINum.Location = New System.Drawing.Point(237, 82)
        Me.lvlANSINum.Name = "lvlANSINum"
        Me.lvlANSINum.Size = New System.Drawing.Size(101, 16)
        Me.lvlANSINum.TabIndex = 13
        Me.lvlANSINum.Text = "ANSI Number"
        '
        'txtAnsiNum
        '
        Me.txtAnsiNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsiNum.Location = New System.Drawing.Point(240, 101)
        Me.txtAnsiNum.Name = "txtAnsiNum"
        Me.txtAnsiNum.Size = New System.Drawing.Size(210, 28)
        Me.txtAnsiNum.TabIndex = 12
        Me.txtAnsiNum.Text = ""
        '
        'txtStringIndex
        '
        Me.txtStringIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStringIndex.Location = New System.Drawing.Point(6, 102)
        Me.txtStringIndex.Name = "txtStringIndex"
        Me.txtStringIndex.Size = New System.Drawing.Size(213, 28)
        Me.txtStringIndex.TabIndex = 11
        Me.txtStringIndex.Text = ""
        '
        'lblStringIndex
        '
        Me.lblStringIndex.AutoSize = True
        Me.lblStringIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStringIndex.Location = New System.Drawing.Point(3, 82)
        Me.lblStringIndex.Name = "lblStringIndex"
        Me.lblStringIndex.Size = New System.Drawing.Size(89, 16)
        Me.lblStringIndex.TabIndex = 10
        Me.lblStringIndex.Text = "String Index"
        '
        'btnFindNext
        '
        Me.btnFindNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindNext.Location = New System.Drawing.Point(334, 44)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(125, 29)
        Me.btnFindNext.TabIndex = 9
        Me.btnFindNext.Text = "Find Next >>>"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnSearchWord
        '
        Me.btnSearchWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchWord.Location = New System.Drawing.Point(204, 44)
        Me.btnSearchWord.Name = "btnSearchWord"
        Me.btnSearchWord.Size = New System.Drawing.Size(124, 29)
        Me.btnSearchWord.TabIndex = 8
        Me.btnSearchWord.Text = "Search"
        Me.btnSearchWord.UseVisualStyleBackColor = True
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTerm.Location = New System.Drawing.Point(6, 45)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Size = New System.Drawing.Size(192, 28)
        Me.txtSearchTerm.TabIndex = 7
        Me.txtSearchTerm.Text = ""
        '
        'lblSearchTerm
        '
        Me.lblSearchTerm.AutoSize = True
        Me.lblSearchTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTerm.Location = New System.Drawing.Point(3, 25)
        Me.lblSearchTerm.Name = "lblSearchTerm"
        Me.lblSearchTerm.Size = New System.Drawing.Size(97, 16)
        Me.lblSearchTerm.TabIndex = 6
        Me.lblSearchTerm.Text = "Search Term"
        '
        'GrpShift
        '
        Me.GrpShift.Controls.Add(Me.lblKey)
        Me.GrpShift.Controls.Add(Me.txtKey)
        Me.GrpShift.Controls.Add(Me.txtShifted)
        Me.GrpShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpShift.Location = New System.Drawing.Point(12, 403)
        Me.GrpShift.Name = "GrpShift"
        Me.GrpShift.Size = New System.Drawing.Size(928, 149)
        Me.GrpShift.TabIndex = 5
        Me.GrpShift.TabStop = False
        Me.GrpShift.Text = "Charachter Shifting"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.Location = New System.Drawing.Point(812, 57)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(34, 16)
        Me.lblKey.TabIndex = 15
        Me.lblKey.Text = "Key"
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(815, 76)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(97, 28)
        Me.txtKey.TabIndex = 14
        Me.txtKey.Text = ""
        '
        'txtShifted
        '
        Me.txtShifted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShifted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtShifted.Location = New System.Drawing.Point(6, 25)
        Me.txtShifted.Name = "txtShifted"
        Me.txtShifted.Size = New System.Drawing.Size(766, 118)
        Me.txtShifted.TabIndex = 1
        Me.txtShifted.Text = ""
        '
        'picBox1
        '
        Me.picBox1.Image = Global.WorkingWithStrings.My.Resources.Resources.unnamed
        Me.picBox1.InitialImage = CType(resources.GetObject("picBox1.InitialImage"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(18, 30)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(265, 212)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox1.TabIndex = 1
        Me.picBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(952, 588)
        Me.Controls.Add(Me.GrpShift)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.GrpCount)
        Me.Controls.Add(Me.GrpContents)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "Form1"
        Me.Text = "Working With Strings Fall 2021"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.GrpContents.ResumeLayout(False)
        Me.GrpCount.ResumeLayout(False)
        Me.GrpCount.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpShift.ResumeLayout(False)
        Me.GrpShift.PerformLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu As MenuStrip
    Friend WithEvents GrpContents As GroupBox
    Friend WithEvents txtContents As RichTextBox
    Friend WithEvents GrpCount As GroupBox
    Friend WithEvents GrpSearch As GroupBox
    Friend WithEvents GrpShift As GroupBox
    Friend WithEvents lblNumWords As Label
    Friend WithEvents txtNumWords As RichTextBox
    Friend WithEvents btnCountChars As Button
    Friend WithEvents TxtNumChars As RichTextBox
    Friend WithEvents lblNumChars As Label
    Friend WithEvents btnCountWords As Button
    Friend WithEvents lvlANSINum As Label
    Friend WithEvents txtAnsiNum As RichTextBox
    Friend WithEvents txtStringIndex As RichTextBox
    Friend WithEvents lblStringIndex As Label
    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnSearchWord As Button
    Friend WithEvents txtSearchTerm As RichTextBox
    Friend WithEvents lblSearchTerm As Label
    Friend WithEvents lblKey As Label
    Friend WithEvents txtKey As RichTextBox
    Friend WithEvents txtShifted As RichTextBox
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents OptionOpenFile As ToolStripMenuItem
    Friend WithEvents OptionEncrpyt As ToolStripMenuItem
    Friend WithEvents OptionDecrypt As ToolStripMenuItem
    Friend WithEvents OptionExit As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
