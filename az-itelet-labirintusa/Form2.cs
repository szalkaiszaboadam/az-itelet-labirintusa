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

            
          



        }


    }
}
