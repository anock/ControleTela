using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTela
{
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {

        public Cadastro()
        {

            InitializeComponent();
            desliga();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDataSet.Table' table. You can move, or remove it, as needed.
          // this.tableTableAdapter.Fill(this.controleDataSet.Table);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //botao adiciona novos dados

            liga();
            txtModelo.Focus();
            this.Validate();
            this.tableBindingSource.AddNew();

            
           


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //botao deleta dados

            if (MessageBox.Show("Desja mesmo excluir ", "Excluir dados", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                txtModelo.Focus();
                this.Validate();
                this.tableBindingSource.RemoveCurrent();
                this.tableTableAdapter.Update(controleDataSet.Table);

            }
            else if (MessageBox.Show("Desja mesmo excluir ", "Excluir dados", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Dados não foram excluidos");
                txtModelo.Focus();
            }
           

           
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edita dados
            liga();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //botao salvar dados
            try
            {
                quantidadeTotal();
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableTableAdapter.Update(controleDataSet.Table);
                txtModelo.Focus();
                MessageBox.Show("Dados salvos com Sucesso ");
                desliga();
            }
            catch
            {
                MessageBox.Show("Erro em salvar ", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
         

        }


        public void quantidadeTotal() // mostra a quantidade total em estoque 
        {
            int azul = int.Parse(txtAzul.Text);
            int preto = int.Parse(txtPreto.Text);
            int branco = int.Parse(txtBranco.Text);
            int dourado = int.Parse(txtDourado.Text);

            int soma = preto + azul + branco + dourado;

            LbSoma.Text = soma.ToString();


        }





        private void btnImagem_Click(object sender, EventArgs e)
        {
            //busca imagem e armazena no banco de dados

            openFileDialog1.ShowDialog();

            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            Bitmap bmp2 = new Bitmap(bmp, picImagem.Size);

            picImagem.Image = bmp2;
            picImagem.Image.Save(Application.StartupPath.ToString() + "\\imagensTelas\\" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            this.Validate();
            this.tableBindingSource.EndEdit();

        }

        //desativa a esntrada de dados
        public void desliga()
        {
            txtAzul.Enabled = false;
            txtBranco.Enabled = false;
            txtCompra.Enabled = false;
            txtDourado.Enabled = false;
            txtModelo.Enabled = false;
            txtPreto.Enabled = false;
            LbSoma.Enabled = false;
            txtVenda.Enabled = false;
            btnImagem.Enabled = false;
            txtData.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSalvar.Enabled = false;
            //metroButton1.Enabled = false;
            //TxtBusca.Enabled = false;

        }
        //ativa a entrada de dados
        public void liga()
        {
            txtAzul.Enabled = true;
            txtBranco.Enabled = true;
            txtCompra.Enabled = true;
            txtDourado.Enabled = true;
            txtModelo.Enabled = true;
            txtPreto.Enabled = true;
            LbSoma.Enabled = true;
            txtVenda.Enabled = true;
            btnImagem.Enabled = true;
            txtData.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSalvar.Enabled = true;
            //metroButton1.Enabled = true;
            //TxtBusca.Enabled = true;


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TxtBusca.Text != "")
            {
                tableTableAdapter.FillBy(controleDataSet.Table, TxtBusca.Text);


            }
            else if (TxtBusca.Text == "")
            {
                MessageBox.Show("Favor digitar o modelo");

            }
        }
    }
}
