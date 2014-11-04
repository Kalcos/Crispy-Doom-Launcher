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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChocolateDoomLauncher
{
    class Game
    {
        private static int connectioMethod = 3;
        private static int episode;
        private static int episodes;
        private static int map;
        private static int maps;
        private static int skill = 3;
        private static int turboSpeed;
        private static int demoMode = 1;
        private static int multiplayerMode = 0;
        private static int nodes = 0;
        private static int time = 0;
        private static bool demo = false;
        private static bool autoJoin = false;
        private static bool multiplayer = false;      
        private static bool titleScreen = false;
        private static bool turbo = false;
        private static bool noMonsters = false;
        private static bool fastMonsters;
        private static bool respawnMonsters;
        private static bool server = false;
        private static bool privateServer;
        private static string address;
        private static string demoFile;
        private static string bin;
        private static string iwad;
        private static string serverName;       

        public static bool NoMonsters
        {
            get { return noMonsters; }
            set { noMonsters = value; }            
        }

        public static bool FastMonsters
        {
            get { return fastMonsters; }            
            set { fastMonsters = value; }
        }

        public static bool RespawnMonsters
        {
            get { return respawnMonsters; }
            set { respawnMonsters = value; }
        }

        public static int Episode
        {
            get { return episode; }
            set { episode = value; }
        }

        public static int Episodes
        {
            get { return episodes; }
        }

        public static bool Turbo
        {
            get { return turbo; }
            set { turbo = value; }
        }

        public static bool Title
        {
            get { return titleScreen; }
            set { titleScreen = value; }
        }

        public static int Epsiodes
        {
            get { return episodes; }
        }

        public static int Map
        {
            get { return map; }
            set { map = value; }
        }

        public static int Maps
        {
            get { return maps; }
        }

        public static int Skill
        {
            get { return skill; }
            set { skill = value; }
        }

        public static int TurboSpeed
        {
            get { return turboSpeed; }
            set { turboSpeed = value; }
        }        

        public static string IWAD
        {
            get { return iwad; }
            set
            {
                iwad = value;

                switch (Path.GetFileName(iwad).ToLower())
                {
                    case "chex.wad":
                        episodes = 1;
                        maps = 5;
                        bin = "chocolate-doom.exe";
                        break;
                    case "doom1.wad":
                        episodes = 1;                        
                        maps = 9;
                        bin = "chocolate-doom.exe";                       
                        break;
                    case "doom.wad":
                        episodes = 4;                        
                        maps = 9;
                        bin = "chocolate-doom.exe";                       
                        break;                 
                    case "heretic1.wad":
                        episodes = 1;
                        maps = 9;
                        bin = "chocolate-heretic.exe"; 
                        break;
                    case "heretic.wad":
                        episodes = 5;
                        maps = 9;
                        bin = "chocolate-heretic.exe";
                        break;
                    default:
                        episodes = 0;                        
                        maps = 32;
                        bin = "chocolate-doom.exe";
                        break;
                }
            }
        }
        
        public static void Run(string[] pwads)
        {
            ArrayList doomArgs = new ArrayList();

            // Setup IWADs and PWADs
            doomArgs.Add(string.Format("-iwad {0}", iwad));            
            if (pwads.Length > 0)
            {
                doomArgs.Add(string.Format("-file {0}", string.Join(" ", pwads)));

                // Detect and use Dehacked files based on given PWAD filenames
                ArrayList dehFiles = new ArrayList();
                foreach (string wad in pwads)
                {
                    string file = Path.ChangeExtension(wad, ".deh");
                    if (File.Exists(file))
                    {
                        dehFiles.Add(file);
                    }
                }

                if (dehFiles.Count > 0)
                {
                    doomArgs.Add(string.Format("-deh {0}", string.Join(" ", dehFiles.ToArray())));
                }
            }

            // Level and skill args
            if (!titleScreen)
            {
                if (episodes != 0)
                {
                    doomArgs.Add(string.Format("-warp {0} {1}", episode, map));
                }
                else
                {
                    doomArgs.Add(string.Format("-warp {0}", map));
                }
                doomArgs.Add(string.Format("-skill {0}", skill));
            }

            // Multiplayer args
            if (multiplayer)
            {
                if (server)
                {
                    doomArgs.Add("-server");

                    if(!string.IsNullOrEmpty(serverName))
                    {
                        doomArgs.Add(string.Format("-servername {0}", serverName));
                    }

                    if (privateServer)
                    {
                        doomArgs.Add("-privateserver");
                    }

                    switch (multiplayerMode)
                    {
                        case 2:
                            doomArgs.Add("-deathmatch");
                            break;
                        case 3:
                            doomArgs.Add("-altdeath");
                            break;
                        default:
                            break;
                    }

                    if (time > 0 && multiplayerMode > 0)
                    {
                        doomArgs.Add(string.Format("-timer {0}", time));
                    }

                    if (nodes > 0)
                    {
                        doomArgs.Add(string.Format("-nodes {0}", nodes));
                    }
                }
                else
                {
                    switch (connectioMethod)
                    {
                        case 1:
                            doomArgs.Add("-autojoin");
                            break;
                        case 2:
                            doomArgs.Add("-localsearch");
                            break;
                        case 3:
                            doomArgs.Add(string.Format("-connect {0}", address));
                            break;
                    }
                }
            }
                        
            if (demo)
            {
                // Demo args
                if (demoMode == 1)
                {
                    doomArgs.Add(string.Format("-playdemo {0}", demoFile));
                }
                else if (demoMode == 2)
                {
                    doomArgs.Add(string.Format("-record {0}", demoFile));
                }
            }
            else
            {
                // Monster args
                if (noMonsters)
                {
                    doomArgs.Add("-nomonsters");
                }
                else
                {
                    if (fastMonsters)
                    {
                        doomArgs.Add("-fast");
                    }
                    if (respawnMonsters)
                    {
                        doomArgs.Add("-respawn");
                    }
                }

                // Turbo args
                if (turbo)
                {
                    doomArgs.Add(string.Format("-turbo {0}", turboSpeed));
                }
            }           
            
            // Run process
            try
            {
                string args = string.Join(" ", doomArgs.ToArray());
                Process Doom = new Process();
                Doom.StartInfo.FileName = bin;
                Doom.StartInfo.Arguments = args;
                Doom.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to run Chocolate Doom.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            
            System.Environment.Exit(0);            
        }

        public class Multiplayer
        {
            public static bool AutoJoin
            {
                get { return autoJoin; }
                set { autoJoin = value; }
            }

            public static bool Enabled
            {
                get { return multiplayer; }
                set
                {
                    multiplayer = value;

                    if (multiplayer)
                    {
                        demoMode = 2;
                    }
                    else
                    {
                        demoMode = 1;
                    }
                }
            }
            
            public static bool Server
            {
                get { return server; }
                set { server = value; }
            }

            public static bool Private
            {
                get { return privateServer; }
                set { privateServer = value; }
            }

            public static int Mode
            {
                get { return multiplayerMode; }
                set
                {
                    multiplayerMode = value;

                    if (multiplayerMode > 0)
                    {
                        server = true;
                    }
                    else
                    {
                        server = false;
                    }
                }
            }

            public static int Connection
            {
                get { return connectioMethod; }
                set { connectioMethod = value; }
            }

            public static int Nodes
            {
                get { return nodes; }
                set { nodes = value; }
            }

            public static int Time
            {
                get { return time; }
                set { time = value; }
            }

            public static string Address
            {
                get { return address; }
                set { address = value; }
            }

            public static string Name
            {
                get { return serverName; }
                set { serverName = value; }
            }
        }

        public class Demo
        {
            public static bool Enabled
            {
                get { return demo; }
                set { demo = value; }
            }

            public static bool Play
            {
                get
                {
                    if (demoMode == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                set
                {
                    if (value == true)
                    {
                        demoMode = 1;
                    }
                    else
                    {
                        demoMode = 2;
                    }
                }
            }

            public static bool Record
            {
                get
                {
                    if (demoMode == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                set
                {
                    if (value == true)
                    {
                        demoMode = 2;
                    }
                    else
                    {
                        demoMode = 1;
                    }
                }
            }

            public static string File
            {
                get { return demoFile; }
                set { demoFile = value; }
            }
        }
    }
}
