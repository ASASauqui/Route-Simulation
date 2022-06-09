
namespace StoreRoutes
{
    partial class AddStoreForm
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
            this.NameStoreTextBoxAS = new System.Windows.Forms.TextBox();
            this.BinnacleButtonAS = new System.Windows.Forms.Button();
            this.NextButtonAS = new System.Windows.Forms.Button();
            this.Label7R = new System.Windows.Forms.Label();
            this.TitleAS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameStoreTextBoxAS
            // 
            this.NameStoreTextBoxAS.Location = new System.Drawing.Point(50, 78);
            this.NameStoreTextBoxAS.Name = "NameStoreTextBoxAS";
            this.NameStoreTextBoxAS.Size = new System.Drawing.Size(184, 20);
            this.NameStoreTextBoxAS.TabIndex = 76;
            // 
            // BinnacleButtonAS
            // 
            this.BinnacleButtonAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BinnacleButtonAS.Location = new System.Drawing.Point(78, 144);
            this.BinnacleButtonAS.Name = "BinnacleButtonAS";
            this.BinnacleButtonAS.Size = new System.Drawing.Size(122, 34);
            this.BinnacleButtonAS.TabIndex = 73;
            this.BinnacleButtonAS.Text = "Bitácora";
            this.BinnacleButtonAS.UseVisualStyleBackColor = true;
            this.BinnacleButtonAS.Click += new System.EventHandler(this.BinnacleButtonAS_Click);
            // 
            // NextButtonAS
            // 
            this.NextButtonAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NextButtonAS.Location = new System.Drawing.Point(78, 104);
            this.NextButtonAS.Name = "NextButtonAS";
            this.NextButtonAS.Size = new System.Drawing.Size(122, 34);
            this.NextButtonAS.TabIndex = 72;
            this.NextButtonAS.Text = "Siguiente";
            this.NextButtonAS.UseVisualStyleBackColor = true;
            this.NextButtonAS.Click += new System.EventHandler(this.NextButtonAS_Click);
            // 
            // Label7R
            // 
            this.Label7R.AutoSize = true;
            this.Label7R.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Label7R.Location = new System.Drawing.Point(57, 51);
            this.Label7R.Name = "Label7R";
            this.Label7R.Size = new System.Drawing.Size(171, 22);
            this.Label7R.TabIndex = 69;
            this.Label7R.Text = "Nombre de la tienda";
            // 
            // TitleAS
            // 
            this.TitleAS.AutoSize = true;
            this.TitleAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.TitleAS.Location = new System.Drawing.Point(12, 9);
            this.TitleAS.Name = "TitleAS";
            this.TitleAS.Size = new System.Drawing.Size(273, 31);
            this.TitleAS.TabIndex = 59;
            this.TitleAS.Text = "Añadir nueva tienda";
            // 
            // AddStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 197);
            this.Controls.Add(this.NameStoreTextBoxAS);
            this.Controls.Add(this.BinnacleButtonAS);
            this.Controls.Add(this.NextButtonAS);
            this.Controls.Add(this.Label7R);
            this.Controls.Add(this.TitleAS);
            this.MaximumSize = new System.Drawing.Size(311, 236);
            this.MinimumSize = new System.Drawing.Size(311, 236);
            this.Name = "AddStoreForm";
            this.Text = "AddStoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameStoreTextBoxAS;
        private System.Windows.Forms.Button BinnacleButtonAS;
        private System.Windows.Forms.Button NextButtonAS;
        private System.Windows.Forms.Label Label7R;
        private System.Windows.Forms.Label TitleAS;
    }
}