using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    class Message
    {
        // ----------------------Errores----------------------
        static public void ShowNegativeAmountWarning()
        {
            MessageBox.Show("No se pueden poner valores negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void ShowRouteNotCreatedMessage()
        {
            MessageBox.Show("No existe ninguna ruta creada, por favor, primero haga la simulación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void ShowNoCheckBoxesSelected()
        {
            MessageBox.Show("Seleccione por lo menos un tipo para abrir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static public void ShowNoStoresToSimulate()
        {
            MessageBox.Show("No hay tiendas para simular, por favor, incluya algunas y levante los pedidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // ----------------------Advertencias----------------------
        static public void ShowWarningOfNotEnoughQuantity()
        {
            MessageBox.Show("No hay suficientes camiones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static public void ShowWarningOfExceedingAmount()
        {
            MessageBox.Show("Se están utilizando camiones de más en un determinado producto, sólo utilice los necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static public void ShowWarningOfExceedingTrucksAmount()
        {
            MessageBox.Show("Se están utilizando más camiones de los que se tienen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static public void ShowIncompleteInformationMessage()
        {
            MessageBox.Show("No se ha llenado el campo, por favor llénelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static public void ShowExistingRouteMessage()
        {
            MessageBox.Show("Ya hay una ruta creada de manera exitosa, no simule de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        // ----------------------Éxitos----------------------
        static public void ShowEndOfSimulationMessage()
        {
            MessageBox.Show("Se ha terminado la simulación de manera exitosa.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public void ShowEndOfRouteMessage()
        {
            MessageBox.Show("Se ha terminado la ruta.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public void ShowSuccessfulStoreAddition()
        {
            MessageBox.Show("La nueva tienda se agregó de manera exitosa.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
