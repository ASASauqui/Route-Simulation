using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    class Binnacle
    {
        static public List<string[]> messages;

        // ----------------------Observers----------------------
        static public void InitializeBinnacleAddComponents()
        {
            messages = new List<string[]>();
        }

        static public void AddMessageToBinnacle(string newMessage)
        {
            String[] currentMessage = { $"{DateTime.Now: dd/MM/yyyy - HH:mm:ss}", newMessage };

            messages.Add(currentMessage);
        }
    }
}
