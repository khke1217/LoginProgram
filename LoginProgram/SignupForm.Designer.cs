namespace LoginProgram
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.MathPWBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDNUM1Box = new System.Windows.Forms.TextBox();
            this.IDNUM2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PW_rule = new System.Windows.Forms.Label();
            this.PW_IsMatched = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.PW_Safty = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Identitiy_Question = new System.Windows.Forms.ComboBox();
            this.Identitiy_Answer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ID_Match = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDBox
            // 
            resources.ApplyResources(this.IDBox, "IDBox");
            this.IDBox.Name = "IDBox";
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PWBox
            // 
            resources.ApplyResources(this.PWBox, "PWBox");
            this.PWBox.Name = "PWBox";
            this.PWBox.TextChanged += new System.EventHandler(this.PWBox_TextChanged);
            // 
            // MathPWBox
            // 
            resources.ApplyResources(this.MathPWBox, "MathPWBox");
            this.MathPWBox.Name = "MathPWBox";
            this.MathPWBox.TextChanged += new System.EventHandler(this.MathPWBox_TextChanged);
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            // 
            // IDNUM1Box
            // 
            resources.ApplyResources(this.IDNUM1Box, "IDNUM1Box");
            this.IDNUM1Box.Name = "IDNUM1Box";
            this.IDNUM1Box.ReadOnly = true;
            this.IDNUM1Box.TabStop = false;
            // 
            // IDNUM2Box
            // 
            resources.ApplyResources(this.IDNUM2Box, "IDNUM2Box");
            this.IDNUM2Box.Name = "IDNUM2Box";
            this.IDNUM2Box.ReadOnly = true;
            this.IDNUM2Box.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // PW_rule
            // 
            resources.ApplyResources(this.PW_rule, "PW_rule");
            this.PW_rule.Name = "PW_rule";
            // 
            // PW_IsMatched
            // 
            resources.ApplyResources(this.PW_IsMatched, "PW_IsMatched");
            this.PW_IsMatched.Name = "PW_IsMatched";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Male
            // 
            resources.ApplyResources(this.Male, "Male");
            this.Male.Name = "Male";
            this.Male.TabStop = true;
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            resources.ApplyResources(this.Female, "Female");
            this.Female.Name = "Female";
            this.Female.TabStop = true;
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // PW_Safty
            // 
            resources.ApplyResources(this.PW_Safty, "PW_Safty");
            this.PW_Safty.Name = "PW_Safty";
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            resources.GetString("Month.Items"),
            resources.GetString("Month.Items1"),
            resources.GetString("Month.Items2"),
            resources.GetString("Month.Items3"),
            resources.GetString("Month.Items4"),
            resources.GetString("Month.Items5"),
            resources.GetString("Month.Items6"),
            resources.GetString("Month.Items7"),
            resources.GetString("Month.Items8"),
            resources.GetString("Month.Items9"),
            resources.GetString("Month.Items10"),
            resources.GetString("Month.Items11")});
            resources.ApplyResources(this.Month, "Month");
            this.Month.Name = "Month";
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            resources.ApplyResources(this.Date, "Date");
            this.Date.Name = "Date";
            this.Date.SelectedIndexChanged += new System.EventHandler(this.Date_SelectedIndexChanged);
            // 
            // Year
            // 
            resources.ApplyResources(this.Year, "Year");
            this.Year.Name = "Year";
            this.Year.TextChanged += new System.EventHandler(this.Year_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Identitiy_Question
            // 
            this.Identitiy_Question.FormattingEnabled = true;
            this.Identitiy_Question.Items.AddRange(new object[] {
            resources.GetString("Identitiy_Question.Items"),
            resources.GetString("Identitiy_Question.Items1"),
            resources.GetString("Identitiy_Question.Items2")});
            resources.ApplyResources(this.Identitiy_Question, "Identitiy_Question");
            this.Identitiy_Question.Name = "Identitiy_Question";
            // 
            // Identitiy_Answer
            // 
            resources.ApplyResources(this.Identitiy_Answer, "Identitiy_Answer");
            this.Identitiy_Answer.Name = "Identitiy_Answer";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // button_OK
            // 
            resources.ApplyResources(this.button_OK, "button_OK");
            this.button_OK.Name = "button_OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Cursor = System.Windows.Forms.Cursors.Help;
            this.label14.Name = "label14";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // NickNameBox
            // 
            resources.ApplyResources(this.NickNameBox, "NickNameBox");
            this.NickNameBox.Name = "NickNameBox";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // ID_Match
            // 
            resources.ApplyResources(this.ID_Match, "ID_Match");
            this.ID_Match.Name = "ID_Match";
            this.ID_Match.UseVisualStyleBackColor = true;
            this.ID_Match.Click += new System.EventHandler(this.ID_Match_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // SignupForm
            // 
            this.AcceptButton = this.button_OK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID_Match);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NickNameBox);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Identitiy_Answer);
            this.Controls.Add(this.Identitiy_Question);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.PW_Safty);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PW_IsMatched);
            this.Controls.Add(this.PW_rule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNUM2Box);
            this.Controls.Add(this.IDNUM1Box);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.MathPWBox);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.TextBox MathPWBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDNUM1Box;
        private System.Windows.Forms.TextBox IDNUM2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PW_rule;
        private System.Windows.Forms.Label PW_IsMatched;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label PW_Safty;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Date;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Identitiy_Answer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ID_Match;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Identitiy_Question;
    }
}