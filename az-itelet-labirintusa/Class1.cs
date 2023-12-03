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
        private string szoveg;
        private bool jatekVege;
        private int ellenseg;
        private int elsoLepes;
        private int masodikLepes;
        private int harmadikLepes;

        public Class1(string sor)
        {
            string[] d = sor.Split('/');
            szoveg = d[0];
            jatekVege = Convert.ToBoolean(d[1]);
            ellenseg = Convert.ToInt32(d[2]);
            elsoLepes = Convert.ToInt32(d[3]);
            masodikLepes = Convert.ToInt32(d[4]);
            harmadikLepes = Convert.ToInt32(d[5]);
        }

        public string Szoveg { get => szoveg; set => szoveg = value; }
        public bool JatekVege { get => jatekVege; set => jatekVege = value; }
        public int Ellenseg { get => ellenseg; set => ellenseg = value; }
        public int ElsoLepes { get => elsoLepes; set => elsoLepes = value; }
        public int MasodikLepes { get => masodikLepes; set => masodikLepes = value; }
        public int HarmadikLepes { get => harmadikLepes; set => harmadikLepes = value; }
    }
}