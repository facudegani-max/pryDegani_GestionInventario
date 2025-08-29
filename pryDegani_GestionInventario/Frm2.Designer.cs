namespace pryDegani_GestionInventario
{
    partial class Frm2
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
            checkBoxCodigo = new CheckBox();
            checkBoxDescripcion = new CheckBox();
            checkBoxNombre = new CheckBox();
            checkBoxPrecio = new CheckBox();
            checkBoxStock = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxCodigo
            // 
            checkBoxCodigo.AutoSize = true;
            checkBoxCodigo.Location = new Point(72, 35);
            checkBoxCodigo.Name = "checkBoxCodigo";
            checkBoxCodigo.Size = new Size(65, 19);
            checkBoxCodigo.TabIndex = 0;
            checkBoxCodigo.Text = "Codigo";
            checkBoxCodigo.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescripcion
            // 
            checkBoxDescripcion.AutoSize = true;
            checkBoxDescripcion.Location = new Point(72, 135);
            checkBoxDescripcion.Name = "checkBoxDescripcion";
            checkBoxDescripcion.Size = new Size(88, 19);
            checkBoxDescripcion.TabIndex = 1;
            checkBoxDescripcion.Text = "Descripcion";
            checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            checkBoxNombre.AutoSize = true;
            checkBoxNombre.Location = new Point(72, 60);
            checkBoxNombre.Name = "checkBoxNombre";
            checkBoxNombre.Size = new Size(70, 19);
            checkBoxNombre.TabIndex = 2;
            checkBoxNombre.Text = "Nombre";
            checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrecio
            // 
            checkBoxPrecio.AutoSize = true;
            checkBoxPrecio.Location = new Point(72, 85);
            checkBoxPrecio.Name = "checkBoxPrecio";
            checkBoxPrecio.Size = new Size(59, 19);
            checkBoxPrecio.TabIndex = 3;
            checkBoxPrecio.Text = "Precio";
            checkBoxPrecio.UseVisualStyleBackColor = true;
            // 
            // checkBoxStock
            // 
            checkBoxStock.AutoSize = true;
            checkBoxStock.Location = new Point(72, 110);
            checkBoxStock.Name = "checkBoxStock";
            checkBoxStock.Size = new Size(55, 19);
            checkBoxStock.TabIndex = 4;
            checkBoxStock.Text = "Stock";
            checkBoxStock.UseVisualStyleBackColor = true;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 251);
            Controls.Add(checkBoxStock);
            Controls.Add(checkBoxPrecio);
            Controls.Add(checkBoxNombre);
            Controls.Add(checkBoxDescripcion);
            Controls.Add(checkBoxCodigo);
            Name = "Frm2";
            Text = "Datos Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxCodigo;
        private CheckBox checkBoxDescripcion;
        private CheckBox checkBoxNombre;
        private CheckBox checkBoxPrecio;
        private CheckBox checkBoxStock;
    }
}