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

namespace Training_WinForm_NoteApp.Forms
{
    public partial class ProductsForm : Form
    {
        LoginResponseDto LoggedUser;
        public ProductsForm(LoginResponseDto appUser)
        {
            InitializeComponent();
            LoggedUser = appUser;
            ProductRefresh();
        }

        private void ProductRefresh()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = GetProducts();
            lstProducts.DisplayMember = "Name";
            lstProducts.ValueMember = "Id";
        }

        private List<Product> GetProducts()
        {
            var products = new List<Product>();

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(reader[0]),
                    Name = Convert.ToString(reader[1]),
                    Stock = Convert.ToInt32(reader[2])
                });
            }

            reader.Close();
            connection.Close();
            command.Parameters.Clear();

            return products;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            txtProductLoginUsername.Text = LoggedUser.Fullname;
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProductsInputsClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNote = lstProducts.SelectedItem as Product;
            if (selectedNote != null)
            {
                txtProductName.Text = selectedNote.Name;
                txtProductPrice.Text = selectedNote.Stock.ToString();
            }
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtProductPrice.Text))
            {
                MessageBox.Show("Alanları boş geçemezsiniz");
                return;
            }

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into Products(Name,Stock) values(@name,@stock)";

            command.Parameters.AddWithValue("@name", txtProductName.Text);
            command.Parameters.AddWithValue("@stock", txtProductPrice.Text);

            connection.Open();
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            connection.Close();

            MessageBox.Show("Products ekleme başarılı");
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            ProductRefresh();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            var selectedProduct = lstProducts.SelectedItem as Product;
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtProductPrice.Text) || selectedProduct == null)
            {
                MessageBox.Show("Alanları boş geçemezsiniz");
                return;
            }

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "update Products set Name=@name, Stock=@stock where Id=@Id";

            command.Parameters.AddWithValue("@name", txtProductName.Text);
            command.Parameters.AddWithValue("@stock", txtProductPrice.Text);
            command.Parameters.AddWithValue("@Id", selectedProduct.Id);

            connection.Open();
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            connection.Close();

            MessageBox.Show("Product güncelleme başarılı");
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            ProductRefresh();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
