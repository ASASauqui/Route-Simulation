
namespace StoreRoutes
{
    partial class TextBoxBinnacleForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CloseButton.Location = new System.Drawing.Point(129, 398);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(182, 32);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(131, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(180, 47);
            this.Title.TabIndex = 9;
            this.Title.Text = "Bitácora";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TextBox.Location = new System.Drawing.Point(32, 76);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(385, 302);
            this.TextBox.TabIndex = 12;
            // 
            // TextBoxBinnacleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(469, 489);
            this.MinimumSize = new System.Drawing.Size(469, 489);
            this.Name = "TextBoxBinnacleForm";
            this.Text = "TextBoxBinnacleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox TextBox;
    }
}