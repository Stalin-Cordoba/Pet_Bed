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
    public partial class Form5 : Form
    {
       


        public Form5()
        {
            InitializeComponent();
        }

        public string NombreDueño
        {
            set { }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtingreso.Text = $"Fecha de Ingreso: {fecha.fechaEntrada.ToString("dd/MM/yyyy")}";
            txtsalida.Text = $"Fecha de Salida: {fecha.fechaSalida.ToString("dd/MM/yyyy")}";
            txtdias.Text = $"Dias Totales: {dias.totaldias.ToString()}";
            txtcostototal.Text = $"{dias.totalcosto.ToString()}";
            txtnombre.Text = $"Nombre: {reserva.nombre.ToString()}";  
            txtcel.Text = $"Teléfono: {reserva.telefono.ToString()}";
            txtcorreo.Text = $"Correo: {reserva.correo.ToString()}";
            txtdire.Text = $"Dirección: {reserva.direccion.ToString()}";
            txtcontacto.Text = $"Contacto: {reserva.contacto.ToString()}";  
            txtpago.Text = $"Método de Pago: {reserva.pago.ToString()}";
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reservar_Click(object sender, EventArgs e)
        {
            Form Final = new Form6();
            this.Close();
            Final.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form Inicio = new Form1();
            this.Close();
            Inicio.Show();
        }

        private void txtingreso_Click(object sender, EventArgs e)
        {

        }

        private void txtcostototal_Click(object sender, EventArgs e)
        {

        }
    }
}
