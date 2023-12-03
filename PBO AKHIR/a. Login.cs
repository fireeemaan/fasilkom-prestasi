using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using fasilkom_prestasi.App.Context;
using System.Threading;


namespace fasilkom_prestasi
{
    public partial class Login : Form
    {
        private long username;
        private string password;
        private int userRole;

        public Login()
        {
            InitializeComponent();
            invalidUsernamePasswordControl1.Hide();


        }

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
            try
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
                        DataTable dataMahasiswa = MahasiswaContext.show(username);


                        this.Hide();
                        HomeGuide homeGuide = new HomeGuide(1, username);
                        homeGuide.ShowDialog();

                    }
                    else if (userRole == 2)
                    {
                        this.Hide();
                        Validation tableValidation = new Validation(username);
                        tableValidation.ShowDialog();

                    };
                }
                else
                {
                    invalidUsernamePasswordControl1.Show();
                    invalidUsernamePasswordControl1.Hide();
                    //MessageBox.Show("Username atau Password anda salah!", "Data Salah", MessageBoxButtons.OK);
                }
            }
            catch
            {
                invalidUsernamePasswordControl1.Show();
                invalidUsernamePasswordControl1.Hide();
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

        private void btnFillAdmin_Click(object sender, EventArgs e)
        {
            UserBox.Text = 12345678912.ToString();
            PassBox.Text = "admin";
        }

        private void btnFillMhs_Click(object sender, EventArgs e)
        {
            UserBox.Text = 222410101000.ToString();
            PassBox.Text = "user";
        }

        private void invalidUsernamePasswordControl1_Load(object sender, EventArgs e)
        {

        }
    }
}