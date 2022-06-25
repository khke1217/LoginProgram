namespace LoginProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_LogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rank = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EXP_num = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.Label();
            this.LV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Total_Exp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Now_Multiple = new System.Windows.Forms.Label();
            this.Now_Gold = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rank_Price = new System.Windows.Forms.Label();
            this.Mult_Price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Buy_Rank = new System.Windows.Forms.Button();
            this.Buy_mult = new System.Windows.Forms.Button();
            this.Get_Gold = new System.Windows.Forms.Button();
            this.Get_Exp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보초기회IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개발자정보DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_LogOut.Location = new System.Drawing.Point(82, 48);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(53, 23);
            this.button_LogOut.TabIndex = 2;
            this.button_LogOut.Text = "LogOut";
            this.toolTip1.SetToolTip(this.button_LogOut, "게임을 저장하고 로그아웃합니다.");
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Rank);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EXP_num);
            this.panel1.Controls.Add(this.NickName);
            this.panel1.Controls.Add(this.LV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 145);
            this.panel1.TabIndex = 3;
            // 
            // Rank
            // 
            this.Rank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rank.Location = new System.Drawing.Point(51, 118);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(100, 17);
            this.Rank.TabIndex = 11;
            this.Rank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "계급";
            // 
            // EXP_num
            // 
            this.EXP_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EXP_num.Location = new System.Drawing.Point(51, 93);
            this.EXP_num.Name = "EXP_num";
            this.EXP_num.Size = new System.Drawing.Size(100, 17);
            this.EXP_num.TabIndex = 9;
            this.EXP_num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NickName
            // 
            this.NickName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NickName.Location = new System.Drawing.Point(51, 16);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(100, 18);
            this.NickName.TabIndex = 4;
            this.NickName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LV
            // 
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.Location = new System.Drawing.Point(51, 41);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(100, 18);
            this.LV.TabIndex = 4;
            this.LV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "LV";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 65);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "EXP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "캐릭터";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Total_Exp);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Now_Multiple);
            this.panel2.Controls.Add(this.Now_Gold);
            this.panel2.Location = new System.Drawing.Point(12, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 125);
            this.panel2.TabIndex = 4;
            // 
            // Total_Exp
            // 
            this.Total_Exp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_Exp.Location = new System.Drawing.Point(13, 92);
            this.Total_Exp.Name = "Total_Exp";
            this.Total_Exp.Size = new System.Drawing.Size(138, 18);
            this.Total_Exp.TabIndex = 9;
            this.Total_Exp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Gold";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "누적 EXP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "Multi";
            // 
            // Now_Multiple
            // 
            this.Now_Multiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Now_Multiple.Location = new System.Drawing.Point(51, 44);
            this.Now_Multiple.Name = "Now_Multiple";
            this.Now_Multiple.Size = new System.Drawing.Size(100, 18);
            this.Now_Multiple.TabIndex = 4;
            this.Now_Multiple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Now_Gold
            // 
            this.Now_Gold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Now_Gold.Location = new System.Drawing.Point(51, 19);
            this.Now_Gold.Name = "Now_Gold";
            this.Now_Gold.Size = new System.Drawing.Size(100, 18);
            this.Now_Gold.TabIndex = 4;
            this.Now_Gold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Rank_Price);
            this.panel3.Controls.Add(this.Mult_Price);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Buy_Rank);
            this.panel3.Controls.Add(this.Buy_mult);
            this.panel3.Location = new System.Drawing.Point(196, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 123);
            this.panel3.TabIndex = 5;
            // 
            // Rank_Price
            // 
            this.Rank_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rank_Price.Location = new System.Drawing.Point(12, 62);
            this.Rank_Price.Name = "Rank_Price";
            this.Rank_Price.Size = new System.Drawing.Size(128, 18);
            this.Rank_Price.TabIndex = 13;
            this.Rank_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mult_Price
            // 
            this.Mult_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mult_Price.Location = new System.Drawing.Point(12, 12);
            this.Mult_Price.Name = "Mult_Price";
            this.Mult_Price.Size = new System.Drawing.Size(128, 18);
            this.Mult_Price.TabIndex = 12;
            this.Mult_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "계급증가";
            this.toolTip1.SetToolTip(this.label8, "매 초마다 얻는 EXP의 양을 증가시킵니다.\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "배수증가";
            this.toolTip1.SetToolTip(this.label7, "일하기의 버튼을 클릭할때마다 증가하는 EXP와 Gold를 1 증가시킵니다.\r\n");
            // 
            // Buy_Rank
            // 
            this.Buy_Rank.Location = new System.Drawing.Point(98, 86);
            this.Buy_Rank.Name = "Buy_Rank";
            this.Buy_Rank.Size = new System.Drawing.Size(42, 20);
            this.Buy_Rank.TabIndex = 1;
            this.Buy_Rank.Text = "Buy";
            this.Buy_Rank.UseVisualStyleBackColor = true;
            this.Buy_Rank.Click += new System.EventHandler(this.Buy_Rank_Click);
            // 
            // Buy_mult
            // 
            this.Buy_mult.Location = new System.Drawing.Point(98, 36);
            this.Buy_mult.Name = "Buy_mult";
            this.Buy_mult.Size = new System.Drawing.Size(42, 20);
            this.Buy_mult.TabIndex = 0;
            this.Buy_mult.Text = "Buy";
            this.Buy_mult.UseVisualStyleBackColor = true;
            this.Buy_mult.Click += new System.EventHandler(this.Buy_mult_Click);
            // 
            // Get_Gold
            // 
            this.Get_Gold.Location = new System.Drawing.Point(84, 14);
            this.Get_Gold.Name = "Get_Gold";
            this.Get_Gold.Size = new System.Drawing.Size(53, 23);
            this.Get_Gold.TabIndex = 3;
            this.Get_Gold.Text = "Gold";
            this.Get_Gold.UseVisualStyleBackColor = true;
            this.Get_Gold.Click += new System.EventHandler(this.Get_Gold_Click);
            // 
            // Get_Exp
            // 
            this.Get_Exp.Location = new System.Drawing.Point(17, 14);
            this.Get_Exp.Name = "Get_Exp";
            this.Get_Exp.Size = new System.Drawing.Size(53, 23);
            this.Get_Exp.TabIndex = 2;
            this.Get_Exp.Text = "EXP";
            this.Get_Exp.UseVisualStyleBackColor = true;
            this.Get_Exp.Click += new System.EventHandler(this.Get_Exp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "인벤토리";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "상점";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Get_Exp);
            this.panel4.Controls.Add(this.Get_Gold);
            this.panel4.Location = new System.Drawing.Point(196, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 51);
            this.panel4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "일하기";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Reset);
            this.panel5.Controls.Add(this.Change);
            this.panel5.Controls.Add(this.button_LogOut);
            this.panel5.Location = new System.Drawing.Point(196, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 86);
            this.panel5.TabIndex = 8;
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Help;
            this.Reset.Location = new System.Drawing.Point(17, 48);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(53, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.toolTip1.SetToolTip(this.Reset, "모든 게임 관련 정보를 초기화합니다.");
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Change
            // 
            this.Change.Cursor = System.Windows.Forms.Cursors.Help;
            this.Change.Font = new System.Drawing.Font("굴림", 8F);
            this.Change.Location = new System.Drawing.Point(17, 13);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(118, 23);
            this.Change.TabIndex = 2;
            this.Change.Text = "Infomation Change";
            this.toolTip1.SetToolTip(this.Change, "계정에 저장된 이름, 닉네임, 생일, 성별정보를 하단 박스의 정보로 바꿉니다.\r\n");
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "옵션";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Female);
            this.panel6.Controls.Add(this.Male);
            this.panel6.Controls.Add(this.Birthday);
            this.panel6.Controls.Add(this.NickNameBox);
            this.panel6.Controls.Add(this.NameBox);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(12, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 76);
            this.panel6.TabIndex = 12;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(272, 44);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(35, 16);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "여";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(224, 44);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(35, 16);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "남";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(215, 12);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(100, 21);
            this.Birthday.TabIndex = 8;
            // 
            // NickNameBox
            // 
            this.NickNameBox.Location = new System.Drawing.Point(64, 42);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(100, 21);
            this.NickNameBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(64, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 21);
            this.NameBox.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "성별";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(184, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "생일";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "닉네임";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "이름";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.옵션OToolStripMenuItem,
            this.정보IToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 옵션OToolStripMenuItem
            // 
            this.옵션OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보초기회IToolStripMenuItem,
            this.로그아웃OToolStripMenuItem});
            this.옵션OToolStripMenuItem.Name = "옵션OToolStripMenuItem";
            this.옵션OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.옵션OToolStripMenuItem.Text = "옵션(&O)";
            // 
            // 정보IToolStripMenuItem
            // 
            this.정보IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보PToolStripMenuItem,
            this.개발자정보DToolStripMenuItem});
            this.정보IToolStripMenuItem.Name = "정보IToolStripMenuItem";
            this.정보IToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.정보IToolStripMenuItem.Text = "정보(&I)";
            // 
            // 정보초기회IToolStripMenuItem
            // 
            this.정보초기회IToolStripMenuItem.Name = "정보초기회IToolStripMenuItem";
            this.정보초기회IToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.정보초기회IToolStripMenuItem.Text = "정보 초기회(&I)";
            this.정보초기회IToolStripMenuItem.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // 로그아웃OToolStripMenuItem
            // 
            this.로그아웃OToolStripMenuItem.Name = "로그아웃OToolStripMenuItem";
            this.로그아웃OToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.로그아웃OToolStripMenuItem.Text = "로그아웃(&O)";
            this.로그아웃OToolStripMenuItem.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // 프로그램정보PToolStripMenuItem
            // 
            this.프로그램정보PToolStripMenuItem.Name = "프로그램정보PToolStripMenuItem";
            this.프로그램정보PToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.프로그램정보PToolStripMenuItem.Text = "프로그램 정보(&P)";
            this.프로그램정보PToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보PToolStripMenuItem_Click);
            // 
            // 개발자정보DToolStripMenuItem
            // 
            this.개발자정보DToolStripMenuItem.Name = "개발자정보DToolStripMenuItem";
            this.개발자정보DToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.개발자정보DToolStripMenuItem.Text = "개발자 정보(&D)";
            this.개발자정보DToolStripMenuItem.Click += new System.EventHandler(this.개발자정보DToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 438);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.button_LogOut_Click);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EXP_num;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Get_Gold;
        private System.Windows.Forms.Button Get_Exp;
        private System.Windows.Forms.Button Buy_Rank;
        private System.Windows.Forms.Button Buy_mult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Rank_Price;
        private System.Windows.Forms.Label Mult_Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label Total_Exp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Now_Multiple;
        private System.Windows.Forms.Label Now_Gold;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox Birthday;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보초기회IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개발자정보DToolStripMenuItem;
    }
}