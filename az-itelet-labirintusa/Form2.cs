using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace az_itelet_labirintusa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
            textBox4.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox7.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox8.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox9.Font = new Font("Courier New", 13, FontStyle.Regular);
            textBox6.Font = new Font("Courier New", 13, FontStyle.Regular);

            /*MessageBox.Font = new Font("Courier New", 13, FontStyle.Regular);
            MessageBoxButtons.*/

            
            


            const string message =
        "Az Osztriga-öböltől délre, nagyjából nyolcvan kilométerre terül el a Koponyák Sivataga. Forró, veszedelmes és mindent egybevetve igen kellemetlen hely, ám te kénytelen vagy átkelni rajta, hisz déli felén terül el a drágakőbányáiról messze földön híres és gazdag Zafirváros. Vonz a hatalmas vagyon, mely minden harcos számára elérhető, aki hajlandó akár a köveket, akár a pénzt kísérni egyik településből a másikba. A munka azonban nem veszélytelen.\r\nAhogy a sivatag felé közeledsz, segélykiáltásokat hallasz az utat szegélyező bozótos túloldaláról. Mikor közelebb lépsz, még épp látod, ahogy egy ocsmány Goblin tört márt egy igen fontosnak látszó Elf férfi szívébe, aki azonnal a földre roskad.\r\nEgyből előre rontasz, hogy elkapd a gyilkost, ám pechedre megbotlasz, az aljas teremtmény pedig észrevesz téged, és eltűnik az aljnövényzetben.\r\nCsak állsz, és a halott Elf tetemét bámulod. Amennyire meg tudod állapítani, az egyik helyi törzs vezetője lehetett. Kezében egy nagy, kék színű gyémántot szorongat. Hirtelen megrezzennek körülötted a bokrok! Arra gondolsz, talán a Goblin tért vissza, így előhúzod kardodat. Legnagyobb meglepetésedre azonban húsz vagy harminc Elf gyűrűjében találod magadat, akik megfeszített íjakkal vesznek körbe. Egyikük előre lép, és komoran megszólít.\r\n\r\n– Ember! – kezdi. – Karddal a kezedben, apám, a Törzsfőnökünk meggyilkolt testével a lábad előtt találtunk rád.\r\nRájössz, hogy ezek azt hiszik, te vagy a gyilkos. Tiltakozni próbálnál, azonban az Elf egy intésére elhallgatsz. Az ítélet Labirintusához viszünk fejezi be mondanivalóját. Hátat fordít neked, és elsétál, te pedig kísérőid körében kénytelen vagy követni. Miközben az örök egymás közt vitatják meg a látottakat, megtudod, hogy a labirintus egy titkos hely, ahol a bűnösöket teszik próbára. Minden ..próba\" előtt egy kis Aranyszobrot rejtenek el annak mélyén, a próba alanyának pedig meg kell találnia azt. Ha ez nem sikerül, bünösnek ítélik, ám ha rálel, és sikerül kijuttatnia odabentről, ártatlannak találják, és szabadon engedik.\r\nA fak ritkulni kezdenek, a menet pedig egy hatalmas fa törzsénél megtorpan. A Főnök fia motyog pár szót, mire a kéreg egy része kinyílik, mögötte pedig feltűnik a labirintus bejárata...?";
            const string caption = "Háttértörténet";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Information);

            // If the no button was pressed ...
           /* if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                //e.Cancel = true;
                System.Windows.Forms.MessageBox.Show("Az Osztriga-öböltől délre, nagyjából nyolcvan kilométerre terül el a Koponyák Sivataga. Forró, veszedelmes és mindent egybevetve igen kellemetlen hely, ám te kénytelen vagy átkelni rajta, hisz déli felén terül el a drágakőbányáiról messze földön híres és gazdag Zafirváros. Vonz a hatalmas vagyon, mely minden harcos számára elérhető, aki hajlandó akár a köveket, akár a pénzt kísérni egyik településből a másikba. A munka azonban nem veszélytelen.\r\nAhogy a sivatag felé közeledsz, segélykiáltásokat hallasz az utat szegélyező bozótos túloldaláról. Mikor közelebb lépsz, még épp látod, ahogy egy ocsmány Goblin tört márt egy igen fontosnak látszó Elf férfi szívébe, aki azonnal a földre roskad.\r\nEgyből előre rontasz, hogy elkapd a gyilkost, ám pechedre megbotlasz, az aljas teremtmény pedig észrevesz téged, és eltűnik az aljnövényzetben.\r\nCsak állsz, és a halott Elf tetemét bámulod. Amennyire meg tudod állapítani, az egyik helyi törzs vezetője lehetett. Kezében egy nagy, kék színű gyémántot szorongat. Hirtelen megrezzennek körülötted a bokrok! Arra gondolsz, talán a Goblin tért vissza, így előhúzod kardodat. Legnagyobb meglepetésedre azonban húsz vagy harminc Elf gyűrűjében találod magadat, akik megfeszített íjakkal vesznek körbe. Egyikük előre lép, és komoran megszólít.\r\n\r\n– Ember! – kezdi. – Karddal a kezedben, apám, a Törzsfőnökünk meggyilkolt testével a lábad előtt találtunk rád.\r\nRájössz, hogy ezek azt hiszik, te vagy a gyilkos. Tiltakozni próbálnál, azonban az Elf egy intésére elhallgatsz. Az ítélet Labirintusához viszünk fejezi be mondanivalóját. Hátat fordít neked, és elsétál, te pedig kísérőid körében kénytelen vagy követni. Miközben az örök egymás közt vitatják meg a látottakat, megtudod, hogy a labirintus egy titkos hely, ahol a bűnösöket teszik próbára. Minden ..próba\" előtt egy kis Aranyszobrot rejtenek el annak mélyén, a próba alanyának pedig meg kell találnia azt. Ha ez nem sikerül, bünösnek ítélik, ám ha rálel, és sikerül kijuttatnia odabentről, ártatlannak találják, és szabadon engedik.\r\nA fak ritkulni kezdenek, a menet pedig egy hatalmas fa törzsénél megtorpan. A Főnök fia motyog pár szót, mire a kéreg egy része kinyílik, mögötte pedig feltűnik a labirintus bejárata...", "Háttértörténet");

            }*/



        }


    }
}
