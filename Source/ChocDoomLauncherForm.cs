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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChocolateDoomLauncher
{
    public partial class ChocDoomLauncherForm : Form
    {
        public ChocDoomLauncherForm()
        {
            InitializeComponent();
        }

        private void ChocDoomLauncherForm_Load(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.WADPath;
            InitWADS(System.IO.Directory.GetCurrentDirectory());
            if (!string.IsNullOrEmpty(path))
            {
                InitWADS(path);
            }            
            EnableDemoControls();
            InitDemoControls();
            InitServerControls();

            comboBoxMultiplayerModes.Items.Add(new ListComboIntContent("Join", 0));
            comboBoxMultiplayerModes.Items.Add(new ListComboIntContent("Cooperative", 1));
            comboBoxMultiplayerModes.Items.Add(new ListComboIntContent("Deathmatch", 2));
            comboBoxMultiplayerModes.Items.Add(new ListComboIntContent("Deathmatch 2.0", 3));
            comboBoxMultiplayerModes.SelectedIndex = Game.Multiplayer.Mode;
            comboBoxMultiplayerModes.SelectedIndexChanged += comboBoxMultiplayerModes_SelectedIndexChanged;
        }

        private void InitWADS(string path)
        {
            string[] files = Directory.GetFiles(path, "*.WAD");

            // Determine WAD files
            foreach (string file in files)
            {
                string wad;
                if (Path.GetDirectoryName(file) == System.IO.Directory.GetCurrentDirectory())
                {
                    wad = Path.GetFileName(file);
                }
                else
                {
                    wad = file;
                }

                switch (Path.GetFileName(wad).ToLower())
                {
                    case "doom1.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Doom (Shareware)", wad));
                        break;
                    case "doom.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("The Ultimate Doom", wad));
                        break;
                    case "doom2.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Doom 2: Hell on Earth", wad));
                        break;
                    case "tnt.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Final Doom: TNT Evilution", wad));
                        break;
                    case "plutonia.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Final Doom: The Plutonia Experiment", wad));
                        break;
                    case "heretic1.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Heretic (Shareware)", wad));
                        break;
                    case "heretic.wad":
                        comboBoxIWAD.Items.Add(new ListComboContent("Heretic", wad));
                        break;
                    default:
                        listBoxWADS.Items.Add(new ListComboContent(Path.GetFileNameWithoutExtension(wad), wad));
                        break;
                }
            }

            if (comboBoxIWAD.Items.Count > 0 && comboBoxIWAD.SelectedItem == null)
            {
                comboBoxIWAD.SelectedIndex = 0;
            }
        }

        private void InitSkills()
        {
            comboBoxSkill.SelectedIndexChanged -= new EventHandler(comboBoxSkill_SelectedIndexChanged);
            comboBoxSkill.Items.Clear();
            switch (Path.GetFileNameWithoutExtension(Game.IWAD).ToLower())
            {
                case "heretic1":
                case "heretic":
                    comboBoxSkill.Items.Add(new ListComboIntContent("Thou needeth a wet-nurse", 1));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Yellowbellies-r-us", 2));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Bringest them oneth", 3));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Thou art a smite-meister", 4));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Black plague possesses thee", 5));
                    break;
                default:
                    comboBoxSkill.Items.Add(new ListComboIntContent("I'm too young to die", 1));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Hey, not too rough", 2));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Hurt me plenty", 3));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Ultra-Violence", 4));
                    comboBoxSkill.Items.Add(new ListComboIntContent("Nightmare!", 5));
                    break;
            }
            comboBoxSkill.SelectedIndex = Game.Skill - 1;
            comboBoxSkill.SelectedIndexChanged += new EventHandler(comboBoxSkill_SelectedIndexChanged);
        }

        private void InitLevels()
        {
            comboBoxLevel.Items.Clear();
            if (Game.Episodes != 0)
            {
                for (int e = 1; e <= Game.Episodes; e++)
                {
                    for (int m = 1; m <= Game.Maps; m++)
                    {
                        comboBoxLevel.Items.Add(new ListComboEpisodeContent(string.Format("E{0}M{1}", e, m), e, m));
                    }
                }
            }
            else
            {
                for (int m = 1; m <= Game.Maps; m++)
                {
                    comboBoxLevel.Items.Add(m);
                }
            }
            comboBoxLevel.SelectedIndex = 0;

            if (Game.Skill == 3)
            {
                checkBoxTitleScreen.Enabled = true;
            }
        }

        private void InitCheckBoxTitle()
        {
            if (!Game.Demo.Enabled && !Game.Multiplayer.Enabled && Game.Skill == 3 && Game.Map == 1 && Game.Episode == 1 | Game.Episode == 0)
            {
                checkBoxTitleScreen.Enabled = true;
            }
            else
            {
                checkBoxTitleScreen.Enabled = false;
            }
        }

        private void EnableControls(bool enable)
        {
            labelSkill.Enabled = enable;
            comboBoxSkill.Enabled = enable;
            labelLevel.Enabled = enable;
            comboBoxLevel.Enabled = enable;                   
            groupBoxOptions.Enabled = enable;           
        }

        private void EnableDemoControls()
        {
            if (Game.Demo.Enabled && Game.Multiplayer.Enabled)
            {
                radioButtonPlayDemo.Enabled = false;
            }
            else
            {
                radioButtonPlayDemo.Enabled = Game.Demo.Enabled;
            }

            textBoxDemoPath.Enabled = Game.Demo.Enabled;
            buttonBrowseDemo.Enabled = Game.Demo.Enabled;                       
            radioButtonRecordDemo.Enabled = Game.Demo.Enabled;
        }

        private void InitPlayButtonState()
        {
            if (Game.Demo.Enabled && Game.Demo.Play)
            {
                checkBoxTitleScreen.Enabled = false;
                groupBoxMultiplayer.Enabled = false;
                EnableControls(false);
            }
            else
            {
                InitCheckBoxTitle();
                groupBoxMultiplayer.Enabled = true;
                if (Game.Multiplayer.Enabled && Game.Multiplayer.Mode == 0)
                {
                    EnableControls(false);
                }
                else
                {
                    EnableControls(true);
                }                
            }
        }

        private void InitServerControls()
        {
            if (Game.Multiplayer.Enabled)
            {
                if (Game.Multiplayer.Mode == 0)
                {                    
                    EnableControls(false);
                }
                else
                {                    
                    EnableControls(true);
                }

                if (Game.Multiplayer.Mode > 1)
                {
                    labelTime.Enabled = Game.Multiplayer.Enabled;
                    numericUpDownTime.Enabled = Game.Multiplayer.Enabled;
                }
                else
                {
                    labelTime.Enabled = false;
                    numericUpDownTime.Enabled = false;
                }
                
                labelServerName.Enabled = Game.Multiplayer.Server;
                textBoxServerName.Enabled = Game.Multiplayer.Server;
                checkBoxPrivateServer.Enabled = Game.Multiplayer.Server;
                labelNodes.Enabled = Game.Multiplayer.Server;
                numericUpDownNodes.Enabled = Game.Multiplayer.Server;

                if (!Game.Multiplayer.Server)
                {
                    radioButtonAutoConnect.Enabled = true;
                    radioButtonLocalSearch.Enabled = true;
                    radioButtonConnect.Enabled = true;

                    if (Game.Multiplayer.Connection == 3)
                    {
                        textBoxAddress.Enabled = true;
                    }
                    else
                    {
                        textBoxAddress.Enabled = false;
                    }
                }
                else
                {
                    radioButtonAutoConnect.Enabled = false;
                    radioButtonLocalSearch.Enabled = false;
                    radioButtonConnect.Enabled = false;
                    textBoxAddress.Enabled = false;
                }
            }
            else
            {                
                EnableControls(true);
                labelTime.Enabled = false;
                numericUpDownTime.Enabled = false;
                labelServerName.Enabled = false;
                textBoxServerName.Enabled = false;
                checkBoxPrivateServer.Enabled = false;
                labelNodes.Enabled = false;
                numericUpDownNodes.Enabled = false;
                radioButtonAutoConnect.Enabled = false;
                radioButtonLocalSearch.Enabled = false;
                radioButtonConnect.Enabled = false;
                textBoxAddress.Enabled = false;
            }

            InitDemoControls();
        }        

        private void InitDemoControls()
        {
            if (Game.Demo.Enabled && Game.Multiplayer.Enabled)
            {
                radioButtonPlayDemo.Enabled = false;
            }
            else
            {
                radioButtonPlayDemo.Enabled = Game.Demo.Enabled;
            }

            radioButtonPlayDemo.CheckedChanged -= radioButtonPlayDemo_CheckedChanged;
            if (Game.Demo.Play)
            {
                radioButtonPlayDemo.Checked = true;
            }
            else
            {
                radioButtonRecordDemo.Checked = true;
            }
            radioButtonPlayDemo.CheckedChanged += radioButtonPlayDemo_CheckedChanged;            
        }        

        // Event handlers
        void comboBoxIWAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboContent iwad = (ListComboContent)comboBoxIWAD.SelectedItem;
            Game.IWAD = iwad.Value;
            InitSkills();
            InitLevels();
        }

        void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Game.Epsiodes != 0)
            {
                ListComboEpisodeContent level = (ListComboEpisodeContent)comboBoxLevel.SelectedItem;
                Game.Episode = level.Episode;
                Game.Map = level.Map;
            }
            else
            {
                Game.Map = Convert.ToInt16(comboBoxLevel.SelectedItem);
            }

            InitCheckBoxTitle();
        }

        void comboBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboIntContent skill = (ListComboIntContent)comboBoxSkill.SelectedItem;
            Game.Skill = skill.Value;
            InitCheckBoxTitle();
        }

        void checkBoxTitleScreen_CheckedChanged(object sender, EventArgs e)
        {
            Game.Title = checkBoxTitleScreen.Checked;
            if (Game.Title)
            {
                EnableControls(false);
                groupBoxMultiplayer.Enabled = false;
                groupBoxDemo.Enabled = false;
            }
            else
            {
                EnableControls(true);
                groupBoxMultiplayer.Enabled = true;
                groupBoxDemo.Enabled = true;
            }
        }

        void checkBoxMultiplayer_CheckedChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Enabled = checkBoxMultiplayer.Checked;
            comboBoxMultiplayerModes.Enabled = Game.Multiplayer.Enabled;
            InitCheckBoxTitle();
            InitServerControls();
            InitPlayButtonState();
        }

        void comboBoxMultiplayerModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListComboIntContent mode = (ListComboIntContent)comboBoxMultiplayerModes.SelectedItem;
            Game.Multiplayer.Mode = mode.Value;
            InitServerControls();
        }

        void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Time = Convert.ToInt16(numericUpDownTime.Value);
        }

        void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Name = textBoxServerName.Text;
        }

        void checkBoxPrivateServer_CheckedChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Private = checkBoxPrivateServer.Checked;
        }

        void numericUpDownNodes_ValueChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Nodes = Convert.ToInt16(numericUpDownNodes.Value);
        }

        void radioButtonAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutoConnect.Checked)
            {
                Game.Multiplayer.Connection = 1;
                textBoxAddress.Enabled = false;
            }
        }

        void radioButtonLocalSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLocalSearch.Checked)
            {
                Game.Multiplayer.Connection = 2;
                textBoxAddress.Enabled = false;
            }
        }

        void radioButtonConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConnect.Checked)
            {
                Game.Multiplayer.Connection = 3;
                textBoxAddress.Enabled = true;
            }
        }
            
        void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Address = textBoxAddress.Text;
        }

        void checkBoxTurbo_CheckedChanged(object sender, EventArgs e)
        {
            Game.Turbo = checkBoxTurbo.Checked;
            numericUpDownTurbo.Enabled = Game.Turbo;
        }        

        void checkBoxNoMonsters_ChckedChanged(object sender, EventArgs e)
        {
            Game.NoMonsters = checkBoxNoMonsters.Checked;

            if (Game.NoMonsters)
            {
                checkBoxFastMonsters.Enabled = false;
                checkBoxRespawnMonsters.Enabled = false;
            }
            else
            {
                checkBoxFastMonsters.Enabled = true;
                checkBoxRespawnMonsters.Enabled = true;
            }
        }

        void buttonAddWADS_Clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                InitWADS(folder.SelectedPath);
                Properties.Settings.Default.WADPath = folder.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        void checkBoxFastMonster_CheckedChanged(object sender, EventArgs e)
        {
            Game.FastMonsters = checkBoxFastMonsters.Checked;
        }

        void checkBoxRespawnMonsters_CheckedChanged(object sender, EventArgs e)
        {
            Game.RespawnMonsters = checkBoxRespawnMonsters.Checked;
        }

        void numericUpDownTurbo_ValueChanged(object sender, EventArgs e)
        {
            Game.TurboSpeed = Convert.ToInt16(numericUpDownTurbo.Value);
        }

        void checkBoxDemo_CheckedChanged(object sender, EventArgs e)
        {
            Game.Demo.Enabled = checkBoxDemo.Checked;
            EnableDemoControls();
            InitPlayButtonState();            
        }

        void radioButtonPlayDemo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDemoPath.Text = "";
            if (radioButtonPlayDemo.Checked)
            {                
                Game.Demo.Play = true;
            }
            else
            {
                Game.Demo.Record = true;
            }

            InitPlayButtonState();
        }

        void textBoxDemoPath_TextChanged(object sender, EventArgs e)
        {
            Game.Demo.File = textBoxDemoPath.Text;
        }

        void buttonBrowseDemoFile_Clicked(object sender, EventArgs e)
        {
            if (Game.Demo.Play)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Lump data (*.lmp)|*.lmp";
                file.ShowDialog();

                if (file.FileName != "")
                {
                    textBoxDemoPath.Text = file.FileName;
                }
            }
            else
            {
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "Lump data (*.lmp)|*.*";
                file.ShowDialog();

                if (file.FileName != "")
                {
                    textBoxDemoPath.Text = file.FileName;
                }
            }
        }

        void buttonExit_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        void buttonRun_Clicked(object sender, EventArgs e)
        {
            string[] pwads = new string[listBoxWADS.SelectedItems.Count];
            for (int i = 0; i <= listBoxWADS.SelectedItems.Count - 1; i++)
            {
                ListComboContent pwad = (ListComboContent)listBoxWADS.SelectedItems[i];
                pwads[i] = pwad.Value;
            }
            Game.Run(pwads);
        }

        // Combobox helpers
        private class ListComboContent
        {
            public string Name;
            public string Value;

            public ListComboContent(string name, string value)
            {
                this.Name = name;
                this.Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private class ListComboIntContent
        {
            public string Name;
            public int Value;

            public ListComboIntContent(string name, int x)
            {
                this.Name = name;
                this.Value = x;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private class ListComboEpisodeContent
        {
            public string Name;
            public int Episode;
            public int Map;

            public ListComboEpisodeContent(string name, int e, int m)
            {
                this.Name = name;
                this.Episode = e;
                this.Map = m;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
