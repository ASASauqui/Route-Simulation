using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
	public delegate void NotifyEvent<T>(T subject, NotifyEventArgs args);

	public class Subject
    {
		public event NotifyEvent<Subject> OnNotify;

		private int exchangeType;

		public void ExchangeTypeChanged(int _exchangeType)
		{
			this.exchangeType = _exchangeType;
			OnNotify(this, new NotifyEventArgs(_exchangeType));
		}
	}
}

