using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_WinForm_NoteApp.DTO;
using Training_WinForm_NoteApp.Entities;

namespace Training_WinForm_NoteApp.Forms
{
    public partial class NavigationForm : Form
    {
        LoginResponseDto LoggedUser;
        public NavigationForm(LoginResponseDto appUser)
        {
            InitializeComponent();
            LoggedUser = appUser;
        }

        private void NavigationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNavigationProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(LoggedUser);
            productsForm.Show();
            this.Hide();
        }

        private void btnNavigationNotes_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm(LoggedUser);
            notesForm.Show();
            this.Hide();
        }
    }
}
