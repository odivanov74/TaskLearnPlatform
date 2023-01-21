using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_HW46
{
    public interface IDataView
    {
        DataView Action(string task="Clean");       
    }
}
