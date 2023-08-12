namespace Training_WinForm_NoteApp.Forms
{
    partial class ProductsForm
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
            txtProductLoginUsername = new TextBox();
            label1 = new Label();
            btnProductsInputsClear = new Button();
            btnProductDelete = new Button();
            btnProductUpdate = new Button();
            btnProductCreate = new Button();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            lstProducts = new ListBox();
            SuspendLayout();
            // 
            // txtProductLoginUsername
            // 
            txtProductLoginUsername.Location = new Point(614, 347);
            txtProductLoginUsername.Name = "txtProductLoginUsername";
            txtProductLoginUsername.ReadOnly = true;
            txtProductLoginUsername.Size = new Size(174, 22);
            txtProductLoginUsername.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 350);
            label1.Name = "label1";
            label1.Size = new Size(168, 14);
            label1.TabIndex = 14;
            label1.Text = "Giriş Yapan Kullanıcı :";
            // 
            // btnProductsInputsClear
            // 
            btnProductsInputsClear.Location = new Point(392, 122);
            btnProductsInputsClear.Name = "btnProductsInputsClear";
            btnProductsInputsClear.Size = new Size(396, 35);
            btnProductsInputsClear.TabIndex = 11;
            btnProductsInputsClear.Text = "Temizle";
            btnProductsInputsClear.UseVisualStyleBackColor = true;
            btnProductsInputsClear.Click += btnProductsInputsClear_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(392, 270);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(396, 35);
            btnProductDelete.TabIndex = 12;
            btnProductDelete.Text = "Sil";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Location = new Point(392, 229);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(396, 35);
            btnProductUpdate.TabIndex = 13;
            btnProductUpdate.Text = "Güncelle";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // btnProductCreate
            // 
            btnProductCreate.Location = new Point(392, 189);
            btnProductCreate.Name = "btnProductCreate";
            btnProductCreate.Size = new Size(396, 35);
            btnProductCreate.TabIndex = 10;
            btnProductCreate.Text = "Ekle";
            btnProductCreate.UseVisualStyleBackColor = true;
            btnProductCreate.Click += btnProductCreate_Click;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(392, 94);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(396, 22);
            txtProductPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(392, 11);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(396, 77);
            txtProductName.TabIndex = 8;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 14;
            lstProducts.Location = new Point(12, 11);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(374, 354);
            lstProducts.TabIndex = 7;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(txtProductLoginUsername);
            Controls.Add(label1);
            Controls.Add(btnProductsInputsClear);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductUpdate);
            Controls.Add(btnProductCreate);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductName);
            Controls.Add(lstProducts);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed;
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductLoginUsername;
        private Label label1;
        private Button btnProductsInputsClear;
        private Button btnProductDelete;
        private Button btnProductUpdate;
        private Button btnProductCreate;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private ListBox lstProducts;
    }
}