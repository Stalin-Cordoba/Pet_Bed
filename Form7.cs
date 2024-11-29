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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("La tarjeta ya caducó");
            }
            else if((!this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrEmpty(t.Text)) || !this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrWhiteSpace(t.Text))))
            {
                MessageBox.Show("Rellene los campos que faltan");
            }
            else if (!this.Controls.OfType<ComboBox>().All(E => !string.IsNullOrEmpty(E.Text)) || !this.Controls.OfType<ComboBox>().All(E => !string.IsNullOrWhiteSpace(E.Text)))
            {
                MessageBox.Show("Falta rellenar los cuadros de lista");
            }
            else
            {
                Form DatosCliente = new Form2();
                this.Close();
                DatosCliente.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FechaSelección = new Form4();
            this.Close();
            FechaSelección.Show();
        }

        private void NombreTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NombreCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
