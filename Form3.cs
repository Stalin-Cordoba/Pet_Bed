using petbedcrack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petbed
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public bool ImagenCargada = false;

        [Serializable]
        public class FormData
        {
            public int ID { get; set; }
            public string txtnombreperro { get; set; }
            public string cbxraza { get; set; }
            public string txtedad { get; set; }
            public string txtpeso { get; set; }
            public string cbxtamaño { get; set; }
            public string rbttcomportamiento { get; set; }
            public string rbttsexo { get; set; }
            public string txtinstrucciones { get; set; }
            public byte[] imagenperro { get; set; }
            public int clienteID { get; set; }

        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            if (imagen == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ConvertirBytesAImagen(byte[] bytesImagen)
        {
            if (bytesImagen == null)
                return null;

            using (MemoryStream ms = new MemoryStream(bytesImagen))
            {
                return Image.FromStream(ms);
            }
        }



        public void GuardarDatos(RadioButton rbttdocil1, RadioButton rbttagresi1, ComboBox cbxtamaño1, ComboBox cbxraza1, PictureBox imagenperro1)
        {
            // Crear una instancia de la clase FormData
            FormData Datos_Perros = new FormData
            {
                txtnombreperro = txtnombreperro.Text,
                cbxraza = cbxraza.SelectedItem?.ToString(),
                txtedad = txtedad.Text,
                txtpeso = txtpeso.Text,
                cbxtamaño = cbxtamaño.SelectedItem?.ToString(),
                rbttcomportamiento = rbttdocil.Checked ? "Dócil" : rbttagresi.Checked ? "Agresivo" : null,
                rbttsexo = rbttmacho.Checked ? "Macho" : rbtthembra.Checked ? "Hembra" : null,
                txtinstrucciones = txtespecial.Text, 
                imagenperro = ConvertirImagenABytes(imagenperro.Image)
                

            };
            // Crear un objeto BinaryFormatter para serializar los datos
            BinaryFormatter formatter = new BinaryFormatter();

            // Usar un archivo para guardar los datos
            using (FileStream stream = new FileStream("Datos_Perros.bin", FileMode.Create))
            {
                formatter.Serialize(stream, Datos_Perros); // Serializa el objeto 'data' y lo guarda en el archivo
            }

            
        }


        public void CargarDatos(RadioButton rbttdocil1, RadioButton rbttagresi1, ComboBox cbxtamaño1, ComboBox cbxraza1, PictureBox imagenperro1)
        {
            if (File.Exists("Datos_Perros.bin"))
            {
                // Crear un objeto BinaryFormatter para deserializar los datos
                BinaryFormatter formatter = new BinaryFormatter();

                // Abrir el archivo donde se guardaron los datos
                using (FileStream stream = new FileStream("Datos_Perros.bin", FileMode.Open))
                {
                    // Deserializar el archivo y convertirlo de nuevo a un objeto 'FormData'
                    FormData data = (FormData)formatter.Deserialize(stream);

                    // Restaurar los valores en los controles
                    txtnombreperro.Text = data.txtnombreperro;
                    cbxraza.Text = data.cbxraza;
                    txtedad.Text = data.txtedad;
                    txtpeso.Text = data.txtpeso;
                    cbxtamaño.Text = data.cbxtamaño;
                    txtespecial.Text = data.txtinstrucciones;
                    

                    if (!string.IsNullOrEmpty(data.cbxtamaño) && cbxtamaño.Items.Contains(data.cbxtamaño))
                    {
                        cbxtamaño.SelectedItem = data.cbxtamaño;
                    }


                    if (data.rbttsexo == "Macho")
                    {
                        rbttmacho.Checked = true;
                    }
                    else if (data.rbttsexo == "Hembra")
                    {
                        rbtthembra.Checked = true;
                    }

                    if (data.rbttcomportamiento == "Dócil")
                    {
                        rbttdocil.Checked = true;
                    }
                    else if (data.rbttcomportamiento == "Agresivo")
                    {
                        rbttagresi.Checked = true;
                    }

                    imagenperro.Image = ConvertirBytesAImagen(data.imagenperro);


                    MessageBox.Show("Datos cargados con éxito.");
                }

                
            }
            else
            {
                MessageBox.Show("No se encontraron datos guardados.");
            }


        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttsubirimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer los filtros para solo mostrar imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                imagenperro.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                ImagenCargada = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrEmpty(t.Text)) || !this.Controls.OfType<System.Windows.Forms.TextBox>().All(t => !string.IsNullOrWhiteSpace(t.Text))))
            {
                MessageBox.Show("Rellene los campos que faltan");
            }
            else if(!ImagenCargada)
            {
                MessageBox.Show("Suba una imagen de su perro");
            }
            else if(!groupBox1.Controls.OfType<RadioButton>().Any(s => s.Checked))
            {
                MessageBox.Show("Marque las opciones que faltan");
            }
            else if(!this.Controls.OfType<RadioButton>().Any(s => s.Checked))
            {
                MessageBox.Show("Marque las opciones que faltan");
            }
            else if(!this.Controls.OfType<ComboBox>().All(E => !string.IsNullOrEmpty(E.Text)) || !this.Controls.OfType<ComboBox>().All(E => !string.IsNullOrWhiteSpace(E.Text)))
            {
                MessageBox.Show("Falta rellenar los cuadros de lista");
            }
            else
            {
                GuardarDatos(rbttdocil, rbttagresi, cbxtamaño, cbxraza, imagenperro);
                Form Confirmación = new Form6();
                this.Hide();
                Confirmación.Show();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void imagenperro_Click(object sender, EventArgs e)
        {

        }

        private void txtraza_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form DatosCliente = new Form2();
            this.Hide();
            DatosCliente.Show();
        }
    }

}

