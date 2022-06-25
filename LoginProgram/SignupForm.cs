using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class SignupForm : Form
    {
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        string connstr = null;

        bool IDcheck = false;
        string gender;
        string[] date = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"};

        public SignupForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label14,"비밀번호는 영문, 숫자, !, @, ?, _ 를 포함할 수 있습니다.");
            toolTip1.SetToolTip(pictureBox1, "비밀번호는 영문, 숫자, !, @, ?, _ 를 포함할 수 있습니다");
        }

        private void MathPWBox_TextChanged(object sender, EventArgs e)
        {
            if (PWBox.Text != MathPWBox.Text)
                PW_IsMatched.Text = "일치하지 않습니다.";
            else
                PW_IsMatched.Text = "";
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Month.Text)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    Date.Items.Clear();
                    Date.Items.AddRange(date);
                    Date.Items.Add("29");
                    Date.Items.Add("30");
                    Date.Items.Add("31");
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    Date.Items.Clear();
                    Date.Items.AddRange(date);
                    Date.Items.Add("29");
                    Date.Items.Add("30");
                    break;
                case "2":
                    Date.Items.Clear();
                    Date.Items.AddRange(date);
                    if (DateTime.IsLeapYear(Int32.Parse(Year.Text)))
                        Date.Items.Add("29");
                    break;
            }
        }

        private void Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year, month, day;
            if (Int32.Parse(Year.Text) < 2000)
                year = string.Format("{0}", Int32.Parse(Year.Text) - 1900);
            else
                year = string.Format("0{0}", Int32.Parse(Year.Text) - 2000);

            if (Int32.Parse(Month.Text) < 10)
                month = string.Format("0{0}", Month.Text);
            else
                month = Month.Text;

            if (Int32.Parse(Date.Text) < 10)
                day = string.Format("0{0}", Date.Text);
            else
                day = Date.Text;

            IDNUM1Box.Text = year + month + day;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Year.Text != "")
            {
                if (Male.Checked)
                {
                    if (Int32.Parse(Year.Text) < 2000)
                        IDNUM2Box.Text = "1";
                    else
                        IDNUM2Box.Text = "3";
                    gender = "남성";
                }
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            if (Year.Text != "")
            {
                if (Female.Checked)
                {
                    if (Int32.Parse(Year.Text) < 2000)
                        IDNUM2Box.Text = "2";
                    else
                        IDNUM2Box.Text = "4";
                    gender = "여성";
                }
            }
        }

        private void PWBox_TextChanged(object sender, EventArgs e)
        {
            switch (PW_Rule_Check(PWBox.Text, IDBox.Text))
            {
                case 1:
                    PW_rule.Text = "암호는 6글자 이상이여야 합니다.";
                    break;
                case 2:
                    PW_rule.Text = "암호는 영문과 숫자를 혼합해서 사용해야 합니다.";
                    break;
                case 3:
                    PW_rule.Text = "암호에 ID와 일치하는 문자열이 있습니다.";
                    break;
                case 4:
                    PW_rule.Text = "특수문자는 !, ?, @, _ 만 사용할 수 있습니다.";
                    break;
                case 0:
                    PW_rule.Text = "";
                    break;
            }

            PW_Safe_Chack(PWBox.Text);
        
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

            foreach(char temp in PW)
            {
                if ('A' <= temp && temp <= 'z')
                {
                    result++;
                    break;
                }
            }

            foreach(char temp in PW)
            {
                if('0'<= temp && temp <='9')
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
                label14.Text = "";
                pictureBox1.Image = Properties.Resources.Danger;
                PW_Safty.Text = "취약";
            }
            else if(result==2)
            {
                label14.Text = "";
                pictureBox1.Image = Properties.Resources.Waring;
                PW_Safty.Text = "보통";
            }
            else if (result ==3)
            {
                label14.Text = "";
                pictureBox1.Image = Properties.Resources.Safe;
                PW_Safty.Text = "강함";
            }
            else if (result == 4)
            {
                label14.Text = "";
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
            foreach(char temp in PW)
            {
                if (!('A' <= temp && temp <= 'z'))
                    if (!('0' <= temp && temp <= '9'))
                        if (temp != '!' && temp != '?' && temp != '@' && temp != '_')
                            return false;
            }
            return true;
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            if (Year.Text.Length == 4)
            {
                if (1900 > Int32.Parse(Year.Text) || Int32.Parse(Year.Text) > Int32.Parse(DateTime.Now.Year.ToString()))
                {
                    MessageBox.Show("년도는 1900년도보다 크고 " + DateTime.Now.Year.ToString() + "년도보다 작아야합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Year.Text = "";
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if(IDBox.Text=="")
                MessageBox.Show("ID를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(PWBox.Text == "")
                MessageBox.Show("암호를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if( 0 < PW_Rule_Check(PWBox.Text, IDBox.Text))
                MessageBox.Show("암호 규칙을 확인해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (NameBox.Text =="" )
                MessageBox.Show("이름을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (NickNameBox.Text=="")
                MessageBox.Show("닉네임를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Year.Text==""||Month.Text==""||Date.Text=="")
                MessageBox.Show("생일을 정확히 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IDNUM2Box.Text=="")
                MessageBox.Show("성별을 체크해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Identitiy_Question.SelectedItem==null||Identitiy_Answer.Text=="")
                MessageBox.Show("본인확인 질문과 답변을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!IDcheck)
                MessageBox.Show("ID 중복확인이 필요합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (PW_Safty.Text=="취약")
                {
                    if (MessageBox.Show("보안에 취약한 암호입니다. 정말 사용하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        PWBox.Text = MathPWBox.Text = "";
                    else
                        SignUp();
                }
                else
                    SignUp();
            }

        }

        private void ID_Match_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                conn = new OleDbConnection(connstr);
                conn.Open();
            }
            string sql = "SELECT * FROM Account WHERE ID='" + IDBox.Text + "'";
            cmd = new OleDbCommand(sql, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
                MessageBox.Show("이미 존재하는 ID입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("ID를 사용할 수 있습니다. 사용하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    IDBox.Text = "";
                else
                    IDcheck = true;
            }
            reader.Close();
            conn.Close();
            conn = null;
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            IDcheck = false;
        }

        private void SignUp()
        {
            if (conn == null)
            {
                connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                conn = new OleDbConnection(connstr);
                conn.Open();
            }

            string pw = LoginForm.CrypPW(PWBox.Text);
            int Birthday = Int32.Parse(Year.Text) * 10000 + Int32.Parse(Month.Text) * 100 + Int32.Parse(Date.Text);

            string sql = "INSERT INTO Account VALUES ('" + IDBox.Text.ToString() + "', '" + pw + "', '" + NameBox.Text.ToString() + "', '" + NickNameBox.Text.ToString() + "', " + Birthday + ", '" + gender + "', " + Identitiy_Question.SelectedIndex + ", '" + Identitiy_Answer.Text.ToString() + "', 0 , 0, 0, 0, 0, 0)";
            cmd = new OleDbCommand(sql, conn);

            try
            {
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    MessageBox.Show("회원가입이 완료되었습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Failed");
            }

            finally
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
