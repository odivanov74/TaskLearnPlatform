using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_HW46
{
    public class ActionBase
    {
        DataView dataView = new DataView();
        public DataViewManager manager;

        public ActionBase(DataSet data)
        {
            manager = new DataViewManager(data);
        }        
    }
}
