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




namespace Recetario_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // que boton se oprime

        public bool MostrarBoton2
        {
            get { return button2.Visible; }
            set { button2.Visible = value; }
        }

        public bool MostrarBoton1
        {
            get { return button1.Visible; }
            set { button1.Visible = value; }
        }

        public Receta receta = new Receta();

        private void button2_Click(object sender, EventArgs e)
        {
            receta.Nombre = textBox1.Text;
            receta.Dificultad = comboBox1.SelectedItem.ToString();

            // Divide el texto de los TextBox en líneas y crea listas a partir de ellas
            receta.Ingredientes = textBox3.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            receta.Pasos = textBox4.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string rutaArchivo = @"C:\Users\Rame\Desktop\Recetario\Recetas.json";

            try
            {
                List<Receta> recetas;

                // Verifica si el archivo ya existe
                if (File.Exists(rutaArchivo))
                {
                    // Lee el contenido actual del archivo JSON
                    string contenido = File.ReadAllText(rutaArchivo);

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
                File.WriteAllText(rutaArchivo, recetasJson);

                MessageBox.Show("Receta agregada a Recetas.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la receta: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
