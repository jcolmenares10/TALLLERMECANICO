namespace BDMiTalller
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
            this.btnLoing = new System.Windows.Forms.Button();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtContr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Datosmal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoing
            // 
            this.btnLoing.Location = new System.Drawing.Point(155, 305);
            this.btnLoing.Name = "btnLoing";
            this.btnLoing.Size = new System.Drawing.Size(170, 50);
            this.btnLoing.TabIndex = 0;
            this.btnLoing.Text = "Iniciar Sesion";
            this.btnLoing.UseVisualStyleBackColor = true;
            this.btnLoing.Click += new System.EventHandler(this.btnLoing_Click);
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(203, 192);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(122, 22);
            this.txtUsr.TabIndex = 1;
            // 
            // txtContr
            // 
            this.txtContr.Location = new System.Drawing.Point(203, 249);
            this.txtContr.Name = "txtContr";
            this.txtContr.Size = new System.Drawing.Size(122, 22);
            this.txtContr.TabIndex = 2;
            this.txtContr.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Taller Mecanico \"  \"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña: ";
            // 
            // Datosmal
            // 
            this.Datosmal.AutoSize = true;
            this.Datosmal.ForeColor = System.Drawing.Color.Red;
            this.Datosmal.Location = new System.Drawing.Point(195, 274);
            this.Datosmal.Name = "Datosmal";
            this.Datosmal.Size = new System.Drawing.Size(0, 17);
            this.Datosmal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BDMiTalller.Properties.Resources.fondoBD;
            this.ClientSize = new System.Drawing.Size(534, 445);
            this.Controls.Add(this.Datosmal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContr);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.btnLoing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoing;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtContr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Datosmal;
    }
}

