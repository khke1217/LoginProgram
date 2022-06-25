namespace LoginProgram
{
    partial class LookUpPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpPassword));
            this.button1 = new System.Windows.Forms.Button();
            this.IdentityQuestion = new System.Windows.Forms.ComboBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.IdentityAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdentityQuestion
            // 
            this.IdentityQuestion.FormattingEnabled = true;
            this.IdentityQuestion.Items.AddRange(new object[] {
            "부모님 이름은?",
            "출신 초등학교 이름은?",
            "좋아하는 가수는?"});
            this.IdentityQuestion.Location = new System.Drawing.Point(124, 56);
            this.IdentityQuestion.Name = "IdentityQuestion";
            this.IdentityQuestion.Size = new System.Drawing.Size(187, 20);
            this.IdentityQuestion.TabIndex = 2;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(124, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(116, 21);
            this.IDBox.TabIndex = 1;
            // 
            // IdentityAnswer
            // 
            this.IdentityAnswer.Location = new System.Drawing.Point(124, 82);
            this.IdentityAnswer.Name = "IdentityAnswer";
            this.IdentityAnswer.Size = new System.Drawing.Size(187, 21);
            this.IdentityAnswer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "본인확인 질문";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "본인확인 답변";
            // 
            // LookUpPassword
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 160);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdentityAnswer);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IdentityQuestion);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LookUpPassword";
            this.Text = "비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox IdentityQuestion;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox IdentityAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}