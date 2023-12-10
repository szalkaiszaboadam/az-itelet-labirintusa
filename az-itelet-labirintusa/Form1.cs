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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Az Ítélet Labirintusa";
            ClientSize = new Size(450, 320);
            Width = 450;
            Height = 320;
            //this.BackColor = Color.FromArgb(0, 0, 0);
            //this.BackColor = Color.FromArgb(255, 255, 255);

            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("MedievalSharp-Regular.ttf");  //Bitmgothic.ttf
            label3.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            label3.Text = "Az Ítélet";
            label5.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            //label3.ForeColor = Color.FromArgb(255, 255, 255);
            label3.ForeColor = Color.FromArgb(60, 32, 22);
            label4.ForeColor = Color.FromArgb(60, 32, 22);
            label1.ForeColor = Color.FromArgb(60, 32, 22);
            //label3.ForeColor = Color.FromArgb(118, 77, 56);

            //label3.BackColor = System.Drawing.Color.Transparent;
            button1.ForeColor = Color.FromArgb(60, 32, 22);
            button2.ForeColor = Color.FromArgb(60, 32, 22);
            label5.ForeColor = Color.FromArgb(60, 32, 22);


            button1.Font = new Font("Courier New", 8, FontStyle.Regular);
            button2.Font = new Font("Courier New", 8, FontStyle.Regular);
            label1.Font = new Font("Courier New", 7, FontStyle.Regular);
            //label2.Font = new Font("Courier New", 8, FontStyle.Regular);
            label4.Font = new Font("Courier New", 7, FontStyle.Regular);



            button1.Text = "Új Játék";
            button2.Text = "Kilépés";  
            label1.Text = "Készítette: Nagy Gábor, Bodri Dávid, Sz.-Sz. Ádám";
            label4.Text = "Írta: Jonathan Ford";

            /*button1.Text = "Uj Jatek";
            button2.Text = "Kilepes";  
            label1.Text = "Keszitette Nagy Gabor, Bodri David es Szalkai-Szabo Adam";*/
            /*button1.Font = new Font(pfc2.Families[0], 11, FontStyle.Regular);
button2.Font = new Font(pfc2.Families[0], 11, FontStyle.Regular);
label1.Font = new Font(pfc2.Families[0], 9, FontStyle.Regular);
label2.Font = new Font(pfc2.Families[0], 9, FontStyle.Regular);*/

            //label2.Text = "PG 2023";


            //button2.BackColor = Color.FromArgb(21, 255, 255);
            /*label1.ForeColor = Color.FromArgb(255, 255, 255);
            label2.ForeColor = Color.FromArgb(255, 255, 255);*/

            //label1.ForeColor = Color.FromArgb(0, 0, 0);
            //label2.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form2().ShowDialog();
            new Form3().ShowDialog();

            /*ClientSize = new Size(1920, 1080);
            Width = 1920;
            Height = 1080;*/

            // button2.Location = new Point(10, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
