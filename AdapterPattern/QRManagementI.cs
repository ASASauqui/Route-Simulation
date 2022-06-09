using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public interface QRManagementI
    {
        void CreateQR(Store store);
        Store ReadQR(string filename);
    }
}
