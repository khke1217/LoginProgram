using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginProgram
{
    public partial class LookUpPassword : Form
    {
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        string connstr = null;

        public LookUpPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            {
                sql = "SELECT * FROM Account WHERE ID='" + IDBox.Text + "' AND IdQNum=" + IdentityQuestion.SelectedIndex + " AND IdAnswer='" + IdentityAnswer.Text + "'";
                cmd = new OleDbCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NewPassword newPassword = new NewPassword();
                    newPassword.ID = IDBox.Text;
                    newPassword.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("본인 확인 질문과 답변이 다릅니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("존재하지 않는 회원 ID입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
