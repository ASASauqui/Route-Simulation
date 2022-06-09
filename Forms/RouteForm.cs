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
    public partial class RouteForm : Form
    {
        // ----------------------Variables a utilizar----------------------
        private Form1 principalForm;
        private Route route;
        private Simulation simulation;
        private BinnacleForm RForm;
        private bool refreshBool;

        public int[] amountProducts;
        public Dictionary<int, NumericUpDown> numericBoxes;
        public Dictionary<int, Label> productsByStoreLabels;




        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="principalForm"></param>
        public RouteForm(Form1 principalForm)
        {
            // Cargar instancia de Form1.
            this.principalForm = principalForm;

            // Poner en falso que se está actualizando el form.
            refreshBool = false;

            // Obtener una instancia de Simulation.
            this.simulation = Simulation.GetInstance();

            // Obtener instancia de Route.
            route = Route.GetInstance();

            // Cargar componentes de Route.
            route.LoadComponents();

            // Inicializar componentes visuales.
            InitializeComponent();

            // Inicializar variables.
            InitializeVariables();

            // Actualizar información visual.
            RefreshInformation();
        }




        // ----------------------Inicialización de variables----------------------

        /// <summary>
        /// Inicializar variables a utilizar.
        /// </summary>
        public void InitializeVariables()
        {
            // Inicializar diccionario.
            numericBoxes = new Dictionary<int, NumericUpDown>();

            // Diccionario de TextBox.
            numericBoxes.Add(0, SodaNumericR);
            numericBoxes.Add(1, BreadNumericR);
            numericBoxes.Add(2, VegetableNumericR);

            // Arreglo de cantidad de productos.
            amountProducts = new int[route.products.Count];


            // Inicializar diccionario.
            productsByStoreLabels = new Dictionary<int, Label>();

            // Diccionario de labels.
            productsByStoreLabels.Add(0, SodaLabelRF);
            productsByStoreLabels.Add(1, BreadLabelRF);
            productsByStoreLabels.Add(2, VegetableLabelRF);
        }




        // ----------------------Controles del Form----------------------

        /// <summary>
        /// Actualizar información visual.
        /// </summary>
        public void RefreshInformation()
        {
            refreshBool = true;

            Binnacle.AddMessageToBinnacle($"Se finalizó un pedido a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");

            IDStoreLabelR.Text = route.stores[0].storeID.ToString();

            if (route.stores[0].products.Count == 0)
            {
                for (int i = 0; i < route.products.Count; i++)
                {
                    productsByStoreLabels[i].Text = 0 + "";
                }
            }
            else
            {
                for (int i = 0; i < route.products.Count; i++)
                {
                    for (int j = 0; j < route.stores[0].products.Count; j++)
                    {
                        if (route.stores[0].products[j].productID == i)
                        {
                            productsByStoreLabels[i].Text = route.stores[0].products[j].productQuantity.ToString();
                        }
                    }
                }
            }

            for (int i = 0; i < route.products.Count; i++)
            {
                numericBoxes[i].Value = 0;
            }

            Array.Clear(route.currentProductAmount, 0, route.currentProductAmount.Length);

            refreshBool = false;
        }

        /// <summary>
        /// Abrir bitácora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BinnacleButtonR_Click(object sender, EventArgs e)
        {
            RForm = new BinnacleForm();

            if (!Application.OpenForms.OfType<BinnacleForm>().Any())
            {
                RForm.Show();
            }
        }

        /// <summary>
        /// Siguiente tienda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonR_Click(object sender, EventArgs e)
        {
            int numericBoxValue = 0;
            
            for(int i = 0; i < route.products.Count; i++)
            {
                numericBoxValue = (int)numericBoxes[i].Value;

                amountProducts[i] = numericBoxValue;

                if(amountProducts[i] < 0)
                {
                    Message.ShowNegativeAmountWarning();
                    return;
                }
            }

            Binnacle.AddMessageToBinnacle($"Se creó un pedido a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
            route.MakeStore(amountProducts);
            Binnacle.AddMessageToBinnacle($"Se creó una imagen en la tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");

            route.NextListElement();

            if (route.stores.Count() == 0)
            {
                simulation.createdRoute = false;

                Message.ShowEndOfRouteMessage();

                this.Close();

                return;
            }

            

            RefreshInformation();
        }

        private void SodaNumericR_ValueChanged(object sender, EventArgs e)
        {
            if (refreshBool == false)
            {
                if (numericBoxes[0].Value > route.currentProductAmount[0])
                {
                    Binnacle.AddMessageToBinnacle($"Se agregó {route.products[0].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[0]++;
                }
                else if (numericBoxes[0].Value < route.currentProductAmount[0])
                {
                    Binnacle.AddMessageToBinnacle($"Se removió {route.products[0].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[0]--;
                }
            }
        }

        private void BreadNumericR_ValueChanged(object sender, EventArgs e)
        {
            if (refreshBool == false)
            {
                if (numericBoxes[1].Value > route.currentProductAmount[1])
                {
                    Binnacle.AddMessageToBinnacle($"Se agregó {route.products[1].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[1]++;
                }
                else if (numericBoxes[1].Value < route.currentProductAmount[1])
                {
                    Binnacle.AddMessageToBinnacle($"Se removió {route.products[1].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[1]--;
                }
            }
        }

        private void VegetableNumericR_ValueChanged(object sender, EventArgs e)
        {
            if (refreshBool == false)
            {
                if (numericBoxes[2].Value > route.currentProductAmount[2])
                {
                    Binnacle.AddMessageToBinnacle($"Se agregó {route.products[2].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[2]++;
                }
                else if (numericBoxes[2].Value < route.currentProductAmount[2])
                {
                    Binnacle.AddMessageToBinnacle($"Se removió {route.products[2].productName} a tienda con ID: {route.stores[0].storeID}, llamada {route.stores[0].storeName}");
                    route.currentProductAmount[2]--;
                }
            }
        }
    }
}
