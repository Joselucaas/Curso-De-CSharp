using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSortear_Click(object sender, EventArgs e)
        {
            int ini;
            int.TryParse(txt1.Text, out ini);

            int fim;
            int.TryParse(txt2.Text, out fim);

            lbl3.Visible = true;
            lbl3.Text = ($"Sorteando de {ini} a {fim}");

            Random sorteio = new Random();
            int num = sorteio.Next(ini, fim);

            await Task.Delay(1500);
            lbl3.Text = ($"O número {num} foi sorteado");


        }
    }
}
