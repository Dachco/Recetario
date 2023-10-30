namespace Recetario_App
{
    partial class Recetario_App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            recipePanel = new Panel();
            buttonAgregar = new Button();
            checkBoxFacil = new CheckBox();
            label1 = new Label();
            checkBoxIntermedio = new CheckBox();
            checkBoxDificil = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 19);
            button1.Name = "button1";
            button1.Size = new Size(214, 66);
            button1.TabIndex = 0;
            button1.Text = "Recetas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // recipePanel
            // 
            recipePanel.AutoScroll = true;
            recipePanel.Location = new Point(232, 19);
            recipePanel.Name = "recipePanel";
            recipePanel.Size = new Size(271, 403);
            recipePanel.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(12, 106);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(214, 76);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar Receta";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // checkBoxFacil
            // 
            checkBoxFacil.AutoSize = true;
            checkBoxFacil.Location = new Point(13, 230);
            checkBoxFacil.Name = "checkBoxFacil";
            checkBoxFacil.Size = new Size(50, 19);
            checkBoxFacil.TabIndex = 3;
            checkBoxFacil.Text = "Facil";
            checkBoxFacil.UseVisualStyleBackColor = true;
            checkBoxFacil.CheckedChanged += checkBoxFacil_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(71, 33);
            label1.TabIndex = 4;
            label1.Text = "Filtros";
            // 
            // checkBoxIntermedio
            // 
            checkBoxIntermedio.AutoSize = true;
            checkBoxIntermedio.Location = new Point(13, 255);
            checkBoxIntermedio.Name = "checkBoxIntermedio";
            checkBoxIntermedio.Size = new Size(84, 19);
            checkBoxIntermedio.TabIndex = 5;
            checkBoxIntermedio.Text = "Intermedio";
            checkBoxIntermedio.UseVisualStyleBackColor = true;
            checkBoxIntermedio.CheckedChanged += checkBoxIntermedio_CheckedChanged;
            // 
            // checkBoxDificil
            // 
            checkBoxDificil.AutoSize = true;
            checkBoxDificil.Location = new Point(12, 280);
            checkBoxDificil.Name = "checkBoxDificil";
            checkBoxDificil.Size = new Size(56, 19);
            checkBoxDificil.TabIndex = 6;
            checkBoxDificil.Text = "Dificil";
            checkBoxDificil.UseVisualStyleBackColor = true;
            checkBoxDificil.CheckedChanged += checkBoxDificil_CheckedChanged;
            // 
            // Recetario_App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(checkBoxDificil);
            Controls.Add(checkBoxIntermedio);
            Controls.Add(label1);
            Controls.Add(checkBoxFacil);
            Controls.Add(buttonAgregar);
            Controls.Add(recipePanel);
            Controls.Add(button1);
            Name = "Recetario_App";
            Text = "Recetas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel recipePanel;
        private Button buttonAgregar;
        private CheckBox checkBoxFacil;
        private Label label1;
        private CheckBox checkBoxIntermedio;
        private CheckBox checkBoxDificil;
    }
}