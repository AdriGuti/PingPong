
namespace PingPong
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonJugar = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BotonJugar
            // 
            this.BotonJugar.Location = new System.Drawing.Point(473, 477);
            this.BotonJugar.Name = "BotonJugar";
            this.BotonJugar.Size = new System.Drawing.Size(101, 36);
            this.BotonJugar.TabIndex = 1;
            this.BotonJugar.Text = "Jugar";
            this.BotonJugar.UseVisualStyleBackColor = true;
            this.BotonJugar.Click += new System.EventHandler(this.BotonJugar_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(473, 519);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(101, 36);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 600);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonJugar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonJugar;
        private System.Windows.Forms.Button BotonCerrar;
    }
}

