namespace pryDegani_GestionInventario
{
    partial class Frm1
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
            lbl1 = new Label();
            btnSalir = new Button();
            btnSalir3 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(59, 57);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(168, 39);
            lbl1.TabIndex = 0;
            lbl1.Text = "Bienvenido";
            lbl1.Click += label1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(190, 240);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnSalir3
            // 
            btnSalir3.Location = new Point(101, 126);
            btnSalir3.Name = "btnSalir3";
            btnSalir3.Size = new Size(90, 29);
            btnSalir3.TabIndex = 5;
            btnSalir3.Text = "Salir";
            btnSalir3.UseVisualStyleBackColor = true;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 281);
            Controls.Add(btnSalir3);
            Controls.Add(btnSalir);
            Controls.Add(lbl1);
            Name = "Frm1";
            Text = "Gestion Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnSalir;
        private Button btnSalir3;
    }
}
