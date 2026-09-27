namespace _04_Project_Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSTART = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbXorO = new System.Windows.Forms.GroupBox();
            this.rbXInTheFirst = new System.Windows.Forms.RadioButton();
            this.rbOInTheFirst = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbO2 = new System.Windows.Forms.RadioButton();
            this.rbX2 = new System.Windows.Forms.RadioButton();
            this.labPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbO1 = new System.Windows.Forms.RadioButton();
            this.rbX1 = new System.Windows.Forms.RadioButton();
            this.labPlyaer1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labScorePlayer1 = new System.Windows.Forms.Label();
            this.labScorePlayer2 = new System.Windows.Forms.Label();
            this.labWin = new System.Windows.Forms.Label();
            this.labLoss = new System.Windows.Forms.Label();
            this.labDraw = new System.Windows.Forms.Label();
            this.txtWinPlayer1 = new System.Windows.Forms.TextBox();
            this.txtWinPlayer2 = new System.Windows.Forms.TextBox();
            this.txtLossPlayer1 = new System.Windows.Forms.TextBox();
            this.txtLossPlayer2 = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.labTurn = new System.Windows.Forms.Label();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.gbXorO.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Enabled = false;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(405, 145);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(190, 190);
            this.btn1.TabIndex = 1;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.Transparent;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(605, 145);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(190, 190);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Enabled = false;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.Transparent;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(805, 145);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(190, 190);
            this.btn3.TabIndex = 3;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Enabled = false;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.Transparent;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(405, 345);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(190, 190);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Enabled = false;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.Color.Transparent;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(605, 345);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(190, 190);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Enabled = false;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.Color.Transparent;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(805, 345);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(190, 190);
            this.btn6.TabIndex = 6;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Enabled = false;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.Color.Transparent;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(405, 545);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(190, 190);
            this.btn7.TabIndex = 7;
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Enabled = false;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.Color.Transparent;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(605, 545);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(190, 190);
            this.btn8.TabIndex = 8;
            this.btn8.Tag = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Enabled = false;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.Color.Transparent;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(805, 545);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(190, 190);
            this.btn9.TabIndex = 9;
            this.btn9.Tag = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.GameForTowPlayer);
            // 
            // btnSTART
            // 
            this.btnSTART.BackColor = System.Drawing.Color.Gold;
            this.btnSTART.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSTART.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSTART.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSTART.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSTART.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTART.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.ForeColor = System.Drawing.Color.Black;
            this.btnSTART.Location = new System.Drawing.Point(414, 801);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(267, 79);
            this.btnSTART.TabIndex = 10;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.Visible = false;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Gold;
            this.btnRESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRESET.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRESET.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRESET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnRESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRESET.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.ForeColor = System.Drawing.Color.Black;
            this.btnRESET.Location = new System.Drawing.Point(728, 801);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(267, 79);
            this.btnRESET.TabIndex = 11;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Visible = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 126);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 985);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Created by Eng. Adnan B. Zaerbani";
            // 
            // gbXorO
            // 
            this.gbXorO.BackColor = System.Drawing.Color.Gold;
            this.gbXorO.Controls.Add(this.rbXInTheFirst);
            this.gbXorO.Controls.Add(this.rbOInTheFirst);
            this.gbXorO.Font = new System.Drawing.Font("Pristina", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXorO.Location = new System.Drawing.Point(1192, 235);
            this.gbXorO.Name = "gbXorO";
            this.gbXorO.Size = new System.Drawing.Size(440, 100);
            this.gbXorO.TabIndex = 14;
            this.gbXorO.TabStop = false;
            this.gbXorO.Text = "X or O at The Beginning";
            // 
            // rbXInTheFirst
            // 
            this.rbXInTheFirst.AutoSize = true;
            this.rbXInTheFirst.BackColor = System.Drawing.Color.Gold;
            this.rbXInTheFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXInTheFirst.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbXInTheFirst.Location = new System.Drawing.Point(236, 45);
            this.rbXInTheFirst.Name = "rbXInTheFirst";
            this.rbXInTheFirst.Size = new System.Drawing.Size(174, 39);
            this.rbXInTheFirst.TabIndex = 17;
            this.rbXInTheFirst.TabStop = true;
            this.rbXInTheFirst.Text = "X in The First";
            this.rbXInTheFirst.UseVisualStyleBackColor = false;
            this.rbXInTheFirst.CheckedChanged += new System.EventHandler(this.rbXInTheFirst_CheckedChanged_1);
            // 
            // rbOInTheFirst
            // 
            this.rbOInTheFirst.AutoSize = true;
            this.rbOInTheFirst.BackColor = System.Drawing.Color.Gold;
            this.rbOInTheFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOInTheFirst.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOInTheFirst.Location = new System.Drawing.Point(27, 45);
            this.rbOInTheFirst.Name = "rbOInTheFirst";
            this.rbOInTheFirst.Size = new System.Drawing.Size(172, 39);
            this.rbOInTheFirst.TabIndex = 16;
            this.rbOInTheFirst.TabStop = true;
            this.rbOInTheFirst.Text = "O in The First";
            this.rbOInTheFirst.UseVisualStyleBackColor = false;
            this.rbOInTheFirst.CheckedChanged += new System.EventHandler(this.rbOInTheFirst_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(1265, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 63);
            this.label3.TabIndex = 15;
            this.label3.Text = "Game Settings";
            // 
            // gbSettings
            // 
            this.gbSettings.BackColor = System.Drawing.Color.Gold;
            this.gbSettings.Controls.Add(this.groupBox2);
            this.gbSettings.Controls.Add(this.groupBox1);
            this.gbSettings.Font = new System.Drawing.Font("Pristina", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettings.Location = new System.Drawing.Point(1192, 385);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(440, 495);
            this.gbSettings.TabIndex = 18;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Chossing Names [Optional]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbO2);
            this.groupBox2.Controls.Add(this.rbX2);
            this.groupBox2.Controls.Add(this.labPlayer2);
            this.groupBox2.Controls.Add(this.txtPlayer2);
            this.groupBox2.Location = new System.Drawing.Point(27, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2 Settings";
            // 
            // rbO2
            // 
            this.rbO2.AutoSize = true;
            this.rbO2.BackColor = System.Drawing.Color.Gold;
            this.rbO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbO2.Enabled = false;
            this.rbO2.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbO2.ForeColor = System.Drawing.Color.IndianRed;
            this.rbO2.Location = new System.Drawing.Point(255, 119);
            this.rbO2.Name = "rbO2";
            this.rbO2.Size = new System.Drawing.Size(56, 39);
            this.rbO2.TabIndex = 18;
            this.rbO2.TabStop = true;
            this.rbO2.Text = "O ";
            this.rbO2.UseVisualStyleBackColor = false;
            this.rbO2.CheckedChanged += new System.EventHandler(this.rbO2_CheckedChanged);
            // 
            // rbX2
            // 
            this.rbX2.AutoSize = true;
            this.rbX2.BackColor = System.Drawing.Color.Gold;
            this.rbX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbX2.Enabled = false;
            this.rbX2.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbX2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbX2.Location = new System.Drawing.Point(127, 119);
            this.rbX2.Name = "rbX2";
            this.rbX2.Size = new System.Drawing.Size(52, 39);
            this.rbX2.TabIndex = 17;
            this.rbX2.TabStop = true;
            this.rbX2.Text = "X";
            this.rbX2.UseVisualStyleBackColor = false;
            this.rbX2.CheckedChanged += new System.EventHandler(this.rbX2_CheckedChanged);
            // 
            // labPlayer2
            // 
            this.labPlayer2.AutoSize = true;
            this.labPlayer2.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayer2.Location = new System.Drawing.Point(6, 60);
            this.labPlayer2.Name = "labPlayer2";
            this.labPlayer2.Size = new System.Drawing.Size(120, 39);
            this.labPlayer2.TabIndex = 0;
            this.labPlayer2.Text = "Player 2 :";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.Gold;
            this.txtPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayer2.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPlayer2.Location = new System.Drawing.Point(127, 56);
            this.txtPlayer2.MaxLength = 15;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(240, 46);
            this.txtPlayer2.TabIndex = 2;
            this.txtPlayer2.Text = "Name Of Player 2";
            this.txtPlayer2.TextChanged += new System.EventHandler(this.txtPlayer2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbO1);
            this.groupBox1.Controls.Add(this.rbX1);
            this.groupBox1.Controls.Add(this.labPlyaer1);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.Location = new System.Drawing.Point(27, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1 Settings";
            // 
            // rbO1
            // 
            this.rbO1.AutoSize = true;
            this.rbO1.BackColor = System.Drawing.Color.Gold;
            this.rbO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbO1.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbO1.ForeColor = System.Drawing.Color.IndianRed;
            this.rbO1.Location = new System.Drawing.Point(255, 119);
            this.rbO1.Name = "rbO1";
            this.rbO1.Size = new System.Drawing.Size(56, 39);
            this.rbO1.TabIndex = 18;
            this.rbO1.TabStop = true;
            this.rbO1.Text = "O ";
            this.rbO1.UseVisualStyleBackColor = false;
            this.rbO1.CheckedChanged += new System.EventHandler(this.rbO1_CheckedChanged);
            // 
            // rbX1
            // 
            this.rbX1.AutoSize = true;
            this.rbX1.BackColor = System.Drawing.Color.Gold;
            this.rbX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbX1.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbX1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbX1.Location = new System.Drawing.Point(127, 119);
            this.rbX1.Name = "rbX1";
            this.rbX1.Size = new System.Drawing.Size(52, 39);
            this.rbX1.TabIndex = 17;
            this.rbX1.TabStop = true;
            this.rbX1.Text = "X";
            this.rbX1.UseVisualStyleBackColor = false;
            this.rbX1.CheckedChanged += new System.EventHandler(this.rbX1_CheckedChanged);
            // 
            // labPlyaer1
            // 
            this.labPlyaer1.AutoSize = true;
            this.labPlyaer1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlyaer1.Location = new System.Drawing.Point(6, 55);
            this.labPlyaer1.Name = "labPlyaer1";
            this.labPlyaer1.Size = new System.Drawing.Size(115, 39);
            this.labPlyaer1.TabIndex = 0;
            this.labPlyaer1.Text = "Player 1 :";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Gold;
            this.txtPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayer1.Enabled = false;
            this.txtPlayer1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPlayer1.Location = new System.Drawing.Point(127, 51);
            this.txtPlayer1.MaxLength = 15;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(240, 46);
            this.txtPlayer1.TabIndex = 2;
            this.txtPlayer1.Text = "Name Of Player 1";
            this.txtPlayer1.TextChanged += new System.EventHandler(this.txtPlayer1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(90, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 63);
            this.label4.TabIndex = 19;
            this.label4.Text = "SCORE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 234);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labScorePlayer1
            // 
            this.labScorePlayer1.AutoSize = true;
            this.labScorePlayer1.BackColor = System.Drawing.Color.Gold;
            this.labScorePlayer1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScorePlayer1.Location = new System.Drawing.Point(94, 235);
            this.labScorePlayer1.Name = "labScorePlayer1";
            this.labScorePlayer1.Size = new System.Drawing.Size(108, 39);
            this.labScorePlayer1.TabIndex = 19;
            this.labScorePlayer1.Text = "Player 1 ";
            // 
            // labScorePlayer2
            // 
            this.labScorePlayer2.AutoSize = true;
            this.labScorePlayer2.BackColor = System.Drawing.Color.Gold;
            this.labScorePlayer2.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScorePlayer2.Location = new System.Drawing.Point(215, 235);
            this.labScorePlayer2.Name = "labScorePlayer2";
            this.labScorePlayer2.Size = new System.Drawing.Size(107, 39);
            this.labScorePlayer2.TabIndex = 21;
            this.labScorePlayer2.Text = "Player 2";
            // 
            // labWin
            // 
            this.labWin.AutoSize = true;
            this.labWin.BackColor = System.Drawing.Color.Gold;
            this.labWin.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWin.Location = new System.Drawing.Point(13, 296);
            this.labWin.Name = "labWin";
            this.labWin.Size = new System.Drawing.Size(79, 39);
            this.labWin.TabIndex = 22;
            this.labWin.Text = "Win :";
            // 
            // labLoss
            // 
            this.labLoss.AutoSize = true;
            this.labLoss.BackColor = System.Drawing.Color.Gold;
            this.labLoss.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoss.Location = new System.Drawing.Point(13, 335);
            this.labLoss.Name = "labLoss";
            this.labLoss.Size = new System.Drawing.Size(72, 39);
            this.labLoss.TabIndex = 23;
            this.labLoss.Text = "Loss :";
            // 
            // labDraw
            // 
            this.labDraw.AutoSize = true;
            this.labDraw.BackColor = System.Drawing.Color.Gold;
            this.labDraw.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDraw.Location = new System.Drawing.Point(13, 374);
            this.labDraw.Name = "labDraw";
            this.labDraw.Size = new System.Drawing.Size(89, 39);
            this.labDraw.TabIndex = 24;
            this.labDraw.Text = "Draw :";
            // 
            // txtWinPlayer1
            // 
            this.txtWinPlayer1.BackColor = System.Drawing.Color.Gold;
            this.txtWinPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWinPlayer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtWinPlayer1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPlayer1.ForeColor = System.Drawing.Color.Green;
            this.txtWinPlayer1.Location = new System.Drawing.Point(117, 289);
            this.txtWinPlayer1.MaxLength = 15;
            this.txtWinPlayer1.Name = "txtWinPlayer1";
            this.txtWinPlayer1.ReadOnly = true;
            this.txtWinPlayer1.Size = new System.Drawing.Size(54, 39);
            this.txtWinPlayer1.TabIndex = 19;
            this.txtWinPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWinPlayer2
            // 
            this.txtWinPlayer2.BackColor = System.Drawing.Color.Gold;
            this.txtWinPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWinPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtWinPlayer2.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPlayer2.ForeColor = System.Drawing.Color.Green;
            this.txtWinPlayer2.Location = new System.Drawing.Point(238, 289);
            this.txtWinPlayer2.MaxLength = 15;
            this.txtWinPlayer2.Name = "txtWinPlayer2";
            this.txtWinPlayer2.ReadOnly = true;
            this.txtWinPlayer2.Size = new System.Drawing.Size(54, 39);
            this.txtWinPlayer2.TabIndex = 25;
            this.txtWinPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLossPlayer1
            // 
            this.txtLossPlayer1.BackColor = System.Drawing.Color.Gold;
            this.txtLossPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLossPlayer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLossPlayer1.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLossPlayer1.ForeColor = System.Drawing.Color.DarkRed;
            this.txtLossPlayer1.Location = new System.Drawing.Point(117, 335);
            this.txtLossPlayer1.MaxLength = 15;
            this.txtLossPlayer1.Name = "txtLossPlayer1";
            this.txtLossPlayer1.ReadOnly = true;
            this.txtLossPlayer1.Size = new System.Drawing.Size(54, 39);
            this.txtLossPlayer1.TabIndex = 26;
            this.txtLossPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLossPlayer2
            // 
            this.txtLossPlayer2.BackColor = System.Drawing.Color.Gold;
            this.txtLossPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLossPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLossPlayer2.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLossPlayer2.ForeColor = System.Drawing.Color.DarkRed;
            this.txtLossPlayer2.Location = new System.Drawing.Point(238, 335);
            this.txtLossPlayer2.MaxLength = 15;
            this.txtLossPlayer2.Name = "txtLossPlayer2";
            this.txtLossPlayer2.ReadOnly = true;
            this.txtLossPlayer2.Size = new System.Drawing.Size(54, 39);
            this.txtLossPlayer2.TabIndex = 27;
            this.txtLossPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDraw
            // 
            this.txtDraw.BackColor = System.Drawing.Color.Gold;
            this.txtDraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDraw.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDraw.ForeColor = System.Drawing.Color.Blue;
            this.txtDraw.Location = new System.Drawing.Point(117, 374);
            this.txtDraw.MaxLength = 15;
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.ReadOnly = true;
            this.txtDraw.Size = new System.Drawing.Size(175, 39);
            this.txtDraw.TabIndex = 28;
            this.txtDraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Gold;
            this.btnEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEndGame.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEndGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEndGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndGame.Font = new System.Drawing.Font("Pristina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.Black;
            this.btnEndGame.Location = new System.Drawing.Point(101, 451);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(162, 45);
            this.btnEndGame.TabIndex = 29;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Visible = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // labTurn
            // 
            this.labTurn.AutoSize = true;
            this.labTurn.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTurn.ForeColor = System.Drawing.Color.Gold;
            this.labTurn.Location = new System.Drawing.Point(185, 817);
            this.labTurn.Name = "labTurn";
            this.labTurn.Size = new System.Drawing.Size(0, 63);
            this.labTurn.TabIndex = 30;
            this.labTurn.Visible = false;
            // 
            // pbBox
            // 
            this.pbBox.BackColor = System.Drawing.Color.Gold;
            this.pbBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBox.Location = new System.Drawing.Point(12, 788);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(159, 115);
            this.pbBox.TabIndex = 31;
            this.pbBox.TabStop = false;
            // 
            // txtTurn
            // 
            this.txtTurn.BackColor = System.Drawing.Color.Gold;
            this.txtTurn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTurn.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTurn.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurn.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTurn.Location = new System.Drawing.Point(20, 817);
            this.txtTurn.MaxLength = 15;
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.ReadOnly = true;
            this.txtTurn.Size = new System.Drawing.Size(127, 63);
            this.txtTurn.TabIndex = 32;
            this.txtTurn.TabStop = false;
            this.txtTurn.Text = "TURN";
            this.txtTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1826, 1043);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.labTurn);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.txtDraw);
            this.Controls.Add(this.txtLossPlayer2);
            this.Controls.Add(this.txtLossPlayer1);
            this.Controls.Add(this.txtWinPlayer2);
            this.Controls.Add(this.txtWinPlayer1);
            this.Controls.Add(this.labDraw);
            this.Controls.Add(this.labLoss);
            this.Controls.Add(this.labWin);
            this.Controls.Add(this.labScorePlayer2);
            this.Controls.Add(this.labScorePlayer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbXorO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.gbXorO.ResumeLayout(false);
            this.gbXorO.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbXorO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbOInTheFirst;
        private System.Windows.Forms.RadioButton rbXInTheFirst;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label labPlyaer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbO1;
        private System.Windows.Forms.RadioButton rbX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbO2;
        private System.Windows.Forms.RadioButton rbX2;
        private System.Windows.Forms.Label labPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labScorePlayer1;
        private System.Windows.Forms.Label labScorePlayer2;
        private System.Windows.Forms.Label labWin;
        private System.Windows.Forms.Label labLoss;
        private System.Windows.Forms.Label labDraw;
        private System.Windows.Forms.TextBox txtWinPlayer1;
        private System.Windows.Forms.TextBox txtWinPlayer2;
        private System.Windows.Forms.TextBox txtLossPlayer1;
        private System.Windows.Forms.TextBox txtLossPlayer2;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label labTurn;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.TextBox txtTurn;
    }
}

