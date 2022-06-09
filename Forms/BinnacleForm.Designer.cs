
namespace StoreRoutes
{
    partial class BinnacleForm
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
            this.ShowButtonBinnacleForm = new System.Windows.Forms.Button();
            this.GroupBoxBinnacleForm = new System.Windows.Forms.GroupBox();
            this.TextBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.GridCheckBox = new System.Windows.Forms.CheckBox();
            this.TXTCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupBoxBinnacleForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowButtonBinnacleForm
            // 
            this.ShowButtonBinnacleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowButtonBinnacleForm.Location = new System.Drawing.Point(88, 225);
            this.ShowButtonBinnacleForm.Name = "ShowButtonBinnacleForm";
            this.ShowButtonBinnacleForm.Size = new System.Drawing.Size(159, 51);
            this.ShowButtonBinnacleForm.TabIndex = 2;
            this.ShowButtonBinnacleForm.Text = "Mostrar";
            this.ShowButtonBinnacleForm.UseVisualStyleBackColor = true;
            this.ShowButtonBinnacleForm.Click += new System.EventHandler(this.ShowButtonBinnacleForm_Click);
            // 
            // GroupBoxBinnacleForm
            // 
            this.GroupBoxBinnacleForm.Controls.Add(this.TextBoxCheckBox);
            this.GroupBoxBinnacleForm.Controls.Add(this.GridCheckBox);
            this.GroupBoxBinnacleForm.Controls.Add(this.TXTCheckBox);
            this.GroupBoxBinnacleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.GroupBoxBinnacleForm.Location = new System.Drawing.Point(31, 12);
            this.GroupBoxBinnacleForm.Name = "GroupBoxBinnacleForm";
            this.GroupBoxBinnacleForm.Size = new System.Drawing.Size(289, 183);
            this.GroupBoxBinnacleForm.TabIndex = 3;
            this.GroupBoxBinnacleForm.TabStop = false;
            this.GroupBoxBinnacleForm.Text = "Mostrar en la siguiente forma";
            // 
            // TextBoxCheckBox
            // 
            this.TextBoxCheckBox.AutoSize = true;
            this.TextBoxCheckBox.Location = new System.Drawing.Point(105, 135);
            this.TextBoxCheckBox.Name = "TextBoxCheckBox";
            this.TextBoxCheckBox.Size = new System.Drawing.Size(96, 26);
            this.TextBoxCheckBox.TabIndex = 5;
            this.TextBoxCheckBox.Text = "TextBox";
            this.TextBoxCheckBox.UseVisualStyleBackColor = true;
            this.TextBoxCheckBox.CheckedChanged += new System.EventHandler(this.TextBoxCheckBox_CheckedChanged);
            // 
            // GridCheckBox
            // 
            this.GridCheckBox.AutoSize = true;
            this.GridCheckBox.Location = new System.Drawing.Point(105, 85);
            this.GridCheckBox.Name = "GridCheckBox";
            this.GridCheckBox.Size = new System.Drawing.Size(63, 26);
            this.GridCheckBox.TabIndex = 4;
            this.GridCheckBox.Text = "Grid";
            this.GridCheckBox.UseVisualStyleBackColor = true;
            this.GridCheckBox.CheckedChanged += new System.EventHandler(this.GridCheckBox_CheckedChanged);
            // 
            // TXTCheckBox
            // 
            this.TXTCheckBox.AutoSize = true;
            this.TXTCheckBox.Location = new System.Drawing.Point(105, 38);
            this.TXTCheckBox.Name = "TXTCheckBox";
            this.TXTCheckBox.Size = new System.Drawing.Size(53, 26);
            this.TXTCheckBox.TabIndex = 3;
            this.TXTCheckBox.Text = ".txt";
            this.TXTCheckBox.UseVisualStyleBackColor = true;
            this.TXTCheckBox.CheckedChanged += new System.EventHandler(this.TXTCheckBox_CheckedChanged);
            // 
            // BinnacleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 316);
            this.Controls.Add(this.GroupBoxBinnacleForm);
            this.Controls.Add(this.ShowButtonBinnacleForm);
            this.MaximumSize = new System.Drawing.Size(369, 355);
            this.MinimumSize = new System.Drawing.Size(369, 355);
            this.Name = "BinnacleForm";
            this.Text = "BinnacleForm";
            this.GroupBoxBinnacleForm.ResumeLayout(false);
            this.GroupBoxBinnacleForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowButtonBinnacleForm;
        private System.Windows.Forms.GroupBox GroupBoxBinnacleForm;
        private System.Windows.Forms.CheckBox TextBoxCheckBox;
        private System.Windows.Forms.CheckBox GridCheckBox;
        private System.Windows.Forms.CheckBox TXTCheckBox;
    }
}