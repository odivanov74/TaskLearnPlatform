using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_HW46
{
    public class ViewService
    {
        IDataView idataView;
        public ViewService(IDataView idataView)
        {
            this.idataView = idataView;
        }

        public DataView View(string task)
        {
            return idataView.Action(task);
        }
    }
}
