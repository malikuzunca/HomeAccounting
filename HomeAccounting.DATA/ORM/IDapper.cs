using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.ORM
{
    public interface IDapper : IDisposable
    {
        List<T> QueryApp<T>(string sql);
    }
}
