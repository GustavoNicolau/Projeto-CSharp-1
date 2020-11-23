namespace Projeto.Forms
{
    partial class FrmPhoto
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
            this.cboProdutos = new MetroFramework.Controls.MetroComboBox();
            this.cboCodeFK = new System.Windows.Forms.ComboBox();
            this.btoPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btoInserir = new System.Windows.Forms.Button();
            this.ltPhoto = new System.Windows.Forms.ListBox();
            this.btoLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProdutos
            // 
            this.cboProdutos.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.ItemHeight = 29;
            this.cboProdutos.Location = new System.Drawing.Point(105, 23);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(219, 35);
            this.cboProdutos.TabIndex = 0;
            this.cboProdutos.UseSelectable = true;
            this.cboProdutos.DropDown += new System.EventHandler(this.cboProdutos_DropDown);
            this.cboProdutos.SelectionChangeCommitted += new System.EventHandler(this.cboProdutos_SelectionChangeCommitted);
            this.cboProdutos.Click += new System.EventHandler(this.cboProdutos_Click);
            this.cboProdutos.MouseHover += new System.EventHandler(this.cboProdutos_MouseHover);
            // 
            // cboCodeFK
            // 
            this.cboCodeFK.FormattingEnabled = true;
            this.cboCodeFK.Location = new System.Drawing.Point(477, 23);
            this.cboCodeFK.Name = "cboCodeFK";
            this.cboCodeFK.Size = new System.Drawing.Size(371, 21);
            this.cboCodeFK.TabIndex = 1;
            this.cboCodeFK.Visible = false;
            // 
            // btoPhoto
            // 
            this.btoPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoPhoto.Location = new System.Drawing.Point(12, 465);
            this.btoPhoto.Name = "btoPhoto";
            this.btoPhoto.Size = new System.Drawing.Size(167, 64);
            this.btoPhoto.TabIndex = 2;
            this.btoPhoto.Text = "Selecionar Foto";
            this.btoPhoto.UseVisualStyleBackColor = true;
            this.btoPhoto.Click += new System.EventHandler(this.btoPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btoInserir
            // 
            this.btoInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoInserir.Location = new System.Drawing.Point(207, 465);
            this.btoInserir.Name = "btoInserir";
            this.btoInserir.Size = new System.Drawing.Size(167, 64);
            this.btoInserir.TabIndex = 4;
            this.btoInserir.Text = "Adicionar Foto";
            this.btoInserir.UseVisualStyleBackColor = true;
            this.btoInserir.Click += new System.EventHandler(this.btoInserir_Click);
            // 
            // ltPhoto
            // 
            this.ltPhoto.FormattingEnabled = true;
            this.ltPhoto.Location = new System.Drawing.Point(689, 72);
            this.ltPhoto.Name = "ltPhoto";
            this.ltPhoto.Size = new System.Drawing.Size(325, 355);
            this.ltPhoto.TabIndex = 5;
            this.ltPhoto.Visible = false;
            this.ltPhoto.SelectedValueChanged += new System.EventHandler(this.ltPhoto_SelectedValueChanged);
            // 
            // btoLoad
            // 
            this.btoLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoLoad.Location = new System.Drawing.Point(516, 183);
            this.btoLoad.Name = "btoLoad";
            this.btoLoad.Size = new System.Drawing.Size(150, 72);
            this.btoLoad.TabIndex = 6;
            this.btoLoad.Text = "Carregar Lista";
            this.btoLoad.UseVisualStyleBackColor = true;
            this.btoLoad.Click += new System.EventHandler(this.btoLoad_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "Abrir Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btoDel
            // 
            this.btoDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoDel.Location = new System.Drawing.Point(864, 457);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(150, 72);
            this.btoDel.TabIndex = 8;
            this.btoDel.Text = "Excluir Foto";
            this.btoDel.UseVisualStyleBackColor = true;
            this.btoDel.Click += new System.EventHandler(this.btoDel_Click);
            // 
            // FrmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 488);
            this.Controls.Add(this.btoDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btoLoad);
            this.Controls.Add(this.ltPhoto);
            this.Controls.Add(this.btoInserir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btoPhoto);
            this.Controls.Add(this.cboCodeFK);
            this.Controls.Add(this.cboProdutos);
            this.Name = "FrmPhoto";
            this.Text = "FOTOS";
            this.Load += new System.EventHandler(this.FrmPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboProdutos;
        private System.Windows.Forms.ComboBox cboCodeFK;
        private System.Windows.Forms.Button btoPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btoInserir;
        private System.Windows.Forms.ListBox ltPhoto;
        private System.Windows.Forms.Button btoLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btoDel;
    }
}