using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Recetario_App
{
    public partial class Recetario_App : Form
    {
        public Recetario_App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileJSon = @"C:\Users\Rame\Desktop\Recetario\Recetas.json"; // Asegúrate de que la ruta sea correcta y que estés apuntando a un archivo JSON válido
                List<Receta> recetas = JsonConvert.DeserializeObject<List<Receta>>(File.ReadAllText(fileJSon));

                // Borra todos los controles existentes en el Panel antes de agregar los nuevos
                recipePanel.Controls.Clear();

                int yPosition = 10; // La posición vertical inicial

                // Itera a través de las recetas
                foreach (Receta receta in recetas)
                {
                    // Crea etiquetas para mostrar los datos de la receta
                    Label nameLabel = new Label
                    {
                        Text = receta.Nombre,
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Location = new Point(10, yPosition)
                    };

                    yPosition += nameLabel.Height + 10;

                    Label difficultyLabel = new Label
                    {
                        Text = "Dificultad: " + receta.Dificultad,
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    yPosition += difficultyLabel.Height + 10;

                    Label ingredientsLabel = new Label
                    {
                        Text = "Ingredientes: " + string.Join(", ", receta.Ingredientes),
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    Label stepsLabel = new Label
                    {
                        Text = "Pasos: " + string.Join(", ", receta.Pasos),
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    Button detailsButton = new Button
                    {
                        Text = "Ver Detalles",
                        Tag = receta,
                        Location = new Point(10, yPosition)
                    };
                    detailsButton.Click += DetailsButton_Click;

                    yPosition += detailsButton.Height + 10;

                    recipePanel.Controls.Add(nameLabel);
                    recipePanel.Controls.Add(difficultyLabel);
                    recipePanel.Controls.Add(detailsButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Receta receta = (Receta)button.Tag;
            string recipeName = receta.Nombre;

            // Crear un mensaje con los ingredientes y pasos en líneas separadas
            string message = "Visualizando receta: " + recipeName + "\n\n";
            message += "Ingredientes:\n";
            message += string.Join("\n", receta.Ingredientes) + "\n\n";
            message += "Pasos:\n";
            message += string.Join("\n", receta.Pasos);

            // Mostrar el mensaje en un cuadro de diálogo
            MessageBox.Show(message, "Detalles de la Receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}


public class Receta
{
    public string Nombre { get; set; }
    public string Dificultad { get; set; }
    public List<string> Ingredientes { get; set; }
    public List<string> Pasos { get; set; }

}

