﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallengeGameSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChallengeGameSelect))
        Me.btnLetsGo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tc_games = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tb_mednafen = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Serverlist = New System.Windows.Forms.ComboBox()
        Me.GameSelectContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_nulldc = New System.Windows.Forms.TableLayoutPanel()
        Me.cbDelay = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.SystemIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tc_games.SuspendLayout()
        Me.tb_mednafen.SuspendLayout()
        Me.GameSelectContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tb_nulldc.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLetsGo
        '
        Me.btnLetsGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLetsGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLetsGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetsGo.Location = New System.Drawing.Point(480, 341)
        Me.btnLetsGo.Name = "btnLetsGo"
        Me.GameSelectContainer.SetRowSpan(Me.btnLetsGo, 2)
        Me.btnLetsGo.Size = New System.Drawing.Size(161, 95)
        Me.btnLetsGo.TabIndex = 1
        Me.btnLetsGo.Text = "LETS GO!"
        Me.btnLetsGo.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(13, 403)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 33)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tc_games
        '
        Me.GameSelectContainer.SetColumnSpan(Me.tc_games, 3)
        Me.tc_games.Controls.Add(Me.TabPage1)
        Me.tc_games.Controls.Add(Me.TabPage2)
        Me.tc_games.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_games.Location = New System.Drawing.Point(13, 13)
        Me.tc_games.Multiline = True
        Me.tc_games.Name = "tc_games"
        Me.tc_games.SelectedIndex = 0
        Me.tc_games.Size = New System.Drawing.Size(628, 322)
        Me.tc_games.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(620, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(620, 296)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tb_mednafen
        '
        Me.tb_mednafen.AutoSize = True
        Me.tb_mednafen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tb_mednafen.ColumnCount = 1
        Me.tb_mednafen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tb_mednafen.Controls.Add(Me.Label3, 0, 0)
        Me.tb_mednafen.Controls.Add(Me.cb_Serverlist, 0, 1)
        Me.tb_mednafen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_mednafen.Location = New System.Drawing.Point(0, 0)
        Me.tb_mednafen.Name = "tb_mednafen"
        Me.tb_mednafen.RowCount = 2
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tb_mednafen.Size = New System.Drawing.Size(373, 56)
        Me.tb_mednafen.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(367, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Server"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cb_Serverlist
        '
        Me.cb_Serverlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Serverlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Serverlist.FormattingEnabled = True
        Me.cb_Serverlist.Location = New System.Drawing.Point(3, 19)
        Me.cb_Serverlist.Name = "cb_Serverlist"
        Me.cb_Serverlist.Size = New System.Drawing.Size(367, 21)
        Me.cb_Serverlist.TabIndex = 29
        '
        'GameSelectContainer
        '
        Me.GameSelectContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GameSelectContainer.ColumnCount = 3
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.GameSelectContainer.Controls.Add(Me.Panel1, 1, 1)
        Me.GameSelectContainer.Controls.Add(Me.btnCancel, 0, 2)
        Me.GameSelectContainer.Controls.Add(Me.btnLetsGo, 2, 1)
        Me.GameSelectContainer.Controls.Add(Me.tc_games, 0, 0)
        Me.GameSelectContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameSelectContainer.Location = New System.Drawing.Point(0, 24)
        Me.GameSelectContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.GameSelectContainer.Name = "GameSelectContainer"
        Me.GameSelectContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.GameSelectContainer.RowCount = 3
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GameSelectContainer.Size = New System.Drawing.Size(654, 449)
        Me.GameSelectContainer.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tb_nulldc)
        Me.Panel1.Controls.Add(Me.tb_mednafen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(101, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 56)
        Me.Panel1.TabIndex = 4
        '
        'tb_nulldc
        '
        Me.tb_nulldc.AutoSize = True
        Me.tb_nulldc.BackColor = System.Drawing.Color.Transparent
        Me.tb_nulldc.ColumnCount = 2
        Me.tb_nulldc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tb_nulldc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tb_nulldc.Controls.Add(Me.cbDelay, 0, 0)
        Me.tb_nulldc.Controls.Add(Me.Label2, 0, 0)
        Me.tb_nulldc.Controls.Add(Me.Label4, 0, 1)
        Me.tb_nulldc.Controls.Add(Me.cbRegion, 1, 1)
        Me.tb_nulldc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_nulldc.Location = New System.Drawing.Point(0, 0)
        Me.tb_nulldc.Name = "tb_nulldc"
        Me.tb_nulldc.RowCount = 2
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_nulldc.Size = New System.Drawing.Size(373, 56)
        Me.tb_nulldc.TabIndex = 25
        '
        'cbDelay
        '
        Me.cbDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbDelay.FormattingEnabled = True
        Me.cbDelay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cbDelay.Location = New System.Drawing.Point(131, 3)
        Me.cbDelay.Name = "cbDelay"
        Me.cbDelay.Size = New System.Drawing.Size(69, 21)
        Me.cbDelay.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 27)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Simulated Delay"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 29)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Region"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbRegion
        '
        Me.cbRegion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"JPN", "USA", "EUR"})
        Me.cbRegion.Location = New System.Drawing.Point(132, 31)
        Me.cbRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(68, 21)
        Me.cbRegion.TabIndex = 23
        '
        'SystemIcons
        '
        Me.SystemIcons.ImageStream = CType(resources.GetObject("SystemIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SystemIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SystemIcons.Images.SetKeyName(0, "icon_Naomi.png")
        Me.SystemIcons.Images.SetKeyName(1, "icon_dreamcast.png")
        Me.SystemIcons.Images.SetKeyName(2, "Icon_SegaSaturn.png")
        Me.SystemIcons.Images.SetKeyName(3, "icon_Genesis.png")
        Me.SystemIcons.Images.SetKeyName(4, "icon_PSX.png")
        Me.SystemIcons.Images.SetKeyName(5, "icon_NES.png")
        Me.SystemIcons.Images.SetKeyName(6, "icon_SNES.png")
        Me.SystemIcons.Images.SetKeyName(7, "icon_fds.png")
        Me.SystemIcons.Images.SetKeyName(8, "icon_NGP.png")
        Me.SystemIcons.Images.SetKeyName(9, "icon_GBA.png")
        Me.SystemIcons.Images.SetKeyName(10, "icon_GBC.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DLCToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DLCToolStripMenuItem
        '
        Me.DLCToolStripMenuItem.Name = "DLCToolStripMenuItem"
        Me.DLCToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.DLCToolStripMenuItem.Text = "Free DLC"
        '
        'frmChallengeGameSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(654, 473)
        Me.Controls.Add(Me.GameSelectContainer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(670, 9000)
        Me.MinimumSize = New System.Drawing.Size(670, 38)
        Me.Name = "frmChallengeGameSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Select"
        Me.tc_games.ResumeLayout(False)
        Me.tb_mednafen.ResumeLayout(False)
        Me.tb_mednafen.PerformLayout()
        Me.GameSelectContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tb_nulldc.ResumeLayout(False)
        Me.tb_nulldc.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLetsGo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tc_games As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tb_mednafen As TableLayoutPanel
    Friend WithEvents cb_Serverlist As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GameSelectContainer As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SystemIcons As ImageList
    Friend WithEvents tb_nulldc As TableLayoutPanel
    Friend WithEvents cbDelay As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DLCToolStripMenuItem As ToolStripMenuItem
End Class
