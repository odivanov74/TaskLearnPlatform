using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_HW46
{
    public class Clean : ActionBase, IDataView
    {
        DataSet data;        

        public Clean(DataSet data) : base(data)
        {
            this.data = data;
        }

        public DataView Action(string task)
        { 
            if (data != null)
            {
                while (data.Tables[0].Rows.Count > 0)
                {
                    data.Tables[0].Rows.RemoveAt(0);
                }
                while (data.Tables[0].Columns.Count > 0)
                {
                    data.Tables[0].Columns.RemoveAt(0);
                }
                data.Tables[0].Clear();
                return base.manager.CreateDataView(data.Tables[0]);
            }
            return null;
        }
    }
}
