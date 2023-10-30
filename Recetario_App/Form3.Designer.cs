namespace Recetario_App
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelIMG = new Panel();
            label1 = new Label();
            label3 = new Label();
            buttonRegresar = new Button();
            textBoxPasos = new TextBox();
            textBoxIngedientes = new TextBox();
            labelDificultad = new Label();
            SuspendLayout();
            // 
            // panelIMG
            // 
            panelIMG.Location = new Point(47, 24);
            panelIMG.Name = "panelIMG";
            panelIMG.Size = new Size(233, 213);
            panelIMG.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(12, 250);
            label1.Name = "label1";
            label1.Size = new Size(299, 23);
            label1.TabIndex = 1;
            label1.Text = "INGREDIENTES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(331, 24);
            label3.Name = "label3";
            label3.Size = new Size(275, 23);
            label3.TabIndex = 3;
            label3.Text = "RECETA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(486, 401);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(120, 37);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Atras";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // textBoxPasos
            // 
            textBoxPasos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPasos.Location = new Point(331, 109);
            textBoxPasos.Multiline = true;
            textBoxPasos.Name = "textBoxPasos";
            textBoxPasos.ReadOnly = true;
            textBoxPasos.ScrollBars = ScrollBars.Vertical;
            textBoxPasos.Size = new Size(275, 286);
            textBoxPasos.TabIndex = 6;
            // 
            // textBoxIngedientes
            // 
            textBoxIngedientes.Location = new Point(12, 288);
            textBoxIngedientes.Multiline = true;
            textBoxIngedientes.Name = "textBoxIngedientes";
            textBoxIngedientes.ReadOnly = true;
            textBoxIngedientes.ScrollBars = ScrollBars.Vertical;
            textBoxIngedientes.Size = new Size(299, 150);
            textBoxIngedientes.TabIndex = 7;
            // 
            // labelDificultad
            // 
            labelDificultad.Location = new Point(331, 69);
            labelDificultad.Name = "labelDificultad";
            labelDificultad.Size = new Size(275, 23);
            labelDificultad.TabIndex = 8;
            labelDificultad.Text = "Dificultad :";
            labelDificultad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(labelDificultad);
            Controls.Add(textBoxIngedientes);
            Controls.Add(textBoxPasos);
            Controls.Add(buttonRegresar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panelIMG);
            Name = "Form3";
            Text = "Receta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelIMG;
        private Label label1;
        private Label label3;
        private Button buttonRegresar;
        private TextBox textBoxPasos;
        private TextBox textBoxIngedientes;
        private Label labelDificultad;
    }
}