using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject1._0
{
    class User : BaseEntity_id
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public string UserType { get; set; }
        public DateTime Birthday { get; set; }
        public uint? HotelID = null;
    }
}
