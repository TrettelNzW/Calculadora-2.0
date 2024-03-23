using System;
using System.Windows.Forms;
using Calculadora.Modelo;

namespace Calculadora
{
    partial class Form1 : Form
    {
        private TextBox txbPrimeiroNumero;
        private TextBox txbSegundoNumero;
        private Button btnSomar;
        private Label lblPrimeiroNumero;
        private Label lblSegundoNumero;
        private Label lblResultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txbPrimeiroNumero = new TextBox();
            txbSegundoNumero = new TextBox();
            btnSomar = new Button();
            lblPrimeiroNumero = new Label();
            lblSegundoNumero = new Label();
            lblResultado = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txbPrimeiroNumero
            // 
            txbPrimeiroNumero.Location = new Point(65, 98);
            txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            txbPrimeiroNumero.Size = new Size(171, 23);
            txbPrimeiroNumero.TabIndex = 0;
            // 
            // txbSegundoNumero
            // 
            txbSegundoNumero.Location = new Point(65, 168);
            txbSegundoNumero.Name = "txbSegundoNumero";
            txbSegundoNumero.Size = new Size(171, 23);
            txbSegundoNumero.TabIndex = 1;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(109, 266);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 3;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Location = new Point(65, 80);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(146, 15);
            lblPrimeiroNumero.TabIndex = 4;
            lblPrimeiroNumero.Text = "Digite o Primeiro Número:";
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Location = new Point(65, 150);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(148, 15);
            lblSegundoNumero.TabIndex = 5;
            lblSegundoNumero.Text = "Digite o Segundo Número:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(65, 337);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // button1
            // 
            button1.Location = new Point(65, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(161, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(65, 237);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(161, 237);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoNumero);
            Controls.Add(lblPrimeiroNumero);
            Controls.Add(btnSomar);
            Controls.Add(txbSegundoNumero);
            Controls.Add(txbPrimeiroNumero);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            if (controle.Validar())
            {
                controle.Executar("+"); // Você pode ajustar o operador conforme necessário
                lblResultado.Text = controle.Mensagem.Equals("") ? controle.Resultado : controle.Mensagem;
            }
            else
            {
                lblResultado.Text = controle.Mensagem;
            }
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}