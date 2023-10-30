using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace Recetario_App
{
    public partial class Form2 : Form
    {
        public Receta Receta { get; set; }
        public string nombreReceta;
        public string fileJSon = @"C:\Users\Nitag\Documents\Trabajos amor\Recetario\Recetas.json";
        public Form2()
        {
            InitializeComponent();
        }

        // que boton se oprime

        public bool MostrarBoton2
        {
            get { return buttonAgregarReceta.Visible; }
            set { buttonAgregarReceta.Visible = value; }
        }

        public bool MostrarBoton1
        {
            get { return buttonModificarReceta.Visible; }
            set { buttonModificarReceta.Visible = value; }
        }

        public void MostrarReceta()
        {
            if (Receta != null)
            {
                // Rellenar los controles en Form2 con los datos de Receta
                textBox1.Text = Receta.Nombre;
                nombreReceta = Receta.Nombre;
                comboBox1.Text = Receta.Dificultad;
                label6.Text = Receta.Img;

                // Mostrar ingredientes en textBox3 con saltos de línea
                textBox3.Text = string.Join(Environment.NewLine, Receta.Ingredientes);

                // Mostrar pasos en textBox4 con saltos de línea
                textBox4.Text = string.Join(Environment.NewLine, Receta.Pasos);

            }
        }

        public Receta receta = new Receta();

        private void buttonAgregarReceta_Click(object sender, EventArgs e)
        {
            receta.Nombre = textBox1.Text;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una dificultad antes de agregar la receta.");
                return; // Salir de la función
            }
            else
            {
                receta.Dificultad = comboBox1.SelectedItem.ToString();
            }
            receta.Img = label6.Text;
            // Divide el texto de los TextBox en líneas y crea listas a partir de ellas
            receta.Ingredientes = textBox3.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            receta.Pasos = textBox4.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (label6.Text == "Cargar imagen")
            {
                MessageBox.Show("No se ha cargado ninguna imagen.");
                return; 
            }


            try
            {
                List<Receta> recetas;

                // Verifica si el archivo ya existe
                if (File.Exists(fileJSon))
                {
                    // Lee el contenido actual del archivo JSON
                    string contenido = File.ReadAllText(fileJSon);

                    // Deserializa el contenido en una lista de objetos Receta
                    recetas = JsonConvert.DeserializeObject<List<Receta>>(contenido);
                }
                else
                {
                    // Si el archivo no existe, crea una nueva lista
                    recetas = new List<Receta>();
                }

                // Agrega la nueva receta a la lista
                recetas.Add(receta);

                // Serializa la lista completa a JSON
                string recetasJson = JsonConvert.SerializeObject(recetas, Formatting.Indented);

                // Escribe la lista en el archivo
                File.WriteAllText(fileJSon, recetasJson);

                MessageBox.Show("Receta agregada a Recetas.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la receta: " + ex.Message);
            }
        }



        private void buttonModificarReceta_Click(object sender, EventArgs e)
        {
            // Asegúrate de que tengas los datos de la receta a modificar en las variables apropiadas.
            string nombreRecetaModificar = nombreReceta; // Nombre actual
            string nuevoNombreReceta = textBox1.Text; // Nuevo nombre
            string dificultadRecetaModificar = comboBox1.SelectedItem.ToString();
            string imgruta = label6.Text;
            List<string> ingredientesRecetaModificar = textBox3.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> pasosRecetaModificar = textBox4.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();


            try
            {
                List<Receta> recetas;

                // Verifica si el archivo ya existe
                if (File.Exists(fileJSon))
                {
                    // Lee el contenido actual del archivo JSON
                    string contenido = File.ReadAllText(fileJSon);

                    // Deserializa el contenido en una lista de objetos Receta
                    recetas = JsonConvert.DeserializeObject<List<Receta>>(contenido);

                    // Busca la receta que deseas modificar por el nombre actual
                    Receta recetaAModificar = recetas.FirstOrDefault(r => r.Nombre == nombreRecetaModificar);

                    if (recetaAModificar != null)
                    {
                        // Actualiza los datos de la receta
                        recetaAModificar.Nombre = nuevoNombreReceta; // Modifica el nombre
                        recetaAModificar.Dificultad = dificultadRecetaModificar;
                        recetaAModificar.Img = imgruta;
                        recetaAModificar.Ingredientes = ingredientesRecetaModificar;
                        recetaAModificar.Pasos = pasosRecetaModificar;

                        // Serializa la lista completa a JSON
                        string recetasJson = JsonConvert.SerializeObject(recetas, Formatting.Indented);

                        // Escribe la lista en el archivo
                        File.WriteAllText(fileJSon, recetasJson);

                        MessageBox.Show("Receta modificada en Recetas.json");
                    }
                    else
                    {
                        MessageBox.Show("Receta no encontrada en la lista. Verifica el nombre actual.");
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de recetas no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la receta: " + ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de diálogo para seleccionar una imagen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configura el cuadro de diálogo
                openFileDialog.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                openFileDialog.Title = "Selecciona una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo de imagen seleccionado
                    string rutaImagen = openFileDialog.FileName;
                    label6.Text = rutaImagen;
                }
            }
        }

    }
}
