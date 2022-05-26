// Chocolate Doom Launcher
// An unofficial front-end for Chocolate Doom
// By Myles Thaiss

// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

namespace CrispyDoomLauncher
{
    partial class MainForm
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.groupBoxGame = new System.Windows.Forms.GroupBox();
        	this.textBoxExtraParms = new System.Windows.Forms.TextBox();
        	this.labelExtraParms = new System.Windows.Forms.Label();
        	this.checkBoxTitleScreen = new System.Windows.Forms.CheckBox();
        	this.labelLevel = new System.Windows.Forms.Label();
        	this.comboBoxLevel = new System.Windows.Forms.ComboBox();
        	this.comboBoxSkill = new System.Windows.Forms.ComboBox();
        	this.labelSkill = new System.Windows.Forms.Label();
        	this.comboBoxIWAD = new System.Windows.Forms.ComboBox();
        	this.labelIWAD = new System.Windows.Forms.Label();
        	this.groupBoxOptions = new System.Windows.Forms.GroupBox();
        	this.numericUpDownTurbo = new System.Windows.Forms.NumericUpDown();
        	this.checkBoxTurbo = new System.Windows.Forms.CheckBox();
        	this.checkBoxRespawnMonsters = new System.Windows.Forms.CheckBox();
        	this.checkBoxFastMonsters = new System.Windows.Forms.CheckBox();
        	this.checkBoxNoMonsters = new System.Windows.Forms.CheckBox();
        	this.buttonRun = new System.Windows.Forms.Button();
        	this.Exit = new System.Windows.Forms.Button();
        	this.groupBoxDemo = new System.Windows.Forms.GroupBox();
        	this.radioButtonRecordDemo = new System.Windows.Forms.RadioButton();
        	this.radioButtonPlayDemo = new System.Windows.Forms.RadioButton();
        	this.buttonBrowseDemo = new System.Windows.Forms.Button();
        	this.textBoxDemoPath = new System.Windows.Forms.TextBox();
        	this.checkBoxDemo = new System.Windows.Forms.CheckBox();
        	this.groupBoxWADs = new System.Windows.Forms.GroupBox();
        	this.buttonAddWADs = new System.Windows.Forms.Button();
        	this.listBoxWADS = new System.Windows.Forms.ListBox();
        	this.groupBoxMultiplayer = new System.Windows.Forms.GroupBox();
        	this.radioButtonLocalSearch = new System.Windows.Forms.RadioButton();
        	this.checkBoxPrivateServer = new System.Windows.Forms.CheckBox();
        	this.labelServerName = new System.Windows.Forms.Label();
        	this.textBoxAddress = new System.Windows.Forms.TextBox();
        	this.radioButtonConnect = new System.Windows.Forms.RadioButton();
        	this.radioButtonAutoConnect = new System.Windows.Forms.RadioButton();
        	this.numericUpDownNodes = new System.Windows.Forms.NumericUpDown();
        	this.labelNodes = new System.Windows.Forms.Label();
        	this.textBoxServerName = new System.Windows.Forms.TextBox();
        	this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
        	this.labelTime = new System.Windows.Forms.Label();
        	this.comboBoxMultiplayerModes = new System.Windows.Forms.ComboBox();
        	this.checkBoxMultiplayer = new System.Windows.Forms.CheckBox();
        	this.groupBoxGame.SuspendLayout();
        	this.groupBoxOptions.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurbo)).BeginInit();
        	this.groupBoxDemo.SuspendLayout();
        	this.groupBoxWADs.SuspendLayout();
        	this.groupBoxMultiplayer.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodes)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// groupBoxGame
        	// 
        	this.groupBoxGame.Controls.Add(this.textBoxExtraParms);
        	this.groupBoxGame.Controls.Add(this.labelExtraParms);
        	this.groupBoxGame.Controls.Add(this.checkBoxTitleScreen);
        	this.groupBoxGame.Controls.Add(this.labelLevel);
        	this.groupBoxGame.Controls.Add(this.comboBoxLevel);
        	this.groupBoxGame.Controls.Add(this.comboBoxSkill);
        	this.groupBoxGame.Controls.Add(this.labelSkill);
        	this.groupBoxGame.Controls.Add(this.comboBoxIWAD);
        	this.groupBoxGame.Controls.Add(this.labelIWAD);
        	this.groupBoxGame.Location = new System.Drawing.Point(16, 15);
        	this.groupBoxGame.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBoxGame.Name = "groupBoxGame";
        	this.groupBoxGame.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBoxGame.Size = new System.Drawing.Size(437, 167);
        	this.groupBoxGame.TabIndex = 0;
        	this.groupBoxGame.TabStop = false;
        	this.groupBoxGame.Text = "Game";
        	// 
        	// textBoxExtraParms
        	// 
        	this.textBoxExtraParms.Location = new System.Drawing.Point(108, 125);
        	this.textBoxExtraParms.Name = "textBoxExtraParms";
        	this.textBoxExtraParms.Size = new System.Drawing.Size(313, 22);
        	this.textBoxExtraParms.TabIndex = 8;
        	this.textBoxExtraParms.TextChanged += new System.EventHandler(this.TextBoxExtraParms_TextChanged);
        	// 
        	// labelExtraParms
        	// 
        	this.labelExtraParms.Location = new System.Drawing.Point(12, 128);
        	this.labelExtraParms.Name = "labelExtraParms";
        	this.labelExtraParms.Size = new System.Drawing.Size(102, 23);
        	this.labelExtraParms.TabIndex = 7;
        	this.labelExtraParms.Text = "Extra params";
        	// 
        	// checkBoxTitleScreen
        	// 
        	this.checkBoxTitleScreen.AutoSize = true;
        	this.checkBoxTitleScreen.Location = new System.Drawing.Point(12, 94);
        	this.checkBoxTitleScreen.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxTitleScreen.Name = "checkBoxTitleScreen";
        	this.checkBoxTitleScreen.Size = new System.Drawing.Size(149, 21);
        	this.checkBoxTitleScreen.TabIndex = 6;
        	this.checkBoxTitleScreen.Text = "Start at title screen";
        	this.checkBoxTitleScreen.UseVisualStyleBackColor = true;
        	this.checkBoxTitleScreen.CheckedChanged += new System.EventHandler(this.checkBoxTitleScreen_CheckedChanged);
        	// 
        	// labelLevel
        	// 
        	this.labelLevel.AutoSize = true;
        	this.labelLevel.Location = new System.Drawing.Point(8, 62);
        	this.labelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelLevel.Name = "labelLevel";
        	this.labelLevel.Size = new System.Drawing.Size(46, 17);
        	this.labelLevel.TabIndex = 4;
        	this.labelLevel.Text = "Level:";
        	// 
        	// comboBoxLevel
        	// 
        	this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxLevel.FormattingEnabled = true;
        	this.comboBoxLevel.Location = new System.Drawing.Point(68, 57);
        	this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(4);
        	this.comboBoxLevel.Name = "comboBoxLevel";
        	this.comboBoxLevel.Size = new System.Drawing.Size(68, 24);
        	this.comboBoxLevel.TabIndex = 5;
        	this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
        	// 
        	// comboBoxSkill
        	// 
        	this.comboBoxSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxSkill.FormattingEnabled = true;
        	this.comboBoxSkill.Location = new System.Drawing.Point(201, 57);
        	this.comboBoxSkill.Margin = new System.Windows.Forms.Padding(4);
        	this.comboBoxSkill.Name = "comboBoxSkill";
        	this.comboBoxSkill.Size = new System.Drawing.Size(220, 24);
        	this.comboBoxSkill.TabIndex = 4;
        	// 
        	// labelSkill
        	// 
        	this.labelSkill.AutoSize = true;
        	this.labelSkill.Location = new System.Drawing.Point(159, 62);
        	this.labelSkill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelSkill.Name = "labelSkill";
        	this.labelSkill.Size = new System.Drawing.Size(37, 17);
        	this.labelSkill.TabIndex = 4;
        	this.labelSkill.Text = "Skill:";
        	// 
        	// comboBoxIWAD
        	// 
        	this.comboBoxIWAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxIWAD.FormattingEnabled = true;
        	this.comboBoxIWAD.Location = new System.Drawing.Point(68, 27);
        	this.comboBoxIWAD.Margin = new System.Windows.Forms.Padding(4);
        	this.comboBoxIWAD.Name = "comboBoxIWAD";
        	this.comboBoxIWAD.Size = new System.Drawing.Size(353, 24);
        	this.comboBoxIWAD.TabIndex = 4;
        	this.comboBoxIWAD.SelectedIndexChanged += new System.EventHandler(this.comboBoxIWAD_SelectedIndexChanged);
        	// 
        	// labelIWAD
        	// 
        	this.labelIWAD.AutoSize = true;
        	this.labelIWAD.Location = new System.Drawing.Point(8, 32);
        	this.labelIWAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelIWAD.Name = "labelIWAD";
        	this.labelIWAD.Size = new System.Drawing.Size(47, 17);
        	this.labelIWAD.TabIndex = 4;
        	this.labelIWAD.Text = "IWAD:";
        	// 
        	// groupBoxOptions
        	// 
        	this.groupBoxOptions.Controls.Add(this.numericUpDownTurbo);
        	this.groupBoxOptions.Controls.Add(this.checkBoxTurbo);
        	this.groupBoxOptions.Controls.Add(this.checkBoxRespawnMonsters);
        	this.groupBoxOptions.Controls.Add(this.checkBoxFastMonsters);
        	this.groupBoxOptions.Controls.Add(this.checkBoxNoMonsters);
        	this.groupBoxOptions.Location = new System.Drawing.Point(16, 327);
        	this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBoxOptions.Name = "groupBoxOptions";
        	this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBoxOptions.Size = new System.Drawing.Size(437, 92);
        	this.groupBoxOptions.TabIndex = 1;
        	this.groupBoxOptions.TabStop = false;
        	this.groupBoxOptions.Text = "Options";
        	// 
        	// numericUpDownTurbo
        	// 
        	this.numericUpDownTurbo.Enabled = false;
        	this.numericUpDownTurbo.Increment = new decimal(new int[] {
        	        	        	10,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numericUpDownTurbo.Location = new System.Drawing.Point(88, 23);
        	this.numericUpDownTurbo.Margin = new System.Windows.Forms.Padding(4);
        	this.numericUpDownTurbo.Maximum = new decimal(new int[] {
        	        	        	1000,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numericUpDownTurbo.Name = "numericUpDownTurbo";
        	this.numericUpDownTurbo.Size = new System.Drawing.Size(52, 22);
        	this.numericUpDownTurbo.TabIndex = 4;
        	this.numericUpDownTurbo.ValueChanged += new System.EventHandler(this.numericUpDownTurbo_ValueChanged);
        	// 
        	// checkBoxTurbo
        	// 
        	this.checkBoxTurbo.AutoSize = true;
        	this.checkBoxTurbo.Location = new System.Drawing.Point(12, 25);
        	this.checkBoxTurbo.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxTurbo.Name = "checkBoxTurbo";
        	this.checkBoxTurbo.Size = new System.Drawing.Size(72, 21);
        	this.checkBoxTurbo.TabIndex = 3;
        	this.checkBoxTurbo.Text = "Turbo:";
        	this.checkBoxTurbo.UseVisualStyleBackColor = true;
        	this.checkBoxTurbo.CheckedChanged += new System.EventHandler(this.checkBoxTurbo_CheckedChanged);
        	// 
        	// checkBoxRespawnMonsters
        	// 
        	this.checkBoxRespawnMonsters.AutoSize = true;
        	this.checkBoxRespawnMonsters.Location = new System.Drawing.Point(273, 55);
        	this.checkBoxRespawnMonsters.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxRespawnMonsters.Name = "checkBoxRespawnMonsters";
        	this.checkBoxRespawnMonsters.Size = new System.Drawing.Size(150, 21);
        	this.checkBoxRespawnMonsters.TabIndex = 2;
        	this.checkBoxRespawnMonsters.Text = "Respawn Monsters";
        	this.checkBoxRespawnMonsters.UseVisualStyleBackColor = true;
        	this.checkBoxRespawnMonsters.CheckedChanged += new System.EventHandler(this.checkBoxRespawnMonsters_CheckedChanged);
        	// 
        	// checkBoxFastMonsters
        	// 
        	this.checkBoxFastMonsters.AutoSize = true;
        	this.checkBoxFastMonsters.Location = new System.Drawing.Point(12, 55);
        	this.checkBoxFastMonsters.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxFastMonsters.Name = "checkBoxFastMonsters";
        	this.checkBoxFastMonsters.Size = new System.Drawing.Size(119, 21);
        	this.checkBoxFastMonsters.TabIndex = 1;
        	this.checkBoxFastMonsters.Text = "Fast Monsters";
        	this.checkBoxFastMonsters.UseVisualStyleBackColor = true;
        	this.checkBoxFastMonsters.CheckedChanged += new System.EventHandler(this.checkBoxFastMonster_CheckedChanged);
        	// 
        	// checkBoxNoMonsters
        	// 
        	this.checkBoxNoMonsters.AutoSize = true;
        	this.checkBoxNoMonsters.Location = new System.Drawing.Point(273, 25);
        	this.checkBoxNoMonsters.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxNoMonsters.Name = "checkBoxNoMonsters";
        	this.checkBoxNoMonsters.Size = new System.Drawing.Size(110, 21);
        	this.checkBoxNoMonsters.TabIndex = 0;
        	this.checkBoxNoMonsters.Text = "No Monsters";
        	this.checkBoxNoMonsters.UseVisualStyleBackColor = true;
        	this.checkBoxNoMonsters.CheckedChanged += new System.EventHandler(this.checkBoxNoMonsters_ChckedChanged);
        	// 
        	// buttonRun
        	// 
        	this.buttonRun.Location = new System.Drawing.Point(597, 537);
        	this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
        	this.buttonRun.Name = "buttonRun";
        	this.buttonRun.Size = new System.Drawing.Size(100, 28);
        	this.buttonRun.TabIndex = 2;
        	this.buttonRun.Text = "Run";
        	this.buttonRun.UseVisualStyleBackColor = true;
        	this.buttonRun.Click += new System.EventHandler(this.buttonRun_Clicked);
        	// 
        	// Exit
        	// 
        	this.Exit.Location = new System.Drawing.Point(16, 537);
        	this.Exit.Margin = new System.Windows.Forms.Padding(4);
        	this.Exit.Name = "Exit";
        	this.Exit.Size = new System.Drawing.Size(100, 28);
        	this.Exit.TabIndex = 3;
        	this.Exit.Text = "Exit";
        	this.Exit.UseVisualStyleBackColor = true;
        	this.Exit.Click += new System.EventHandler(this.buttonExit_Clicked);
        	// 
        	// groupBoxDemo
        	// 
        	this.groupBoxDemo.Controls.Add(this.radioButtonRecordDemo);
        	this.groupBoxDemo.Controls.Add(this.radioButtonPlayDemo);
        	this.groupBoxDemo.Controls.Add(this.buttonBrowseDemo);
        	this.groupBoxDemo.Controls.Add(this.textBoxDemoPath);
        	this.groupBoxDemo.Controls.Add(this.checkBoxDemo);
        	this.groupBoxDemo.Location = new System.Drawing.Point(16, 427);
        	this.groupBoxDemo.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBoxDemo.Name = "groupBoxDemo";
        	this.groupBoxDemo.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBoxDemo.Size = new System.Drawing.Size(437, 92);
        	this.groupBoxDemo.TabIndex = 4;
        	this.groupBoxDemo.TabStop = false;
        	this.groupBoxDemo.Text = "Demo";
        	// 
        	// radioButtonRecordDemo
        	// 
        	this.radioButtonRecordDemo.AutoSize = true;
        	this.radioButtonRecordDemo.Location = new System.Drawing.Point(88, 57);
        	this.radioButtonRecordDemo.Margin = new System.Windows.Forms.Padding(4);
        	this.radioButtonRecordDemo.Name = "radioButtonRecordDemo";
        	this.radioButtonRecordDemo.Size = new System.Drawing.Size(75, 21);
        	this.radioButtonRecordDemo.TabIndex = 4;
        	this.radioButtonRecordDemo.Text = "Record";
        	this.radioButtonRecordDemo.UseVisualStyleBackColor = true;
        	// 
        	// radioButtonPlayDemo
        	// 
        	this.radioButtonPlayDemo.AutoSize = true;
        	this.radioButtonPlayDemo.Checked = true;
        	this.radioButtonPlayDemo.Location = new System.Drawing.Point(12, 57);
        	this.radioButtonPlayDemo.Margin = new System.Windows.Forms.Padding(4);
        	this.radioButtonPlayDemo.Name = "radioButtonPlayDemo";
        	this.radioButtonPlayDemo.Size = new System.Drawing.Size(56, 21);
        	this.radioButtonPlayDemo.TabIndex = 3;
        	this.radioButtonPlayDemo.TabStop = true;
        	this.radioButtonPlayDemo.Text = "Play";
        	this.radioButtonPlayDemo.UseVisualStyleBackColor = true;
        	this.radioButtonPlayDemo.CheckedChanged += new System.EventHandler(this.radioButtonPlayDemo_CheckedChanged);
        	// 
        	// buttonBrowseDemo
        	// 
        	this.buttonBrowseDemo.Location = new System.Drawing.Point(392, 22);
        	this.buttonBrowseDemo.Margin = new System.Windows.Forms.Padding(4);
        	this.buttonBrowseDemo.Name = "buttonBrowseDemo";
        	this.buttonBrowseDemo.Size = new System.Drawing.Size(32, 28);
        	this.buttonBrowseDemo.TabIndex = 2;
        	this.buttonBrowseDemo.Text = "...";
        	this.buttonBrowseDemo.UseVisualStyleBackColor = true;
        	this.buttonBrowseDemo.Click += new System.EventHandler(this.buttonBrowseDemoFile_Clicked);
        	// 
        	// textBoxDemoPath
        	// 
        	this.textBoxDemoPath.Location = new System.Drawing.Point(88, 25);
        	this.textBoxDemoPath.Margin = new System.Windows.Forms.Padding(4);
        	this.textBoxDemoPath.Name = "textBoxDemoPath";
        	this.textBoxDemoPath.Size = new System.Drawing.Size(295, 22);
        	this.textBoxDemoPath.TabIndex = 1;
        	this.textBoxDemoPath.TextChanged += new System.EventHandler(this.textBoxDemoPath_TextChanged);
        	// 
        	// checkBoxDemo
        	// 
        	this.checkBoxDemo.AutoSize = true;
        	this.checkBoxDemo.Location = new System.Drawing.Point(12, 27);
        	this.checkBoxDemo.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxDemo.Name = "checkBoxDemo";
        	this.checkBoxDemo.Size = new System.Drawing.Size(71, 21);
        	this.checkBoxDemo.TabIndex = 0;
        	this.checkBoxDemo.Text = "Demo:";
        	this.checkBoxDemo.UseVisualStyleBackColor = true;
        	this.checkBoxDemo.CheckedChanged += new System.EventHandler(this.checkBoxDemo_CheckedChanged);
        	// 
        	// groupBoxWADs
        	// 
        	this.groupBoxWADs.Controls.Add(this.buttonAddWADs);
        	this.groupBoxWADs.Controls.Add(this.listBoxWADS);
        	this.groupBoxWADs.Location = new System.Drawing.Point(464, 15);
        	this.groupBoxWADs.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBoxWADs.Name = "groupBoxWADs";
        	this.groupBoxWADs.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBoxWADs.Size = new System.Drawing.Size(233, 504);
        	this.groupBoxWADs.TabIndex = 5;
        	this.groupBoxWADs.TabStop = false;
        	this.groupBoxWADs.Text = "WADs";
        	// 
        	// buttonAddWADs
        	// 
        	this.buttonAddWADs.Location = new System.Drawing.Point(8, 462);
        	this.buttonAddWADs.Margin = new System.Windows.Forms.Padding(4);
        	this.buttonAddWADs.Name = "buttonAddWADs";
        	this.buttonAddWADs.Size = new System.Drawing.Size(59, 28);
        	this.buttonAddWADs.TabIndex = 1;
        	this.buttonAddWADs.Text = "Add";
        	this.buttonAddWADs.UseVisualStyleBackColor = true;
        	this.buttonAddWADs.Click += new System.EventHandler(this.buttonAddWADS_Clicked);
        	// 
        	// listBoxWADS
        	// 
        	this.listBoxWADS.FormattingEnabled = true;
        	this.listBoxWADS.ItemHeight = 16;
        	this.listBoxWADS.Location = new System.Drawing.Point(11, 27);
        	this.listBoxWADS.Margin = new System.Windows.Forms.Padding(4);
        	this.listBoxWADS.Name = "listBoxWADS";
        	this.listBoxWADS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
        	this.listBoxWADS.Size = new System.Drawing.Size(209, 420);
        	this.listBoxWADS.TabIndex = 0;
        	// 
        	// groupBoxMultiplayer
        	// 
        	this.groupBoxMultiplayer.Controls.Add(this.radioButtonLocalSearch);
        	this.groupBoxMultiplayer.Controls.Add(this.checkBoxPrivateServer);
        	this.groupBoxMultiplayer.Controls.Add(this.labelServerName);
        	this.groupBoxMultiplayer.Controls.Add(this.textBoxAddress);
        	this.groupBoxMultiplayer.Controls.Add(this.radioButtonConnect);
        	this.groupBoxMultiplayer.Controls.Add(this.radioButtonAutoConnect);
        	this.groupBoxMultiplayer.Controls.Add(this.numericUpDownNodes);
        	this.groupBoxMultiplayer.Controls.Add(this.labelNodes);
        	this.groupBoxMultiplayer.Controls.Add(this.textBoxServerName);
        	this.groupBoxMultiplayer.Controls.Add(this.numericUpDownTime);
        	this.groupBoxMultiplayer.Controls.Add(this.labelTime);
        	this.groupBoxMultiplayer.Controls.Add(this.comboBoxMultiplayerModes);
        	this.groupBoxMultiplayer.Controls.Add(this.checkBoxMultiplayer);
        	this.groupBoxMultiplayer.Location = new System.Drawing.Point(16, 190);
        	this.groupBoxMultiplayer.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBoxMultiplayer.Name = "groupBoxMultiplayer";
        	this.groupBoxMultiplayer.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBoxMultiplayer.Size = new System.Drawing.Size(437, 129);
        	this.groupBoxMultiplayer.TabIndex = 6;
        	this.groupBoxMultiplayer.TabStop = false;
        	this.groupBoxMultiplayer.Text = "Multiplayer";
        	// 
        	// radioButtonLocalSearch
        	// 
        	this.radioButtonLocalSearch.AutoSize = true;
        	this.radioButtonLocalSearch.Location = new System.Drawing.Point(83, 92);
        	this.radioButtonLocalSearch.Margin = new System.Windows.Forms.Padding(4);
        	this.radioButtonLocalSearch.Name = "radioButtonLocalSearch";
        	this.radioButtonLocalSearch.Size = new System.Drawing.Size(63, 21);
        	this.radioButtonLocalSearch.TabIndex = 2;
        	this.radioButtonLocalSearch.TabStop = true;
        	this.radioButtonLocalSearch.Text = "Local";
        	this.radioButtonLocalSearch.UseVisualStyleBackColor = true;
        	this.radioButtonLocalSearch.CheckedChanged += new System.EventHandler(this.radioButtonLocalSearch_CheckedChanged);
        	// 
        	// checkBoxPrivateServer
        	// 
        	this.checkBoxPrivateServer.AutoSize = true;
        	this.checkBoxPrivateServer.Location = new System.Drawing.Point(237, 63);
        	this.checkBoxPrivateServer.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxPrivateServer.Name = "checkBoxPrivateServer";
        	this.checkBoxPrivateServer.Size = new System.Drawing.Size(74, 21);
        	this.checkBoxPrivateServer.TabIndex = 2;
        	this.checkBoxPrivateServer.Text = "Private";
        	this.checkBoxPrivateServer.UseVisualStyleBackColor = true;
        	this.checkBoxPrivateServer.CheckedChanged += new System.EventHandler(this.checkBoxPrivateServer_CheckedChanged);
        	// 
        	// labelServerName
        	// 
        	this.labelServerName.AutoSize = true;
        	this.labelServerName.Location = new System.Drawing.Point(8, 64);
        	this.labelServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelServerName.Name = "labelServerName";
        	this.labelServerName.Size = new System.Drawing.Size(54, 17);
        	this.labelServerName.TabIndex = 7;
        	this.labelServerName.Text = "Server:";
        	// 
        	// textBoxAddress
        	// 
        	this.textBoxAddress.Location = new System.Drawing.Point(257, 91);
        	this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
        	this.textBoxAddress.Name = "textBoxAddress";
        	this.textBoxAddress.Size = new System.Drawing.Size(164, 22);
        	this.textBoxAddress.TabIndex = 10;
        	this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
        	// 
        	// radioButtonConnect
        	// 
        	this.radioButtonConnect.AutoSize = true;
        	this.radioButtonConnect.Checked = true;
        	this.radioButtonConnect.Location = new System.Drawing.Point(163, 92);
        	this.radioButtonConnect.Margin = new System.Windows.Forms.Padding(4);
        	this.radioButtonConnect.Name = "radioButtonConnect";
        	this.radioButtonConnect.Size = new System.Drawing.Size(85, 21);
        	this.radioButtonConnect.TabIndex = 9;
        	this.radioButtonConnect.TabStop = true;
        	this.radioButtonConnect.Text = "Connect:";
        	this.radioButtonConnect.UseVisualStyleBackColor = true;
        	this.radioButtonConnect.CheckedChanged += new System.EventHandler(this.radioButtonConnect_CheckedChanged);
        	// 
        	// radioButtonAutoConnect
        	// 
        	this.radioButtonAutoConnect.AutoSize = true;
        	this.radioButtonAutoConnect.Location = new System.Drawing.Point(12, 92);
        	this.radioButtonAutoConnect.Margin = new System.Windows.Forms.Padding(4);
        	this.radioButtonAutoConnect.Name = "radioButtonAutoConnect";
        	this.radioButtonAutoConnect.Size = new System.Drawing.Size(58, 21);
        	this.radioButtonAutoConnect.TabIndex = 8;
        	this.radioButtonAutoConnect.Text = "Auto";
        	this.radioButtonAutoConnect.UseVisualStyleBackColor = true;
        	this.radioButtonAutoConnect.CheckedChanged += new System.EventHandler(this.radioButtonAutoConnect_CheckedChanged);
        	// 
        	// numericUpDownNodes
        	// 
        	this.numericUpDownNodes.Location = new System.Drawing.Point(381, 60);
        	this.numericUpDownNodes.Margin = new System.Windows.Forms.Padding(4);
        	this.numericUpDownNodes.Maximum = new decimal(new int[] {
        	        	        	4,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numericUpDownNodes.Name = "numericUpDownNodes";
        	this.numericUpDownNodes.Size = new System.Drawing.Size(41, 22);
        	this.numericUpDownNodes.TabIndex = 7;
        	this.numericUpDownNodes.ValueChanged += new System.EventHandler(this.numericUpDownNodes_ValueChanged);
        	// 
        	// labelNodes
        	// 
        	this.labelNodes.AutoSize = true;
        	this.labelNodes.Location = new System.Drawing.Point(323, 64);
        	this.labelNodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelNodes.Name = "labelNodes";
        	this.labelNodes.Size = new System.Drawing.Size(53, 17);
        	this.labelNodes.TabIndex = 6;
        	this.labelNodes.Text = "Nodes:";
        	// 
        	// textBoxServerName
        	// 
        	this.textBoxServerName.Location = new System.Drawing.Point(68, 60);
        	this.textBoxServerName.Margin = new System.Windows.Forms.Padding(4);
        	this.textBoxServerName.Name = "textBoxServerName";
        	this.textBoxServerName.Size = new System.Drawing.Size(155, 22);
        	this.textBoxServerName.TabIndex = 5;
        	this.textBoxServerName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
        	// 
        	// numericUpDownTime
        	// 
        	this.numericUpDownTime.Location = new System.Drawing.Point(360, 28);
        	this.numericUpDownTime.Margin = new System.Windows.Forms.Padding(4);
        	this.numericUpDownTime.Name = "numericUpDownTime";
        	this.numericUpDownTime.Size = new System.Drawing.Size(63, 22);
        	this.numericUpDownTime.TabIndex = 3;
        	this.numericUpDownTime.ValueChanged += new System.EventHandler(this.numericUpDownTime_ValueChanged);
        	// 
        	// labelTime
        	// 
        	this.labelTime.AutoSize = true;
        	this.labelTime.Location = new System.Drawing.Point(312, 31);
        	this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.labelTime.Name = "labelTime";
        	this.labelTime.Size = new System.Drawing.Size(43, 17);
        	this.labelTime.TabIndex = 2;
        	this.labelTime.Text = "Time:";
        	// 
        	// comboBoxMultiplayerModes
        	// 
        	this.comboBoxMultiplayerModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBoxMultiplayerModes.Enabled = false;
        	this.comboBoxMultiplayerModes.FormattingEnabled = true;
        	this.comboBoxMultiplayerModes.Location = new System.Drawing.Point(121, 27);
        	this.comboBoxMultiplayerModes.Margin = new System.Windows.Forms.Padding(4);
        	this.comboBoxMultiplayerModes.Name = "comboBoxMultiplayerModes";
        	this.comboBoxMultiplayerModes.Size = new System.Drawing.Size(137, 24);
        	this.comboBoxMultiplayerModes.TabIndex = 1;
        	// 
        	// checkBoxMultiplayer
        	// 
        	this.checkBoxMultiplayer.AutoSize = true;
        	this.checkBoxMultiplayer.Location = new System.Drawing.Point(12, 30);
        	this.checkBoxMultiplayer.Margin = new System.Windows.Forms.Padding(4);
        	this.checkBoxMultiplayer.Name = "checkBoxMultiplayer";
        	this.checkBoxMultiplayer.Size = new System.Drawing.Size(102, 21);
        	this.checkBoxMultiplayer.TabIndex = 0;
        	this.checkBoxMultiplayer.Text = "Multiplayer:";
        	this.checkBoxMultiplayer.UseVisualStyleBackColor = true;
        	this.checkBoxMultiplayer.CheckedChanged += new System.EventHandler(this.checkBoxMultiplayer_CheckedChanged);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(713, 578);
        	this.Controls.Add(this.groupBoxMultiplayer);
        	this.Controls.Add(this.groupBoxWADs);
        	this.Controls.Add(this.groupBoxDemo);
        	this.Controls.Add(this.Exit);
        	this.Controls.Add(this.buttonRun);
        	this.Controls.Add(this.groupBoxOptions);
        	this.Controls.Add(this.groupBoxGame);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Crispy Doom Launcher";
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.groupBoxGame.ResumeLayout(false);
        	this.groupBoxGame.PerformLayout();
        	this.groupBoxOptions.ResumeLayout(false);
        	this.groupBoxOptions.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurbo)).EndInit();
        	this.groupBoxDemo.ResumeLayout(false);
        	this.groupBoxDemo.PerformLayout();
        	this.groupBoxWADs.ResumeLayout(false);
        	this.groupBoxMultiplayer.ResumeLayout(false);
        	this.groupBoxMultiplayer.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodes)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label labelExtraParms;
        private System.Windows.Forms.TextBox textBoxExtraParms;

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.ComboBox comboBoxIWAD;
        private System.Windows.Forms.Label labelIWAD;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox comboBoxSkill;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.CheckBox checkBoxTitleScreen;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownTurbo;
        private System.Windows.Forms.CheckBox checkBoxTurbo;
        private System.Windows.Forms.CheckBox checkBoxRespawnMonsters;
        private System.Windows.Forms.CheckBox checkBoxFastMonsters;
        private System.Windows.Forms.CheckBox checkBoxNoMonsters;
        private System.Windows.Forms.GroupBox groupBoxDemo;
        private System.Windows.Forms.GroupBox groupBoxWADs;
        private System.Windows.Forms.ListBox listBoxWADS;
        private System.Windows.Forms.Button buttonAddWADs;
        private System.Windows.Forms.RadioButton radioButtonRecordDemo;
        private System.Windows.Forms.RadioButton radioButtonPlayDemo;
        private System.Windows.Forms.Button buttonBrowseDemo;
        private System.Windows.Forms.TextBox textBoxDemoPath;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.GroupBox groupBoxMultiplayer;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxMultiplayerModes;
        private System.Windows.Forms.CheckBox checkBoxMultiplayer;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.NumericUpDown numericUpDownNodes;
        private System.Windows.Forms.Label labelNodes;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.RadioButton radioButtonConnect;
        private System.Windows.Forms.RadioButton radioButtonAutoConnect;
        private System.Windows.Forms.CheckBox checkBoxPrivateServer;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.RadioButton radioButtonLocalSearch;
    }
}

