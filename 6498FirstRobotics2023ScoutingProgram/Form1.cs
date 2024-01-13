using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;
using static _6498FirstRobotics2023ScoutingProgram.Program;
using static System.Net.WebRequestMethods;

namespace _6498FirstRobotics2023ScoutingProgram
{
    public partial class frmData : Form
    {
#warning all code is untested
#warning form will not clear on submit
        private static readonly string TEMP_STORAGE_FILE_PATH = $"{Application.CommonAppDataPath}\\Local\\Temp";
        readonly string tempPath = $"{TEMP_STORAGE_FILE_PATH}\\2024Scouting\\temp.csv";
        static readonly string backupPath = $"{TEMP_STORAGE_FILE_PATH}\\Local\\Temp\\2024Scouting\\backups";
        List<TextBox> unsavedData = new List<TextBox>();
        bool dataSaved = false;
        Dictionary<string, string> data = new Dictionary<string, string>
        {
            {"Team Number", "" },
            {"Match Number", ""},
            {"DriveType", ""},
            {"AutoMoves", "" },
            {"AutoTaxis", ""},
            {"AutoRingsInAmp", ""},
            {"AutoRingsInSpeaker", ""},
            {"TeleRingsInAmp", ""},
            {"TeleRingsInSpeaker",""},
            {"EndGameClimbed", "" },
            {"EndGameEnsemble", "" },
            {"EndGameScoredInTrap", ""}
        };
        public frmData()
        {
            InitializeComponent();
            FormClosing += frmData_FormClosing;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //puts form in the middle of the screen
            Width = 1400;
            Height = 577;
            CenterToScreen();
            Top -= 100;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }
        private void SaveMatchDataTemp()
        {
            data["Team Number"] = TeamNum.Text;
            data["Match Number"] = null;
            data["DriveType"] = DriveType.SelectedItem.ToString();
            data["AutoMoves"] = AutoMoves.Checked.ToString();
            data["AutoTaxis"] = AutoTaxis.Checked.ToString();
            data["AutoRingsInAmp"] = AutoAmp.Value.ToString();
            data["AutoRingsInSpeaker"] = AutoSpeaker.Value.ToString();
            data["TeleRingsInAmp"] = TeleAmp.Value.ToString();
            data["TeleRingsInSpeaker"] = TeleSpeaker.Value.ToString();
            data["EndGameClimbed"] = EndGameClimbed.Checked.ToString();
            data["EndGameEnsemble"] = EndGameEnsemble.Checked.ToString();
            data["EndGameScoredInTrap"] = EndgameTrap.Value.ToString();
            //writes data to a temporary file in the Global AppData Directory (must have hidden files enabled to see) (also works as a recovery directory)
            if (System.IO.File.Exists(tempPath))
            {
                using (StreamWriter sw = new StreamWriter(tempPath))
                {
                    foreach (string item in data.Values)
                    {
                        sw.Write($"{item},");
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(tempPath))
                {
                    foreach (string Key in data.Keys)
                    {
                        sw.Write($"{Key},");
                    }
                    sw.Write(sw.NewLine);
                    foreach (string item in data.Values)
                    {
                        sw.Write($"{item},");
                    }

                }
            }
        }

        private void frmData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dataSaved)
            {
                DialogResult = MessageBox.Show("Would you like to save your data before closing?");
                if(DialogResult == DialogResult.OK)
                {
                    SaveCSV.ShowDialog();
                }
            }
        }

        private void SaveCSV_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dia = (SaveFileDialog)sender;
            using (StreamReader reader = new StreamReader(tempPath))
            {
                StreamWriter writer = new StreamWriter(Path.GetFullPath(dia.FileName));
                string content  = reader.ReadToEnd(); // all the data stored in the temporary file
                writer.Write(content);
                
                writer.Close();
                string exactbackuppath = $"{backupPath}\\data1.csv";

                //makes sure the backup does not exist and makes a new file if the path does exist
                while(exactbackuppath != checkFileExists(exactbackuppath))
                {
                    exactbackuppath = checkFileExists(exactbackuppath);
                }

                StreamWriter backupWriter = new StreamWriter($"{backupPath}");
                backupWriter.Write(content);
                dataSaved = true;
            }
        }
        private string checkFileExists(string path)
        {
            path = path.Remove(path.Length - 5); // remove the .csv ending
            if (System.IO.File.Exists(path)) 
            { 
              int backupNum = Convert.ToInt32(path.Substring(path.Length - 2)); //get the backup number from the file name
              return path.Remove(path.Length - 2) + backupNum.ToString(); //remove the old number, add one and try again
            }
            else {  return path; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveMatchDataTemp();
        }
    }
}
