using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                        // Configurar el tamaño del panel para que coincida con el tamaño deseado
                        panelIMG.Size = new Size(300, 300); // Puedes ajustar el tamaño según tus necesidades

                        // Escalar la imagen al tamaño del panel
                        Image scaledImage = ScaleImage(image, panelIMG.Size);

                        // Asignar la imagen escalada como fondo y configurar el diseño para que se ajuste al panel
                        panelIMG.BackgroundImage = new Bitmap(scaledImage);
                        panelIMG.BackgroundImageLayout = ImageLayout.Center;
                    }
                }

                // Mostrar ingredientes en textBox3 con saltos de línea
                textBoxIngedientes.Text = string.Join(Environment.NewLine, Receta.Ingredientes);

                // Mostrar pasos en textBox4 con saltos de línea
                textBoxPasos.Text = string.Join(Environment.NewLine, Receta.Pasos);
            }
        }

        private Image ScaleImage(Image image, Size newSize)
        {
            if (image == null || newSize.Width <= 0 || newSize.Height <= 0)
            {
                return null;
            }

            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return newImage;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
