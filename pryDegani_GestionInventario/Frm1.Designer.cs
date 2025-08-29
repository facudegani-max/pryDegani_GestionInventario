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
            btnCarga = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BorderStyle = BorderStyle.FixedSingle;
            lbl1.Location = new Point(35, 26);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(216, 17);
            lbl1.TabIndex = 0;
            lbl1.Text = "Seleccione la opcion que quiere realizar";
            lbl1.Click += label1_Click;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(92, 68);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(90, 29);
            btnCarga.TabIndex = 1;
            btnCarga.Text = "Cargar";
            btnCarga.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(92, 103);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(92, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(92, 173);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 281);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCarga);
            Controls.Add(lbl1);
            Name = "Frm1";
            Text = "Gestion Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnCarga;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}
