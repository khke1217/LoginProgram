namespace LoginProgram
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Signup = new System.Windows.Forms.Button();
            this.PW_Box = new System.Windows.Forms.TextBox();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForgetPassword_Link = new System.Windows.Forms.LinkLabel();
            this.ForgetID_Link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(55, 164);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Signup
            // 
            this.button_Signup.Location = new System.Drawing.Point(154, 164);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(75, 23);
            this.button_Signup.TabIndex = 3;
            this.button_Signup.Text = "Sign Up";
            this.button_Signup.UseVisualStyleBackColor = true;
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click);
            // 
            // PW_Box
            // 
            this.PW_Box.Location = new System.Drawing.Point(44, 48);
            this.PW_Box.MaxLength = 20;
            this.PW_Box.Name = "PW_Box";
            this.PW_Box.PasswordChar = '*';
            this.PW_Box.Size = new System.Drawing.Size(137, 21);
            this.PW_Box.TabIndex = 1;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(44, 21);
            this.ID_Box.MaxLength = 100;
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(137, 21);
            this.ID_Box.TabIndex = 0;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "PW";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ForgetPassword_Link);
            this.panel1.Controls.Add(this.ForgetID_Link);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ID_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PW_Box);
            this.panel1.Location = new System.Drawing.Point(42, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 111);
            this.panel1.TabIndex = 6;
            // 
            // ForgetPassword_Link
            // 
            this.ForgetPassword_Link.AutoSize = true;
            this.ForgetPassword_Link.Location = new System.Drawing.Point(85, 77);
            this.ForgetPassword_Link.Name = "ForgetPassword_Link";
            this.ForgetPassword_Link.Size = new System.Drawing.Size(101, 12);
            this.ForgetPassword_Link.TabIndex = 9;
            this.ForgetPassword_Link.TabStop = true;
            this.ForgetPassword_Link.Text = "Forget Password";
            this.ForgetPassword_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassword_Link_LinkClicked);
            // 
            // ForgetID_Link
            // 
            this.ForgetID_Link.AutoSize = true;
            this.ForgetID_Link.Location = new System.Drawing.Point(17, 77);
            this.ForgetID_Link.Name = "ForgetID_Link";
            this.ForgetID_Link.Size = new System.Drawing.Size(55, 12);
            this.ForgetID_Link.TabIndex = 8;
            this.ForgetID_Link.TabStop = true;
            this.ForgetID_Link.Text = "Forget ID";
            this.ForgetID_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetID_Link_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "If you don\'t have account, click Sign Up Button";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Signup);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Signup;
        private System.Windows.Forms.TextBox PW_Box;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ForgetPassword_Link;
        private System.Windows.Forms.LinkLabel ForgetID_Link;
    }
}

