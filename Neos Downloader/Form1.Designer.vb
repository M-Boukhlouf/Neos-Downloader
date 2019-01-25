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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New Neos_Downloader.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RemoveAllLinksButton = New Neos_Downloader.XylosButton()
        Me.RemoveLinkButton = New Neos_Downloader.XylosButton()
        Me.AddLinkButton = New Neos_Downloader.XylosButton()
        Me.LinksListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DelayUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BuildPage = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DelayUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "download.png")
        Me.ImageList1.Images.SetKeyName(1, "link.png")
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.BuildPage)
        Me.TabControl1.FirstHeaderBorder = False
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(40, 170)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(532, 217)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.RemoveAllLinksButton)
        Me.TabPage1.Controls.Add(Me.RemoveLinkButton)
        Me.TabPage1.Controls.Add(Me.AddLinkButton)
        Me.TabPage1.Controls.Add(Me.LinksListBox)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.ImageIndex = 1
        Me.TabPage1.Location = New System.Drawing.Point(174, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(354, 209)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Links"
        '
        'RemoveAllLinksButton
        '
        Me.RemoveAllLinksButton.EnabledCalc = True
        Me.RemoveAllLinksButton.Location = New System.Drawing.Point(222, 166)
        Me.RemoveAllLinksButton.Name = "RemoveAllLinksButton"
        Me.RemoveAllLinksButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveAllLinksButton.TabIndex = 4
        Me.RemoveAllLinksButton.Text = "Remove All"
        '
        'RemoveLinkButton
        '
        Me.RemoveLinkButton.EnabledCalc = True
        Me.RemoveLinkButton.Location = New System.Drawing.Point(141, 166)
        Me.RemoveLinkButton.Name = "RemoveLinkButton"
        Me.RemoveLinkButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveLinkButton.TabIndex = 3
        Me.RemoveLinkButton.Text = "Remove"
        '
        'AddLinkButton
        '
        Me.AddLinkButton.EnabledCalc = True
        Me.AddLinkButton.Location = New System.Drawing.Point(60, 166)
        Me.AddLinkButton.Name = "AddLinkButton"
        Me.AddLinkButton.Size = New System.Drawing.Size(75, 23)
        Me.AddLinkButton.TabIndex = 2
        Me.AddLinkButton.Text = "Add"
        '
        'LinksListBox
        '
        Me.LinksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinksListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.LinksListBox.FormattingEnabled = True
        Me.LinksListBox.ItemHeight = 15
        Me.LinksListBox.Location = New System.Drawing.Point(6, 8)
        Me.LinksListBox.Name = "LinksListBox"
        Me.LinksListBox.Size = New System.Drawing.Size(339, 137)
        Me.LinksListBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DelayUpDown)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(174, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(354, 209)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Delay (seconds):"
        '
        'DelayUpDown
        '
        Me.DelayUpDown.BackColor = System.Drawing.SystemColors.Window
        Me.DelayUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DelayUpDown.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DelayUpDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.DelayUpDown.Location = New System.Drawing.Point(9, 23)
        Me.DelayUpDown.Name = "DelayUpDown"
        Me.DelayUpDown.Size = New System.Drawing.Size(87, 23)
        Me.DelayUpDown.TabIndex = 2
        '
        'BuildPage
        '
        Me.BuildPage.BackColor = System.Drawing.Color.White
        Me.BuildPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BuildPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.BuildPage.ImageIndex = 0
        Me.BuildPage.Location = New System.Drawing.Point(174, 4)
        Me.BuildPage.Name = "BuildPage"
        Me.BuildPage.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.BuildPage.Size = New System.Drawing.Size(354, 209)
        Me.BuildPage.TabIndex = 1
        Me.BuildPage.Text = "Build"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 217)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neos Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DelayUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As Neos_Downloader.XylosTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BuildPage As System.Windows.Forms.TabPage
    Friend WithEvents RemoveAllLinksButton As Neos_Downloader.XylosButton
    Friend WithEvents RemoveLinkButton As Neos_Downloader.XylosButton
    Friend WithEvents AddLinkButton As Neos_Downloader.XylosButton
    Friend WithEvents LinksListBox As System.Windows.Forms.ListBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DelayUpDown As System.Windows.Forms.NumericUpDown

End Class
