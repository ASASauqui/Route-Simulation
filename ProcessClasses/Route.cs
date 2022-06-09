using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public class Route
    {
        // ----------------------Variables a utilizar----------------------
        private static Route instance;
        private QRCodeAdapter qr;

        public List<Store> stores;
        public List<Store> storesCopy;
        public List<Product> products;
        public int[] currentProductAmount;




        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor protegido. Singleton.
        /// </summary>
        protected Route()
        {
            storesCopy = new List<Store>();
            products = new List<Product>();
            currentProductAmount = new int[3] { 0,0,0};
        }

        /// <summary>
        /// Retornar la instancia de la clase.
        /// </summary>
        /// <returns></returns>
        public static Route GetInstance()
        {
            if (instance == null)
            {
                instance = new Route();
            }

            return instance;
        }





        // ----------------------Creación de nuevas tiendas----------------------

        public void LoadComponents()
        {
            // Cargar productos.
            products = StructuredInformation.products;
        }





        // ----------------------Creación de nuevas tiendas----------------------

        /// <summary>
        /// Crear nueva tienda.
        /// </summary>
        /// <param name="currentAmount"></param>
        public void MakeStore(int[] currentAmount)
        {
            ProductOrder productOrder;
            List<ProductOrder> productsOrder = new List<ProductOrder>();


            stores[0].products = new List<ProductOrder>();

            for (int i = 0; i < products.Count; i++)
            {
                productOrder = new ProductOrder()
                {
                    productID = products[i].productID,
                    productName = products[i].productName,
                    productPrice = products[i].productPrice,
                    productQuantity = currentAmount[i]
                };

                productsOrder.Add(productOrder);
            }

            Store newStore = new Store()
            {
                storeID = stores[0].storeID,
                storeName = stores[0].storeName,
                products = productsOrder
            };

            storesCopy.Add(newStore);

            GenerateQR(newStore);
        }

        /// <summary>
        /// Generar nuevo código QR según una nueva tienda dada.
        /// </summary>
        /// <param name="newStore"></param>
        public void GenerateQR(Store newStore)
        {
            qr = new QRCodeAdapter();
            qr.CreateQR(newStore);
        }




        // ----------------------Controles de clase----------------------

        /// <summary>
        /// Siguiente elemento de la lista.
        /// </summary>
        public void NextListElement()
        {
            stores.RemoveAt(0);
        }
    }
}
