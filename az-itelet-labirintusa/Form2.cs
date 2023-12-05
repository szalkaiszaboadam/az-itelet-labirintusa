/*using az_itelet_labirintusa.Resources;*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace az_itelet_labirintusa
{

    public partial class Form2 : Form
    {

        static Random Rnd = new Random(); 
        public static int dobokocka()
        {
            return Rnd.Next(1, 7);
        }

        


        static List<Class1> jatekFajl = new List<Class1>();


        List<string> felszereles = new List<string>();
        List<string> elelem = new List<string>();
        List<string> ekkovek = new List<string>();


        int arany;


        int italDarab;
        string valasztottItal;

        int jelenlegiFejezet;

        int eredetiEletero;
        int eredetiUgyesseg;
        int eredetiSzerencse;

        int jelenlegiEletero;
        int jelenlegiUgyesseg;
        int jelenlegiSzerencse;


        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 jatekos = new Form2();



            this.BackColor = Color.FromArgb(255, 255, 255);
            this.Text = "Az Ítélet Labirintusa - Új Játék";
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("MedievalSharp-Regular.ttf");  //Bitmgothic.ttf
            label1.Font = new Font(pfc.Families[0], 67, FontStyle.Bold);         
            label1.Text = " Az Ítélet Labirintusa";
            //label3.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(0, 0, 00);

            textBox1.Font = new Font(pfc.Families[0], 37, FontStyle.Regular);

            //richTextBox1.Text = "Belöknek a lenti alagútba, és rád zárják az ajtót, kizárva ezzel a nyíláson át beszűrődő természetes világosságot. Innentől kezdve kizárólag a falra rögzített fáklyáktól remélhetsz valamennyi fényt. Ahogy szemed hozzászokik a homályhoz, látod, hogy az alagút észak felé indul. Nagyot sóhajtasz a dolog igazságtalansága felett, majd elindulsz abba az irányba. Lapozz a 41-re.";

            groupBox1.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox2.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox4.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox3.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox5.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox6.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox7.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);
            groupBox8.Font = new Font(pfc.Families[0], 17, FontStyle.Bold);

            textBox2.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox3.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox5.Font = new Font("Courier New", 13, FontStyle.Regular);
            /*felszereles*/textBox4.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox7.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox8.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox9.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox6.Font = new Font("Courier New", 13, FontStyle.Regular);

            /*MessageBox.Font = new Font("Courier New", 13, FontStyle.Regular);
            MessageBoxButtons.*/

            //https://stackoverflow.com/questions/70963656/how-to-make-a-form-click-a-button-when-loaded



            StreamReader sr = new StreamReader("teszt.txt", Encoding.UTF8);
            //sr.ReadLine();
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Class1 h = new Class1(sor);
                jatekFajl.Add(h);
            }

            /*while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Class1 h = new Class1(sor);
                jatekFajl.Add(h);
            }*/
            sr.Close();

            lapozKetto.Visible = false;
            lapozHarom.Visible = false;

            jelenlegiFejezet = 1;

            arany = 20;

            valasztottItal = Form3.valasztott;
            italDarab = 2;

            felszereles.Add("Kard");
            felszereles.Add("Bőrvért");


            //ÜGYESSÉG, ÉLETERŐ ÉS SZERENCSE

            int tempEletero = dobokocka() + 12;
            int tempUgyesseg = dobokocka() + 6;
            int tempSzerencse = dobokocka() + 6;

            eredetiEletero = tempEletero;
            eredetiUgyesseg = tempUgyesseg;
            eredetiSzerencse = tempSzerencse;

            jelenlegiEletero = tempEletero;
            jelenlegiUgyesseg = tempUgyesseg;
            jelenlegiSzerencse = tempSzerencse;



            textBox1.Text = jatekFajl[1].Szoveg;

            textBox8.Text = String.Join(Environment.NewLine, ekkovek);
            textBox6.Text = String.Join(Environment.NewLine, elelem);
            textBox4.Text = String.Join(Environment.NewLine, felszereles);
            textBox7.Text = arany.ToString();

            textBox5.Text = eredetiEletero  + "/" + jelenlegiEletero;
            textBox2.Text = eredetiUgyesseg + "/" + jelenlegiUgyesseg;
            textBox3.Text = eredetiSzerencse + "/" + jelenlegiSzerencse;

            textBox9.Text = "2/" + italDarab + " " + valasztottItal;

            lapozEgy.Visible = true;
            lapozEgy.Text = "Lapozz a(z) " + jatekFajl[1].ElsoLepes + ". lapodra";
            jelenlegiFejezet = jatekFajl[1].ElsoLepes;

            label2.Text = jelenlegiFejezet.ToString();
        }

        private void lapozEgy_Click(object sender, EventArgs e)
        {
            if (jatekFajl[jelenlegiFejezet].JatekVege == true)
            {
                const string szoveg = "A játék számodra most véget ért! Vágj neki újra!";
                const string fejlec = "";
                DialogResult result = MessageBox.Show(szoveg, fejlec,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }


            label2.Text = jelenlegiFejezet.ToString();


            if (jatekFajl[jelenlegiFejezet].MasodikLepes != 0)
            {
                lapozKetto.Visible = true;
                lapozKetto.Text = "Lapozz a(z) " + jatekFajl[jelenlegiFejezet].MasodikLepes + ". lapodra";
            }

            if (jatekFajl[jelenlegiFejezet].HarmadikLepes != 0)
            {
                lapozHarom.Visible = true;
                lapozHarom.Text = "Lapozz a(z) " + jatekFajl[jelenlegiFejezet].MasodikLepes + ". lapodra";
            }


            if (jatekFajl[jelenlegiFejezet].ElsoLepes != 0)
            {
                lapozEgy.Visible = true;
                lapozEgy.Text = "Lapozz a(z) " + jatekFajl[jelenlegiFejezet].ElsoLepes + ". lapodra";
            }

       


            textBox1.Text = jatekFajl[jelenlegiFejezet].Szoveg;

            textBox8.Text = String.Join(Environment.NewLine, ekkovek);
            textBox6.Text = String.Join(Environment.NewLine, elelem);
            textBox4.Text = String.Join(Environment.NewLine, felszereles);
            textBox7.Text = arany.ToString();

            textBox5.Text = eredetiEletero + "/" + jelenlegiEletero;
            textBox2.Text = eredetiUgyesseg + "/" + jelenlegiUgyesseg;
            textBox3.Text = eredetiSzerencse + "/" + jelenlegiSzerencse;

            textBox9.Text = "2/" + italDarab + " " + valasztottItal;





            jelenlegiFejezet = jatekFajl[jelenlegiFejezet].ElsoLepes;
        }
    }
}
