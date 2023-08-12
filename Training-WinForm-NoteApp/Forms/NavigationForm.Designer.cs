namespace Training_WinForm_NoteApp.Forms
{
    partial class NavigationForm
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
            btnNavigationProducts = new Button();
            btnNavigationNotes = new Button();
            SuspendLayout();
            // 
            // btnNavigationProducts
            // 
            btnNavigationProducts.Location = new Point(12, 11);
            btnNavigationProducts.Name = "btnNavigationProducts";
            btnNavigationProducts.Size = new Size(120, 120);
            btnNavigationProducts.TabIndex = 0;
            btnNavigationProducts.Text = "Ürün Listesi";
            btnNavigationProducts.UseVisualStyleBackColor = true;
            btnNavigationProducts.Click += btnNavigationProducts_Click;
            // 
            // btnNavigationNotes
            // 
            btnNavigationNotes.Location = new Point(138, 12);
            btnNavigationNotes.Name = "btnNavigationNotes";
            btnNavigationNotes.Size = new Size(120, 120);
            btnNavigationNotes.TabIndex = 1;
            btnNavigationNotes.Text = "Özlü Sözler";
            btnNavigationNotes.UseVisualStyleBackColor = true;
            btnNavigationNotes.Click += btnNavigationNotes_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 144);
            Controls.Add(btnNavigationNotes);
            Controls.Add(btnNavigationProducts);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NavigationForm";
            Text = "NavigationForm";
            FormClosed += NavigationForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNavigationProducts;
        private Button btnNavigationNotes;
    }
}