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
    public partial class PreAddStoreForm : Form
    {
        // ----------------------Variables a utilizar----------------------
        private Form1 principalForm;



        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="principalForm"></param>
        public PreAddStoreForm(Form1 principalForm)
        {
            this.principalForm = principalForm;

            InitializeComponent();
        }



        // ----------------------Controles del Form----------------------

        /// <summary>
        /// Abrir Form de añadir nueva tienda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PASAddStoreButton_Click(object sender, EventArgs e)
        {
            AddStoreForm addStoreForm = new AddStoreForm(principalForm);

            this.Hide();
            addStoreForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Mostrar la ventana de stores ordenadas por ganancia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PASBackMenuButton_Click(object sender, EventArgs e)
        {
            SortStoresForm sortStoresForm = new SortStoresForm();

            this.Hide();
            sortStoresForm.ShowDialog();
            this.Close();
        }
    }
}
