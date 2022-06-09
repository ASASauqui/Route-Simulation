using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public class NotifyEventArgs : EventArgs
	{
		private int _exchangeType;
		public int ExchangeType
		{
			get
			{
				return _exchangeType;
			}
		}

		public NotifyEventArgs(int state)
		{
			_exchangeType = state;
		}
	}
}

