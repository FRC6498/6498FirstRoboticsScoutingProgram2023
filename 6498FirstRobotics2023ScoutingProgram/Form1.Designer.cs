namespace _6498FirstRobotics2023ScoutingProgram
{
    partial class frmData
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
            this.ofdOpenCSV = new System.Windows.Forms.OpenFileDialog();
            this.SaveCSV = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeamNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AutoTaxis = new System.Windows.Forms.CheckBox();
            this.AutoMoves = new System.Windows.Forms.CheckBox();
            this.AutoAmp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AutoSpeaker = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TeleAmp = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TeleSpeaker = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.EndGameEnsemble = new System.Windows.Forms.CheckBox();
            this.EndGameClimbed = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.EndgameTrap = new System.Windows.Forms.NumericUpDown();
            this.DriveType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoAmp)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSpeaker)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleAmp)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleSpeaker)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndgameTrap)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveCSV
            // 
            this.SaveCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveCSV_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLocalToolStripMenuItem,
            this.exportToMainToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLocalToolStripMenuItem
            // 
            this.saveLocalToolStripMenuItem.Name = "saveLocalToolStripMenuItem";
            this.saveLocalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveLocalToolStripMenuItem.Text = "Save Local";
            // 
            // exportToMainToolStripMenuItem
            // 
            this.exportToMainToolStripMenuItem.Name = "exportToMainToolStripMenuItem";
            this.exportToMainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToMainToolStripMenuItem.Text = "Export to main";
            // 
            // TeamNum
            // 
            this.TeamNum.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNum.Location = new System.Drawing.Point(556, 36);
            this.TeamNum.MaxLength = 4;
            this.TeamNum.Name = "TeamNum";
            this.TeamNum.Size = new System.Drawing.Size(100, 44);
            this.TeamNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(454, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(822, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(406, 404);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(986, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(86, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Auto";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AutoTaxis);
            this.panel2.Controls.Add(this.AutoMoves);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 109);
            this.panel2.TabIndex = 0;
            // 
            // AutoTaxis
            // 
            this.AutoTaxis.AutoSize = true;
            this.AutoTaxis.Font = new System.Drawing.Font("Arial", 12F);
            this.AutoTaxis.ForeColor = System.Drawing.SystemColors.Window;
            this.AutoTaxis.Location = new System.Drawing.Point(163, 67);
            this.AutoTaxis.Name = "AutoTaxis";
            this.AutoTaxis.Size = new System.Drawing.Size(62, 22);
            this.AutoTaxis.TabIndex = 1;
            this.AutoTaxis.Text = "Taxis";
            this.AutoTaxis.UseVisualStyleBackColor = true;
            // 
            // AutoMoves
            // 
            this.AutoMoves.AutoSize = true;
            this.AutoMoves.Font = new System.Drawing.Font("Arial", 12F);
            this.AutoMoves.ForeColor = System.Drawing.SystemColors.Window;
            this.AutoMoves.Location = new System.Drawing.Point(18, 67);
            this.AutoMoves.Name = "AutoMoves";
            this.AutoMoves.Size = new System.Drawing.Size(73, 22);
            this.AutoMoves.TabIndex = 0;
            this.AutoMoves.Text = "Moves";
            this.AutoMoves.UseVisualStyleBackColor = true;
            // 
            // AutoAmp
            // 
            this.AutoAmp.Font = new System.Drawing.Font("Arial", 24F);
            this.AutoAmp.Location = new System.Drawing.Point(126, 44);
            this.AutoAmp.Name = "AutoAmp";
            this.AutoAmp.ReadOnly = true;
            this.AutoAmp.Size = new System.Drawing.Size(58, 44);
            this.AutoAmp.TabIndex = 2;
            this.AutoAmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rings Scored:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.AutoAmp);
            this.panel4.Location = new System.Drawing.Point(3, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 108);
            this.panel4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(96, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amp";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 97);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 462);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.AutoSpeaker);
            this.panel5.Location = new System.Drawing.Point(3, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 108);
            this.panel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(77, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Speaker";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(14, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Rings Scored:";
            // 
            // AutoSpeaker
            // 
            this.AutoSpeaker.Font = new System.Drawing.Font("Arial", 24F);
            this.AutoSpeaker.Location = new System.Drawing.Point(126, 44);
            this.AutoSpeaker.Name = "AutoSpeaker";
            this.AutoSpeaker.ReadOnly = true;
            this.AutoSpeaker.Size = new System.Drawing.Size(58, 44);
            this.AutoSpeaker.TabIndex = 2;
            this.AutoSpeaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(282, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 462);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 109);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(66, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "TeleOp";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.TeleAmp);
            this.panel3.Location = new System.Drawing.Point(3, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 108);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(96, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(14, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Rings Scored:";
            // 
            // TeleAmp
            // 
            this.TeleAmp.Font = new System.Drawing.Font("Arial", 24F);
            this.TeleAmp.Location = new System.Drawing.Point(126, 44);
            this.TeleAmp.Name = "TeleAmp";
            this.TeleAmp.ReadOnly = true;
            this.TeleAmp.Size = new System.Drawing.Size(58, 44);
            this.TeleAmp.TabIndex = 2;
            this.TeleAmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.TeleSpeaker);
            this.panel6.Location = new System.Drawing.Point(3, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 108);
            this.panel6.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(77, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Speaker";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(14, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Rings Scored:";
            // 
            // TeleSpeaker
            // 
            this.TeleSpeaker.Font = new System.Drawing.Font("Arial", 24F);
            this.TeleSpeaker.Location = new System.Drawing.Point(126, 44);
            this.TeleSpeaker.Name = "TeleSpeaker";
            this.TeleSpeaker.ReadOnly = true;
            this.TeleSpeaker.Size = new System.Drawing.Size(58, 44);
            this.TeleSpeaker.TabIndex = 2;
            this.TeleSpeaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.panel7);
            this.flowLayoutPanel3.Controls.Add(this.panel8);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(552, 97);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(264, 462);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.EndGameEnsemble);
            this.panel7.Controls.Add(this.EndGameClimbed);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 109);
            this.panel7.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(58, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 37);
            this.label13.TabIndex = 4;
            this.label13.Text = "Endgame";
            // 
            // EndGameEnsemble
            // 
            this.EndGameEnsemble.AutoSize = true;
            this.EndGameEnsemble.Font = new System.Drawing.Font("Arial", 12F);
            this.EndGameEnsemble.ForeColor = System.Drawing.SystemColors.Window;
            this.EndGameEnsemble.Location = new System.Drawing.Point(142, 68);
            this.EndGameEnsemble.Name = "EndGameEnsemble";
            this.EndGameEnsemble.Size = new System.Drawing.Size(97, 22);
            this.EndGameEnsemble.TabIndex = 1;
            this.EndGameEnsemble.Text = "Ensemble";
            this.EndGameEnsemble.UseVisualStyleBackColor = true;
            // 
            // EndGameClimbed
            // 
            this.EndGameClimbed.AutoSize = true;
            this.EndGameClimbed.Font = new System.Drawing.Font("Arial", 12F);
            this.EndGameClimbed.ForeColor = System.Drawing.SystemColors.Window;
            this.EndGameClimbed.Location = new System.Drawing.Point(19, 68);
            this.EndGameClimbed.Name = "EndGameClimbed";
            this.EndGameClimbed.Size = new System.Drawing.Size(86, 22);
            this.EndGameClimbed.TabIndex = 0;
            this.EndGameClimbed.Text = "Climbed";
            this.EndGameClimbed.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.EndgameTrap);
            this.panel8.Location = new System.Drawing.Point(3, 118);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(253, 108);
            this.panel8.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(96, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Trap";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(14, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Rings Scored:";
            // 
            // EndgameTrap
            // 
            this.EndgameTrap.Font = new System.Drawing.Font("Arial", 24F);
            this.EndgameTrap.Location = new System.Drawing.Point(126, 44);
            this.EndgameTrap.Name = "EndgameTrap";
            this.EndgameTrap.ReadOnly = true;
            this.EndgameTrap.Size = new System.Drawing.Size(58, 44);
            this.EndgameTrap.TabIndex = 2;
            this.EndgameTrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DriveType
            // 
            this.DriveType.Font = new System.Drawing.Font("Arial", 24F);
            this.DriveType.FormattingEnabled = true;
            this.DriveType.Items.AddRange(new object[] {
            "Swerve",
            "Tank",
            "Mechanum"});
            this.DriveType.Location = new System.Drawing.Point(662, 36);
            this.DriveType.Name = "DriveType";
            this.DriveType.Size = new System.Drawing.Size(171, 44);
            this.DriveType.TabIndex = 9;
            this.DriveType.Text = "Drive Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1326, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1402, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DriveType);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamNum);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmData";
            this.Text = "Scouting Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmData_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoAmp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoSpeaker)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleAmp)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleSpeaker)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndgameTrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdOpenCSV;
        private System.Windows.Forms.SaveFileDialog SaveCSV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToMainToolStripMenuItem;
        private System.Windows.Forms.TextBox TeamNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AutoTaxis;
        private System.Windows.Forms.CheckBox AutoMoves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AutoAmp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown AutoSpeaker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown TeleAmp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown TeleSpeaker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox EndGameEnsemble;
        private System.Windows.Forms.CheckBox EndGameClimbed;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown EndgameTrap;
        private System.Windows.Forms.ComboBox DriveType;
        private System.Windows.Forms.Button button1;
    }
}

