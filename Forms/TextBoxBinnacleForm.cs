using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public partial class TextBoxBinnacleForm : Form
    {
        public TextBoxBinnacleForm()
        {
            InitializeComponent();

            InsertInformation();
        }

        private void InsertInformation()
        {
            foreach (var message in Binnacle.messages)
            {
                TextBox.AppendText($"---({message[0]}): {message[1]}" + "\r\n");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

