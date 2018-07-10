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

namespace ControleTela
{
    public partial class estoque : MetroFramework.Forms.MetroForm
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDataSet1.Table' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'controleDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.controleDataSet.Table);
           

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                tableTableAdapter.FillBy(controleDataSet.Table, txtBuscar.Text);
               
                
            }
            else if (txtBuscar.Text == "")
            {
                this.tableTableAdapter.Fill(this.controleDataSet.Table);

            }
           
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy1(this.controleDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
