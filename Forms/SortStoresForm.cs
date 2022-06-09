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
    public partial class SortStoresForm : Form
    {
        private Simulation simulation;

        public SortStoresForm()
        {
            // Inicializar componentes visuales.
            InitializeComponent();

            // Obtener instancia de la clase Simulation.
            simulation = Simulation.GetInstance();

            // Poner la info en el Data Grid View.
            ShowOrderedStoresInfo();
        }

        private void SSFBackMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowOrderedStoresInfo()
        {
            foreach(var store in simulation.orderedStores)
            {
                string[] row = { store.storeID.ToString(), store.storeName };
                SSFDataGridView1.Rows.Add(row);
            }
        }
    }
}
