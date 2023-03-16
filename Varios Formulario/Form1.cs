using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varios_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor inserir um nome no campo!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            textBox2.Text = textBox1.Text + " ,"; //botao de mult texto
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            
        }

        private void btnSegundoform_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox2.Text); //  chama segundo formulario 
            form2.ShowDialog();

        }
    }
}
