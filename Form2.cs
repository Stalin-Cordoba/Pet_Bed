using petbedcrack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petbed
{

    
    public partial class Form2 : Form
    {
        public int PerrosC = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private List<Cliente> clientes = new List<Cliente>();
        private int siguienteID = 1;

        [Serializable]


        public class Cliente
        {
            public int ID { get; set; }
            public string txtnombrecompleto { get; set; }
            public string txtcel { get; set; }
            public string txtemail { get; set; }
            public string txtdireccion { get; set; }
            public string txtcontacto { get; set; }
            public string txtnumperros { get; set; } 
            

        }

        public void GuardarDatos()
        {
            // Crear una instancia de la clase FormData
            Cliente Datos_Clientes = new Cliente
            {
                ID = siguienteID,
                txtnombrecompleto = txtnomb.Text ,
                txtcel = txttelefono.ToString() ,
                txtemail = txtemail.ToString() ,
                txtdireccion = txtdire.ToString() ,
                txtcontacto = txtctc1.ToString() ,
                txtnumperros = txtnumper.ToString() ,
                
            };

            // Crear un objeto BinaryFormatter para serializar los datos
            BinaryFormatter formatter = new BinaryFormatter();

            // Usar un archivo para guardar los datos
            using (FileStream stream = new FileStream("Datos_Clientes.bin", FileMode.Create))
            {
                formatter.Serialize(stream, Datos_Clientes); // Serializa el objeto 'data' y lo guarda en el archivo
            }

            
        }


        public void CargarDatos()
        {
            if (File.Exists("Datos_Clientes.bin"))
            {
                // Crear un objeto BinaryFormatter para deserializar los datos
                BinaryFormatter formatter = new BinaryFormatter();

                // Abrir el archivo donde se guardaron los datos
                using (FileStream stream = new FileStream("Datos_Clientes.bin", FileMode.Open))
                {
                    // Deserializar el archivo y convertirlo de nuevo a un objeto 'FormData'
                    Cliente data = (Cliente)formatter.Deserialize(stream);

                    // Restaurar los valores en los controles
                   siguienteID = data.ID;
                   txtnomb.Text = data.txtnombrecompleto;
                   txttelefono.Text = data.txtcel;
                   txtemail.Text = data.txtemail;
                   txtdire.Text = data.txtdireccion;
                   txtctc1.Text = data.txtcontacto;
                   txtnumper.Text = data.txtnumperros;

                    siguienteID = clientes.Count > 0 ? clientes[0].ID + 1 : 1;
                }

                MessageBox.Show("Datos cargados con éxito.");
            }
            else
            {
                MessageBox.Show("No se encontraron datos guardados.");
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int totalformularios;
        private int formularioscreados;



        private void registrar(object sender, EventArgs e)
        {
            //Verifica si todos los cuadros de texto están rellenados, en caso de que no lo estén, evitará que el usuario vaya al siguiente formulario
            if (!this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrEmpty(t.Text)) || !this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrWhiteSpace(t.Text)))
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else if (int.TryParse(txtnumper.Text, out totalformularios) && totalformularios > 0 && totalformularios <= 4) //Verifica si la cantidad de perros ingresada es correcta y adecuada
            {
                PerrosC = int.Parse(txtnumper.Text);
                crearformulario();
            }
            else if(!txtemail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese una dirección de correo válida");
            }
            else
            {
                MessageBox.Show("No puedes hospedar más de 4 perros");
            }
        }
        
        private void crearformulario()
        {
            Form DatosPerro = new Form3();
            this.Hide();
            DatosPerro.Show();
        }

        private void txtnumper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mostrar mensaje de error usando ErrorProvider
                errorProvider2.SetError(txtnumper, "Solo se permiten números");
                e.Handled = true; // Anula la tecla
            }
            else
            {
                // Limpiar el mensaje de error si la entrada es válida
                errorProvider2.SetError(txtnumper, "");
            }
        }

        private void txtnomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Anula la tecla para evitar que se muestre en el TextBox
                errorProvider3.SetError(txtnomb, "Solo se permiten letras");
                e.Handled = true;
                
            }
            else
            { 
                errorProvider3.SetError(txtnomb, "");
            
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtemail.Text.Contains("@"))
            {
                // Mostrar el error si no contiene '@' y '.com'
                errorProvider4.SetError(txtemail, "Ingrese un correo válido");
            }
            else
            {
                // Limpiar el mensaje de error si contiene '@' y '.com'
                errorProvider4.SetError(txtemail, "");
            }
        }

       
            
        private void bttContinuar (object sender, EventArgs e)
        {

                Form FechaSelección = new Form4();
                this.Hide();
                FechaSelección.Show();
        }
    }
}

