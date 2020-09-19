using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApplication1
{
    public class Law
    {
        public string ID;
        public string lType;
        public string LawText;
        public static List<Law> Lawslist = new List<Law>();

        public Law()
        {
            ID = "";
            lType = "";
            LawText = "";
        }
        public Law(string i, string t, string tx)
        {
            ID = i;
            lType = t;
            LawText = tx;
        }
        public void Update(string Lawid, string lawtxt)
        {
            for (int i = 0; i < Law.Lawslist.Count; i++)
            {
                if (Law.Lawslist[i].ID == Lawid)
                {
                    Law.Lawslist[i].LawText = lawtxt;
                }
            }
            Data.writeFile();
        }
        public void DeleteLaw(string id)
        {
            for (int i = 0; i < Lawslist.Count; i++)
            {
                if(Lawslist[i].ID==id)
                {
                    Lawslist.RemoveAt(i);
                }
            }
            Data.writeFile();
        }
        public void AddLaw(string id,string t,string txt)
        {
            Law a = new Law(id, t, txt);
            Law.Lawslist.Add(a);
            Data.writeFile();
        }

    }
}
