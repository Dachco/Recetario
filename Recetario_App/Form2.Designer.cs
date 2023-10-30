namespace Recetario_App
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            buttonAgregarReceta = new Button();
            comboBox1 = new ComboBox();
            buttonModificarReceta = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre Receta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Dificultad";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 176);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(227, 115);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(25, 175);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Ingredientes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(150, 306);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(227, 115);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(25, 306);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "Pasos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAgregarReceta
            // 
            buttonAgregarReceta.Location = new Point(159, 443);
            buttonAgregarReceta.Name = "buttonAgregarReceta";
            buttonAgregarReceta.Size = new Size(111, 40);
            buttonAgregarReceta.TabIndex = 9;
            buttonAgregarReceta.Text = "Agregar";
            buttonAgregarReceta.UseVisualStyleBackColor = true;
            buttonAgregarReceta.Click += buttonAgregarReceta_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fácil", "Intermedio", "Difícil" });
            comboBox1.Location = new Point(150, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 11;
            // 
            // buttonModificarReceta
            // 
            buttonModificarReceta.Location = new Point(159, 443);
            buttonModificarReceta.Name = "buttonModificarReceta";
            buttonModificarReceta.Size = new Size(111, 40);
            buttonModificarReceta.TabIndex = 12;
            buttonModificarReceta.Text = "Modificar";
            buttonModificarReceta.UseVisualStyleBackColor = true;
            buttonModificarReceta.Click += buttonModificarReceta_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(25, 126);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 13;
            label5.Text = "Imagen";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(150, 126);
            label6.Name = "label6";
            label6.Size = new Size(196, 24);
            label6.TabIndex = 14;
            label6.Text = "Cargar imagen";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(352, 126);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 15;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 504);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonModificarReceta);
            Controls.Add(comboBox1);
            Controls.Add(buttonAgregarReceta);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Agregar Receta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button buttonAgregarReceta;
        private ComboBox comboBox1;
        private Button buttonModificarReceta;
        private Label label5;
        private Label label6;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}