
using System.Windows.Forms;
using System;
using WindowsVirtualDesktopHelper.Util;

namespace WindowsVirtualDesktopHelper {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.notifyIconNumber = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSwitchVD = new System.Windows.Forms.ToolStripMenuItem();
            this.vD1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRenameVD = new System.Windows.Forms.ToolStripMenuItem();
            this.vD1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyedMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hotkeyedMenuSwitchVD = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyedMenuRenameVD = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyedMenuMoveWndToVD = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconPrev = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconNext = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxShowPrevNextIcons = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClickDesktopNumberTaskView = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonOverlayMicroDuration = new System.Windows.Forms.RadioButton();
            this.radioButtonOverlayLongDuration = new System.Windows.Forms.RadioButton();
            this.radioButtonOverlayMediumDuration = new System.Windows.Forms.RadioButton();
            this.radioButtonOverlayShortDuration = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPositionBottomRight = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionBottomCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionBottomLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionMiddleRight = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionMiddleCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionMiddleLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionTopRight = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionTopCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonPositionTopLeft = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOverlayTranslucent = new System.Windows.Forms.CheckBox();
            this.checkBoxOverlayAnimate = new System.Windows.Forms.CheckBox();
            this.checkBoxShowOverlay = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxStartupWithWindows = new System.Windows.Forms.CheckBox();
            this.notifyIconName = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripMenuItemMoveWndToVD = new System.Windows.Forms.ToolStripMenuItem();
            this.vD1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.hotkeyedMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconNumber
            // 
            this.notifyIconNumber.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconNumber.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconNumber.Icon")));
            this.notifyIconNumber.Text = "Windows Virtual Desktop Helper";
            this.notifyIconNumber.Visible = true;
            this.notifyIconNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconNumber_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSwitchVD,
            this.toolStripMenuItemRenameVD,
            this.toolStripMenuItemMoveWndToVD,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemDonate,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(279, 261);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItemSwitchVD
            // 
            this.toolStripMenuItemSwitchVD.Name = "toolStripMenuItemSwitchVD";
            this.toolStripMenuItemSwitchVD.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemSwitchVD.Tag = "switchVd";
            this.toolStripMenuItemSwitchVD.Text = "Switch VD";
            this.toolStripMenuItemSwitchVD.DropDownOpening += new System.EventHandler(this.toolStripMenuItemSwitchVD_DropDownOpening);
            // 
            // vD1ToolStripMenuItem
            // 
            this.vD1ToolStripMenuItem.Name = "vD1ToolStripMenuItem";
            this.vD1ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.vD1ToolStripMenuItem.Text = "VD1";
            // 
            // renameVDToolStripMenuItem
            // 
            this.toolStripMenuItemRenameVD.Name = "renameVDToolStripMenuItem";
            this.toolStripMenuItemRenameVD.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemRenameVD.Text = "Rename VD";
            this.toolStripMenuItemRenameVD.DropDownOpening += new System.EventHandler(this.renameVDToolStripMenuItem_DropDownOpening);
            // 
            // vD1ToolStripMenuItem1
            // 
            this.vD1ToolStripMenuItem1.Name = "vD1ToolStripMenuItem1";
            this.vD1ToolStripMenuItem1.Size = new System.Drawing.Size(148, 34);
            this.vD1ToolStripMenuItem1.Text = "VD1";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemAbout.Tag = "about";
            this.toolStripMenuItemAbout.Text = "About";
            // 
            // toolStripMenuItemDonate
            // 
            this.toolStripMenuItemDonate.Name = "toolStripMenuItemDonate";
            this.toolStripMenuItemDonate.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemDonate.Tag = "donate";
            this.toolStripMenuItemDonate.Text = "Donate";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemSettings.Tag = "settings";
            this.toolStripMenuItemSettings.Text = "Settings";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(278, 32);
            this.toolStripMenuItemExit.Tag = "exit";
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // hotkeyedMenu
            // 
            this.hotkeyedMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.hotkeyedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeyedMenuSwitchVD,
            this.hotkeyedMenuRenameVD,
			this.hotkeyedMenuMoveWndToVD});
            this.hotkeyedMenu.Name = "hotkeyedMenu";
            this.hotkeyedMenu.Size = new System.Drawing.Size(177, 68);
            // 
            // hotkeyedMenuSwitchVD
            // 
            this.hotkeyedMenuSwitchVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vD1ToolStripMenuItem});
            this.hotkeyedMenuSwitchVD.Name = "hotkeyedMenuSwitchVD";
            this.hotkeyedMenuSwitchVD.Size = new System.Drawing.Size(176, 32);
            this.hotkeyedMenuSwitchVD.Tag = "switchVd";
            this.hotkeyedMenuSwitchVD.Text = "Switch VD";
            this.hotkeyedMenuSwitchVD.DropDownOpening += new System.EventHandler(this.toolStripMenuItemSwitchVD_DropDownOpening);
            // 
            // hotkeyedMenuRenameVD
            // 
            this.hotkeyedMenuRenameVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vD1ToolStripMenuItem1});
            this.hotkeyedMenuRenameVD.Name = "hotkeyedMenuRenameVD";
            this.hotkeyedMenuRenameVD.Size = new System.Drawing.Size(176, 32);
            this.hotkeyedMenuRenameVD.Text = "Rename VD";
            this.hotkeyedMenuRenameVD.DropDownOpening += new System.EventHandler(this.renameVDToolStripMenuItem_DropDownOpening);
            // 
            // notifyIconPrev
            // 
            this.notifyIconPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconPrev.Icon")));
            this.notifyIconPrev.Text = "Previous Desktop";
            this.notifyIconPrev.Visible = true;
            this.notifyIconPrev.Click += new System.EventHandler(this.notifyIconPrev_Click);
            // 
            // notifyIconNext
            // 
            this.notifyIconNext.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconNext.Icon")));
            this.notifyIconNext.Text = "Next Desktop";
            this.notifyIconNext.Visible = true;
            this.notifyIconNext.Click += new System.EventHandler(this.notifyIconNext_Click);
            // 
            // checkBoxShowPrevNextIcons
            // 
            this.checkBoxShowPrevNextIcons.AutoSize = true;
            this.checkBoxShowPrevNextIcons.Location = new System.Drawing.Point(22, 29);
            this.checkBoxShowPrevNextIcons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShowPrevNextIcons.Name = "checkBoxShowPrevNextIcons";
            this.checkBoxShowPrevNextIcons.Size = new System.Drawing.Size(332, 24);
            this.checkBoxShowPrevNextIcons.TabIndex = 1;
            this.checkBoxShowPrevNextIcons.Text = "Show Previous / Next Desktop in Icon Tray";
            this.checkBoxShowPrevNextIcons.UseVisualStyleBackColor = true;
            this.checkBoxShowPrevNextIcons.CheckedChanged += new System.EventHandler(this.checkBoxShowPrevNextIcons_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxClickDesktopNumberTaskView);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxOverlayTranslucent);
            this.groupBox1.Controls.Add(this.checkBoxOverlayAnimate);
            this.groupBox1.Controls.Add(this.checkBoxShowOverlay);
            this.groupBox1.Controls.Add(this.checkBoxShowPrevNextIcons);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(620, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // checkBoxClickDesktopNumberTaskView
            // 
            this.checkBoxClickDesktopNumberTaskView.AutoSize = true;
            this.checkBoxClickDesktopNumberTaskView.Location = new System.Drawing.Point(22, 305);
            this.checkBoxClickDesktopNumberTaskView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxClickDesktopNumberTaskView.Name = "checkBoxClickDesktopNumberTaskView";
            this.checkBoxClickDesktopNumberTaskView.Size = new System.Drawing.Size(422, 24);
            this.checkBoxClickDesktopNumberTaskView.TabIndex = 20;
            this.checkBoxClickDesktopNumberTaskView.Text = "Clicking Desktop Number in Icon Tray opens Task View";
            this.checkBoxClickDesktopNumberTaskView.UseVisualStyleBackColor = true;
            this.checkBoxClickDesktopNumberTaskView.CheckedChanged += new System.EventHandler(this.checkBoxClickDesktopNumberTaskView_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonOverlayMicroDuration);
            this.panel2.Controls.Add(this.radioButtonOverlayLongDuration);
            this.panel2.Controls.Add(this.radioButtonOverlayMediumDuration);
            this.panel2.Controls.Add(this.radioButtonOverlayShortDuration);
            this.panel2.Location = new System.Drawing.Point(60, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 38);
            this.panel2.TabIndex = 19;
            // 
            // radioButtonOverlayMicroDuration
            // 
            this.radioButtonOverlayMicroDuration.AutoSize = true;
            this.radioButtonOverlayMicroDuration.Location = new System.Drawing.Point(8, 8);
            this.radioButtonOverlayMicroDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOverlayMicroDuration.Name = "radioButtonOverlayMicroDuration";
            this.radioButtonOverlayMicroDuration.Size = new System.Drawing.Size(82, 24);
            this.radioButtonOverlayMicroDuration.TabIndex = 9;
            this.radioButtonOverlayMicroDuration.TabStop = true;
            this.radioButtonOverlayMicroDuration.Text = "500ms";
            this.radioButtonOverlayMicroDuration.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverlayLongDuration
            // 
            this.radioButtonOverlayLongDuration.AutoSize = true;
            this.radioButtonOverlayLongDuration.Location = new System.Drawing.Point(304, 8);
            this.radioButtonOverlayLongDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOverlayLongDuration.Name = "radioButtonOverlayLongDuration";
            this.radioButtonOverlayLongDuration.Size = new System.Drawing.Size(91, 24);
            this.radioButtonOverlayLongDuration.TabIndex = 8;
            this.radioButtonOverlayLongDuration.TabStop = true;
            this.radioButtonOverlayLongDuration.Text = "3000ms";
            this.radioButtonOverlayLongDuration.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverlayMediumDuration
            // 
            this.radioButtonOverlayMediumDuration.AutoSize = true;
            this.radioButtonOverlayMediumDuration.Location = new System.Drawing.Point(206, 8);
            this.radioButtonOverlayMediumDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOverlayMediumDuration.Name = "radioButtonOverlayMediumDuration";
            this.radioButtonOverlayMediumDuration.Size = new System.Drawing.Size(91, 24);
            this.radioButtonOverlayMediumDuration.TabIndex = 7;
            this.radioButtonOverlayMediumDuration.TabStop = true;
            this.radioButtonOverlayMediumDuration.Text = "2000ms";
            this.radioButtonOverlayMediumDuration.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverlayShortDuration
            // 
            this.radioButtonOverlayShortDuration.AutoSize = true;
            this.radioButtonOverlayShortDuration.Location = new System.Drawing.Point(104, 8);
            this.radioButtonOverlayShortDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonOverlayShortDuration.Name = "radioButtonOverlayShortDuration";
            this.radioButtonOverlayShortDuration.Size = new System.Drawing.Size(91, 24);
            this.radioButtonOverlayShortDuration.TabIndex = 6;
            this.radioButtonOverlayShortDuration.TabStop = true;
            this.radioButtonOverlayShortDuration.Text = "1000ms";
            this.radioButtonOverlayShortDuration.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPositionBottomRight);
            this.panel1.Controls.Add(this.radioButtonPositionBottomCenter);
            this.panel1.Controls.Add(this.radioButtonPositionBottomLeft);
            this.panel1.Controls.Add(this.radioButtonPositionMiddleRight);
            this.panel1.Controls.Add(this.radioButtonPositionMiddleCenter);
            this.panel1.Controls.Add(this.radioButtonPositionMiddleLeft);
            this.panel1.Controls.Add(this.radioButtonPositionTopRight);
            this.panel1.Controls.Add(this.radioButtonPositionTopCenter);
            this.panel1.Controls.Add(this.radioButtonPositionTopLeft);
            this.panel1.Location = new System.Drawing.Point(130, 205);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 91);
            this.panel1.TabIndex = 18;
            // 
            // radioButtonPositionBottomRight
            // 
            this.radioButtonPositionBottomRight.AutoSize = true;
            this.radioButtonPositionBottomRight.Location = new System.Drawing.Point(64, 63);
            this.radioButtonPositionBottomRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionBottomRight.Name = "radioButtonPositionBottomRight";
            this.radioButtonPositionBottomRight.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionBottomRight.TabIndex = 26;
            this.radioButtonPositionBottomRight.TabStop = true;
            this.radioButtonPositionBottomRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionBottomCenter
            // 
            this.radioButtonPositionBottomCenter.AutoSize = true;
            this.radioButtonPositionBottomCenter.Location = new System.Drawing.Point(34, 63);
            this.radioButtonPositionBottomCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionBottomCenter.Name = "radioButtonPositionBottomCenter";
            this.radioButtonPositionBottomCenter.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionBottomCenter.TabIndex = 25;
            this.radioButtonPositionBottomCenter.TabStop = true;
            this.radioButtonPositionBottomCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionBottomLeft
            // 
            this.radioButtonPositionBottomLeft.AutoSize = true;
            this.radioButtonPositionBottomLeft.Location = new System.Drawing.Point(4, 63);
            this.radioButtonPositionBottomLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionBottomLeft.Name = "radioButtonPositionBottomLeft";
            this.radioButtonPositionBottomLeft.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionBottomLeft.TabIndex = 24;
            this.radioButtonPositionBottomLeft.TabStop = true;
            this.radioButtonPositionBottomLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionMiddleRight
            // 
            this.radioButtonPositionMiddleRight.AutoSize = true;
            this.radioButtonPositionMiddleRight.Location = new System.Drawing.Point(64, 34);
            this.radioButtonPositionMiddleRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionMiddleRight.Name = "radioButtonPositionMiddleRight";
            this.radioButtonPositionMiddleRight.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionMiddleRight.TabIndex = 23;
            this.radioButtonPositionMiddleRight.TabStop = true;
            this.radioButtonPositionMiddleRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionMiddleCenter
            // 
            this.radioButtonPositionMiddleCenter.AutoSize = true;
            this.radioButtonPositionMiddleCenter.Location = new System.Drawing.Point(34, 34);
            this.radioButtonPositionMiddleCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionMiddleCenter.Name = "radioButtonPositionMiddleCenter";
            this.radioButtonPositionMiddleCenter.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionMiddleCenter.TabIndex = 22;
            this.radioButtonPositionMiddleCenter.TabStop = true;
            this.radioButtonPositionMiddleCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionMiddleLeft
            // 
            this.radioButtonPositionMiddleLeft.AutoSize = true;
            this.radioButtonPositionMiddleLeft.Location = new System.Drawing.Point(4, 34);
            this.radioButtonPositionMiddleLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionMiddleLeft.Name = "radioButtonPositionMiddleLeft";
            this.radioButtonPositionMiddleLeft.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionMiddleLeft.TabIndex = 21;
            this.radioButtonPositionMiddleLeft.TabStop = true;
            this.radioButtonPositionMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionTopRight
            // 
            this.radioButtonPositionTopRight.AutoSize = true;
            this.radioButtonPositionTopRight.Location = new System.Drawing.Point(64, 5);
            this.radioButtonPositionTopRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionTopRight.Name = "radioButtonPositionTopRight";
            this.radioButtonPositionTopRight.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionTopRight.TabIndex = 20;
            this.radioButtonPositionTopRight.TabStop = true;
            this.radioButtonPositionTopRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionTopCenter
            // 
            this.radioButtonPositionTopCenter.AutoSize = true;
            this.radioButtonPositionTopCenter.Location = new System.Drawing.Point(34, 5);
            this.radioButtonPositionTopCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionTopCenter.Name = "radioButtonPositionTopCenter";
            this.radioButtonPositionTopCenter.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionTopCenter.TabIndex = 19;
            this.radioButtonPositionTopCenter.TabStop = true;
            this.radioButtonPositionTopCenter.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositionTopLeft
            // 
            this.radioButtonPositionTopLeft.AutoSize = true;
            this.radioButtonPositionTopLeft.Location = new System.Drawing.Point(4, 5);
            this.radioButtonPositionTopLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPositionTopLeft.Name = "radioButtonPositionTopLeft";
            this.radioButtonPositionTopLeft.Size = new System.Drawing.Size(21, 20);
            this.radioButtonPositionTopLeft.TabIndex = 18;
            this.radioButtonPositionTopLeft.TabStop = true;
            this.radioButtonPositionTopLeft.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Position:";
            // 
            // checkBoxOverlayTranslucent
            // 
            this.checkBoxOverlayTranslucent.AutoSize = true;
            this.checkBoxOverlayTranslucent.Location = new System.Drawing.Point(64, 171);
            this.checkBoxOverlayTranslucent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOverlayTranslucent.Name = "checkBoxOverlayTranslucent";
            this.checkBoxOverlayTranslucent.Size = new System.Drawing.Size(118, 24);
            this.checkBoxOverlayTranslucent.TabIndex = 7;
            this.checkBoxOverlayTranslucent.Text = "Translucent";
            this.checkBoxOverlayTranslucent.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverlayAnimate
            // 
            this.checkBoxOverlayAnimate.AutoSize = true;
            this.checkBoxOverlayAnimate.Location = new System.Drawing.Point(64, 135);
            this.checkBoxOverlayAnimate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOverlayAnimate.Name = "checkBoxOverlayAnimate";
            this.checkBoxOverlayAnimate.Size = new System.Drawing.Size(142, 24);
            this.checkBoxOverlayAnimate.TabIndex = 6;
            this.checkBoxOverlayAnimate.Text = "Animate In/Out";
            this.checkBoxOverlayAnimate.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowOverlay
            // 
            this.checkBoxShowOverlay.AutoSize = true;
            this.checkBoxShowOverlay.Location = new System.Drawing.Point(22, 65);
            this.checkBoxShowOverlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShowOverlay.Name = "checkBoxShowOverlay";
            this.checkBoxShowOverlay.Size = new System.Drawing.Size(306, 24);
            this.checkBoxShowOverlay.TabIndex = 2;
            this.checkBoxShowOverlay.Text = "Show Overlay when switching Desktop";
            this.checkBoxShowOverlay.UseVisualStyleBackColor = true;
            this.checkBoxShowOverlay.CheckedChanged += new System.EventHandler(this.checkBoxShowOverlay_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxStartupWithWindows);
            this.groupBox2.Location = new System.Drawing.Point(18, 395);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(620, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBoxStartupWithWindows
            // 
            this.checkBoxStartupWithWindows.AutoSize = true;
            this.checkBoxStartupWithWindows.Location = new System.Drawing.Point(22, 29);
            this.checkBoxStartupWithWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxStartupWithWindows.Name = "checkBoxStartupWithWindows";
            this.checkBoxStartupWithWindows.Size = new System.Drawing.Size(188, 24);
            this.checkBoxStartupWithWindows.TabIndex = 1;
            this.checkBoxStartupWithWindows.Text = "Startup with Windows";
            this.checkBoxStartupWithWindows.UseVisualStyleBackColor = true;
            this.checkBoxStartupWithWindows.CheckedChanged += new System.EventHandler(this.checkBoxStartupWithWindows_CheckedChanged);
            // 
            // notifyIconName
            // 
            this.notifyIconName.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconName.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconName.Icon")));
            this.notifyIconName.Text = "Desktop Name";
            this.notifyIconName.Visible = true;
            this.notifyIconName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconName_MouseClick);
			// 
			// moveCurrentWindowToToolStripMenuItem
			// 
			this.toolStripMenuItemMoveWndToVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.vD1ToolStripMenuItem2});
			this.toolStripMenuItemMoveWndToVD.Name = "moveCurrentWindowToToolStripMenuItem";
			this.toolStripMenuItemMoveWndToVD.Size = new System.Drawing.Size(278, 32);
			this.toolStripMenuItemMoveWndToVD.Text = "Move current window to";
			this.toolStripMenuItemMoveWndToVD.DropDownOpening += new System.EventHandler(this.populateMoveWndToVdDropDownOpening);
			// 
			// hotkeyedMenuMoveWndToVD
			// 
			this.hotkeyedMenuMoveWndToVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.vD1ToolStripMenuItem2});
			this.hotkeyedMenuMoveWndToVD.Name = "hotkeyedMenuMoveWndToVD";
			this.hotkeyedMenuMoveWndToVD.Size = new System.Drawing.Size(278, 32);
			this.hotkeyedMenuMoveWndToVD.Text = "Move current window to";
			this.hotkeyedMenuMoveWndToVD.DropDownOpening += new System.EventHandler(this.populateMoveWndToVdDropDownOpening);
			// 
			// vD1ToolStripMenuItem2
			// 
			this.vD1ToolStripMenuItem2.Name = "vD1ToolStripMenuItem2";
            this.vD1ToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.vD1ToolStripMenuItem2.Text = "VD1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.hotkeyedMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip hotkeyedMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSwitchVD;
        private System.Windows.Forms.ToolStripMenuItem hotkeyedMenuSwitchVD;
        private System.Windows.Forms.NotifyIcon notifyIconPrev;
        private System.Windows.Forms.NotifyIcon notifyIconNext;
        private System.Windows.Forms.CheckBox checkBoxShowPrevNextIcons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxStartupWithWindows;
        private System.Windows.Forms.CheckBox checkBoxShowOverlay;
        private System.Windows.Forms.CheckBox checkBoxOverlayTranslucent;
        private System.Windows.Forms.CheckBox checkBoxOverlayAnimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonOverlayLongDuration;
        private System.Windows.Forms.RadioButton radioButtonOverlayMediumDuration;
        private System.Windows.Forms.RadioButton radioButtonOverlayShortDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonPositionBottomRight;
        private System.Windows.Forms.RadioButton radioButtonPositionBottomCenter;
        private System.Windows.Forms.RadioButton radioButtonPositionBottomLeft;
        private System.Windows.Forms.RadioButton radioButtonPositionMiddleRight;
        private System.Windows.Forms.RadioButton radioButtonPositionMiddleCenter;
        private System.Windows.Forms.RadioButton radioButtonPositionMiddleLeft;
        private System.Windows.Forms.RadioButton radioButtonPositionTopRight;
        private System.Windows.Forms.RadioButton radioButtonPositionTopCenter;
        private System.Windows.Forms.RadioButton radioButtonPositionTopLeft;
        private System.Windows.Forms.RadioButton radioButtonOverlayMicroDuration;
        private System.Windows.Forms.CheckBox checkBoxClickDesktopNumberTaskView;
        private System.Windows.Forms.NotifyIcon notifyIconName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRenameVD;
        private System.Windows.Forms.ToolStripMenuItem hotkeyedMenuRenameVD;
        private System.Windows.Forms.ToolStripMenuItem vD1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vD1ToolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItemMoveWndToVD;
		private ToolStripMenuItem hotkeyedMenuMoveWndToVD;
		private ToolStripMenuItem vD1ToolStripMenuItem2;
	}
}