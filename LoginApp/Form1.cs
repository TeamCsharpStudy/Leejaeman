using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            m_id = "lividious";
            m_password = "happy1234";
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            CompareTotal(ID_Text.Text, Password_Text.Text);
        }

        private void Password_Text_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CompareTotal(ID_Text.Text, Password_Text.Text);
            }
        }

        private void CompareTotal(string id, string password)
        {
            bool isSameId = CompareId(id);
            bool isSamePassword = ComparePassword(password);

            if(isSameId && isSamePassword)
                MessageBox.Show("로그인 되었습니다~~!");
        }

        private bool CompareId(string id)
        {
            if (m_id != id)
            {
                MessageBox.Show("아이디가 틀렸습니다");
                return false;
            }

            return true;
        }

        private bool ComparePassword(string password)
        {
            if (m_password != Password_Text.Text)
            {
                MessageBox.Show("비밀번호가 틀렸습니다");
                return false;
            }

            return true;
        }

    }// end of public partial class Login : Form
}
