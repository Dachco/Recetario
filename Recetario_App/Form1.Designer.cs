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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Recetas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // recipePanel
            // 
            recipePanel.AutoScroll = true;
            recipePanel.Location = new Point(355, 19);
            recipePanel.Name = "recipePanel";
            recipePanel.Size = new Size(471, 403);
            recipePanel.TabIndex = 1;
            // 
            // Recetario_App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 450);
            Controls.Add(recipePanel);
            Controls.Add(button1);
            Name = "Recetario_App";
            Text = "Recetas";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel recipePanel;
    }
}