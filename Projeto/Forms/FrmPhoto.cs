using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;
using System.Diagnostics;

namespace Projeto.Forms
{
    public partial class FrmPhoto : Form
    {
        public FrmPhoto()
        {
            InitializeComponent();
            
        }

        string _sql = "SERVER=localhost;DATABASE=projeto;UID=root;PASSWORD= ;";

        public static string id;

        private void tema()
        {
            foreach (Control btn in this.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    Button btns = (Button)btn;
                    btns.BackColor = cores.primaria;
                    btns.ForeColor = Color.White;
                    btns.FlatAppearance.BorderColor = cores.secundaria;
                }
            }
        }

        void CarregarCombo()
        {
            string sql = "select id_produto, nome_produto from produto";

            MySqlConnection praonde = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(sql, praonde);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;

            DataTable tabela = new DataTable();

            praonde.Open();

            try
            {
                reader = cmd.ExecuteReader();

                tabela.Load(reader);
                cboProdutos.DisplayMember = "nome_produto";
                cboProdutos.DataSource = tabela;

                cboCodeFK.DisplayMember = "id_produto";
                cboCodeFK.DataSource = tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.ToString());
                Application.Exit();
            }
            finally
            {
                praonde.Close();
            }
        }

        private void FrmPhoto_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            tema();
            list();
        }

        private void btoPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JPG Files(*.jpg)| *.jpg|PNG Files(*.png)| *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                
                pictureBox1.ImageLocation = foto;


            }
        }

        private void list()
        {
            
            string query = "SELECT caminho_fotoproduto from fotoproduto where id_produto =  " + cboCodeFK.Text;
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;



            try
            {
                my.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string pasta = "A:/xampp/htdocs/alone/img/" + cboCodeFK.Text + "/";
                    ltPhoto.Items.Add(rd.GetString(0));
                   
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                my.Close();
            }
        }

        private void btoInserir_Click(object sender, EventArgs e)
        {
            string sintax = "insert into fotoproduto (id_produto,caminho_fotoproduto) values (@id,@foto)";
            

            MySqlConnection conexao = new MySqlConnection(_sql);

            MySqlCommand cmd = new MySqlCommand(sintax, conexao);
            MySqlDataReader reader;
            if (pictureBox1.ImageLocation == "")
            {
                MessageBox.Show("Insira uma foto");
                return;
            }
            try
            {

                conexao.Open();
                
                cmd.Parameters.Add(new MySqlParameter("@id", cboCodeFK.Text));
                cmd.Parameters.Add(new MySqlParameter("@foto", System.IO.Path.GetFileName(pictureBox1.ImageLocation)));
                string pasta = "A:/xampp/htdocs/alone/img/" + cboCodeFK.Text + "/";
                reader = cmd.ExecuteReader();
                if (!File.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }
                System.IO.File.Copy(pictureBox1.ImageLocation, pasta + System.IO.Path.GetFileName(pictureBox1.ImageLocation));
                MessageBox.Show("Imagem inserida com sucesso");
            }
            catch (MySqlException E)
            {
                switch (E.Number)
                {
                    case 1048:
                        MessageBox.Show("Insira uma foto");
                        break;

                }
            }
            finally
            {
                conexao.Close();
               
                pictureBox1.ImageLocation = "";
                ltPhoto.Items.Clear();
                ltPhoto.Visible = true;
                list();
            }
        }

       

        

        private void cboProdutos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ltPhoto.Items.Clear();
            list();
        }

        private void cboProdutos_Click(object sender, EventArgs e)
        {
            ltPhoto.Visible = false;

        }

        private void btoLoad_Click(object sender, EventArgs e)
        {
            ltPhoto.Items.Clear();
            list();
            ltPhoto.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = "A:/xampp/htdocs/alone/img/" + cboCodeFK.Text + "/";

            
            if (!File.Exists(pasta))
            {
               
                if(ltPhoto.SelectedIndex > -1)
                {
                    Process.Start(pasta + ltPhoto.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecione uma foto");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma foto");

            }
          
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string query = "delete from fotoproduto where id_produto = ' " + cboCodeFK.Text + "' and caminho_fotoproduto = '" + ltPhoto.SelectedItem + "'";
            MySqlConnection my = new MySqlConnection(_sql);
            MySqlCommand cmd = new MySqlCommand(query, my);
            cmd.CommandType = CommandType.Text;
            string pasta = "A:/xampp/htdocs/alone/img/" + cboCodeFK.Text + "/";


            try
            {
                my.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Foto deletado com sucesso");
                    System.IO.File.Delete(pasta + ltPhoto.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecione a foto");
                }
            }
            catch (MySqlException ex)
            {

                if (ex.Number == 1064)
                {
                    MessageBox.Show("Insira uma categoria para deletar");
                    return;
                }
            }
            finally
            {
                
                ltPhoto.Items.Clear();
                list();
            }
        }

        private void cboProdutos_MouseHover(object sender, EventArgs e)
        {
            ltPhoto.Visible = false;
        }

        private void ltPhoto_SelectedValueChanged(object sender, EventArgs e)
        {
            string pasta = "A:/xampp/htdocs/alone/img/" + cboCodeFK.Text + "/";


            if (File.Exists(pasta))
            {
                Process.Start(pasta + ltPhoto.SelectedItem);
            }
        }

        private void cboProdutos_DropDown(object sender, EventArgs e)
        {
            ltPhoto.Visible = false;
        }
    }
}
