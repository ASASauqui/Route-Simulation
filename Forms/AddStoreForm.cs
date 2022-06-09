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
    public partial class AddStoreForm : Form
    {
        // ----------------------Variables a utilizar----------------------
        private Form1 principalForm;
        private Simulation simulation;
        private BinnacleForm RForm;




        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="principalForm"></param>
        public AddStoreForm(Form1 principalForm)
        {
            this.principalForm = principalForm;

            simulation = Simulation.GetInstance();

            InitializeComponent();
        }




        // ----------------------Controles del Form----------------------

        /// <summary>
        /// Introducir tienda..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonAS_Click(object sender, EventArgs e)
        {
            // Extraer información del TextBox.
            String storeName_ = NameStoreTextBoxAS.Text;

            // Variable para guardar la StoreID.
            int storeID_ = 0;

            // Si a StoreName no se le ha puesto nada.
            if(storeName_ == "")
            {
                Message.ShowIncompleteInformationMessage();
                return;
            }

            // Buscar el ID que debe tener.
            while(StructuredInformation.storesID.Contains(storeID_))
            {
                storeID_++;
            }

            // Añadir ID a los storesID.
            StructuredInformation.storesID.Add(storeID_);

            // Crear nueva tienda.
            Store newStore = new Store()
            {
                storeID = storeID_,
                storeName = storeName_
            };

            // Añadir la tienda nueva a la lista que se va utilizar. 
            simulation.orderedStores.Add(newStore);

            // Mostrar mensaje de éxito.
            Message.ShowSuccessfulStoreAddition();

            Binnacle.AddMessageToBinnacle($"Se agregó una nueva tienda a la ruta, de ID: {newStore.storeID}, llamada {newStore.storeName}");

            // Abrir ventanas y cerrar.
            PreAddStoreForm preAddStoreForm = new PreAddStoreForm(principalForm);
            this.Hide();
            preAddStoreForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Abrir bitácora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BinnacleButtonAS_Click(object sender, EventArgs e)
        {
            RForm = new BinnacleForm();

            if (!Application.OpenForms.OfType<BinnacleForm>().Any())
            {
                RForm.Show();
            }
        }
    }
}
