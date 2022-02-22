using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tListaSocios.Text += tNombre.Text + " " + tApellidos.Text + " " + tTelefono.Text + "\r\n";
            tNombre.Clear();
            tApellidos.Clear();
            tTelefono.Clear();
            tNombre.Focus();
        }
    }
}
