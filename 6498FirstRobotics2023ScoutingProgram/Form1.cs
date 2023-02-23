using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6498FirstRobotics2023ScoutingProgram.Program;
using static System.Net.WebRequestMethods;

namespace _6498FirstRobotics2023ScoutingProgram
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }
        //6498 Scouting Program for
        //2023 FIRST Robotics Compeition Season "Charged Up"
        //Programmed by: Graham Jones

        //list of textboxes used to prevent unsaved data from changing
        List<TextBox> unsavedData = new List<TextBox>();
        bool dataNotSaved = false;
        bool notesOpened = false;

        public string filePath = "";

        public string recoveryFilePath = "";
        // "Team Number,Position,Match Number,Mobility Achieved,Auto High Cones,Auto Mid Cones,Auto Low Cones,
        // Auto High Cubes,Auto Mid Cubes,Auto Low Cubes,Auto Charging Station Position,
        // Tele High Cones,Tele Mid Cones,Tele Low Cones,Tele High Cubes,Tele Mid Cubes,Tele Low Cubes,
        // End Game Charging Station,Link Coordination,Parked,Floor Pickup,Shelf Pickup,Notes";
        //
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>
        {
            {"Team Number", new List<string>() },
            {"Position", new List<string>()},
            {"Match Number", new List<string>()},
            {"Mobility Achieved", new List<string>()},
            {"Auto High Cones", new List<string>() },
            {"Auto Mid Cones", new List<string>()},
            {"Auto Low Cones", new List<string>()},
            {"Auto High Cubes", new List<string>()},
            {"Auto Mid Cubes", new List<string>()},
            {"Auto Low Cubes", new List<string>()},
            {"Auto Charging Station Position", new List<string>() },
            {"Tele High Cones", new List<string>() },
            {"Tele Mid Cones", new List<string>()},
            {"Tele Low Cones", new List<string>()},
            {"Tele High Cubes", new List<string>()},
            {"Tele Mid Cubes", new List<string>()},
            {"Tele Low Cubes", new List<string>()},
            {"End Game Charging Station", new List<string>() },
            {"Link Coordination", new List<string>()},
            {"Parked", new List<string>()},
            {"Floor Pickup", new List<string>()},
            {"Shelf Pickup", new List<string>()},
            {"Notes", new List<string>() }

        };

        //string[] test = new string[5] { "notes", "ata", "testing", "reset", "finalSlot"};

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //puts form in a single spot since the window is undraggable.
            #region Setup of form size
            this.Width = 1400;
            this.Height = 577;
            this.CenterToScreen();
            this.Top -= 100;
            tb_Notes.Height = 110;
            tb_Notes.Width += 15;
            #endregion 

            cmb_Info_Position.SelectedIndex = 0; //only does this in the beginning to prevent resetting alliance position during actual gameplay.
            //sets up the ability of the users to be able to input values
            ResetInputs();
            ButtonDeclaration();
        }

        //Broke out a region for things that only occur on form load
        #region Form Initializations
        /* This is clever and I like it, but I'm setting it to use the names of the textbox controls
         * so it's future proofed if the names ever need to be changed again.  Not necessary,
         * but it's a good practice to be somewhat prepared for change.
        */
        private void ButtonDeclaration()
        {
            //defines all of the corresponding textboxes for each button,
            //allowing for the program to read the tag and pass it through to affect the value of the corresponding textbox.
            #region Positive Buttons
            btn_Auto_ConeHighAdd.Tag = tb_Auto_ConeHigh.Name;
            btn_Auto_ConeMidAdd.Tag = tb_Auto_ConeMid.Name;
            btn_Auto_ConeLowAdd.Tag = tb_Auto_ConeLow.Name;

            btn_Auto_CubeHighAdd.Tag = tb_Auto_CubeHigh.Name;
            btn_Auto_CubeMidAdd.Tag = tb_Auto_CubeMid.Name;
            btn_Auto_CubeLowAdd.Tag = tb_Auto_CubeLow.Name;

            btn_TeleOp_ConeHighAdd.Tag = tb_TeleOp_ConeHigh.Name;
            btn_TeleOp_ConeMidAdd.Tag = tb_TeleOp_ConeMid.Name;
            btn_TeleOp_ConeLowAdd.Tag = tb_TeleOp_ConeLow.Name;

            btn_TeleOp_CubeHighAdd.Tag = tb_TeleOp_CubeHigh.Name;
            btn_TeleOp_CubeMidAdd.Tag = tb_TeleOp_CubeMid.Name;
            btn_TeleOp_CubeLowAdd.Tag = tb_TeleOp_CubeLow.Name;
            #endregion

            //This structure is fine, but if you would like, each textbox control can be onelined cleanly like the below example
            /* 
             *    btn_Auto_ConeHighAdd.Tag = btn_Auto_ConeHighSub.Tag = tb_Auto_ConeHigh.Name;
             * 
             *     as long as they are both the correct buttons for the intended textbox
             */

            //does the same process for the buttons that subtract.
            #region Negative Buttons
            btn_Auto_ConeHighSub.Tag = tb_Auto_ConeHigh.Name;
            btn_Auto_ConeMidSub.Tag = tb_Auto_ConeMid.Name;
            btn_Auto_ConeLowSub.Tag = tb_Auto_ConeLow.Name;

            btn_Auto_CubeHighSub.Tag = tb_Auto_CubeHigh.Name;
            btn_Auto_CubeMidSub.Tag = tb_Auto_CubeMid.Name;
            btn_Auto_CubeLowSub.Tag = tb_Auto_CubeLow.Name;

            btn_TeleOp_ConeHighSub.Tag = tb_TeleOp_ConeHigh.Name;
            btn_TeleOp_ConeMidSub.Tag = tb_TeleOp_ConeMid.Name;
            btn_TeleOp_ConeLowSub.Tag = tb_TeleOp_ConeLow.Name;

            btn_TeleOp_CubeHighSub.Tag = tb_TeleOp_CubeHigh.Name;
            btn_TeleOp_CubeMidSub.Tag = tb_TeleOp_CubeMid.Name;
            btn_TeleOp_CubeLowSub.Tag = tb_TeleOp_CubeLow.Name;
            #endregion

            #region Textbox Addition to the list checking system.
            unsavedData.Add(tb_Auto_ConeHigh);
            unsavedData.Add(tb_Auto_ConeMid);
            unsavedData.Add(tb_Auto_ConeLow);

            unsavedData.Add(tb_Auto_CubeHigh);
            unsavedData.Add(tb_Auto_CubeMid);
            unsavedData.Add(tb_Auto_CubeLow);

            unsavedData.Add(tb_TeleOp_ConeHigh);
            unsavedData.Add(tb_TeleOp_ConeMid);
            unsavedData.Add(tb_TeleOp_ConeLow);

            unsavedData.Add(tb_TeleOp_CubeHigh);
            unsavedData.Add(tb_TeleOp_CubeMid);
            unsavedData.Add(tb_TeleOp_CubeLow);
            #endregion
        }
        private void ResetInputs()
        {
            //resets auto cones
            tb_Auto_ConeHigh.Text = "0";
            tb_Auto_ConeMid.Text = "0";
            tb_Auto_ConeLow.Text = "0";
            //rests auto cubes
            tb_Auto_CubeHigh.Text = "0";
            tb_Auto_CubeMid.Text = "0";
            tb_Auto_CubeLow.Text = "0";
            //resets the tele cones
            tb_TeleOp_ConeHigh.Text = "0";
            tb_TeleOp_ConeMid.Text = "0";
            tb_TeleOp_ConeLow.Text = "0";
            //resets tele cubes
            tb_TeleOp_CubeHigh.Text = "0";
            tb_TeleOp_CubeMid.Text = "0";
            tb_TeleOp_CubeLow.Text = "0";
            //---------------------------------------//
            //resets indentifying info about the robot.
            tb_Info_TeamNumber.Text = null;
            tb_Info_MatchNumber.Text = null;

            //resets checkboxes
            chk_Auto_Community.Checked = false;
            chk_EndGame_Coordination.Checked = false;
            chk_Intake_Shelf.Checked = false;
            chk_Intake_Floor.Checked = false;
            //sets the default value to the [0] item in the list, which is technically the first, as a default.
            cmb_Auto_Station.SelectedIndex = 0;
            cmb_EndGame_Station.SelectedIndex = 0;

            tb_Notes.Text = null;
        }
        #endregion


        //More regions for this too
        #region Increment / decrement buttons
        private void IncrementValue(object sender, int value /*,bool add*/)
        {
            /* In all what's happening here, is we are putting the current value to an int first,
             * then we are changing it.  Basically the same, but hopefully easier to read what is happening
             * and a bit less visual clutter
             * 
             * Also as you can see below, using (newType)variable or "Casting" vs using the "as" keyword both
             * work, so you can figure out which one you want to use here, I personally like "as" since it
             * feels a bit more readable
             */


            //takes the name of the corresponding textbox to the button and passes it into this line of code
            Button button = (Button)sender;
            string buttonTag = button.Tag.ToString();
            //Assigning these their own variables helps with clarity, it looks at the parent of the button to find the control since panels knida mess with looking directly at controls
            TextBox buttonBox = (button.Parent.Controls[buttonTag]) as TextBox;
            int currentValue = int.Parse(buttonBox.Text);
            //Increment 'current value', turn it back to a string, and set it to the textbox
            buttonBox.Text = Math.Max(0, currentValue + value).ToString();



            /* This is a fine way to do it, but since we already have the separate events
             * for pressing a + vs a - button, we can do something a lil bit easier
             */

            /*if (add)
            {
                //what this line does is it takes the corresponding tag on the button (declared in ButtonDeclaration()) and whenever one is clicked
                //it will increase the value by one
                this.Controls[buttonTag].Text = (Convert.ToInt16(this.Controls[buttonTag].Text) + 1).ToString();
            }
            else
            {
                //checks the value of the corresponding textbox to see if it is >0.
                //if yes, the value will drop by one, that way the minimum value in the textbox is "0"
                if (Convert.ToInt16(this.Controls[buttonTag].Text) > 0)
                {
                    this.Controls[buttonTag].Text = (Convert.ToInt16(this.Controls[buttonTag].Text) - 1).ToString();
                }
            }*/
        }


        //Also for both of them, it is perfectly fine to just pass the sender further down
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //takes the button that was clicked and turns it into a passthrough into the next subprogram
            //var button = sender;
            //specifically told to add one to the corresponding button
            IncrementValue(sender, 1);
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            //takes the button that was clicked and turns it into a passthrough into the next subprogram
            //var button = sender;
            //specifically told to add one to the corresponding button
            //subtracts 1 from the value if there is one to subtract.
            IncrementValue(sender, -1);
        }
        #endregion

        //Regions are really nice for keeping things sorted
        #region Misc buttons
        private void btn_ShowNotes_Click(object sender, EventArgs e)
        {
            /* Usually when checking a bool, you don't need to check it against any value.  With that, you
             * also don't need to 'else if', since the only other condition (false) is always going to be
             * caught by an 'else'
             */
            if (!notesOpened)
            {
                this.Height += 125;
                notesOpened = true;
                btn_ShowNotes.Text = "Collapse";
            } else {
                this.Height -= 125;
                notesOpened = false;
                btn_ShowNotes.Text = "Notes";
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //We might want to change this into adding to the dictionary
            RecordDataIntoCSV(data);
            AddValuesToDictionary();
            ResetInputs();
        }

        #region assigns varaibles values from the user into dictionary

        private void AddValuesToDictionary()
        {
            data["Team Number"].Add(tb_Info_TeamNumber.Text);
            data["Position"].Add(cmb_Info_Position.Text);
            data["Match Number"].Add(tb_Info_MatchNumber.Text);

            data["Mobility Achieved"].Add(chk_Auto_Community.Checked.ToString());
            data["Auto High Cones"].Add(tb_Auto_ConeHigh.Text);
            data["Auto Mid Cones"].Add(tb_Auto_ConeMid.Text);
            data["Auto Low Cones"].Add(tb_Auto_ConeLow.Text);
            data["Auto High Cubes"].Add(tb_Auto_CubeHigh.Text);
            data["Auto Mid Cubes"].Add(tb_Auto_CubeMid.Text);
            data["Auto Low Cubes"].Add(tb_Auto_CubeLow.Text);
            data["Auto Charging Station Position"].Add(cmb_Auto_Station.Text);
            data["Tele High Cones"].Add(tb_TeleOp_ConeHigh.Text);
            data["Tele Mid Cones"].Add(tb_TeleOp_ConeMid.Text);
            data["Tele Low Cones"].Add(tb_TeleOp_ConeLow.Text);
            data["Tele High Cubes"].Add(tb_TeleOp_CubeHigh.Text);
            data["Tele Mid Cubes"].Add(tb_TeleOp_CubeMid.Text);
            data["Tele Low Cubes"].Add(tb_TeleOp_CubeLow.Text);
            data["End Game Charging Station"].Add(cmb_EndGame_Station.Text);
            data["Link Coordination"].Add(chk_EndGame_Coordination.Checked.ToString());
            data["Parked"].Add(chk_EndGame_Park.Checked.ToString());
            data["Floor Pickup"].Add(chk_Intake_Floor.Checked.ToString());
            data["Shelf Pickup"].Add(chk_Intake_Shelf.Checked.ToString());
            data["Notes"].Add(tb_Notes.Text);










        }



        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //this button acts as an alt+f4, unless data has been changed.
            //If it has, it will give a popup showing unsaved entries are present.
            dataNotSaved = false;

            #region Detects Unsaved Data
            for (int i = 0; i < unsavedData.Count; i++)
            {
                if (Convert.ToInt16(unsavedData[i].Text) != 0)
                {
                    dataNotSaved = true;
                }
            }

            if (tb_Info_TeamNumber.Text != "" || tb_Info_MatchNumber.Text != "" || tb_Notes.Text != "" || cmb_Auto_Station.SelectedIndex != 0 || cmb_EndGame_Station.SelectedIndex != 0 || chk_Intake_Floor.Checked == true || chk_EndGame_Coordination.Checked == true || chk_Auto_Community.Checked == true || chk_Intake_Shelf.Checked == true)
            {
                dataNotSaved = true;
            }
            #endregion

            if (dataNotSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to discard your currently unsaved data?\nWARNING: It cannot be recovered if you select \"Yes\"", "UNSAVED DATA DETECTED", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }


        }
        #endregion

        //Same thing for the 'intercepts', maybe wrong term but for intercepting 'illegal' keypresses
        #region Keypress Intercepts
        private void tb_Notes_Keypress(object sender, KeyPressEventArgs e)
        {
            //General forbidden characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) e.Handled = true;
            //Specific forbidden characters
            if (e.KeyChar == Convert.ToChar(",") || e.KeyChar == Convert.ToChar("\r") || e.KeyChar == Convert.ToChar("\n")) e.Handled = true;
        }

        private void tb_TeamNumber_Keypress(object sender, KeyPressEventArgs e)
        {
            //stack overflow explains this quite well
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            //prevents non numeric characters from being put into the textbox
            //done to prevent accidental commas that could mess up the .CSV file that is exported.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            sfdSaveCSV.Filter = "csv files (*.csv)|*.csv";
            sfdSaveCSV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdOpenCSV.Filter = "csv files (*.csv)|*.csv";
            ofdOpenCSV.ShowDialog();
            
        }

        private void ofdOpenCSV_FileOk(object sender, CancelEventArgs e)
        {
            filePath = ofdOpenCSV.FileName;
            
        }

        private void sfdSaveCSV_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter writer = null;
            string fileAccess = sfdSaveCSV.FileName;
            writer = new StreamWriter(fileAccess);

            string header = "";

            foreach (KeyValuePair<string, List<string>> i in data)
            {
                header += (i.Key + ",");
            }

            writer.WriteLine(header);

            writer.Close();

            filePath = sfdSaveCSV.FileName;
        }

        private void frmData_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecoveryDataCSV(data);
        }

        //USE IN RECOVERY DIRECTORY SETUP
        //const string FILE_NAME = @"/Coffee_Shop_Info.xml";
        //
        //filePath = Directory.GetCurrentDirectory() + FILE_NAME;

    }
}
