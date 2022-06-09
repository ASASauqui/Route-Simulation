using IronBarCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public class QRCodeAdapter : QRManagementI
    {
        /// <summary>
        /// Crear código QR desde la API.
        /// </summary>
        /// <param name="store"></param>
        public void CreateQR(Store store)
        {
            string filename = store.storeID.ToString() + ".jpg";
            BarcodeWriter.CreateBarcode(JsonConvert.SerializeObject(store), BarcodeWriterEncoding.QRCode,500,500).SaveAsJpeg(filename);
        }

        /// <summary>
        /// Leer código QR desde la API.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public Store ReadQR(string filename)
        {
            Console.WriteLine(filename);
            filename = filename + ".jpg";
            BarcodeResult QR_data = BarcodeReader.QuicklyReadOneBarcode(filename);

            if (QR_data != null)
            {
                return JsonConvert.DeserializeObject<Store>(QR_data.Value);
            }

            throw new Exception("El QR no existe.");
        }
    }
}
