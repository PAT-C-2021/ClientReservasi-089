
namespace ClientReservasi_20190140089
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dtRegster = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(286, 75);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(187, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(642, 70);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(107, 36);
            this.buttonSimpan.TabIndex = 2;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(286, 141);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(187, 22);
            this.textBoxPass.TabIndex = 5;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "Admin",
            "Resepsionis"});
            this.comboBoxKategori.Location = new System.Drawing.Point(286, 209);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(187, 24);
            this.comboBoxKategori.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(642, 113);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(107, 36);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(642, 155);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(107, 36);
            this.buttonHapus.TabIndex = 9;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(642, 197);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 36);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dtRegster
            // 
            this.dtRegster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegster.Location = new System.Drawing.Point(60, 270);
            this.dtRegster.Name = "dtRegster";
            this.dtRegster.RowHeadersWidth = 51;
            this.dtRegster.RowTemplate.Height = 24;
            this.dtRegster.Size = new System.Drawing.Size(689, 168);
            this.dtRegster.TabIndex = 11;
            this.dtRegster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegster_CellClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(586, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(202, 22);
            this.textBoxID.TabIndex = 12;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dtRegster);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRegster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dtRegster;
        private System.Windows.Forms.TextBox textBoxID;
    }
}