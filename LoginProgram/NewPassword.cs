using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class NewPassword : Form
    {
        string id;

        public String ID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        string connstr = null;

        public NewPassword()
        {
            InitializeComponent();
            this.Focus();
        }

        private void PWBox2_TextChanged(object sender, EventArgs e)
        {
            if (PWBox.Text == PWBox2.Text)
                IsMach.Text = "일치";
            else
                IsMach.Text = "불일치";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (IsMach.Text == "일치")
            {
                if (PW_Safty.Text == "취약")
                    if (MessageBox.Show("보안에 취약한 암호입니다. 정말 사용하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        PWBox.Text = PWBox2.Text = "";
                    else
                        UpdatePW();
                else
                    UpdatePW();
            }
            else
                MessageBox.Show("암호가 일치하지 않습니다.","경고",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private int PW_Rule_Check(string PW, string ID)
        {
            if (PW.Length < 6)
                return 1;
            else if (!PW_Rule1(PW))
                return 2;
            else if (!PW_Rule2(PW, ID))
                return 3;
            else if (!PW_Rule3(PW))
                return 4;
            else
                return 0;
        }

        private bool PW_Rule1(string PW)
        {
            int result = 0;

            foreach (char temp in PW)
            {
                if ('A' <= temp && temp <= 'z')
                {
                    result++;
                    break;
                }
            }

            foreach (char temp in PW)
            {
                if ('0' <= temp && temp <= '9')
                {
                    result++;
                    break;
                }
            }

            if (result == 2)
                return true;
            else
                return false;
        }

        private void PW_Safe_Chack(string PW)
        {
            int result = 0;

            if (PW.Length > 9)
                result++;

            foreach (char temp in PW)
            {
                if ('A' <= temp && temp <= 'Z')
                {
                    result++;
                    break;
                }
            }

            foreach (char temp in PW)
            {
                if ('a' <= temp && temp <= 'z')
                {
                    result++;
                    break;
                }
            }

            foreach (char temp in PW)
            {
                if (temp == '!' || temp == '?' || temp == '@' || temp == '_')
                {
                    result++;
                    break;
                }
            }

            if (result <= 1)
            {
                label2.Text = "";
                pictureBox1.Image = Properties.Resources.Danger;
                PW_Safty.Text = "취약";
            }
            else if (result == 2)
            {
                label2.Text = "";
                pictureBox1.Image = Properties.Resources.Waring;
                PW_Safty.Text = "보통";
            }
            else if (result == 3)
            {
                label2.Text = "";
                pictureBox1.Image = Properties.Resources.Safe;
                PW_Safty.Text = "강함";
            }
            else if (result == 4)
            {
                label2.Text = "";
                pictureBox1.Image = Properties.Resources.Safe;
                PW_Safty.Text = "매우강함";
            }
        }

        private bool PW_Rule2(string PW, string ID)
        {
            for (int i = 0; i < ID.Length - 2; i++)
            {
                for (int j = 0; j < PW.Length - 2; j++)
                {
                    if (PW.ElementAt(j) == ID.ElementAt(i))
                        if (PW.ElementAt(j + 1) == ID.ElementAt(i + 1))
                            if (PW.ElementAt(j + 2) == ID.ElementAt(i + 2))
                                return false;
                }
            }
            return true;
        }

        private bool PW_Rule3(string PW)
        {
            foreach (char temp in PW)
            {
                if (!('A' <= temp && temp <= 'z'))
                    if (!('0' <= temp && temp <= '9'))
                        if (temp != '!' && temp != '?' && temp != '@' && temp != '_')
                            return false;
            }
            return true;
        }

        private void PWBox_TextChanged(object sender, EventArgs e)
        {
            switch (PW_Rule_Check(PWBox.Text, id))
            {
                case 1:
                    PW_Rule.Text = "암호는 6글자 이상이여야 합니다.";
                    break;
                case 2:
                    PW_Rule.Text = "암호는 영문과 숫자를 혼합해서 사용해야 합니다.";
                    break;
                case 3:
                    PW_Rule.Text = "암호에 ID와 일치하는 문자열이 있습니다.";
                    break;
                case 4:
                    PW_Rule.Text = "특수문자는 !, ?, @, _ 만 사용할 수 있습니다.";
                    break;
                case 0:
                    PW_Rule.Text = "";
                    break;
            }

            PW_Safe_Chack(PWBox.Text);
        }

        private void UpdatePW()
        {
            string pw = LoginForm.CrypPW(PWBox.Text);
            if (conn == null)
            {
                connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                conn = new OleDbConnection(connstr);
                conn.Open();
            }
            string sql = "UPDATE Account SET PW='" + pw + "' WHERE ID='"+ id +"'";
            cmd = new OleDbCommand(sql, conn);
            try
            {
                int x = cmd.ExecuteNonQuery();
                if (x >= 1)
                    MessageBox.Show("정상적으로 변경되었습니다", "Update Success!");
                conn.Close();
                conn = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error!");
            }
        }
    }
}
