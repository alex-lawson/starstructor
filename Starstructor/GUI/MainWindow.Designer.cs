/*Starstructor, the Starbound Toolet
Copyright (C) 2013-2014  Chris Stamford
Contact: cstamford@gmail.com

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System.Windows.Forms;
namespace Starstructor.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewCollisionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBrushToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newPartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assetBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SaveActive = new System.Windows.Forms.SaveFileDialog();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BottomBarTable = new System.Windows.Forms.TableLayoutPanel();
            this.BottomBarStaticBrushLabel = new System.Windows.Forms.Label();
            this.BottomBarGfxModePanel = new System.Windows.Forms.Panel();
            this.BottomBarGfxCombo = new System.Windows.Forms.ComboBox();
            this.BottomBarModeLabel = new System.Windows.Forms.Label();
            this.BottomBarBrushLabel = new System.Windows.Forms.Label();
            this.BottomBarZoomLabel = new System.Windows.Forms.Label();
            this.BottomBarPositionLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RightPanelSplit = new System.Windows.Forms.SplitContainer();
            this.RightPanelTabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelMainTab = new System.Windows.Forms.TableLayoutPanel();
            this.LabelMainTabWelcome = new System.Windows.Forms.Label();
            this.ButtonImportBrush = new System.Windows.Forms.Button();
            this.ButtonImportPart = new System.Windows.Forms.Button();
            this.PartsTab = new System.Windows.Forms.TabPage();
            this.PartTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuPartsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.renamePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrushesTab = new System.Windows.Forms.TabPage();
            this.BrushesTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuBrushesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.renameBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightPanelProperties = new System.Windows.Forms.PropertyGrid();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.SaveScreenshotDlg = new System.Windows.Forms.SaveFileDialog();
            this.VisualRgbaBrushImageBox = new Starstructor.GUI.NoAliasPictureBox();
            this.VisualGraphicBrushImageBox = new Starstructor.GUI.NoAliasPictureBox();
            this.MainPictureBox = new Starstructor.GUI.ImageBox();
            this.MainMenu.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.BottomBarTable.SuspendLayout();
            this.BottomBarGfxModePanel.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.RightPanelSplit)).BeginInit();
            this.RightPanelSplit.Panel1.SuspendLayout();
            this.RightPanelSplit.Panel2.SuspendLayout();
            this.RightPanelSplit.SuspendLayout();
            this.RightPanelTabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.TableLayoutPanelMainTab.SuspendLayout();
            this.PartsTab.SuspendLayout();
            this.contextMenuPartsList.SuspendLayout();
            this.BrushesTab.SuspendLayout();
            this.contextMenuBrushesList.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.VisualRgbaBrushImageBox)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.VisualGraphicBrushImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(1264, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Enabled = false;
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.recentFilesToolStripMenuItem.Text = "&Recent Files";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeScreenshotToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewCollisionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // takeScreenshotToolStripMenuItem
            // 
            this.takeScreenshotToolStripMenuItem.Enabled = false;
            this.takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
            this.takeScreenshotToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.takeScreenshotToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.takeScreenshotToolStripMenuItem.Text = "Take &Screenshot";
            this.takeScreenshotToolStripMenuItem.Click += new System.EventHandler(this.takeScreenshotToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // viewCollisionsToolStripMenuItem
            // 
            this.viewCollisionsToolStripMenuItem.Name = "viewCollisionsToolStripMenuItem";
            this.viewCollisionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewCollisionsToolStripMenuItem.Text = "View &Collisions";
            this.viewCollisionsToolStripMenuItem.Click += new System.EventHandler(this.viewCollisionsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBrushToolStripMenuItem1,
            this.newPartToolStripMenuItem1,
            this.assetBrowserToolStripMenuItem,
            this.setDirectoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // newBrushToolStripMenuItem1
            // 
            this.newBrushToolStripMenuItem1.Enabled = false;
            this.newBrushToolStripMenuItem1.Name = "newBrushToolStripMenuItem1";
            this.newBrushToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.newBrushToolStripMenuItem1.Text = "New Brush";
            this.newBrushToolStripMenuItem1.Click += new System.EventHandler(this.newBrushToolStripMenuItem1_Click);
            // 
            // newPartToolStripMenuItem1
            // 
            this.newPartToolStripMenuItem1.Enabled = false;
            this.newPartToolStripMenuItem1.Name = "newPartToolStripMenuItem1";
            this.newPartToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.newPartToolStripMenuItem1.Text = "New Part";
            this.newPartToolStripMenuItem1.Click += new System.EventHandler(this.newPartToolStripMenuItem1_Click);
            // 
            // assetBrowserToolStripMenuItem
            // 
            this.assetBrowserToolStripMenuItem.Name = "assetBrowserToolStripMenuItem";
            this.assetBrowserToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.assetBrowserToolStripMenuItem.Text = "Asset Browser";
            this.assetBrowserToolStripMenuItem.Click += new System.EventHandler(this.assetBrowserToolStripMenuItem_Click);
            // 
            // setDirectoryToolStripMenuItem
            // 
            this.setDirectoryToolStripMenuItem.Name = "setDirectoryToolStripMenuItem";
            this.setDirectoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.setDirectoryToolStripMenuItem.Text = "Set Directory";
            this.setDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setDirectoryToolStripMenuItem_Click);
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.FileName = "open";
            this.OpenFileDlg.Filter = "All Editor Types|*.dungeon;*.structure|Dungeon Files|*.dungeon|Ship Files|*.struc" +
    "ture";
            this.OpenFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDungeonOrImageMap_FileOk);
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.BottomBarTable, 0, 1);
            this.MainTableLayout.Controls.Add(this.splitContainer1, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 24);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(1264, 738);
            this.MainTableLayout.TabIndex = 3;
            // 
            // BottomBarTable
            // 
            this.BottomBarTable.BackColor = System.Drawing.SystemColors.Control;
            this.BottomBarTable.ColumnCount = 7;
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomBarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomBarTable.Controls.Add(this.BottomBarStaticBrushLabel, 0, 0);
            this.BottomBarTable.Controls.Add(this.BottomBarGfxModePanel, 0, 0);
            this.BottomBarTable.Controls.Add(this.BottomBarBrushLabel, 4, 0);
            this.BottomBarTable.Controls.Add(this.BottomBarZoomLabel, 5, 0);
            this.BottomBarTable.Controls.Add(this.BottomBarPositionLabel, 6, 0);
            this.BottomBarTable.Controls.Add(this.VisualRgbaBrushImageBox, 3, 0);
            this.BottomBarTable.Controls.Add(this.VisualGraphicBrushImageBox, 2, 0);
            this.BottomBarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarTable.Location = new System.Drawing.Point(0, 707);
            this.BottomBarTable.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarTable.Name = "BottomBarTable";
            this.BottomBarTable.RowCount = 1;
            this.BottomBarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomBarTable.Size = new System.Drawing.Size(1264, 31);
            this.BottomBarTable.TabIndex = 3;
            // 
            // BottomBarStaticBrushLabel
            // 
            this.BottomBarStaticBrushLabel.AutoSize = true;
            this.BottomBarStaticBrushLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarStaticBrushLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarStaticBrushLabel.Location = new System.Drawing.Point(180, 0);
            this.BottomBarStaticBrushLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarStaticBrushLabel.Name = "BottomBarStaticBrushLabel";
            this.BottomBarStaticBrushLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomBarStaticBrushLabel.Size = new System.Drawing.Size(42, 31);
            this.BottomBarStaticBrushLabel.TabIndex = 8;
            this.BottomBarStaticBrushLabel.Text = "Brush:";
            this.BottomBarStaticBrushLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomBarGfxModePanel
            // 
            this.BottomBarGfxModePanel.AutoScroll = true;
            this.BottomBarGfxModePanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarGfxModePanel.Controls.Add(this.BottomBarGfxCombo);
            this.BottomBarGfxModePanel.Controls.Add(this.BottomBarModeLabel);
            this.BottomBarGfxModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarGfxModePanel.Location = new System.Drawing.Point(0, 0);
            this.BottomBarGfxModePanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarGfxModePanel.Name = "BottomBarGfxModePanel";
            this.BottomBarGfxModePanel.Size = new System.Drawing.Size(180, 31);
            this.BottomBarGfxModePanel.TabIndex = 1;
            // 
            // BottomBarGfxCombo
            // 
            this.BottomBarGfxCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BottomBarGfxCombo.FormattingEnabled = true;
            this.BottomBarGfxCombo.Items.AddRange(new object[] {
            "Graphical Display",
            "Colour Display"});
            this.BottomBarGfxCombo.Location = new System.Drawing.Point(45, 5);
            this.BottomBarGfxCombo.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarGfxCombo.Name = "BottomBarGfxCombo";
            this.BottomBarGfxCombo.Size = new System.Drawing.Size(125, 21);
            this.BottomBarGfxCombo.TabIndex = 5;
            // 
            // BottomBarModeLabel
            // 
            this.BottomBarModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarModeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarModeLabel.Location = new System.Drawing.Point(0, 0);
            this.BottomBarModeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarModeLabel.Name = "BottomBarModeLabel";
            this.BottomBarModeLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomBarModeLabel.Size = new System.Drawing.Size(180, 31);
            this.BottomBarModeLabel.TabIndex = 1;
            this.BottomBarModeLabel.Text = "Mode:";
            this.BottomBarModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomBarBrushLabel
            // 
            this.BottomBarBrushLabel.AutoSize = true;
            this.BottomBarBrushLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarBrushLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarBrushLabel.Location = new System.Drawing.Point(284, 0);
            this.BottomBarBrushLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarBrushLabel.Name = "BottomBarBrushLabel";
            this.BottomBarBrushLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomBarBrushLabel.Size = new System.Drawing.Size(800, 31);
            this.BottomBarBrushLabel.TabIndex = 3;
            this.BottomBarBrushLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomBarZoomLabel
            // 
            this.BottomBarZoomLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarZoomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarZoomLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BottomBarZoomLabel.Location = new System.Drawing.Point(1084, 0);
            this.BottomBarZoomLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarZoomLabel.Name = "BottomBarZoomLabel";
            this.BottomBarZoomLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomBarZoomLabel.Size = new System.Drawing.Size(80, 31);
            this.BottomBarZoomLabel.TabIndex = 4;
            this.BottomBarZoomLabel.Text = "Zoom:";
            this.BottomBarZoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomBarPositionLabel
            // 
            this.BottomBarPositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBarPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBarPositionLabel.Location = new System.Drawing.Point(1164, 0);
            this.BottomBarPositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomBarPositionLabel.Name = "BottomBarPositionLabel";
            this.BottomBarPositionLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BottomBarPositionLabel.Size = new System.Drawing.Size(100, 31);
            this.BottomBarPositionLabel.TabIndex = 5;
            this.BottomBarPositionLabel.Text = "Grid: N/A";
            this.BottomBarPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainPictureBox);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightPanelSplit);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 707);
            this.splitContainer1.SplitterDistance = 1024;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 4;
            // 
            // RightPanelSplit
            // 
            this.RightPanelSplit.BackColor = System.Drawing.SystemColors.Control;
            this.RightPanelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelSplit.Location = new System.Drawing.Point(0, 0);
            this.RightPanelSplit.Name = "RightPanelSplit";
            this.RightPanelSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RightPanelSplit.Panel1
            // 
            this.RightPanelSplit.Panel1.Controls.Add(this.RightPanelTabControl);
            // 
            // RightPanelSplit.Panel2
            // 
            this.RightPanelSplit.Panel2.Controls.Add(this.RightPanelProperties);
            this.RightPanelSplit.Size = new System.Drawing.Size(238, 707);
            this.RightPanelSplit.SplitterDistance = 370;
            this.RightPanelSplit.SplitterWidth = 2;
            this.RightPanelSplit.TabIndex = 6;
            // 
            // RightPanelTabControl
            // 
            this.RightPanelTabControl.Controls.Add(this.MainTab);
            this.RightPanelTabControl.Controls.Add(this.PartsTab);
            this.RightPanelTabControl.Controls.Add(this.BrushesTab);
            this.RightPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelTabControl.Location = new System.Drawing.Point(0, 0);
            this.RightPanelTabControl.Name = "RightPanelTabControl";
            this.RightPanelTabControl.SelectedIndex = 0;
            this.RightPanelTabControl.Size = new System.Drawing.Size(238, 370);
            this.RightPanelTabControl.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.TableLayoutPanelMainTab);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(230, 344);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelMainTab
            // 
            this.TableLayoutPanelMainTab.ColumnCount = 1;
            this.TableLayoutPanelMainTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMainTab.Controls.Add(this.LabelMainTabWelcome, 0, 0);
            this.TableLayoutPanelMainTab.Controls.Add(this.ButtonImportBrush, 0, 1);
            this.TableLayoutPanelMainTab.Controls.Add(this.ButtonImportPart, 0, 2);
            this.TableLayoutPanelMainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMainTab.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelMainTab.Name = "TableLayoutPanelMainTab";
            this.TableLayoutPanelMainTab.RowCount = 3;
            this.TableLayoutPanelMainTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMainTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMainTab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMainTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelMainTab.Size = new System.Drawing.Size(224, 338);
            this.TableLayoutPanelMainTab.TabIndex = 0;
            // 
            // LabelMainTabWelcome
            // 
            this.LabelMainTabWelcome.AutoSize = true;
            this.LabelMainTabWelcome.Location = new System.Drawing.Point(3, 0);
            this.LabelMainTabWelcome.Name = "LabelMainTabWelcome";
            this.LabelMainTabWelcome.Size = new System.Drawing.Size(218, 143);
            this.LabelMainTabWelcome.TabIndex = 0;
            this.LabelMainTabWelcome.Text = resources.GetString("LabelMainTabWelcome.Text");
            // 
            // ButtonImportBrush
            // 
            this.ButtonImportBrush.Enabled = false;
            this.ButtonImportBrush.Location = new System.Drawing.Point(3, 153);
            this.ButtonImportBrush.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ButtonImportBrush.Name = "ButtonImportBrush";
            this.ButtonImportBrush.Size = new System.Drawing.Size(125, 23);
            this.ButtonImportBrush.TabIndex = 1;
            this.ButtonImportBrush.Text = "New Brush Wizard";
            this.ButtonImportBrush.UseVisualStyleBackColor = true;
            this.ButtonImportBrush.Click += new System.EventHandler(this.ButtonImportBrush_Click);
            // 
            // ButtonImportPart
            // 
            this.ButtonImportPart.Enabled = false;
            this.ButtonImportPart.Location = new System.Drawing.Point(3, 182);
            this.ButtonImportPart.Name = "ButtonImportPart";
            this.ButtonImportPart.Size = new System.Drawing.Size(125, 23);
            this.ButtonImportPart.TabIndex = 2;
            this.ButtonImportPart.Text = "New Part Wizard";
            this.ButtonImportPart.UseVisualStyleBackColor = true;
            this.ButtonImportPart.Click += new System.EventHandler(this.ButtonImportPart_Click);
            // 
            // PartsTab
            // 
            this.PartsTab.Controls.Add(this.PartTreeView);
            this.PartsTab.Location = new System.Drawing.Point(4, 22);
            this.PartsTab.Name = "PartsTab";
            this.PartsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PartsTab.Size = new System.Drawing.Size(230, 344);
            this.PartsTab.TabIndex = 1;
            this.PartsTab.Text = "Parts";
            this.PartsTab.UseVisualStyleBackColor = true;
            // 
            // PartTreeView
            // 
            this.PartTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartTreeView.ContextMenuStrip = this.contextMenuPartsList;
            this.PartTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartTreeView.FullRowSelect = true;
            this.PartTreeView.HideSelection = false;
            this.PartTreeView.Indent = 12;
            this.PartTreeView.LabelEdit = true;
            this.PartTreeView.Location = new System.Drawing.Point(3, 3);
            this.PartTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.PartTreeView.Name = "PartTreeView";
            this.PartTreeView.ShowLines = false;
            this.PartTreeView.Size = new System.Drawing.Size(224, 338);
            this.PartTreeView.TabIndex = 5;
            // 
            // contextMenuPartsList
            // 
            this.contextMenuPartsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPartToolStripMenuItem,
            this.toolStripSeparator5,
            this.renamePartToolStripMenuItem,
            this.resizePartToolStripMenuItem,
            this.deletePartToolStripMenuItem});
            this.contextMenuPartsList.Name = "contextMenuPartsList";
            this.contextMenuPartsList.Size = new System.Drawing.Size(142, 98);
            // 
            // newPartToolStripMenuItem
            // 
            this.newPartToolStripMenuItem.Enabled = false;
            this.newPartToolStripMenuItem.Name = "newPartToolStripMenuItem";
            this.newPartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newPartToolStripMenuItem.Text = "&New Part";
            this.newPartToolStripMenuItem.Click += new System.EventHandler(this.newPartToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // renamePartToolStripMenuItem
            // 
            this.renamePartToolStripMenuItem.Enabled = false;
            this.renamePartToolStripMenuItem.Name = "renamePartToolStripMenuItem";
            this.renamePartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.renamePartToolStripMenuItem.Text = "&Rename Part";
            this.renamePartToolStripMenuItem.Click += new System.EventHandler(this.renamePartToolStripMenuItem_Click);
            // 
            // resizePartToolStripMenuItem
            // 
            this.resizePartToolStripMenuItem.Enabled = false;
            this.resizePartToolStripMenuItem.Name = "resizePartToolStripMenuItem";
            this.resizePartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.resizePartToolStripMenuItem.Text = "Resize Part";
            this.resizePartToolStripMenuItem.Click += new System.EventHandler(this.resizePartToolStripMenuItem_Click);
            // 
            // deletePartToolStripMenuItem
            // 
            this.deletePartToolStripMenuItem.Enabled = false;
            this.deletePartToolStripMenuItem.Name = "deletePartToolStripMenuItem";
            this.deletePartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deletePartToolStripMenuItem.Text = "&Delete Part";
            this.deletePartToolStripMenuItem.Click += new System.EventHandler(this.deletePartToolStripMenuItem_Click);
            // 
            // BrushesTab
            // 
            this.BrushesTab.Controls.Add(this.BrushesTreeView);
            this.BrushesTab.Location = new System.Drawing.Point(4, 22);
            this.BrushesTab.Name = "BrushesTab";
            this.BrushesTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrushesTab.Size = new System.Drawing.Size(230, 344);
            this.BrushesTab.TabIndex = 2;
            this.BrushesTab.Text = "Brushes";
            this.BrushesTab.UseVisualStyleBackColor = true;
            // 
            // BrushesTreeView
            // 
            this.BrushesTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrushesTreeView.ContextMenuStrip = this.contextMenuBrushesList;
            this.BrushesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrushesTreeView.FullRowSelect = true;
            this.BrushesTreeView.HideSelection = false;
            this.BrushesTreeView.Indent = 12;
            this.BrushesTreeView.LabelEdit = true;
            this.BrushesTreeView.Location = new System.Drawing.Point(3, 3);
            this.BrushesTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.BrushesTreeView.Name = "BrushesTreeView";
            this.BrushesTreeView.PathSeparator = "/";
            this.BrushesTreeView.ShowLines = false;
            this.BrushesTreeView.ShowNodeToolTips = true;
            this.BrushesTreeView.ShowPlusMinus = false;
            this.BrushesTreeView.ShowRootLines = false;
            this.BrushesTreeView.Size = new System.Drawing.Size(224, 338);
            this.BrushesTreeView.TabIndex = 6;
            // 
            // contextMenuBrushesList
            // 
            this.contextMenuBrushesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBrushToolStripMenuItem,
            this.toolStripSeparator6,
            this.renameBrushToolStripMenuItem,
            this.deleteBrushToolStripMenuItem});
            this.contextMenuBrushesList.Name = "contextMenuBrushesList";
            this.contextMenuBrushesList.Size = new System.Drawing.Size(151, 76);
            // 
            // newBrushToolStripMenuItem
            // 
            this.newBrushToolStripMenuItem.Enabled = false;
            this.newBrushToolStripMenuItem.Name = "newBrushToolStripMenuItem";
            this.newBrushToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newBrushToolStripMenuItem.Text = "&New Brush";
            this.newBrushToolStripMenuItem.Click += new System.EventHandler(this.newBrushToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(147, 6);
            // 
            // renameBrushToolStripMenuItem
            // 
            this.renameBrushToolStripMenuItem.Enabled = false;
            this.renameBrushToolStripMenuItem.Name = "renameBrushToolStripMenuItem";
            this.renameBrushToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.renameBrushToolStripMenuItem.Text = "&Rename Brush";
            this.renameBrushToolStripMenuItem.Click += new System.EventHandler(this.renameBrushToolStripMenuItem_Click);
            // 
            // deleteBrushToolStripMenuItem
            // 
            this.deleteBrushToolStripMenuItem.Enabled = false;
            this.deleteBrushToolStripMenuItem.Name = "deleteBrushToolStripMenuItem";
            this.deleteBrushToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteBrushToolStripMenuItem.Text = "&Delete Brush";
            this.deleteBrushToolStripMenuItem.Click += new System.EventHandler(this.deleteBrushToolStripMenuItem_Click);
            // 
            // RightPanelProperties
            // 
            this.RightPanelProperties.BackColor = System.Drawing.SystemColors.Control;
            this.RightPanelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelProperties.Location = new System.Drawing.Point(0, 0);
            this.RightPanelProperties.Name = "RightPanelProperties";
            this.RightPanelProperties.Size = new System.Drawing.Size(238, 335);
            this.RightPanelProperties.TabIndex = 0;
            this.RightPanelProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.RightPanelProperties_PropertyValueChanged);
            // 
            // SaveFileDlg
            // 
            this.SaveFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFile_FileOk);
            // 
            // SaveScreenshotDlg
            // 
            this.SaveScreenshotDlg.DefaultExt = "png";
            this.SaveScreenshotDlg.Filter = "Portable Network Graphic|*.png";
            this.SaveScreenshotDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveScreenshotDlg_FileOk);
            // 
            // VisualRgbaBrushImageBox
            // 
            this.VisualRgbaBrushImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisualRgbaBrushImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualRgbaBrushImageBox.Location = new System.Drawing.Point(258, 5);
            this.VisualRgbaBrushImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.VisualRgbaBrushImageBox.Name = "VisualRgbaBrushImageBox";
            this.VisualRgbaBrushImageBox.Size = new System.Drawing.Size(21, 21);
            this.VisualRgbaBrushImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisualRgbaBrushImageBox.TabIndex = 6;
            this.VisualRgbaBrushImageBox.TabStop = false;
            // 
            // VisualGraphicBrushImageBox
            // 
            this.VisualGraphicBrushImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.VisualGraphicBrushImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualGraphicBrushImageBox.Location = new System.Drawing.Point(227, 5);
            this.VisualGraphicBrushImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.VisualGraphicBrushImageBox.Name = "VisualGraphicBrushImageBox";
            this.VisualGraphicBrushImageBox.Size = new System.Drawing.Size(21, 21);
            this.VisualGraphicBrushImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisualGraphicBrushImageBox.TabIndex = 7;
            this.VisualGraphicBrushImageBox.TabStop = false;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(1024, 707);
            this.MainPictureBox.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(1152, 648);
            this.Name = "MainWindow";
            this.Text = "Dungeon Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.BottomBarTable.ResumeLayout(false);
            this.BottomBarTable.PerformLayout();
            this.BottomBarGfxModePanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RightPanelSplit.Panel1.ResumeLayout(false);
            this.RightPanelSplit.Panel2.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.RightPanelSplit)).EndInit();
            this.RightPanelSplit.ResumeLayout(false);
            this.RightPanelTabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.TableLayoutPanelMainTab.ResumeLayout(false);
            this.TableLayoutPanelMainTab.PerformLayout();
            this.PartsTab.ResumeLayout(false);
            this.contextMenuPartsList.ResumeLayout(false);
            this.BrushesTab.ResumeLayout(false);
            this.contextMenuBrushesList.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.VisualRgbaBrushImageBox)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.VisualGraphicBrushImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.SaveFileDialog SaveActive;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewCollisionsToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TableLayoutPanel MainTableLayout;
        private TableLayoutPanel BottomBarTable;
        private Label BottomBarStaticBrushLabel;
        private Panel BottomBarGfxModePanel;
        private ComboBox BottomBarGfxCombo;
        private Label BottomBarModeLabel;
        private Label BottomBarBrushLabel;
        private Label BottomBarZoomLabel;
        private Label BottomBarPositionLabel;
        private NoAliasPictureBox VisualRgbaBrushImageBox;
        private NoAliasPictureBox VisualGraphicBrushImageBox;
        private SplitContainer splitContainer1;
        private ImageBox MainPictureBox;
        private SplitContainer RightPanelSplit;
        private TabControl RightPanelTabControl;
        private TabPage MainTab;
        private TabPage PartsTab;
        private TabPage BrushesTab;
        private PropertyGrid RightPanelProperties;
        private SaveFileDialog SaveFileDlg;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private TreeView PartTreeView;
        private TreeView BrushesTreeView;
        private ToolStripMenuItem takeScreenshotToolStripMenuItem;
        private SaveFileDialog SaveScreenshotDlg;
        private ToolStripMenuItem recentFilesToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem assetBrowserToolStripMenuItem;
        private ToolStripMenuItem setDirectoryToolStripMenuItem;
        private ContextMenuStrip contextMenuPartsList;
        private ToolStripMenuItem newPartToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem renamePartToolStripMenuItem;
        private ToolStripMenuItem deletePartToolStripMenuItem;
        private ContextMenuStrip contextMenuBrushesList;
        private ToolStripMenuItem newBrushToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem renameBrushToolStripMenuItem;
        private ToolStripMenuItem deleteBrushToolStripMenuItem;
        private ToolStripMenuItem resizePartToolStripMenuItem;
        private TableLayoutPanel TableLayoutPanelMainTab;
        private Label LabelMainTabWelcome;
        private Button ButtonImportBrush;
        private Button ButtonImportPart;
        private ToolStripMenuItem newBrushToolStripMenuItem1;
        private ToolStripMenuItem newPartToolStripMenuItem1;

    }
}

