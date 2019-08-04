namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalPesos = new System.Windows.Forms.Label();
            this.totalDolares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalPesos
            // 
            this.totalPesos.AutoSize = true;
            this.totalPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPesos.Location = new System.Drawing.Point(26, 74);
            this.totalPesos.Name = "totalPesos";
            this.totalPesos.Size = new System.Drawing.Size(161, 33);
            this.totalPesos.TabIndex = 0;
            this.totalPesos.Text = "totalPesos";
            // 
            // totalDolares
            // 
            this.totalDolares.AutoSize = true;
            this.totalDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDolares.Location = new System.Drawing.Point(202, 74);
            this.totalDolares.Name = "totalDolares";
            this.totalDolares.Size = new System.Drawing.Size(183, 33);
            this.totalDolares.TabIndex = 1;
            this.totalDolares.Text = "totalDolares";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalDolares);
            this.Controls.Add(this.totalPesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalPesos;
        private System.Windows.Forms.Label totalDolares;
    }
}

