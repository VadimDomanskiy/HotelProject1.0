using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject1._0
{
    class BaseEntity_id
    {
       public string ID;
       public BaseEntity_id()
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
