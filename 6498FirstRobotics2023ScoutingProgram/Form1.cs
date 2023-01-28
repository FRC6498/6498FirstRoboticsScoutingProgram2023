using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void Form1_Load(object sender, EventArgs e)
        {
            //puts form in a single spot since the window is undraggable.
            #region Setup of form size
            this.Width = 1400;
            this.Height = 577;
            this.CenterToScreen();
            this.Top -= 100;
            txtNotes.Height = 110;
            txtNotes.Width += 15;
            #endregion 

            cmbPosition.SelectedIndex = 0; //only does this in the beginning to prevent resetting alliance position during actual gameplay.
            //sets up the ability of the users to be able to input values
            ResetInputs();
            ButtonDeclaration();
        }


        private void button24_Click(object sender, EventArgs e)
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

            if (txtTeamNumber.Text != "" || txtMatchNumber.Text != "" || cmbAutoCharge.SelectedIndex != 0 || cmbEndGameChargingStation.SelectedIndex != 0 || chkFloor.Checked == true || chkLink.Checked == true || chkMobility.Checked == true || chkShelf.Checked == true)
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

        private void ResetInputs()
        {
            //resets auto cones
            txtAutoHighCones.Text = "0";
            txtAutoMidCones.Text = "0";
            txtAutoLowCones.Text = "0";
            //rests auto cubes
            txtAutoHighCubes.Text = "0";
            txtAutoMidCubes.Text = "0";
            txtAutoLowCubes.Text = "0";
            //resets the tele cones
            txtTeleHighCones.Text = "0";
            txtTeleMidCones.Text = "0";
            txtTeleLowCones.Text = "0";
            //resets tele cubes
            txtTeleHighCubes.Text = "0";
            txtTeleMidCubes.Text = "0";
            txtTeleLowCubes.Text = "0";
            //-------------------------------------------------------------------------
            //resets indentifying info about the robot.
            txtTeamNumber.Text = null;
            txtMatchNumber.Text = null;
            //resets checkboxes
            chkMobility.Checked = false;
            chkLink.Checked = false;
            chkShelf.Checked = false;
            chkFloor.Checked = false;
            //sets the default value to the [0] item in the list, which is technically the first, as a default.
            cmbAutoCharge.SelectedIndex = 0;
            cmbEndGameChargingStation.SelectedIndex = 0;


        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void IncreaseValue(object sender, bool add)
        {
            //takes the name of the corresponding textbox to the button and passes it into this line of code
            Button y = (Button)sender;
            string x = y.Tag.ToString();

            if (add == true)
            {
                //what this line does is it takes the corresponding tag on the button (declared in ButtonDeclaration()) and whenever one is clicked
                //it will increase the value by one
                this.Controls[x].Text = (Convert.ToInt16(this.Controls[x].Text) + 1).ToString();
            }
            else
            {
                //checks the value of the corresponding textbox to see if it is >0.
                //if yes, the value will drop by one, that way the minimum value in the textbox is "0"
                if (Convert.ToInt16(this.Controls[x].Text) > 0)
                {
                    this.Controls[x].Text = (Convert.ToInt16(this.Controls[x].Text) - 1).ToString();
                }
            }
        }

        private void ButtonDeclaration()
        {
            //defines all of the corresponding textboxes for each button,
            //allowing for the program to read the tag and pass it through to affect the value of the corresponding textbox.
            #region Positive Buttons
            btnAddHighAutoCone.Tag = "txtAutoHighCones";
            btnAddMidAutoCone.Tag = "txtAutoMidCones";
            btnAddLowAutoCone.Tag = "txtAutoLowCones";

            btnAddHighAutoCube.Tag = "txtAutoHighCubes";
            btnAddMidAutoCube.Tag = "txtAutoMidCubes";
            btnAddLowAutoCube.Tag = "txtAutoLowCubes";

            btnAddHighTeleCone.Tag = "txtTeleHighCones";
            btnAddMidTeleCone.Tag = "txtTeleMidCones";
            btnAddLowTeleCone.Tag = "txtTeleLowCones";

            btnAddHighTeleCube.Tag = "txtTeleHighCubes";
            btnAddMidTeleCube.Tag = "txtTeleMidCubes";
            btnAddLowTeleCube.Tag = "txtTeleLowCubes";
            #endregion
            //does the same process for the buttons that subtract.
            #region Negative Buttons
            btnSubtractHighAutoCone.Tag = "txtAutoHighCones";
            btnSubtractMidAutoCone.Tag = "txtAutoMidCones";
            btnSubtractLowAutoCone.Tag = "txtAutoLowCones";

            btnSubtractHighAutoCube.Tag = "txtAutoHighCubes";
            btnSubtractMidAutoCube.Tag = "txtAutoMidCubes";
            btnSubtractLowAutoCube.Tag = "txtAutoLowCubes";

            btnSubtractHighTeleCone.Tag = "txtTeleHighCones";
            btnSubtractMidTeleCone.Tag = "txtTeleMidCones";
            btnSubtractLowTeleCone.Tag = "txtTeleLowCones";

            btnSubtractHighTeleCube.Tag = "txtTeleHighCubes";
            btnSubtractMidTeleCube.Tag = "txtTeleMidCubes";
            btnSubtractLowTeleCube.Tag = "txtTeleLowCubes";
            #endregion

            #region Textbox Addition to the list checking system.
            unsavedData.Add(txtAutoHighCones);
            unsavedData.Add(txtAutoMidCones);
            unsavedData.Add(txtAutoLowCones);

            unsavedData.Add(txtAutoHighCubes);
            unsavedData.Add(txtAutoMidCubes);
            unsavedData.Add(txtAutoLowCubes);

            unsavedData.Add(txtTeleHighCones);
            unsavedData.Add(txtTeleMidCones);
            unsavedData.Add(txtTeleLowCones);

            unsavedData.Add(txtTeleHighCubes);
            unsavedData.Add(txtTeleMidCubes);
            unsavedData.Add(txtTeleLowCubes);
            #endregion
        }

        private void btnAddHighAutoCone_Click(object sender, EventArgs e)
        {
            //takes the button that was clicked and turns it into a passthrough into the next subprogram
            var button = sender;
            //specifically told to add one to the corresponding button
            IncreaseValue(button, true);
        }

        private void btnSubtractHighAutoCone_Click(object sender, EventArgs e)
        {
            //takes the button that was clicked and turns it into a passthrough into the next subprogram
            var button = sender;
            //specifically told to add one to the corresponding button
            //subtracts 1 from the value if there is one to subtract.
            IncreaseValue(button, false);
        }

        private void txtTeamNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //stack overflow explains this quite well
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            //prevents non numeric characters from being put into the textbox
            //done to prevent accidental commas that could mess up the .CSV file that is exported.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (notesOpened == false)
            {
                this.Height += 125;
                notesOpened = true;
                btnNotes.Text = "Collapse";
            } else if (notesOpened == true) {
                this.Height -= 125;
                notesOpened = false;
                btnNotes.Text = "Notes";
            }
        }

        private void txtNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(","))
            {
                e.Handled = true;
            }
        }
    }
}
