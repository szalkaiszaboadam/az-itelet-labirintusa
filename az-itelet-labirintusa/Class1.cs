using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace az_itelet_labirintusa/*.Resources*/
{
    internal class Class1
    {
        /*
        private string szoveg;
        priavte string jatekVege;
        private bool probaSzerencse;
        private bool kulcs;
        private string aranytaller; //private bool dobokockaDobas; 
        private string elsoEllenseg;
        private int elsoUgyesseg;
        private int elsoElet;
        private string masodikEllenseg;
        private int masodikUgyesseg;
        private int masodikElet;
        private int elsoLepes;
        private int masodikLepes;
        private int harmadikLepes;
        private int eleteroVesztes;
        private int szerencseVesztes;
        private bool eleteroDobas
        //
        //

        */


        private string szoveg;
        private string jatekVege;
        private int ellenseg;//
        private int elsoLepes;
        private int masodikLepes;
        private int harmadikLepes;
        private int eleteroVesztes;
        private int szerencseVesztes;
        private bool probaSzerencse;
        private string elsoEllenseg;
        private int elsoElet;
        private int elsoUgyesseg;
        private string masodikEllenseg;
        private int masodikElet;
        private int masodikUgyesseg;
        private string egyszerreKulon;//

        public Class1(string sor)
        {
            string[] d = sor.Split('/');
            szoveg = d[0];
            jatekVege = d[1];
            ellenseg = Convert.ToInt32(d[2]);
            elsoLepes = Convert.ToInt32(d[3]);
            masodikLepes = Convert.ToInt32(d[4]);
            harmadikLepes = Convert.ToInt32(d[5]);
            eleteroVesztes = Convert.ToInt32(d[6]);
            szerencseVesztes = Convert.ToInt32(d[7]);
            probaSzerencse = Convert.ToBoolean(d[8]);
            elsoEllenseg = d[9];
            elsoElet = Convert.ToInt32(d[10]);
            elsoUgyesseg = Convert.ToInt32(d[11]);
            masodikEllenseg = d[12];
            masodikElet = Convert.ToInt32(d[13]);
            masodikUgyesseg = Convert.ToInt32(d[14]);
            egyszerreKulon = d[15];

            /*szoveg = d[0];
            jatekVege = d[1];
            probaSzerencse = Convert.ToBoolean(d[2]);
            kulcs = Convert.ToBoolean(d[3]);
            aranytaller = d[4];
            elsoEllenseg = d[5];
            elsoUgyesseg = Convert.ToInt32(d[6]);
            elsoElet = Convert.ToInt32(d[7]);
            masodikEllenseg = d[8];
            masodikUgyesseg = Convert.ToInt32(d[9]);
            masodikElet = Convert.ToInt32(d[10]);
            elsoLepes = Convert.ToInt32(d[11]);
            masodikLepes = Convert.ToInt32(d[12]);
            harmadikLepes = Convert.ToInt32(d[13]);
            eleteroVesztes = Convert.ToInt32(d[14]);
            szerencseVesztes = Convert.ToInt32(d[15]);
            eleteroDobas = Convert.ToBoolean(d[16]);*/

        }
    
        /*
        public string Szoveg { get => szoveg; set => szoveg = value; }
        public string JatekVege { get => jatekVege; set => jatekVege = value; }
        public bool ProbaSzerencse { get => probaSzerencse; set => probaSzerencse = value; }
        public bool Kulcs { get => kulcs; set => kulcs = value; }
        public string Aranytaller { get => aranytaller; set => aranytaller = value; }
        public string ElsoEllenseg { get => elsoEllenseg; set => elsoEllenseg = value; }
        public int ElsoUgyesseg { get => elsoUgyesseg; set => elsoUgyesseg = value; }
        public int ElsoElet { get => elsoElet; set => elsoElet = value; }
        public string MasodikEllenseg { get => masodikEllenseg; set => masodikEllenseg = value; }
        public int MasodikUgyesseg { get => masodikUgyesseg; set => masodikUgyesseg = value; }
        public int MasodikElet { get => masodikElet; set => masodikElet = value; }
        public int ElsoLepes { get => elsoLepes; set => elsoLepes = value; }
        public int MasodikLepes { get => masodikLepes; set => masodikLepes = value; }
        public int HarmadikLepes { get => harmadikLepes; set => harmadikLepes = value; }
        public int EleteroVesztes { get => eleteroVesztes; set => eleteroVesztes = value; }
        public int SzerencseVesztes { get => szerencseVesztes; set => szerencseVesztes = value; }
        public bool EleteroDobas { get => eleteroDobas; set => eleteroDobas = value; }
        */


        public string Szoveg { get => szoveg; set => szoveg = value; }
        public string JatekVege { get => jatekVege; set => jatekVege = value; }
        public int Ellenseg { get => ellenseg; set => ellenseg = value; }
        public int ElsoLepes { get => elsoLepes; set => elsoLepes = value; }
        public int MasodikLepes { get => masodikLepes; set => masodikLepes = value; }
        public int HarmadikLepes { get => harmadikLepes; set => harmadikLepes = value; }
        public int EleteroVesztes { get => eleteroVesztes; set => eleteroVesztes = value; }
        public int SzerencseVesztes { get => szerencseVesztes; set => szerencseVesztes = value; }
        public bool ProbaSzerencse { get => probaSzerencse; set => probaSzerencse = value; }


        public string ElsoEllenseg { get => elsoEllenseg; set => elsoEllenseg = value; }
        public int ElsoElet { get => elsoElet; set => elsoElet = value; }
        public int ElsoUgyesseg { get => elsoUgyesseg; set => elsoUgyesseg = value; }


        public string MasodikEllenseg { get => masodikEllenseg; set => masodikEllenseg = value; }
        public int MasodikElet { get => masodikElet; set => masodikElet = value; }
        public int MasodikUgyesseg { get => masodikUgyesseg; set => masodikUgyesseg = value; }

        public string EgyszerreKulon { get => egyszerreKulon; set => egyszerreKulon = value; }
    }
}