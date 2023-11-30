using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using fasilkom_prestasi.App.Context;

namespace fasilkom_prestasi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.username = username;
            this.userRole = userRole;
            this.password = password;

        }
        private long username;
        private string password;
        private int userRole;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = long.Parse(UserBox.Text);
            password = PassBox.Text;

            var loginstatus = LoginContext.login(username, password);


            if (loginstatus == 1)
            {
                DataTable dataCreditials = LoginContext.show(username);
                userRole = int.Parse(dataCreditials.Rows[0]["user_role"].ToString());

                if (userRole == 1)
                {
                    this.Hide();
                    Record tableRecord = new Record();
                    tableRecord.ShowDialog();
                }
                else if (userRole == 2)
                {
                    this.Hide();
                    Validation tableValidation = new Validation();
                    tableValidation.ShowDialog();

                };
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassBox.PasswordChar = '\0';
            }
            else if (!checkBox1.Checked)
            {
                PassBox.PasswordChar = '*';
            }
        }
    }
}