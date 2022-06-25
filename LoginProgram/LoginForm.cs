using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class LoginForm : Form
    {
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        string connstr = null;

        int errcount = 0;

        public static string CrypPW(string PWText)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] pw_text = UE.GetBytes(PWText);
            SHA1Managed SHhash = new SHA1Managed();
            byte[] pw = SHhash.ComputeHash(pw_text);
            return BitConverter.ToString(pw);
        }

        public LoginForm()
        {
            InitializeComponent();
            ID_Box.Focus();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (ID_Box.Text == "")
                MessageBox.Show("ID를 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (PW_Box.Text == "")
                MessageBox.Show("비밀번호를 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string id = ID_Box.Text.Trim();
                string pw = CrypPW(PW_Box.Text);

                if (conn == null)
                {
                    connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                    conn = new OleDbConnection(connstr);
                    conn.Open();
                }
                string sql = "SELECT * FROM Account WHERE ID='" + id + "' AND PW='" + pw + "'";
                cmd = new OleDbCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    errcount = 0;
                    MainForm main = new MainForm();
                    reader.Close();
                    conn.Close();
                    conn = null;
                    main.ID = id;
                    main.LoginHandle = this;
                    main.Show();
                    this.Hide();
                }
                else
                {
                    if (errcount < 5)
                    {
                        MessageBox.Show("ID와 비밀번호를 확인하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errcount++;
                        reader.Close();
                        conn.Close();
                        conn = null;
                    }
                    else
                    {
                        MessageBox.Show("ID와 비밀번호를 5회 이상 잘못 입력하여 프로그램이 종료됩니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        conn.Close();
                        conn = null;
                        this.Close();
                    }
                }
            }
           
        }

        private void button_Signup_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog();
        }

        private void ForgetID_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LookUpID lookUpID = new LookUpID();
            lookUpID.ShowDialog();
        }

        private void ForgetPassword_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LookUpPassword lookUpPassword = new LookUpPassword();
            lookUpPassword.ShowDialog();
        }

        private void ID_Box_TextChanged(object sender, EventArgs e)
        {
            errcount = 0;
        }
    }

    public class Cryp
    {
        public string ConvertPW(string PWText)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] pw_text = UE.GetBytes(PWText);
            SHA1Managed SHhash = new SHA1Managed();
            byte[] pw = SHhash.ComputeHash(pw_text);
            return BitConverter.ToString(pw);
        }
    }
}
