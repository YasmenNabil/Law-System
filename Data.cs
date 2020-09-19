using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApplication1
{
    public class Data
    {
        public void read_Lawyer()
        {
            FileStream fs = new FileStream("Lawyers.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] arr = s.Split(',');
                string id = arr[0];
                string name = arr[1];
                string phone = arr[2];
                string email = arr[3];
                string T = arr[4];
                int r = int.Parse(arr[5]);
                Lawyer cc = new Lawyer(id, name, phone, email, T,r);
                Lawyer.Lawyerslist.Add(cc);
            }
            fs.Close();
        }
        public void read_Law()
        {
            FileStream fs = new FileStream("Law.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] arr = s.Split(',');
                string id = arr[0];
                string type = arr[1];
                string txt = arr[2];
                
                Law cc = new Law(id, type, txt);
                Law.Lawslist.Add(cc);
            }
            fs.Close();
        }
        public void read_Courts()
        {
            FileStream fs = new FileStream("Court.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] arr = s.Split(',');
                string city = arr[0];
                string name = arr[1];
                string address = arr[2];

                Courts cc = new Courts(city, name, address);
                Courts.Courtslist.Add(cc);
            }
            fs.Close();
        }
        

        public static void writeFile()
        {
            TextWriter txt = new StreamWriter(@"Law.txt");
            for (int i = 0; i < Law.Lawslist.Count; i++)
            {

                txt.WriteLine(Law.Lawslist[i].ID.ToString() + "," + Law.Lawslist[i].lType + "," + Law.Lawslist[i].LawText + ".");
            }
            txt.Close();


        }
        public static void writeFilelawyer()
        {

            TextWriter txt = new StreamWriter(@"Lawyers.txt");
            for (int i = 0; i < Lawyer.Lawyerslist.Count; i++)
            {

                txt.WriteLine(Lawyer.Lawyerslist[i].ID.ToString() + "," + Lawyer.Lawyerslist[i].Name.ToString() + ","
                    + Lawyer.Lawyerslist[i].phoneNumber.ToString() + "," + Lawyer.Lawyerslist[i].Email.ToString() + "," +
                    Lawyer.Lawyerslist[i].Type.ToString() + "," + Lawyer.Lawyerslist[i].rate.ToString());
            }
            txt.Close();
        }
        public void read_users()
        {
            FileStream fs = new FileStream("Reserve.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] arr = s.Split(',');
                string fname = arr[0];
                string p = arr[1];
                string e = arr[2];
                string lname = arr[3];
                string casee = arr[4];
                Userr cc = new Userr(fname, p, e, lname, casee);
                Adminu.userlist.Add(cc);
            }
            fs.Close();
        }
    }
}
