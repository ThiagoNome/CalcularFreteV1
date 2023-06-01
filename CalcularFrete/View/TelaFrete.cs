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
            string uf = cbUF.Text;
            decimal v = Convert.ToDecimal(txtValor.Text);

            txtFrete.Text = frete.Calcular(uf, v).ToString();
            
        }
    }
}
