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
        public string vege;
        public string probaszerencse;
        public string kulcs;
        public string dobokockadobas;
        public string szorny1nev;
        public int szorny1ugyesseg;
        public int szorny1eleterö;
        public string szorny2nev;
        public int szorny2ugyesseg;
        public int szorny2eleterö;
        public int lapoz1;
        public int lapoz2;
        public int lapoz3;
        public int eleterolevonas;
        public int szerencslevonas;
        public string eleterodobas;
        
        public modul(string sor)
        {
            string[]szet = sor.Split('/');
            this.szoveg = szet[0];
            this.vege = szet[1];
            this.probaszerencse = szet[2];
            this.kulcs = szet[3];
            this.dobokockadobas = szet[4];
            this.szorny1nev = szet[5];
            this.szorny1ugyesseg = Convert.ToInt32(szet[6]);
            this.szorny1eleterö = Convert.ToInt32(szet[7]);
            this.szorny2nev = szet[8];
            this.szorny2ugyesseg = Convert.ToInt32(szet[9]);
            this.szorny2eleterö = Convert.ToInt32(szet[10]);
            this.lapoz1 = Convert.ToInt32(szet[11]);
            this.lapoz2 = Convert.ToInt32(szet[12]);
            this.lapoz3 = Convert.ToInt32(szet[13]);
            this.eleterolevonas = Convert.ToInt32(szet[14]);
            this.szerencslevonas = Convert.ToInt32(szet[15]);
            this.eleterodobas = szet[16];
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                #region file beolvasás 
                modul[] modulok = new modul[201];
                StreamReader olvas = new StreamReader("szoveg.txt");
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
