using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public class TextBoxObserver : AbstractObserver
    {
        private int _exchangeType;

        public TextBoxObserver()
        {
            this._exchangeType = 3;
        }

        public override void Update(Subject subject, NotifyEventArgs args)
        {
            this._exchangeType = args.ExchangeType;

            TextBoxBinnacleForm textBoxBinnacleForm = new TextBoxBinnacleForm();

            if (!Application.OpenForms.OfType<TextBoxBinnacleForm>().Any())
            {
                textBoxBinnacleForm.Show();
            }
        }
    }
}