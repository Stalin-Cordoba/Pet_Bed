using petbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petbedcrack
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void FinalizarReserva_Click(object sender, EventArgs e)
        {
            Form Inicio = new Form1();
            this.Close();
            Inicio.Show();
        }
    }
}
