using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesVirtuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDeletreo_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
   
            for (int i = 0; i < txtString.Text.Length; i++)
            {
                lblResultado.Text = lblResultado.Text + txtString.Text.Substring(i, 1) + "\n\r";             
            }
        }

        private void btMayuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToUpper(); 
        }

        private void btMinuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToLower();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.Replace(txtBuscar.Text, "");
        }

        private void btLongitud_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.Length.ToString();
        }

        private void btRemplazar_Click(object sender, EventArgs e)
        {
            if (txtRemplazo.Text == "")
            {
                lblResultado.Text = txtString.Text.Replace(txtBuscar.Text, "");
            }
            else
            {
                lblResultado.Text = txtString.Text.Replace(txtBuscar.Text, txtRemplazo.Text);
            }
        }
    }
}
