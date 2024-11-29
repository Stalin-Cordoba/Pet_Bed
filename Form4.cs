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
            dtpentrada.ValueChanged += (s, e) => CalcularCosto();
            dtpsalida.ValueChanged += (s, e) => CalcularCosto();
            rbttnormal.CheckedChanged += (s, e) => CalcularCosto();
            rbttgrande.CheckedChanged += (s, e) => CalcularCosto();
            rbttvip.CheckedChanged += (s, e) => CalcularCosto();


            dtpentrada.MinDate = DateTime.Today;
            dtpsalida.MinDate = dtpentrada.Value;

        }

        public RadioButton HGRANDE => rbttgrande;
        public RadioButton HNORMAL => rbttnormal;
        public RadioButton HVIP => rbttvip;

        int cantidadDias;

        private void CalcularCosto()
        {

            DateTime fechaEntrada = dtpentrada.Value.Date;
            DateTime fechaSalida = dtpsalida.Value.Date;

            // Validar que la fecha de salida sea posterior a la de entrada
            if (fechaSalida <= fechaEntrada)
            {
                txtcostototal.Text = "Costo Total: ";
                return;
            }

            // Calcular la cantidad de días
            cantidadDias = (fechaSalida - fechaEntrada).Days;

            // Determinar el costo diario según el RadioButton seleccionado
            int costoDiario = 0;
            if (rbttnormal.Checked)
            {
                costoDiario = 15;
            }
            else if (rbttgrande.Checked)
            {
                costoDiario = 20;
            }
            else if (rbttvip.Checked)
            {
                costoDiario = 25;
            }
            else
            {
                txtcostototal.Text = "Costo Total:";
                return;
            }

            // Calcular el costo total
            int costoTotal = costoDiario * cantidadDias;

            // Mostrar el resultado en el Label
            txtcostototal.Text = $"Costo Total: ${costoTotal}";

        }



        public void dtphospedaje_ValueChanged(object sender, EventArgs e)
        {
            dtpsalida.MinDate = dtpentrada.Value;

        }

        public void dtpsalida_ValueChanged(object sender, EventArgs e)
        {
            
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

                    fecha.fechaEntrada = dtpentrada.Value.Date;
                    fecha.fechaSalida = dtpsalida.Value.Date;
                    dias.totaldias = cantidadDias;
                    dias.totalcosto = txtcostototal.Text;
                   
                    if (rbttcredito.Checked)
                    {
                        reserva.pago = rbttcredito.Text = "Tarjeta Crédito";

                    }

                    else if (rbttdebito.Checked)
                    {
                        reserva.pago = rbttdebito.Text = "Tarjeta Débito";
                    }
                    else
                    {
                        reserva.pago = rbttefectivo.Text = "Efectivo";
                    }


                    if (fecha.fechaSalida <= fecha.fechaEntrada)
                    {
                        MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

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

        private void txtcostototal_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
