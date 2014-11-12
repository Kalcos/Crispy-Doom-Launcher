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
using System.Collections;
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
    public partial class MainForm : Form
    {
        // Variables
        DataTable wads = new DataTable();
        private string game;
        private string selectedIWAD;

        public MainForm()
        {
            InitializeComponent();
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
                    case "chex.wad":
                        string dehFile = Path.ChangeExtension(wad, ".deh");
                        if (File.Exists(dehFile))
                        {
                            wads.Rows.Add("Chex Quest", wad, true);
                        }
                        break;
                    case "doom1.wad":
                        wads.Rows.Add("Doom (Shareware)", wad, true);
                        break;
                    case "doom.wad":
                        wads.Rows.Add("The Ultimate Doom", wad, true);
                        break;
                    case "doom2.wad":
                        wads.Rows.Add("Doom 2: Hell on Earth", wad, true);
                        break;
                    case "tnt.wad":
                        wads.Rows.Add("Final Doom: TNT Evilution", wad, true);
                        break;
                    case "plutonia.wad":
                        wads.Rows.Add("Final Doom: The Plutonia Experiment", wad, true);
                        break;
                    case "heretic1.wad":
                        wads.Rows.Add("Heretic (Shareware)", wad, true);
                        break;
                    case "heretic.wad":
                        wads.Rows.Add("Heretic: Shadow of the Serpent Riders", wad, true);
                        break;
                    case "hexen.wad":
                        wads.Rows.Add("Hexen: Beyond Heretic", wad, true);
                        break;
                    case "strife1.wad":
                        wads.Rows.Add("Strife", wad, true);
                        break;
                    case "voices.wad":
                    case "zdoom.wad":
                        break;
                    default:
                        wads.Rows.Add(Path.GetFileNameWithoutExtension(wad), wad, false);
                        break;
                }
            }

            // Sort datatable
            DataView dataView = wads.DefaultView;
            dataView.Sort = "File";
            wads = dataView.ToTable();

            if (comboBoxIWAD.SelectedItem != null)
            {
                comboBoxIWAD.SelectedIndexChanged -= comboBoxIWAD_SelectedIndexChanged;
                InitIWADCombobox();
                comboBoxIWAD.SelectedIndexChanged += comboBoxIWAD_SelectedIndexChanged;
            }
            else
            {
                InitIWADCombobox();
            }

            InitWADSListBox();
        }

        private void InitIWADCombobox()
        {
            int i = 0;
            int y = 0;
            DataRow[] iwads = wads.Select("IWAD = true");

            comboBoxIWAD.Items.Clear();
            foreach (DataRow row in iwads)
            {
                comboBoxIWAD.Items.Add(new ListContent(row[0].ToString(), row[1].ToString()));

                if (row[0].ToString() == selectedIWAD)
                {
                    i = y;
                }
                y++;
            }

            if (comboBoxIWAD.Items.Count > 0)
            {
                comboBoxIWAD.SelectedIndex = i;
            }            
        }

        private void InitWADSListBox()
        {
            DataRow[] pwads = wads.Select("IWAD = false");
            listBoxWADS.Items.Clear();

            foreach (DataRow row in pwads)
            {
                listBoxWADS.Items.Add(new ListContent(row[0].ToString(), row[1].ToString()));
            }
        }

        private void InitSkills()
        {
            comboBoxSkill.SelectedIndexChanged -= new EventHandler(comboBoxSkill_SelectedIndexChanged);
            comboBoxSkill.Items.Clear();
            switch (game)
            {
                case "chex":
                    comboBoxSkill.Items.Add(new ListContent("Easy does it", 1));
                    comboBoxSkill.Items.Add(new ListContent("Not so sticky", 2));
                    comboBoxSkill.Items.Add(new ListContent("Gobs of god", 3));
                    comboBoxSkill.Items.Add(new ListContent("Extreme ooze", 4));
                    comboBoxSkill.Items.Add(new ListContent("Super slimey!", 5));
                    break;
                case "heretic1":
                case "heretic":
                    comboBoxSkill.Items.Add(new ListContent("Thou needeth a wet-nurse", 1));
                    comboBoxSkill.Items.Add(new ListContent("Yellowbellies-r-us", 2));
                    comboBoxSkill.Items.Add(new ListContent("Bringest them oneth", 3));
                    comboBoxSkill.Items.Add(new ListContent("Thou art a smite-meister", 4));
                    comboBoxSkill.Items.Add(new ListContent("Black plague possesses thee", 5));
                    break;
                case "hexen":
                    switch (Game.Class)
                    {
                        case 0:
                            comboBoxSkill.Items.Add(new ListContent("squire", 1));
                            comboBoxSkill.Items.Add(new ListContent("knight", 2));
                            comboBoxSkill.Items.Add(new ListContent("warrior", 3));
                            comboBoxSkill.Items.Add(new ListContent("berserker", 4));
                            comboBoxSkill.Items.Add(new ListContent("titan", 5));
                            break;
                        case 1:
                            comboBoxSkill.Items.Add(new ListContent("altar boy", 1));
                            comboBoxSkill.Items.Add(new ListContent("acolyte", 2));
                            comboBoxSkill.Items.Add(new ListContent("priest", 3));
                            comboBoxSkill.Items.Add(new ListContent("cardinal", 4));
                            comboBoxSkill.Items.Add(new ListContent("pope", 5));
                            break;
                        case 2:
                            comboBoxSkill.Items.Add(new ListContent("apprentice", 1));
                            comboBoxSkill.Items.Add(new ListContent("enchanter", 2));
                            comboBoxSkill.Items.Add(new ListContent("sorcerer", 3));
                            comboBoxSkill.Items.Add(new ListContent("warlock", 4));
                            comboBoxSkill.Items.Add(new ListContent("archmage", 5));
                            break;
                    }
                    break;
                case "strife1":
                    comboBoxSkill.Items.Add(new ListContent("Training", 1));
                    comboBoxSkill.Items.Add(new ListContent("Rookie", 2));
                    comboBoxSkill.Items.Add(new ListContent("Veteran", 3));
                    comboBoxSkill.Items.Add(new ListContent("Elite", 4));
                    comboBoxSkill.Items.Add(new ListContent("Bloodbath", 5));
                    break;
                default:
                    comboBoxSkill.Items.Add(new ListContent("I'm too young to die", 1));
                    comboBoxSkill.Items.Add(new ListContent("Hey, not too rough", 2));
                    comboBoxSkill.Items.Add(new ListContent("Hurt me plenty", 3));
                    comboBoxSkill.Items.Add(new ListContent("Ultra-Violence", 4));
                    comboBoxSkill.Items.Add(new ListContent("Nightmare!", 5));
                    break;
            }
            comboBoxSkill.SelectedIndex = Game.Skill - 1;
            comboBoxSkill.SelectedIndexChanged += new EventHandler(comboBoxSkill_SelectedIndexChanged);
        }

        private void InitLevels()
        {
            comboBoxLevel.Items.Clear();

            if (game == "hexen")
            {
                // Hexen player classes
                labelLevel.Text = "Class:";
                comboBoxLevel.Items.Add(new ListContent("fighter", 0));
                comboBoxLevel.Items.Add(new ListContent("cleric", 1));
                comboBoxLevel.Items.Add(new ListContent("mage", 2));
            }
            else
            {
                labelLevel.Text = "Level:";

                if (Game.Episodes != 0)
                {
                    // Episodes and Maps
                    for (int e = 1; e <= Game.Episodes; e++)
                    {
                        for (int m = 1; m <= Game.Maps; m++)
                        {
                            comboBoxLevel.Items.Add(new ListNumTable(string.Format("E{0}M{1}", e, m), e, m));
                        }
                    }
                }
                else
                {
                    // Maps
                    for (int m = 1; m <= Game.Maps; m++)
                    {
                        comboBoxLevel.Items.Add(m);
                    }
                }
            }

            if (game == "strife1")
            {
                // Strife starts at map 2
                comboBoxLevel.SelectedIndex = 1;
            }
            else
            {
                comboBoxLevel.SelectedIndex = 0;
            }            

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            wads.Columns.Add("Name", typeof(string));
            wads.Columns.Add("File", typeof(string));
            wads.Columns.Add("IWAD", typeof(bool));

            string path = Properties.Settings.Default.WADPath;
            selectedIWAD = Properties.Settings.Default.SelectedIWAD;
            InitWADS(System.IO.Directory.GetCurrentDirectory());
            if (!string.IsNullOrEmpty(path))
            {
                InitWADS(path);
            }
            EnableDemoControls();
            InitDemoControls();
            InitServerControls();

            comboBoxMultiplayerModes.Items.Add(new ListContent("Join", 0));
            comboBoxMultiplayerModes.Items.Add(new ListContent("Cooperative", 1));
            comboBoxMultiplayerModes.Items.Add(new ListContent("Deathmatch", 2));
            comboBoxMultiplayerModes.Items.Add(new ListContent("Deathmatch 2.0", 3));
            comboBoxMultiplayerModes.SelectedIndex = Game.Multiplayer.Mode;
            comboBoxMultiplayerModes.SelectedIndexChanged += comboBoxMultiplayerModes_SelectedIndexChanged;
        }

        private void comboBoxIWAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListContent iwad = (ListContent)comboBoxIWAD.SelectedItem;
            Game.IWAD = iwad.Value;
            selectedIWAD = iwad.Name;
            game = Path.GetFileNameWithoutExtension(Game.IWAD).ToLower();
            InitSkills();
            InitLevels();
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (game == "hexen")
            {
                ListContent hexClass = (ListContent)comboBoxLevel.SelectedItem;
                Game.Class = hexClass.Num;
                InitSkills();
            }
            else
            {
                if (Game.Epsiodes != 0)
                {
                    ListNumTable level = (ListNumTable)comboBoxLevel.SelectedItem;
                    Game.Episode = level.X;
                    Game.Map = level.Y;
                }
                else
                {
                    Game.Map = Convert.ToInt16(comboBoxLevel.SelectedItem);
                }

                InitCheckBoxTitle();
            }
        }

        private void comboBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListContent skill = (ListContent)comboBoxSkill.SelectedItem;
            Game.Skill = skill.Num;
            InitCheckBoxTitle();
        }

        private void checkBoxTitleScreen_CheckedChanged(object sender, EventArgs e)
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

        private void checkBoxMultiplayer_CheckedChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Enabled = checkBoxMultiplayer.Checked;
            comboBoxMultiplayerModes.Enabled = Game.Multiplayer.Enabled;
            InitCheckBoxTitle();
            InitServerControls();
            InitPlayButtonState();
        }

        private void comboBoxMultiplayerModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListContent mode = (ListContent)comboBoxMultiplayerModes.SelectedItem;
            Game.Multiplayer.Mode = mode.Num;
            InitServerControls();
        }

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Time = Convert.ToInt16(numericUpDownTime.Value);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Name = textBoxServerName.Text;
        }

        private void checkBoxPrivateServer_CheckedChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Private = checkBoxPrivateServer.Checked;
        }

        private void numericUpDownNodes_ValueChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Nodes = Convert.ToInt16(numericUpDownNodes.Value);
        }

        private void radioButtonAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutoConnect.Checked)
            {
                Game.Multiplayer.Connection = 1;
                textBoxAddress.Enabled = false;
            }
        }

        private void radioButtonLocalSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLocalSearch.Checked)
            {
                Game.Multiplayer.Connection = 2;
                textBoxAddress.Enabled = false;
            }
        }

        private void radioButtonConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConnect.Checked)
            {
                Game.Multiplayer.Connection = 3;
                textBoxAddress.Enabled = true;
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            Game.Multiplayer.Address = textBoxAddress.Text;
        }

        private void checkBoxTurbo_CheckedChanged(object sender, EventArgs e)
        {
            Game.Turbo = checkBoxTurbo.Checked;
            numericUpDownTurbo.Enabled = Game.Turbo;
        }

        private void checkBoxNoMonsters_ChckedChanged(object sender, EventArgs e)
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

        private void buttonAddWADS_Clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                InitWADS(folder.SelectedPath);
                Properties.Settings.Default.WADPath = folder.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBoxFastMonster_CheckedChanged(object sender, EventArgs e)
        {
            Game.FastMonsters = checkBoxFastMonsters.Checked;
        }

        private void checkBoxRespawnMonsters_CheckedChanged(object sender, EventArgs e)
        {
            Game.RespawnMonsters = checkBoxRespawnMonsters.Checked;
        }

        private void numericUpDownTurbo_ValueChanged(object sender, EventArgs e)
        {
            Game.TurboSpeed = Convert.ToInt16(numericUpDownTurbo.Value);
        }

        private void checkBoxDemo_CheckedChanged(object sender, EventArgs e)
        {
            Game.Demo.Enabled = checkBoxDemo.Checked;
            EnableDemoControls();
            InitPlayButtonState();
        }

        private void radioButtonPlayDemo_CheckedChanged(object sender, EventArgs e)
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

        private void textBoxDemoPath_TextChanged(object sender, EventArgs e)
        {
            Game.Demo.File = textBoxDemoPath.Text;
        }

        private void buttonBrowseDemoFile_Clicked(object sender, EventArgs e)
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

        private void buttonExit_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonRun_Clicked(object sender, EventArgs e)
        {
            if (selectedIWAD != Properties.Settings.Default.SelectedIWAD)
            {
                Properties.Settings.Default.SelectedIWAD = selectedIWAD;
                Properties.Settings.Default.Save();
            }

            string[] pwads = new string[listBoxWADS.SelectedItems.Count];
            for (int i = 0; i <= listBoxWADS.SelectedItems.Count - 1; i++)
            {
                ListContent pwad = (ListContent)listBoxWADS.SelectedItems[i];
                pwads[i] = pwad.Value;
            }
            Game.Run(pwads);
        }

        // Combobox helpers
        private class ListLabel
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public override string ToString()
            {
                return name;
            }
        }

        private class ListContent : ListLabel
        {
            private string content;
            private int x;

            public string Value
            {
                get { return content; }
                set { content = value; }
            }

            public int Num
            {
                get { return x; }
                set { x = value; }
            }

            public ListContent(string label, string value)
            {
                this.Name = label;
                content = value;
            }

            public ListContent(string label, int y)
            {
                this.Name = label;
                x = y;
            }
        }

        private class ListNumTable : ListLabel
        {
            private int x;
            private int y;

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public ListNumTable(string label, int a, int b)
            {
                this.Name = label;
                x = a;
                y = b;
            }
        }
    }
}
