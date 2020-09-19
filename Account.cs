using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApplication1
{
    public abstract class Account
    {
        public string ID;
        public string Name;

        public Account()
        {
            ID = " ";
            Name = " ";
        }
        public Account(string i, string n)
        {
            ID = i;
            Name = n;
        }
        
    }
    public class Adminu : Account
    {
        public static List<Userr> userlist = new List<Userr>();

        bool check=false;
        public Adminu()
        {

        }
        public Adminu(string NId, string Nname,bool c)
            : base(NId, Nname)
        {
            check = c;
        }
        
        public bool CheckUpdates(string txt)
        {
            return check;
        }

        public static void saveReservations(string name,string phone,string email,string lname,string ucase)
        {
            Userr rr = new Userr(name,phone,email,lname,ucase); //name , phone ,email,lawyer name
            Adminu.userlist.Add(rr);
            TextWriter txt = new StreamWriter(@"Reserve.txt");
            for (int i = 0; i < Adminu.userlist.Count; i++)
            {

                txt.WriteLine(userlist[i].fullname.ToString() + "," + userlist[i].phone.ToString() + ","
                    + userlist[i].mail.ToString() + "," + userlist[i].lawyername.ToString() + "," + userlist[i].user_case.ToString() + ".");
            }
            txt.Close();
        }
    }

    public class Lawyer 
    {
        public string phoneNumber;
        public string Email;
        public string Type;
        public static List<Lawyer> Lawyerslist = new List<Lawyer>();
        public string ID;
        public string Name;
        public int rate;
        public Lawyer(string NId, string Nname, string p, string e, string s,int r)
        {
            ID = NId;
            Name = Nname;
            phoneNumber = p;
            Email = e;
            Type = s;
            rate = r;
        }
        public Lawyer()
            : base()
        {
            phoneNumber = "-";
            Email = "-";
            Type = "-";
        }
        public static void addrate(string n,int r)
        {
            for(int i=0;i<Lawyerslist.Count;i++)
            {
                if(Lawyerslist[i].Name==n)
                {
                    Lawyerslist[i].rate = (Lawyerslist[i].rate+r)/ 5;
                }
            }

        }

    }
    public class Userr
    {
        public string fullname;
        public string phone;
        public string mail;
        public string lawyername;
        public string user_case;
        public Userr()
        {
            fullname = " ";
            phone = " ";
            mail = " ";
            lawyername = "";
            user_case = "";
        }
        public Userr(string f,string p,string e,string l,string n)
        {
            fullname = f;
            phone = p;
            mail = e;
            lawyername=l;
            user_case=n;
        }
    }
   
}
