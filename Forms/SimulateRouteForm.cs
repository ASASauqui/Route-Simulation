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
    public partial class SimulateRouteForm : Form
    {
        // ----------------------Variables a utilizar----------------------
        private BinnacleForm RForm;
        private Dictionary<int, Label> amountLabels;
        private Dictionary<int, Label> trucksLabels;
        private Simulation simulation;
        private Form1 principalForm;



        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="principalForm"></param>
        public SimulateRouteForm(Form1 principalForm)
        {
            // Pasar instancia del Form1.
            this.principalForm = principalForm;

            // Obtener instancia de simulación.
            simulation = Simulation.GetInstance();

            // Cargar componentes.
            simulation.LoadComponents();

            // Inicializar componente.
            InitializeComponent();

            // Inicializar diccionarios.
            InitializeDictionaries();

            // Refrescar información de forma visual.
            RefreshInformation();
        }

        // ----------------------Inicialización de variables----------------------

        /// <summary>
        /// Inicialización de diccionarios a utilizar.
        /// </summary>
        public void InitializeDictionaries()
        {
            // Inicializar los diccionarios.
            amountLabels = new Dictionary<int, Label>();
            trucksLabels = new Dictionary<int, Label>();

            // Diccionarios de amount.
            amountLabels.Add(0, SodaLabelSR);
            amountLabels.Add(1, BreadLabelSR);
            amountLabels.Add(2, VegetableLabelSR);

            // Diccionarios de trucks.
            trucksLabels.Add(0, SodaTrucksLabelSR);
            trucksLabels.Add(1, BreadTrucksLabelSR);
            trucksLabels.Add(2, VegetablesTrucksLabelSR);
        }




        // ----------------------Controles generales del Form----------------------

        /// <summary>
        /// Actualizar información visual.
        /// </summary>
        public void RefreshInformation()
        {
            for (int i = 0; i < simulation.products.Count; i++)
            {
                trucksLabels[i].Text = simulation.products[i].truckAmount + "";

                amountLabels[i].Text = simulation.products[i].totalAmountPerProduct.ToString();
            }
        }

        /// <summary>
        /// Actualizar información visual. Sólo etiquetas de cantidad de camiones.
        /// </summary>
        public void RefreshOnlyTrucksLabels()
        {
            for (int i = 0; i < simulation.products.Count; i++)
            {
                trucksLabels[i].Text = simulation.products[i].truckAmount + "";
            }
        }

        /// <summary>
        /// Abrir Form de la bitácora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BinnacleButtonSR_Click(object sender, EventArgs e)
        {
            RForm = new BinnacleForm();

            if (!Application.OpenForms.OfType<BinnacleForm>().Any())
            {
                RForm.Show();
            }
        }

        /// <summary>
        /// Siguiente elemento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonSR_Click(object sender, EventArgs e)
        {
            Binnacle.AddMessageToBinnacle("Comienzo de la simulación.");

            if (!simulation.GeneralCheck())
            {
                return;
            }

            Binnacle.AddMessageToBinnacle("Fin de la simulación.");

            Message.ShowEndOfSimulationMessage();

            simulation.SortStoresByProfits();

            PreAddStoreForm preAddStoreForm = new PreAddStoreForm(principalForm);

            simulation.createdRoute = true;

            this.Hide();
            preAddStoreForm.ShowDialog();
            this.Close();
        }




        // ----------------------Sumas y restas visuales----------------------

        /// <summary>
        /// Sumar camiones de refrescos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSodaTrucksButtonSR_Click(object sender, EventArgs e)
        {
            Binnacle.AddMessageToBinnacle("Se agregó un camión de sodas.");
            simulation.products[0].truckAmount++;
            RefreshOnlyTrucksLabels();
        }

        /// <summary>
        /// Restar camiones de refrescos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubstractSodaTrucksButtonSR_Click(object sender, EventArgs e)
        {
            if (simulation.products[0].truckAmount - 1 >= 0)
            {
                Binnacle.AddMessageToBinnacle("Se removió un camión de sodas.");
                simulation.products[0].truckAmount--;
                RefreshOnlyTrucksLabels();

                return;
            }
            Message.ShowNegativeAmountWarning();
        }

        /// <summary>
        /// Sumar camiones de panes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBreadTrucksButtonSR_Click(object sender, EventArgs e)
        {
            Binnacle.AddMessageToBinnacle("Se agregó un camión de pan.");
            simulation.products[1].truckAmount++;
            RefreshOnlyTrucksLabels();
        }

        /// <summary>
        /// Restar camiones de panes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubstractBreadTrucksButtonSR_Click(object sender, EventArgs e)
        {
            if (simulation.products[1].truckAmount - 1 >= 0)
            {
                Binnacle.AddMessageToBinnacle("Se removió un camión de pan.");
                simulation.products[1].truckAmount--;
                RefreshOnlyTrucksLabels();

                return;
            }
            Message.ShowNegativeAmountWarning();
        }

        /// <summary>
        /// Sumar camiones de verduras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVegatablesTrucksButtonSR_Click(object sender, EventArgs e)
        {
            Binnacle.AddMessageToBinnacle("Se agregó un camión de verduras.");
            simulation.products[2].truckAmount++;
            RefreshOnlyTrucksLabels();
        }

        /// <summary>
        /// Restar camiones de verduras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubsctractVegatablesTrucksButtonSR_Click(object sender, EventArgs e)
        {
            if (simulation.products[2].truckAmount - 1 >= 0)
            {
                Binnacle.AddMessageToBinnacle("Se removió un camión de verduras.");
                simulation.products[2].truckAmount--;
                RefreshOnlyTrucksLabels();

                return;
            }
            Message.ShowNegativeAmountWarning();
        }
    }
}
