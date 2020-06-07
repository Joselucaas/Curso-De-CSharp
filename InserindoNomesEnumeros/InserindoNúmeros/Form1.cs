using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserindoNomesEnumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int a = 0;
            int.TryParse(txtNum.Text, out a);  // int a = Convert.ToInt32(txtNum.Text);
            int d = a * 2;
            lblMsg.Text = "O dobro de " + a + " é igual a " + d;
            lblMsg.Visible = true;
        }
    }
  
}