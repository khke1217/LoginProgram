namespace LoginProgram
{
    partial class NewPassword
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
            this.OK = new System.Windows.Forms.Button();
            this.PWBox2 = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IsMach = new System.Windows.Forms.Label();
            this.PW_Rule = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PW_Safty = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(162, 111);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PWBox2
            // 
            this.PWBox2.Location = new System.Drawing.Point(90, 82);
            this.PWBox2.Name = "PWBox2";
            this.PWBox2.PasswordChar = '*';
            this.PWBox2.Size = new System.Drawing.Size(100, 21);
            this.PWBox2.TabIndex = 1;
            this.PWBox2.TextChanged += new System.EventHandler(this.PWBox2_TextChanged);
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(90, 38);
            this.PWBox.Name = "PWBox";
            this.PWBox.PasswordChar = '*';
            this.PWBox.Size = new System.Drawing.Size(100, 21);
            this.PWBox.TabIndex = 0;
            this.PWBox.TextChanged += new System.EventHandler(this.PWBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "비밀번호";
            // 
            // IsMach
            // 
            this.IsMach.AutoSize = true;
            this.IsMach.Location = new System.Drawing.Point(196, 87);
            this.IsMach.Name = "IsMach";
            this.IsMach.Size = new System.Drawing.Size(0, 12);
            this.IsMach.TabIndex = 5;
            // 
            // PW_Rule
            // 
            this.PW_Rule.AutoSize = true;
            this.PW_Rule.Location = new System.Drawing.Point(89, 64);
            this.PW_Rule.Name = "PW_Rule";
            this.PW_Rule.Size = new System.Drawing.Size(0, 12);
            this.PW_Rule.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Location = new System.Drawing.Point(197, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "?";
            this.toolTip1.SetToolTip(this.label2, "비밀번호는 영문, 숫자, !, @, ?, _ 를 포함할 수 있습니다.");
            // 
            // PW_Safty
            // 
            this.PW_Safty.AutoSize = true;
            this.PW_Safty.Location = new System.Drawing.Point(224, 43);
            this.PW_Safty.Name = "PW_Safty";
            this.PW_Safty.Size = new System.Drawing.Size(0, 12);
            this.PW_Safty.TabIndex = 9;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 152);
            this.Controls.Add(this.PW_Safty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PW_Rule);
            this.Controls.Add(this.IsMach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.PWBox2);
            this.Controls.Add(this.OK);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox PWBox2;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IsMach;
        private System.Windows.Forms.Label PW_Rule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PW_Safty;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}