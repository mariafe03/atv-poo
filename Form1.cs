using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C38Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtquantid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string cliente = txtcliente.Text;
            int quantid = int.Parse(txtquantid.Text);
            double valor = 0;
            double valortotal = 0;
            double desconto = 0;

            if (quantid <= 0)
            {
                MessageBox.Show("Por favor, digite uma quantidade válida");
            }
            else
            {
                if (quantid > 0 && quantid <= 10)
                {
                    valor = quantid * 1.99;
                    lblvalor.Text = valor.ToString("C");
                    lbldesconto.Text = "Que pena! Você não recebeu nenhum desconto.";
                    lblvalortotal.Text = valor.ToString("C");
                    lblcliente.Text = "Agradecemos sua compra, " + cliente + "!";
                    lblvolte.Text = "Volte sempre";
                }
                else if (quantid > 10 && quantid < 26)
                {
                    valor = quantid * 1.99;
                    lblvalor.Text = valor.ToString("C");
                    desconto = valor * 0.05;
                    lbldesconto.Text = "Você recebeu um desconto de 5%, economizou " + desconto.ToString("C");
                    valortotal = valor - desconto;
                    lblvalortotal.Text = valortotal.ToString("C");
                    lblcliente.Text = "Agradecemos sua compra, " + cliente + "!";
                    lblvolte.Text = "Volte sempre";
                }
                else
                {
                    valor = quantid * 1.99;
                    lblvalor.Text = valor.ToString("C");
                    desconto = valor * 0.08;
                    lbldesconto.Text = "Você recebeu um desconto de 8%, economizou " + desconto.ToString("C");
                    valortotal = valor - desconto;
                    lblvalortotal.Text = valortotal.ToString("C");
                    lblcliente.Text = "Agradecemos sua compra, " + cliente + "!";
                    lblvolte.Text = "Volte sempre";
                }
            }
        }

    }
}
