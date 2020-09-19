using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Courts
    {
        public string City;
        public string Name;
        public string Address;
        public static List<Courts> Courtslist = new List<Courts>();

        public Courts()
        {
            City = "";
            Name = "";
            Address = "";
        }
        public Courts(string i, string t, string tx)
        {
            City = i;
            Name = t;
            Address = tx;
        }

    }
}
