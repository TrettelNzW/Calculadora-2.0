using System;
using System.Windows.Forms;
using Calculadora.Modelo;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            if (controle.Validar())
            {
                controle.Executar("+");
                lblResultado.Text = controle.Mensagem.Equals("") ? controle.Resultado : controle.Mensagem;
            }
            else
            {
                lblResultado.Text = controle.Mensagem;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
