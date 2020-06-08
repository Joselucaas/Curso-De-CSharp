using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class Brasil : Form
    {
        public Brasil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            await Task.Delay(1000);
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;

            await Task.Delay(1000);
            label2.BackColor = Color.Yellow;
            label2.ForeColor = Color.Green;

            await Task.Delay(1000);
            label3.BackColor = Color.Green;
            label3.ForeColor = Color.Yellow;
        }
    }
}
