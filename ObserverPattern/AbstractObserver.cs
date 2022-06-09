using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public abstract class AbstractObserver
    {
        public abstract void Update(Subject subject, NotifyEventArgs args);
    }
}

