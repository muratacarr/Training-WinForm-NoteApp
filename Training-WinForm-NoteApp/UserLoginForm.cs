using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_WinForm_NoteApp.DTO;
using Training_WinForm_NoteApp.Entities;
using Training_WinForm_NoteApp.Forms;

namespace Training_WinForm_NoteApp
{
    public partial class UserLoginForm : Form
    {
        AppUser LoggedUser;
        public UserLoginForm()
        {
            InitializeComponent();
            LoggedUser = new AppUser();
        }

        private void btnUserLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserLoginGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserLoginUsername.Text) || string.IsNullOrEmpty(txtUserLoginPassword.Text))
            {
                MessageBox.Show("Alanları doldurunuz.");
                return;
            }

            if (!(txtUserLoginUsername.Text is string) || !(int.TryParse(txtUserLoginPassword.Text, out int intValue)))
            {
                MessageBox.Show("Girilen değerleri kontrol ediniz");
                return;
            }

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where Username=@username and Password=@password";

            command.Parameters.AddWithValue("@username", txtUserLoginUsername.Text);
            command.Parameters.AddWithValue("@password", txtUserLoginPassword.Text);

            connection.Open();
            var reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Kullanıcı Adı yada Parola Yanlış");
                reader.Close();
                connection.Close();
                return;
            }

            userPropsReset();
            while (reader.Read())
            {
                appUserFill(reader);
            }
            reader.Close();
            connection.Close();

            NavigationForm navigationForm = new NavigationForm(new LoginResponseDto
            {
                Fullname=LoggedUser.Fullname,
                Id=LoggedUser.Id
            });
            navigationForm.Show();
            this.Hide();

        }
        private void userPropsReset()
        {
            LoggedUser.Id = -1;
            LoggedUser.Username = string.Empty;
            LoggedUser.Fullname = string.Empty;
            LoggedUser.Password = -1;
        }

        private void appUserFill(SqlDataReader reader)
        {
            LoggedUser.Id = Convert.ToInt32(reader[0]);
            LoggedUser.Username = Convert.ToString(reader[1]);
            LoggedUser.Fullname = Convert.ToString(reader[2]);
            LoggedUser.Password = Convert.ToInt32(reader[3]);
        }
    }
}
