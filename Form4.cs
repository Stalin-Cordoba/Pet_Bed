using petbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petbedcrack
{


    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            fecha.fechaEntrada = dtpentrada.Value;
           fecha.fechaSalida = dtpsalida.Value;
            
            dtpentrada.MinDate = DateTime.Today;
            dtpsalida.MinDate = DateTime.Today;

        }

        public RadioButton HGRANDE => rbttgrande;
        public RadioButton HNORMAL => rbttnormal;
        public RadioButton HVIP => rbttvip;

        public DateTimePicker fentrada => dtpentrada;
        public DateTimePicker fsalida => dtpsalida;


        public void dtphospedaje_ValueChanged(object sender, EventArgs e)
        {
            if (dtpentrada.Value.Date < dtpsalida.Value)
            {

                if (fecha.fechaEntrada == default || fecha.fechaSalida == default)
                {
                    MessageBox.Show("Las fechas no se han configurado correctamente en el Form4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        public void dtpsalida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpsalida.Value < dtpentrada.Value)
            {
                dtpentrada.Value = dtpsalida.Value;
                if (fecha.fechaEntrada == default || fecha.fechaSalida == default)
                {
                    MessageBox.Show("Las fechas no se han configurado correctamente en el Form4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Inicio = new Form1();
            this.Hide();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!groupBox1.Controls.OfType<RadioButton>().Any(r => r.Checked))
            {
                MessageBox.Show("Seleccione el tipo de comodidad");
            }
            else if (!groupBox2.Controls.OfType<RadioButton>().Any(r => r.Checked))
            {
                MessageBox.Show("Seleccione el tamaño de la cama");
            }
            else if (!groupBox3.Controls.OfType<RadioButton>().Any(r => r.Checked))
            {
                MessageBox.Show("Seleccione el método de pago");
            }
            else
            {
                if (rbttcredito.Checked || rbttdebito.Checked)
                {
                    Form DatosTarjeta = new Form7();
                    this.Hide();
                    DatosTarjeta.Show();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Text = "Datos del Cliente";
                    form2.Size = new System.Drawing.Size(616, 405);
                    this.Hide();
                    form2.Show();
                }
            }
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
