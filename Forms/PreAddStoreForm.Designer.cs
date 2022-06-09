
namespace StoreRoutes
{
    partial class PreAddStoreForm
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
            this.PASAddStoreButton = new System.Windows.Forms.Button();
            this.TitleLabelPAS = new System.Windows.Forms.Label();
            this.PASBackMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PASAddStoreButton
            // 
            this.PASAddStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PASAddStoreButton.Location = new System.Drawing.Point(75, 56);
            this.PASAddStoreButton.Name = "PASAddStoreButton";
            this.PASAddStoreButton.Size = new System.Drawing.Size(182, 32);
            this.PASAddStoreButton.TabIndex = 3;
            this.PASAddStoreButton.Text = "Agregar nueva tienda";
            this.PASAddStoreButton.UseVisualStyleBackColor = true;
            this.PASAddStoreButton.Click += new System.EventHandler(this.PASAddStoreButton_Click);
            // 
            // TitleLabelPAS
            // 
            this.TitleLabelPAS.AutoSize = true;
            this.TitleLabelPAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.TitleLabelPAS.Location = new System.Drawing.Point(12, 19);
            this.TitleLabelPAS.Name = "TitleLabelPAS";
            this.TitleLabelPAS.Size = new System.Drawing.Size(331, 17);
            this.TitleLabelPAS.TabIndex = 2;
            this.TitleLabelPAS.Text = "¿Desea agregar una nueva tienda a la ruta?";
            // 
            // PASBackMenuButton
            // 
            this.PASBackMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PASBackMenuButton.Location = new System.Drawing.Point(75, 94);
            this.PASBackMenuButton.Name = "PASBackMenuButton";
            this.PASBackMenuButton.Size = new System.Drawing.Size(182, 32);
            this.PASBackMenuButton.TabIndex = 4;
            this.PASBackMenuButton.Text = "Continuar";
            this.PASBackMenuButton.UseVisualStyleBackColor = true;
            this.PASBackMenuButton.Click += new System.EventHandler(this.PASBackMenuButton_Click);
            // 
            // PreAddStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 138);
            this.Controls.Add(this.PASBackMenuButton);
            this.Controls.Add(this.PASAddStoreButton);
            this.Controls.Add(this.TitleLabelPAS);
            this.MaximumSize = new System.Drawing.Size(370, 177);
            this.MinimumSize = new System.Drawing.Size(370, 177);
            this.Name = "PreAddStoreForm";
            this.Text = "PreAddStoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PASAddStoreButton;
        private System.Windows.Forms.Label TitleLabelPAS;
        private System.Windows.Forms.Button PASBackMenuButton;
    }
}