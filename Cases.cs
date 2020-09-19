using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cases
    {
        public static string Type;
        public static string casee;
        public static List<Cases> Caseslist = new List<Cases>();
         public Cases()
        {
            Type = " ";
            casee = " ";
        }
         public Cases(string f, string p)
        {
            Type = f;
            casee = p;
        }
        public void fill(string c,string t)
        {
            //Cases c = new Cases(t,c);


        }

    }
}
