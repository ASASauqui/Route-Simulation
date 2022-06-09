using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StoreRoutes
{
    class StructuredInformation
    {
        // ----------------------Variables a utilizar----------------------
        static public List<Product> products = new List<Product>();
        static public QRCodeAdapter qr = new QRCodeAdapter();
        static public List<int> storesID = new List<int>();
        static public List<Truck> trucks = new List<Truck>();
        static public List<Store> stores = new List<Store>();
        static public Subject listenersManager;
        static public int trucksAmountLimit = 5;


        static StructuredInformation()
        {
            products = new List<Product>();
            qr = new QRCodeAdapter();
            storesID = new List<int>();
            trucks = new List<Truck>();
            stores = new List<Store>();
            trucksAmountLimit = 5;
        }




        // ----------------------Lectura de datos----------------------

        /// <summary>
        /// Leer datos de productos y cargarlos.
        /// </summary>
        static public void ReadProducts()
        {
            // Dirección del JSON
            string path = Path.GetFullPath("..\\..\\Databases\\Products.json");

            // Leer archivo
            using (StreamReader jsonStream = File.OpenText(path))
            {
                // String del JSON
                string json = jsonStream.ReadToEnd();

                // Lista del JSON con todas sus componentes
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }

        /// <summary>
        /// Leer datos de camiones y cargarlos.
        /// </summary>
        static public void ReadTrucks()
        {
            // Dirección del JSON
            string path = Path.GetFullPath("..\\..\\Databases\\Trucks.json");

            // Leer archivo
            using (StreamReader jsonStream = File.OpenText(path))
            {
                // String del JSON
                string json = jsonStream.ReadToEnd();

                // Lista del JSON con todas sus componentes
                trucks = JsonConvert.DeserializeObject<List<Truck>>(json);
            }
        }





        // ----------------------Búsqueda de datos----------------------

        /// <summary>
        /// Buscar IDs de los QR y cargarlos.
        /// </summary>
        static public void SearchQRCodes()
        {
            storesID.Clear();

            string[] QRFiles = Directory.GetFiles("..\\..\\bin\\Debug", "*.jpg");
            foreach (var file in QRFiles)
            {
                string pattern = @"(\d+)(?=.(jpg)$)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(file);

                storesID.Add(int.Parse(matches[0].ToString()));
            }
        }

        /// <summary>
        /// Buscar tiendas por ID y cargarlas.
        /// </summary>
        static public void Searchstores()
        {
            if (products == null || products.Capacity == 0)
            {
                ReadProducts();
            }

            if (storesID == null || storesID.Capacity == 0)
            {
                SearchQRCodes();
            }

            stores = new List<Store>();

            foreach (var IDs in storesID)
            {
                stores.Add(qr.ReadQR(IDs.ToString()));
            }
        }
    }
}
