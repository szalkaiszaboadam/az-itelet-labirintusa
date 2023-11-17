using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_labirintusgame
{
    class modul
    {
        public string szoveg;
        public bool vege;
        public bool szerencse;
        public string szorny1nev;
        public int szorny1ugyesseg;
        public int szorny1eleterö;
        public string szorny2nev;
        public int szorny2ugyesseg;
        public int szorny2eleterö;
        public int lapoz1;
        public int lapoz2;


        public modul(string sor)
        {
            string[] szet = sor.Split('/');
            this.szoveg = szet[0];
            this.vege = Convert.ToBoolean(szet[1]);
            this.szerencse = Convert.ToBoolean(szet[2]);
            this.szorny1nev = szet[3];
            this.szorny1ugyesseg = Convert.ToInt32(szet[4]);
            this.szorny1eleterö = Convert.ToInt32(szet[5]);
            this.szorny2nev = szet[6];
            this.szorny2ugyesseg = Convert.ToInt32(szet[7]);
            this.szorny2eleterö = Convert.ToInt32(szet[8]);
            this.lapoz1 = Convert.ToInt32(szet[9]);
            this.lapoz2 = Convert.ToInt32(szet[10]);

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                #region file beolvasás 
                modul[] modulok = new modul[250];
                StreamReader olvas = new StreamReader("teszt.txt");
                int length = 1;
                
                while (!olvas.EndOfStream)
                {
                    modulok[length] = new modul(olvas.ReadLine());
                    length++;
                }
                
                olvas.Close();
                Console.WriteLine("kész!");
                #endregion


                Console.ReadKey();  
            }
        }
    }
}
