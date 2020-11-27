﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Idle", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("DND", System.Windows.Forms.HorizontalAlignment.Center)
        Me.Matchlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OptionsToolStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChallengeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadRomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.BtnJoin = New System.Windows.Forms.Button()
        Me.btnOffline = New System.Windows.Forms.Button()
        Me.niBEAR = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.PlayerList = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MainMenuContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbVer = New System.Windows.Forms.Label()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ReplaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreeDLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatreonO3oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgBeta = New System.Windows.Forms.PictureBox()
        Me.sus_i = New System.Windows.Forms.PictureBox()
        Me.OptionsToolStrip.SuspendLayout()
        Me.MainMenuContainer.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        CType(Me.imgBeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sus_i, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Matchlist
        '
        Me.Matchlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Matchlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Matchlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.MainMenuContainer.SetColumnSpan(Me.Matchlist, 4)
        Me.Matchlist.ContextMenuStrip = Me.OptionsToolStrip
        Me.Matchlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Matchlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matchlist.ForeColor = System.Drawing.Color.Red
        Me.Matchlist.FullRowSelect = True
        Me.Matchlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Matchlist.HideSelection = False
        Me.Matchlist.Location = New System.Drawing.Point(260, 45)
        Me.Matchlist.Margin = New System.Windows.Forms.Padding(0)
        Me.Matchlist.MultiSelect = False
        Me.Matchlist.Name = "Matchlist"
        Me.Matchlist.ShowItemToolTips = True
        Me.Matchlist.Size = New System.Drawing.Size(609, 411)
        Me.Matchlist.SmallImageList = Me.SystemIcons
        Me.Matchlist.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Matchlist.TabIndex = 3
        Me.Matchlist.TileSize = New System.Drawing.Size(32, 32)
        Me.Matchlist.UseCompatibleStateImageBehavior = False
        Me.Matchlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Text = "Player"
        Me.ColumnHeader1.Width = 168
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 0
        Me.ColumnHeader3.Text = "Ping"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Game"
        Me.ColumnHeader4.Width = 204
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 70
        '
        'OptionsToolStrip
        '
        Me.OptionsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChallengeToolStripMenuItem, Me.DownloadRomToolStripMenuItem, Me.PingToolStripMenuItem})
        Me.OptionsToolStrip.Name = "OptionsToolStrip"
        Me.OptionsToolStrip.Size = New System.Drawing.Size(178, 70)
        '
        'ChallengeToolStripMenuItem
        '
        Me.ChallengeToolStripMenuItem.Name = "ChallengeToolStripMenuItem"
        Me.ChallengeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ChallengeToolStripMenuItem.Text = "Challenge/Spectate"
        '
        'DownloadRomToolStripMenuItem
        '
        Me.DownloadRomToolStripMenuItem.Name = "DownloadRomToolStripMenuItem"
        Me.DownloadRomToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DownloadRomToolStripMenuItem.Text = "Download Rom"
        '
        'PingToolStripMenuItem
        '
        Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
        Me.PingToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PingToolStripMenuItem.Text = "Ping"
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
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(260, 456)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Refresh ↺"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'BtnJoin
        '
        Me.BtnJoin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnJoin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJoin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.BtnJoin.Location = New System.Drawing.Point(412, 456)
        Me.BtnJoin.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnJoin.Name = "BtnJoin"
        Me.BtnJoin.Size = New System.Drawing.Size(152, 28)
        Me.BtnJoin.TabIndex = 5
        Me.BtnJoin.TabStop = False
        Me.BtnJoin.Text = "Challenge"
        Me.BtnJoin.UseVisualStyleBackColor = False
        '
        'btnOffline
        '
        Me.btnOffline.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnOffline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOffline.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOffline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnOffline.Location = New System.Drawing.Point(716, 456)
        Me.btnOffline.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOffline.Name = "btnOffline"
        Me.btnOffline.Size = New System.Drawing.Size(153, 28)
        Me.btnOffline.TabIndex = 7
        Me.btnOffline.TabStop = False
        Me.btnOffline.Text = "Play Offline"
        Me.btnOffline.UseVisualStyleBackColor = False
        '
        'niBEAR
        '
        Me.niBEAR.Text = "BEAR"
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Idle", "DND", "Hidden"})
        Me.cbStatus.Location = New System.Drawing.Point(10, 456)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(125, 21)
        Me.cbStatus.TabIndex = 15
        Me.cbStatus.TabStop = False
        '
        'PlayerList
        '
        Me.PlayerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.MainMenuContainer.SetColumnSpan(Me.PlayerList, 2)
        Me.PlayerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerList.FullRowSelect = True
        Me.PlayerList.GridLines = True
        ListViewGroup1.Header = "Idle"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "Idle"
        ListViewGroup2.Header = "DND"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "DND"
        Me.PlayerList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.PlayerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.PlayerList.HideSelection = False
        Me.PlayerList.Location = New System.Drawing.Point(10, 45)
        Me.PlayerList.Margin = New System.Windows.Forms.Padding(0)
        Me.PlayerList.MultiSelect = False
        Me.PlayerList.Name = "PlayerList"
        Me.PlayerList.ShowItemToolTips = True
        Me.PlayerList.Size = New System.Drawing.Size(250, 411)
        Me.PlayerList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.PlayerList.TabIndex = 20
        Me.PlayerList.UseCompatibleStateImageBehavior = False
        Me.PlayerList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 1
        Me.ColumnHeader6.Text = "Player"
        Me.ColumnHeader6.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 2
        Me.ColumnHeader7.Text = "IP"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 0
        Me.ColumnHeader8.Text = "Ping"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Game"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Hosting"
        Me.ColumnHeader10.Width = 0
        '
        'MainMenuContainer
        '
        Me.MainMenuContainer.ColumnCount = 6
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MainMenuContainer.Controls.Add(Me.btnOffline, 5, 2)
        Me.MainMenuContainer.Controls.Add(Me.btnSearch, 2, 2)
        Me.MainMenuContainer.Controls.Add(Me.BtnJoin, 3, 2)
        Me.MainMenuContainer.Controls.Add(Me.cbStatus, 0, 2)
        Me.MainMenuContainer.Controls.Add(Me.Label2, 2, 0)
        Me.MainMenuContainer.Controls.Add(Me.Label1, 0, 0)
        Me.MainMenuContainer.Controls.Add(Me.Matchlist, 2, 1)
        Me.MainMenuContainer.Controls.Add(Me.PlayerList, 0, 1)
        Me.MainMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainMenuContainer.Location = New System.Drawing.Point(0, 24)
        Me.MainMenuContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainMenuContainer.Name = "MainMenuContainer"
        Me.MainMenuContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.MainMenuContainer.RowCount = 3
        Me.MainMenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.MainMenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainMenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.MainMenuContainer.Size = New System.Drawing.Size(879, 494)
        Me.MainMenuContainer.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MainMenuContainer.SetColumnSpan(Me.Label2, 4)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(260, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(609, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Network Games"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MainMenuContainer.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Network Players"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbVer
        '
        Me.lbVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVer.AutoSize = True
        Me.lbVer.BackColor = System.Drawing.Color.Transparent
        Me.lbVer.Location = New System.Drawing.Point(845, 0)
        Me.lbVer.Name = "lbVer"
        Me.lbVer.Size = New System.Drawing.Size(34, 13)
        Me.lbVer.TabIndex = 10
        Me.lbVer.Text = "0.00a"
        Me.lbVer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplaysToolStripMenuItem, Me.ControlsToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.FreeDLCToolStripMenuItem, Me.DiscordToolStripMenuItem, Me.PatreonO3oToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MainMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainMenuStrip.Size = New System.Drawing.Size(879, 24)
        Me.MainMenuStrip.TabIndex = 22
        Me.MainMenuStrip.Text = "MainMenuStrip"
        '
        'ReplaysToolStripMenuItem
        '
        Me.ReplaysToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReplaysToolStripMenuItem.Name = "ReplaysToolStripMenuItem"
        Me.ReplaysToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.ReplaysToolStripMenuItem.Text = "Replays"
        '
        'ControlsToolStripMenuItem1
        '
        Me.ControlsToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ControlsToolStripMenuItem1.Name = "ControlsToolStripMenuItem1"
        Me.ControlsToolStripMenuItem1.Size = New System.Drawing.Size(64, 24)
        Me.ControlsToolStripMenuItem1.Text = "Controls"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OptionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'FreeDLCToolStripMenuItem
        '
        Me.FreeDLCToolStripMenuItem.Name = "FreeDLCToolStripMenuItem"
        Me.FreeDLCToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.FreeDLCToolStripMenuItem.Text = "Free DLC"
        '
        'DiscordToolStripMenuItem
        '
        Me.DiscordToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DiscordToolStripMenuItem.Name = "DiscordToolStripMenuItem"
        Me.DiscordToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.DiscordToolStripMenuItem.Text = "Discord"
        '
        'PatreonO3oToolStripMenuItem
        '
        Me.PatreonO3oToolStripMenuItem.Name = "PatreonO3oToolStripMenuItem"
        Me.PatreonO3oToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.PatreonO3oToolStripMenuItem.Text = "Patreon o3o"
        '
        'imgBeta
        '
        Me.imgBeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgBeta.BackColor = System.Drawing.Color.Transparent
        Me.imgBeta.BackgroundImage = Global.NullDC_CvS2_BEAR.My.Resources.Resources.Beta
        Me.imgBeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgBeta.Location = New System.Drawing.Point(793, 1)
        Me.imgBeta.Margin = New System.Windows.Forms.Padding(0)
        Me.imgBeta.Name = "imgBeta"
        Me.imgBeta.Size = New System.Drawing.Size(48, 18)
        Me.imgBeta.TabIndex = 11
        Me.imgBeta.TabStop = False
        '
        'sus_i
        '
        Me.sus_i.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sus_i.BackColor = System.Drawing.Color.Transparent
        Me.sus_i.BackgroundImage = Global.NullDC_CvS2_BEAR.My.Resources.Resources.sus
        Me.sus_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.sus_i.Location = New System.Drawing.Point(829, 37)
        Me.sus_i.Margin = New System.Windows.Forms.Padding(0)
        Me.sus_i.Name = "sus_i"
        Me.sus_i.Size = New System.Drawing.Size(32, 29)
        Me.sus_i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sus_i.TabIndex = 18
        Me.sus_i.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(879, 518)
        Me.Controls.Add(Me.sus_i)
        Me.Controls.Add(Me.imgBeta)
        Me.Controls.Add(Me.MainMenuContainer)
        Me.Controls.Add(Me.lbVer)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.DoubleBuffered = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NullDC BEAR"
        Me.OptionsToolStrip.ResumeLayout(False)
        Me.MainMenuContainer.ResumeLayout(False)
        Me.MainMenuContainer.PerformLayout()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        CType(Me.imgBeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sus_i, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Matchlist As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BtnJoin As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnOffline As Button
    Friend WithEvents niBEAR As NotifyIcon
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents PlayerList As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents MainMenuContainer As TableLayoutPanel
    Friend WithEvents lbVer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SystemIcons As ImageList
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DiscordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatreonO3oToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStrip As ContextMenuStrip
    Friend WithEvents PingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChallengeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadRomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents imgBeta As PictureBox
    Friend WithEvents sus_i As PictureBox
    Friend WithEvents FreeDLCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
