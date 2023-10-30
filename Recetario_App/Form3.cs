using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recetario_App
{
    public partial class Form3 : Form
    {
        public Receta Receta { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        public void MostrarReceta()
        {
            if (Receta != null)
            {

                label3.Text = Receta.Nombre;
                labelDificultad.Text = "Dificultad: " + Receta.Dificultad;
                if (!string.IsNullOrEmpty(Receta.Img) && File.Exists(Receta.Img))
                {
                    using (Image image = Image.FromFile(Receta.Img))
                    {
                        // Configurar el tamaño del panel para que coincida con el tamaño de la imagen
                        panelIMG.Size = new Size(image.Width, image.Height);

                        // Asignar la imagen como fondo y configurar el diseño para que se ajuste al panel
                        panelIMG.BackgroundImage = new Bitmap(image);
                        panelIMG.BackgroundImageLayout = ImageLayout.Center;
                    }
                }

                // Mostrar ingredientes en textBox3 con saltos de línea
                textBoxIngedientes.Text = string.Join(Environment.NewLine, Receta.Ingredientes);

                // Mostrar pasos en textBox4 con saltos de línea
                textBoxPasos.Text = string.Join(Environment.NewLine, Receta.Pasos);
            }
        }
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
