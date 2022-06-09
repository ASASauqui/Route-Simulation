using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public class Simulation
    {
        // ----------------------Variables a utilizar----------------------
        private static Simulation instance;

        public bool createdRoute;
        public List<Store> stores;
        public List<Store> orderedStores;
        public List<Product> products;




        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor protegido.
        /// </summary>
        protected Simulation()
        {
            createdRoute = false;
            orderedStores = new List<Store>();
            products = new List<Product>();
        }

        /// <summary>
        /// Retornar instancia. Singleton.
        /// </summary>
        /// <returns></returns>
        public static Simulation GetInstance()
        {
            if (instance == null)
            {
                instance = new Simulation();
            }

            return instance;
        }





        // ----------------------Cargas----------------------

        /// <summary>
        /// Cargar componentes que se van a necesitar.
        /// </summary>
        public void LoadComponents()
        {
            // Leer productos.
            StructuredInformation.ReadProducts();

            // Cargar productos.
            products = StructuredInformation.products;

            // Cargar camiones.
            StructuredInformation.ReadTrucks();

            // Buscar tiendas.
            StructuredInformation.Searchstores();

            // Obtener tiendas.
            stores = StructuredInformation.stores;

            //Crear clases.
            LoadClasses();

            // Calcular total de productos.
            CalculateTotalSumPerProduct();
        }

        /// <summary>
        /// Cargar clases que se van a utilizar.
        /// </summary>
        private void LoadClasses()
        {
            for(int i = 0; i < products.Count; i++)
            {
                products[i].totalAmountPerProduct = 0;
                products[i].truckAmount = 0;
            }
        }



        // ----------------------Cálculos----------------------
        public void CalculateTotalSumPerProduct()
        {
            foreach (var store in stores)
            {
                foreach (var storeProduct in store.products)
                {
                    int product_ID = storeProduct.productID;

                    products.Find(product => product.productID == product_ID).totalAmountPerProduct += storeProduct.productQuantity;
                }
            }
        }


        // ----------------------Ganancias----------------------

        /// <summary>
        /// Ordenar las ganancias de cada tienda.
        /// </summary>
        public void SortStoresByProfits()
        {
            // Ganancias organizadas de mayor a menor.
            List<Profit> orderedProfits = GetProfits();

            // Añadir a orderedStores las tiendas ordenadas de mayor a menor.
            foreach (var profit in orderedProfits)
            {
                foreach (var store in stores)
                {
                    if (store.storeID == profit.storeID)
                    {
                        orderedStores.Add(store);
                        break;
                    }
                }
            }

            /*
            foreach (var a in orderedStores)
            {
                Console.WriteLine(a.storeID + "  " + a.storeName);
            }
            */
        }

        /// <summary>
        /// Obtener la lista de ganancias de manera ordenada.
        /// </summary>
        /// <returns></returns>
        public List<Profit> GetProfits()
        {
            List<Profit> profits = new List<Profit>();

            foreach (var store in stores)
            {
                Profit profit = new Profit()
                {
                    storeID = store.storeID,
                    productProfit = GetProfitByStore(store.products)
                };


                profits.Add(profit);
            }

            List<Profit> orderedProfits = profits.OrderByDescending(o => o.productProfit).ToList();

            return orderedProfits;
        }

        /// <summary>
        /// Obtener ganancia por tienda.
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public float GetProfitByStore(List<ProductOrder> products)
        {
            float profit = 0;
            foreach (var product in products)
            {
                profit += product.productPrice * product.productQuantity;
            }

            return profit;
        }





        // ----------------------Checks----------------------

        /// <summary>
        /// Checar si hay suficiente cantidad de camiones.
        /// </summary>
        /// <returns></returns>
        public bool CheckEnoughQuantityOfTrucks()
        {
            int currentAmount = 0;

            for (int i = 0; i < products.Count; i++)
            {
                currentAmount = 0;

                currentAmount = StructuredInformation.trucks[i].truckCapacity * products[i].truckAmount - products[i].totalAmountPerProduct;

                if (currentAmount < 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checar si excede la cantidad de camiones necesarios.
        /// </summary>
        /// <returns></returns>
        public bool CheckExceedsAmount()
        {
            int currentAmount = 0;

            for (int i = 0; i < products.Count; i++)
            {
                currentAmount = 0;

                currentAmount = StructuredInformation.trucks[i].truckCapacity * products[i].truckAmount - products[i].totalAmountPerProduct;

                if (currentAmount >= StructuredInformation.trucks[products[i].productID].truckCapacity)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checar si excede la cantidad límite de N camiones por producto.
        /// </summary>
        /// <returns></returns>
        public bool CheckExceedsTrucksAmount()
        {
            foreach (var product in products)
            {
                if (product.truckAmount > StructuredInformation.trucks[product.productID].truckAmount)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checar si sobrepasa la cantidad de camiones máxima general.
        /// </summary>
        /// <returns></returns>
        public bool CheckTrucksGeneralAmount()
        {
            int totalAmountTrucks = 0;
            for (int i = 0; i < products.Count; i++)
            {
                totalAmountTrucks += products[i].truckAmount;
            }

            if (totalAmountTrucks > StructuredInformation.trucksAmountLimit)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Comprobar todas las validaciones.
        /// </summary>
        /// <returns></returns>
        public bool GeneralCheck()
        {
            if (!CheckEnoughQuantityOfTrucks())
            {
                Message.ShowWarningOfNotEnoughQuantity();
                return false;
            }

            if (!CheckExceedsAmount())
            {
                Message.ShowWarningOfExceedingAmount();
                return false;
            }

            if (!CheckExceedsTrucksAmount())
            {
                Message.ShowWarningOfExceedingTrucksAmount();
                return false;
            }

            if (!CheckTrucksGeneralAmount())
            {
                throw new Exception("Se ha superado la cantidad general límite de camiones disponibles. Se han ingresado más productos de los que se pueden repartir. Incremente la cantidad de camiones límite.");
            }

            return true;
        }





        // ----------------------Clases internas----------------------

        /// <summary>
        /// Clase para organizar los beneficios por cada tienda.
        /// </summary>
        public class Profit
        {
            public int storeID { get; set; }
            public float productProfit { get; set; }
        }
    }
}
