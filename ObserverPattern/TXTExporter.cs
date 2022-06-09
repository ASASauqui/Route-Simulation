using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public class TXTExporter
    {
        // ----------------------Variables a utilizar----------------------
        private static TXTExporter instance;
        private string fileName = "..\\..\\Binnacle\\Bitácora.txt";

        protected TXTExporter()
        {
            try
            {
                // Checa si el archivo ya existe para borrarlo   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                MessageBox.Show("Ruta innexistente.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        public static TXTExporter GetInstance()
        {
            if (instance == null)
            {
                instance = new TXTExporter();
            }

            return instance;
        }

        public void AddLinesToTXT()
        {
            string structuredLastMessage = "";

            try
            {
                // Checa si el archivo ya existe para borrarlo   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                foreach(var message in Binnacle.messages)
                {
                    structuredLastMessage = $"---{message[0]}:  {message[1]}";
                    File.AppendAllText(fileName, structuredLastMessage + Environment.NewLine);
                }

                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            
        }
    }
}
