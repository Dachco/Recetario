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
            button2 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            checkBox2 = new CheckBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
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
            recipePanel.Location = new Point(268, 19);
            recipePanel.Name = "recipePanel";
            recipePanel.Size = new Size(235, 403);
            recipePanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 106);
            button2.Name = "button2";
            button2.Size = new Size(214, 76);
            button2.TabIndex = 2;
            button2.Text = "Agregar Receta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Facil --> Dificil";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 197);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Filtros";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 240);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Dificil --> Facil";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 274);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo de Dieta";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Vegatariano", "Vegano", "Carnivoro" });
            checkedListBox1.Location = new Point(13, 305);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 7;
            // 
            // Recetario_App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button2);
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
        private Button button2;
        private CheckBox checkBox1;
        private Label label1;
        private CheckBox checkBox2;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}