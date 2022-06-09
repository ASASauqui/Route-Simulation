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
    public partial class Form1 : Form
    {
        // ----------------------Variables a utilizar----------------------
        private Simulation simulation;
        private Route route;
        private BinnacleForm RForm;



        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            Binnacle.InitializeBinnacleAddComponents();
        }



        // ----------------------Controles del Form----------------------

        /// <summary>
        ///  Abrir la ventana de simulación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SRButtonPrincipalForm_Click(object sender, EventArgs e)
        {
            // Obtener instancia de simulation.
            simulation = Simulation.GetInstance();

            // Si no hay ninguna ruta creada.
            if(simulation.createdRoute == false)
            {
                // Cargar componentes de simulation.
                simulation.LoadComponents();

                // Si las tiendas son cero.
                if(simulation.stores.Count == 0)
                {
                    // Mostrar mensaje de no hay tiendas.
                    Message.ShowNoStoresToSimulate();

                    // Ruta creada.
                    simulation.createdRoute = true;

                    // Inicializar AddStoreForm.
                    AddStoreForm addStoreForm = new AddStoreForm(this);

                    // Mostrar AddStoreForm.
                    addStoreForm.ShowDialog();

                    return;
                }

                // Inicializar SimulateRouteForm.
                SimulateRouteForm SRForm = new SimulateRouteForm(this);

                // Mostrar SimulateRouteForm.
                SRForm.ShowDialog();

                return;
            }

            // Mostrar mensaje de que ya existe una ruta.
            Message.ShowExistingRouteMessage();
        }

        /// <summary>
        /// Abrir ventana de ruta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRButtonPrincipalForm_Click(object sender, EventArgs e)
        {
            // Obtener instancia de simulación.
            simulation = Simulation.GetInstance();

            // Si no hay ninguna ruta creada.
            if(simulation.createdRoute == false)
            {
                // Mostrar mensaje de que no hay ninguna ruta creada.
                Message.ShowRouteNotCreatedMessage();

                return;
            }

            // Obtener instancia de Route.
            route = Route.GetInstance();

            // Pasar las stores ordenadas a route.stores.
            route.stores = simulation.orderedStores;

            // Inicializar RouteForm.
            RouteForm RForm = new RouteForm(this);

            // Mostrar RouteForm.
            RForm.ShowDialog();
        }

        /// <summary>
        /// Abrir ventana de bitácora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BButtonPrincipalForm_Click(object sender, EventArgs e)
        {
            // Inicializar BinnacleForm.
            RForm = new BinnacleForm();

            // Si no hay ningún elemento BinnacleForm abierto.
            if (!Application.OpenForms.OfType<BinnacleForm>().Any())
            {
                RForm.Show();
            }
        }
    }
}
