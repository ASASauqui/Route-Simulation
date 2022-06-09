using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public class TXTObserver : AbstractObserver
    {
        private int _exchangeType;

        public TXTObserver()
        {
            this._exchangeType = 3;
        }

        public override void Update(Subject subject, NotifyEventArgs args)
        {
            this._exchangeType = args.ExchangeType;

            TXTExporter txtExporter = TXTExporter.GetInstance();
            txtExporter.AddLinesToTXT();
        }
    }
}
