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
    public partial class Vendas : MetroFramework.Forms.MetroForm
    {




        public Vendas()
        {
            InitializeComponent();

        }

        private void txtModelo_Click(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDataSet.Table' table. You can move, or remove it, as needed.

            //this.tableTableAdapter.Fill(this.controleDataSet.Table);
            //tableTableAdapter.FillBy(controleDataSet.Table, txtModelo.Text);

        }



        private void Calcular_Click(object sender, EventArgs e)
        {

            valorTotal();

        }
        public void valorTotal()
        {  //calculo o  preco total 

            int b = int.Parse(txtBr.Text);
            int p = int.Parse(txtPt.Text);
            int d = int.Parse(txtDr.Text);
            int a = int.Parse(txtAz.Text);
            int preco = int.Parse(txtPreco.Text);

            int soma = a + b + d + p;

            int total = soma * preco;
            lbResultado.Text = total.ToString();

           
                
          

        }

        private void btnOk_Click(object sender, EventArgs e) // busca por nome 
        {

            tableTableAdapter.FillBy(controleDataSet.Table, txtModelo.Text);
        }

        private void btnFinaliza_Click(object sender, EventArgs e)//finaliza a venda 
        {


            baixaTotal();

            quantidadeTotal();
             
            this.Validate();
            this.tableBindingSource.EndEdit();
            tableTableAdapter.Update(this.controleDataSet.Table);

            MessageBox.Show("Venda efetuada com sucesso");

        }

        public void baixaTotal() // baixa o estoque por cor 
        {
            int azul = int.Parse(txtAzul.Text);
            int az = int.Parse(txtAz.Text);
            int diminuir = azul - az;
            txtAzul.Text = diminuir.ToString();


            int preto = int.Parse(txtPreto.Text);
            int pr = int.Parse(txtPt.Text);
            int diminuir1 = preto - pr;
            txtPreto.Text = diminuir1.ToString();



            int branco = int.Parse(txtBranco.Text);
            int br = int.Parse(txtBr.Text);
            int diminuir2 = branco - br;
            txtBranco.Text = diminuir2.ToString();



            int dourado = int.Parse(txtDourado.Text);
            int dr = int.Parse(txtDr.Text);
            int diminuir3 = dourado - dr;
            txtDourado.Text = diminuir3.ToString();




            //this.Validate();
            //this.tableBindingSource.EndEdit();
            //t/his.tableTableAdapter.Update(controleDataSet.Table);
        }


        public void quantidadeTotal() // mostra a quantidade total 
        {
            int azul = int.Parse(txtAzul.Text);
            int preto = int.Parse(txtPreto.Text);
            int branco = int.Parse(txtBranco.Text);
            int dourado = int.Parse(txtDourado.Text);

            int soma = preto + azul + branco + dourado;

            txtTotal.Text = soma.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }

}




