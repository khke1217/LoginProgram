using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class MainForm : Form
    {
        private string id = string.Empty;
        private LoginForm loginhandle;
        private int Gold, Multiple, NowExp, TotalExp, LV_Value, Rank_Value;

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        string connstr = null;

        public String ID
        {
            get { return id;}
            set
            {
                id = value;
            }
        }

        public LoginForm LoginHandle
        {
            get { return loginhandle; }
            set
            {
                loginhandle = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Get_Exp_Click(object sender, EventArgs e)
        {
            if ((NowExp + 1 + Multiple) > progressBar1.Maximum)
                LevelUp();
            else
            {
                NowExp += 1 + Multiple;
                TotalExp += 1 + Multiple;
                if (progressBar1.Value == progressBar1.Maximum)
                    LevelUp();
            }
            UpdateValue();
        }

        private void Get_Gold_Click(object sender, EventArgs e)
        {
            Gold += 1 + Multiple;
            UpdateValue();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                conn = new OleDbConnection(connstr);
                conn.Open();
            }
            string sql = "SELECT * FROM Account WHERE ID='" + id + "'";
            cmd = new OleDbCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NickName.Text = NickNameBox.Text = reader["NickName"].ToString();
                LV_Value = Int32.Parse(reader["LV"].ToString());
                LV.Text = LV_Value.ToString();
                NowExp = Int32.Parse(reader["EXP"].ToString());
                progressBar1.Value = NowExp;
                EXP_num.Text = NowExp.ToString();
                Birthday.Text = reader["Birthday"].ToString();
                if (reader["Gender"].ToString() == "남성")
                    Male.Select();
                else
                    Female.Select();
                NameBox.Text = reader["MamberName"].ToString();
                Rank_Value = Int32.Parse(reader["Rank"].ToString());
                Rank.Text = Rank_Value.ToString();
                TotalExp = Int32.Parse(reader["Total"].ToString());
                Total_Exp.Text = TotalExp.ToString();
                Gold = Int32.Parse(reader["Gold"].ToString());
                Multiple = Int32.Parse(reader["Multiple"].ToString());
                Now_Gold.Text = Gold.ToString();
                Now_Multiple.Text = Multiple.ToString();
                progressBar1.Maximum = 10 * (int)Math.Pow(2, LV_Value);
            }
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((NowExp + 1 + Rank_Value) > progressBar1.Maximum)
                LevelUp();
            else
            {
                NowExp += 1 + Rank_Value;
                TotalExp += 1 + Rank_Value;
                if (progressBar1.Value == progressBar1.Maximum)
                    LevelUp();
            }
            UpdateValue();
        }

        private void Buy_mult_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Mult_Price.Text) <= Int32.Parse(Now_Gold.Text))
            {
                Multiple++;
                Gold -= Int32.Parse(Mult_Price.Text);
                UpdateValue();
            }
        }

        private void Buy_Rank_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Rank_Price.Text) <= Int32.Parse(Now_Gold.Text))
            {
                Rank_Value++;
                Gold -= Int32.Parse(Rank_Price.Text);
                UpdateValue();
            }
        }

        private void 프로그램정보PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 개발자정보DToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LevelUp()
        {
            progressBar1.Maximum *= 2;
            progressBar1.Value = 0;
            NowExp = 0;
            LV_Value++;
        }

        private void UpdateValue()
        {
            Total_Exp.Text = TotalExp.ToString();
            LV.Text = LV_Value.ToString();
            EXP_num.Text = NowExp.ToString();
            Rank.Text = Rank_Value.ToString();
            Total_Exp.Text = TotalExp.ToString();
            Now_Gold.Text = Gold.ToString();
            Now_Multiple.Text = Multiple.ToString();
            progressBar1.Value = NowExp;
            Mult_Price.Text = Math.Pow(5, (double)(Multiple + 1)).ToString();
            Rank_Price.Text = Math.Pow(3, (double)(Rank_Value + 1)).ToString();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (conn == null)
            {
                connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                conn = new OleDbConnection(connstr);
                conn.Open();
            }
            string sql = "UPDATE Account SET EXP=" + NowExp + ", LV=" + LV_Value + ", Rank=" + Rank_Value + ", Multiple=" + Multiple + ", Gold=" + Gold + ", Total=" + TotalExp + " WHERE ID='" + id + "'";
            cmd = new OleDbCommand(sql, conn);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            conn = null;
            this.Close();
            loginhandle.Show();
            loginhandle.Focus();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("정말로 초기화하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LV_Value = NowExp = Gold = Multiple = TotalExp = Rank_Value = 0;
                progressBar1.Maximum = 10;
            }
            UpdateValue();
            timer1.Start();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            int birthday;
            string gender;
            if (Male.Checked)
                gender = "남성";
            else
                gender = "여성";
            if (Birthday.Text.Length == 8 && Int32.TryParse(Birthday.Text, out birthday))
            {
                if (conn == null)
                {
                    connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                    conn = new OleDbConnection(connstr);
                    conn.Open();
                }
                string sql = "UPDATE Account SET MamberName='" + NameBox + "', NickName='" + NickNameBox + "', Birthday='" + Birthday + "', Gender='" + gender + "' WHERE ID='" + id + "'";
                cmd = new OleDbCommand(sql, conn);
                int x = cmd.ExecuteNonQuery();
                conn.Close();
                conn = null;
            }
            else
                MessageBox.Show("생일은 8자리 숫자만 입력해주세요.","경고",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
