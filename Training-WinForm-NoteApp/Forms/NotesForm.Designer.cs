namespace Training_WinForm_NoteApp.Forms
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstNotes = new ListBox();
            txtNoteDescription = new TextBox();
            btnNotesCreate = new Button();
            btnNotesUpdate = new Button();
            btnNotesInputsClear = new Button();
            label1 = new Label();
            txtNotesLoginUsername = new TextBox();
            SuspendLayout();
            // 
            // lstNotes
            // 
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 14;
            lstNotes.Location = new Point(12, 12);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(374, 382);
            lstNotes.TabIndex = 0;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            // 
            // txtNoteDescription
            // 
            txtNoteDescription.Location = new Point(392, 12);
            txtNoteDescription.Multiline = true;
            txtNoteDescription.Name = "txtNoteDescription";
            txtNoteDescription.Size = new Size(396, 82);
            txtNoteDescription.TabIndex = 1;
            // 
            // btnNotesCreate
            // 
            btnNotesCreate.Location = new Point(392, 183);
            btnNotesCreate.Name = "btnNotesCreate";
            btnNotesCreate.Size = new Size(396, 37);
            btnNotesCreate.TabIndex = 3;
            btnNotesCreate.Text = "Ekle";
            btnNotesCreate.UseVisualStyleBackColor = true;
            btnNotesCreate.Click += btnNotesCreate_Click;
            // 
            // btnNotesUpdate
            // 
            btnNotesUpdate.Location = new Point(392, 226);
            btnNotesUpdate.Name = "btnNotesUpdate";
            btnNotesUpdate.Size = new Size(396, 37);
            btnNotesUpdate.TabIndex = 4;
            btnNotesUpdate.Text = "Güncelle";
            btnNotesUpdate.UseVisualStyleBackColor = true;
            btnNotesUpdate.Click += btnNotesUpdate_Click;
            // 
            // btnNotesInputsClear
            // 
            btnNotesInputsClear.Location = new Point(392, 100);
            btnNotesInputsClear.Name = "btnNotesInputsClear";
            btnNotesInputsClear.Size = new Size(396, 37);
            btnNotesInputsClear.TabIndex = 4;
            btnNotesInputsClear.Text = "Temizle";
            btnNotesInputsClear.UseVisualStyleBackColor = true;
            btnNotesInputsClear.Click += btnNotesInputsClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 375);
            label1.Name = "label1";
            label1.Size = new Size(168, 14);
            label1.TabIndex = 5;
            label1.Text = "Giriş Yapan Kullanıcı :";
            // 
            // txtNotesLoginUsername
            // 
            txtNotesLoginUsername.Location = new Point(614, 372);
            txtNotesLoginUsername.Name = "txtNotesLoginUsername";
            txtNotesLoginUsername.ReadOnly = true;
            txtNotesLoginUsername.Size = new Size(174, 22);
            txtNotesLoginUsername.TabIndex = 6;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 407);
            Controls.Add(txtNotesLoginUsername);
            Controls.Add(label1);
            Controls.Add(btnNotesInputsClear);
            Controls.Add(btnNotesUpdate);
            Controls.Add(btnNotesCreate);
            Controls.Add(txtNoteDescription);
            Controls.Add(lstNotes);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NotesForm";
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNotes;
        private TextBox txtNoteDescription;
        private Button btnNotesCreate;
        private Button btnNotesUpdate;
        private Button btnNotesInputsClear;
        private Label label1;
        private TextBox txtNotesLoginUsername;
    }
}