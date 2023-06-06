using CalcularFrete.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete.View
{
    public partial class TelaFrete : Form
    {   
        Frete frete = new Frete();

        public TelaFrete()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            if (cbUF.Text == string.Empty || txtValor.Text == string.Empty || txtCliente.Text == string.Empty)
            {
                MessageBox.Show ("Alguns campos não foram preenchidos","Atenção");
            }
            else
            {
                string uf = cbUF.Text;
                decimal v = Convert.ToDecimal(txtValor.Text);
                decimal vfrete = frete.Calcular(uf, v);
                decimal total = vfrete + v;

                decimal uffrete = (vfrete / total);

                txtFrete.Text = uffrete.ToString("P1");

                lbResultado.Text = "Estado: " + uf + "\nValor do Produto: R$ " + v + "\nValor Frete: R$ " + vfrete + "\nValor Total: R$ " + total.ToString("N2");
            }


        }
    }
}
