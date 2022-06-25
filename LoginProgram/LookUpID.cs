using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class LookUpID : Form
    {
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        string connstr = null;

        public LookUpID()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label3,"생년월일은 숫자 8자리만 적어주세요.");
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int birthday;
            if (BirthdayBox.Text.Length == 8 && Int32.TryParse(BirthdayBox.Text, out birthday))
            {
                if (conn == null)
                {
                    connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Account.mdb";
                    conn = new OleDbConnection(connstr);
                    conn.Open();
                }
                string sql = "SELECT * FROM Account WHERE MamberName='" + NameBox.Text + "'";
                cmd = new OleDbCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sql = "SELECT ID FROM Account WHERE MamberName='" + NameBox.Text + "' AND Birthday=" + birthday;
                    cmd = new OleDbCommand(sql, conn);
                    MessageBox.Show("회원님의 ID는 " + cmd.ExecuteScalar() + " 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("회원이 아닙니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reader.Close();
                conn.Close();
            }
            else
                MessageBox.Show("생일의 형식을 맞춰서 적어주세요." , "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
