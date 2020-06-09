using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num;
            float.TryParse(txtNum.Text, out num);
            lbl2.Text = ($"Você digitou o valor {num:N3}");

            int n1 = (int) num; // Pega somente a parte inteira do número
            lbl3.Text = ($"A parte inteira é {n1}");

            int n2 = Convert.ToInt16(num);// Arredonda o número para o número inteiro mais próximo
            lbl4.Text = ($"Arredondando, temos {n2}");
        }
    }
}
