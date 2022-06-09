
namespace StoreRoutes
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
            this.TitleLabelPrincipalForm = new System.Windows.Forms.Label();
            this.SRButtonPrincipalForm = new System.Windows.Forms.Button();
            this.CRButtonPrincipalForm = new System.Windows.Forms.Button();
            this.BButtonPrincipalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabelPrincipalForm
            // 
            this.TitleLabelPrincipalForm.AutoSize = true;
            this.TitleLabelPrincipalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.TitleLabelPrincipalForm.Location = new System.Drawing.Point(34, 30);
            this.TitleLabelPrincipalForm.Name = "TitleLabelPrincipalForm";
            this.TitleLabelPrincipalForm.Size = new System.Drawing.Size(414, 47);
            this.TitleLabelPrincipalForm.TabIndex = 0;
            this.TitleLabelPrincipalForm.Text = "Entrega de productos";
            // 
            // SRButtonPrincipalForm
            // 
            this.SRButtonPrincipalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SRButtonPrincipalForm.Location = new System.Drawing.Point(121, 123);
            this.SRButtonPrincipalForm.Name = "SRButtonPrincipalForm";
            this.SRButtonPrincipalForm.Size = new System.Drawing.Size(237, 58);
            this.SRButtonPrincipalForm.TabIndex = 1;
            this.SRButtonPrincipalForm.Text = "Simular ruta";
            this.SRButtonPrincipalForm.UseVisualStyleBackColor = true;
            this.SRButtonPrincipalForm.Click += new System.EventHandler(this.SRButtonPrincipalForm_Click);
            // 
            // CRButtonPrincipalForm
            // 
            this.CRButtonPrincipalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CRButtonPrincipalForm.Location = new System.Drawing.Point(121, 206);
            this.CRButtonPrincipalForm.Name = "CRButtonPrincipalForm";
            this.CRButtonPrincipalForm.Size = new System.Drawing.Size(237, 58);
            this.CRButtonPrincipalForm.TabIndex = 2;
            this.CRButtonPrincipalForm.Text = "Comenzar ruta";
            this.CRButtonPrincipalForm.UseVisualStyleBackColor = true;
            this.CRButtonPrincipalForm.Click += new System.EventHandler(this.CRButtonPrincipalForm_Click);
            // 
            // BButtonPrincipalForm
            // 
            this.BButtonPrincipalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BButtonPrincipalForm.Location = new System.Drawing.Point(121, 291);
            this.BButtonPrincipalForm.Name = "BButtonPrincipalForm";
            this.BButtonPrincipalForm.Size = new System.Drawing.Size(237, 58);
            this.BButtonPrincipalForm.TabIndex = 3;
            this.BButtonPrincipalForm.Text = "Bitácora";
            this.BButtonPrincipalForm.UseVisualStyleBackColor = true;
            this.BButtonPrincipalForm.Click += new System.EventHandler(this.BButtonPrincipalForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 414);
            this.Controls.Add(this.BButtonPrincipalForm);
            this.Controls.Add(this.CRButtonPrincipalForm);
            this.Controls.Add(this.SRButtonPrincipalForm);
            this.Controls.Add(this.TitleLabelPrincipalForm);
            this.MaximumSize = new System.Drawing.Size(506, 453);
            this.MinimumSize = new System.Drawing.Size(506, 453);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabelPrincipalForm;
        private System.Windows.Forms.Button SRButtonPrincipalForm;
        private System.Windows.Forms.Button CRButtonPrincipalForm;
        private System.Windows.Forms.Button BButtonPrincipalForm;
    }
}

