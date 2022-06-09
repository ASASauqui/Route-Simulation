
namespace StoreRoutes
{
    partial class SortStoresForm
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
            this.TitleSR = new System.Windows.Forms.Label();
            this.SSFDataGridView1 = new System.Windows.Forms.DataGridView();
            this.Store_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSFBackMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SSFDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleSR
            // 
            this.TitleSR.AutoSize = true;
            this.TitleSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.TitleSR.Location = new System.Drawing.Point(32, 18);
            this.TitleSR.Name = "TitleSR";
            this.TitleSR.Size = new System.Drawing.Size(381, 47);
            this.TitleSR.TabIndex = 2;
            this.TitleSR.Text = "Orden de ruta final";
            // 
            // SSFDataGridView1
            // 
            this.SSFDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SSFDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Store_ID,
            this.Store_Name});
            this.SSFDataGridView1.Location = new System.Drawing.Point(26, 92);
            this.SSFDataGridView1.Name = "SSFDataGridView1";
            this.SSFDataGridView1.Size = new System.Drawing.Size(413, 291);
            this.SSFDataGridView1.TabIndex = 3;
            // 
            // Store_ID
            // 
            this.Store_ID.HeaderText = "ID";
            this.Store_ID.Name = "Store_ID";
            this.Store_ID.ReadOnly = true;
            // 
            // Store_Name
            // 
            this.Store_Name.HeaderText = "Nombre";
            this.Store_Name.Name = "Store_Name";
            this.Store_Name.ReadOnly = true;
            this.Store_Name.Width = 270;
            // 
            // SSFBackMenuButton
            // 
            this.SSFBackMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SSFBackMenuButton.Location = new System.Drawing.Point(143, 406);
            this.SSFBackMenuButton.Name = "SSFBackMenuButton";
            this.SSFBackMenuButton.Size = new System.Drawing.Size(182, 32);
            this.SSFBackMenuButton.TabIndex = 5;
            this.SSFBackMenuButton.Text = "Volver a Menú";
            this.SSFBackMenuButton.UseVisualStyleBackColor = true;
            this.SSFBackMenuButton.Click += new System.EventHandler(this.SSFBackMenuButton_Click);
            // 
            // SortStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.SSFBackMenuButton);
            this.Controls.Add(this.SSFDataGridView1);
            this.Controls.Add(this.TitleSR);
            this.MaximumSize = new System.Drawing.Size(481, 489);
            this.MinimumSize = new System.Drawing.Size(481, 489);
            this.Name = "SortStoresForm";
            this.Text = "SortStoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.SSFDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TitleSR;
        private System.Windows.Forms.DataGridView SSFDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_Name;
        private System.Windows.Forms.Button SSFBackMenuButton;
    }
}