using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSeriesForms_Kinyapin.DataBase;

namespace TimeSeriesForms_Kinyapin
{
    static public class SaveContext
    {
        static public ContextDB _contextDB;
        static public ContextDB GetContext()
        {
            return _contextDB;
        }
        static public void SetContext(ContextDB context)
        {
            _contextDB = context;
        }
    }
}
