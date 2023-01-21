using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_HW46
{
    public class FilterData : ActionBase, IDataView
    {
        DataSet data;

        public FilterData(DataSet data) : base(data)
        {
            this.data = data;
        }

        public DataView Action(string task)
        {
            base.manager.DataViewSettings[0].RowFilter = task;
            return base.manager.CreateDataView(data.Tables[0]);
        }
    }
}
