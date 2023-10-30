using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Recetario_App
{
    public partial class Recetario_App : Form
    {

        public Recetario_App()
        {
            InitializeComponent();
        }
        public string fileJSon = @"C:\Users\Nitag\Documents\Trabajos amor\Recetario\Recetas.json";
        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            checkBoxFacil.Checked = false;
            checkBoxIntermedio.Checked = false;
            checkBoxDificil.Checked = false;

            try
            {
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
                        Text = "Ingredientes: " + string.Join(", ", receta.Ingredientes)
                    };

                    Label stepsLabel = new Label
                    {
                        Text = "Pasos: " + string.Join(", ", receta.Pasos),
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    Label img = new Label
                    {
                        Text = receta.Img,
                    };

                    Button detailsButton = new Button
                    {
                        Text = "Receta",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    Button modifyButton = new Button
                    {
                        Text = "Modificar",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(95, yPosition)
                    };

                    Button deleteButton = new Button
                    {
                        Text = "Eliminar",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(180, yPosition)
                    };

                    detailsButton.Click += DetailsButton_Click;
                    modifyButton.Click += modifyButton_Click;
                    deleteButton.Click += deleteButton_Click;




                    yPosition += detailsButton.Height + 10;

                    recipePanel.Controls.Add(nameLabel);
                    recipePanel.Controls.Add(difficultyLabel);
                    recipePanel.Controls.Add(detailsButton);
                    recipePanel.Controls.Add(modifyButton);
                    recipePanel.Controls.Add(deleteButton);


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
            // Crea una instancia de Form2
            Form3 form3 = new Form3();

            form3.Receta = receta;
            form3.MostrarReceta();
            form3.Show();

        }

        //mofificar receta
        private void modifyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Receta receta = (Receta)button.Tag;

            // Crea una instancia de Form2
            Form2 form2 = new Form2();
            form2.MostrarBoton1 = true;
            form2.MostrarBoton2 = false;

            form2.Receta = receta; // Pasa la receta a Form2
            form2.MostrarReceta(); // Llena los controles en Form2
            form2.Show();

        }


        //agregar receta
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MostrarBoton1 = false;
            form2.MostrarBoton2 = true;
            form2.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Obtén la receta que deseas eliminar del botón presionado.
            Button button = (Button)sender;
            Receta recetaEliminar = (Receta)button.Tag;

            // Carga todas las recetas desde el archivo JSON en una lista.

            List<Receta> recetas;

            try
            {
                if (File.Exists(fileJSon))
                {
                    string contenido = File.ReadAllText(fileJSon);
                    recetas = JsonConvert.DeserializeObject<List<Receta>>(contenido);

                    // Utiliza un bucle foreach para encontrar y eliminar la receta deseada
                    foreach (Receta receta in recetas)
                    {
                        if (receta.Nombre == recetaEliminar.Nombre)
                        {
                            recetaEliminar = receta;
                            break; // Rompe el bucle una vez que se encuentra la receta
                        }
                    }

                    if (recetaEliminar != null)
                    {
                        // Muestra un cuadro de diálogo para confirmar la eliminación
                        DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar esta receta?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            recetas.Remove(recetaEliminar); // Elimina la receta de la lista
                            string recetasJson = JsonConvert.SerializeObject(recetas, Formatting.Indented);

                            File.WriteAllText(fileJSon, recetasJson); // Sobrescribe el archivo JSON con la lista actualizada

                            MessageBox.Show("Receta eliminada de Recetas.json");
                        }
                        else
                        {
                            MessageBox.Show("La eliminación de la receta fue cancelada.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Receta no encontrada en la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de recetas no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la receta: " + ex.Message);
            }

        }


        private void FiltrarRecetas()
        {
            try
            {
                List<Receta> recetas = JsonConvert.DeserializeObject<List<Receta>>(File.ReadAllText(fileJSon));

                List<Receta> recetasFiltradas = new List<Receta>();

                foreach (Receta receta in recetas)
                {
                    if ((checkBoxFacil.Checked && receta.Dificultad == "Fácil") ||
                    (checkBoxIntermedio.Checked && receta.Dificultad == "Intermedio") ||
                        (checkBoxDificil.Checked && receta.Dificultad == "Difícil"))
                    {
                        recetasFiltradas.Add(receta);
                    }
                }
                // Borra todos los controles existentes en el Panel antes de agregar los nuevos
                recipePanel.Controls.Clear();

                int yPosition = 10; // La posición vertical inicial

                // Itera a través de las recetas
                foreach (Receta receta in recetasFiltradas)
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
                        Text = "Receta",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    Button modifyButton = new Button
                    {
                        Text = "Modificar",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(90, yPosition)
                    };


                    Button deleteButton = new Button
                    {
                        Text = "Eliminar",
                        Tag = receta,
                        AutoSize = true,
                        Location = new Point(170, yPosition)
                    };

                    detailsButton.Click += DetailsButton_Click;
                    modifyButton.Click += modifyButton_Click;
                    deleteButton.Click += deleteButton_Click;




                    yPosition += detailsButton.Height + 10;

                    recipePanel.Controls.Add(nameLabel);
                    recipePanel.Controls.Add(difficultyLabel);
                    recipePanel.Controls.Add(detailsButton);
                    recipePanel.Controls.Add(modifyButton);
                    recipePanel.Controls.Add(deleteButton);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBoxFacil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFacil.Checked)
            {
                // Si "Facil" está seleccionado, deselecciona los otros dos checkboxes
                checkBoxIntermedio.Checked = false;
                checkBoxDificil.Checked = false;
            }
            FiltrarRecetas();
        }

        private void checkBoxIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIntermedio.Checked)
            {
                // Si "Intermedio" está seleccionado, deselecciona los otros dos checkboxes
                checkBoxFacil.Checked = false;
                checkBoxDificil.Checked = false;
            }
            FiltrarRecetas();
        }

        private void checkBoxDificil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDificil.Checked)
            {
                // Si "Dificil" está seleccionado, deselecciona los otros dos checkboxes
                checkBoxFacil.Checked = false;
                checkBoxIntermedio.Checked = false;
            }
            FiltrarRecetas();
        }
    }
}


public class Receta
{
    public string Nombre { get; set; }
    public string Dificultad { get; set; }
    public string Img { get; set; }
    public List<string> Ingredientes { get; set; }
    public List<string> Pasos { get; set; }

}

