using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursV2.View
{
    internal class BaseContext
    {
        private static ProductMarketEntities11 _GetContext;
        public static ProductMarketEntities11 GetContext()
        {
            if(_GetContext == null)
                _GetContext = new ProductMarketEntities11();
            return _GetContext;
        }
    }
}
