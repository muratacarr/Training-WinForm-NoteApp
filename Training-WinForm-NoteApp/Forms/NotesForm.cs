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
    public partial class NotesForm : Form
    {
        LoginResponseDto LoggedUser;
        public NotesForm(LoginResponseDto appUser)
        {
            InitializeComponent();
            LoggedUser = appUser;
            NotesRefresh();
        }

        private void NotesRefresh()
        {
            lstNotes.DataSource = null;
            lstNotes.DataSource = GetNotes();
            lstNotes.DisplayMember = "Description";
            lstNotes.ValueMember = "Id";
        }

        private List<Note> GetNotes()
        {
            var notes = new List<Note>();

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Notes where UserId=@userId";
            command.Parameters.AddWithValue("@userId", LoggedUser.Id);

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                notes.Add(new Note
                {
                    Id = Convert.ToInt32(reader[0]),
                    Description = Convert.ToString(reader[1]),
                    UserId = Convert.ToInt32(reader[2]),
                });

            }

            reader.Close();
            connection.Close();
            command.Parameters.Clear();

            return notes;
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            txtNotesLoginUsername.Text = LoggedUser.Fullname;
        }

        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNotesInputsClear_Click(object sender, EventArgs e)
        {
            txtNoteDescription.Text = string.Empty;
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNote = lstNotes.SelectedItem as Note;
            if (selectedNote != null)
            {
                txtNoteDescription.Text = selectedNote.Description;
            }
        }

        private void btnNotesCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoteDescription.Text))
            {
                MessageBox.Show("Alanları boş geçemezsiniz");
                return;
            }

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into Notes values(@description,@userId)";

            command.Parameters.AddWithValue("@description", txtNoteDescription.Text);
            command.Parameters.AddWithValue("@userId", LoggedUser.Id);

            connection.Open();
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            connection.Close();

            MessageBox.Show("Note ekleme başarılı");
            txtNoteDescription.Text = string.Empty;
            NotesRefresh();

        }

        private void btnNotesUpdate_Click(object sender, EventArgs e)
        {
            var selectedNote = lstNotes.SelectedItem as Note;
            if (string.IsNullOrEmpty(txtNoteDescription.Text) || selectedNote == null)
            {
                MessageBox.Show("Alanları boş geçemezsiniz");
                return;
            }

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress;database=TutorialDb;integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "update Notes set Description=@description where Id=@Id";

            command.Parameters.AddWithValue("@description", txtNoteDescription.Text);
            command.Parameters.AddWithValue("@Id", selectedNote.Id);

            connection.Open();
            command.ExecuteNonQuery();

            command.Parameters.Clear();
            connection.Close();

            MessageBox.Show("Note güncelleme başarılı");
            txtNoteDescription.Text = string.Empty;
            NotesRefresh();
        }
    }
}
