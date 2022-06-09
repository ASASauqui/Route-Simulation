using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public class GridObserver : AbstractObserver
    {
        private int _exchangeType;

        public GridObserver()
        {
            this._exchangeType = 3;

        }
        public override void Update(Subject subject, NotifyEventArgs args)
        {
            this._exchangeType = args.ExchangeType;

            GridBinnacleForm gridBinnacleForm = new GridBinnacleForm();

            if (!Application.OpenForms.OfType<GridBinnacleForm>().Any())
            {
                gridBinnacleForm.Show();
            }
        }
    }
}
