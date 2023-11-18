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
            ClientSize = new Size(400, 300);
            Width = 400;
            Height = 300;
            this.BackColor = Color.FromArgb(0, 0, 0);


            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("Bitmgothic.ttf");
            label3.Font = new Font(pfc.Families[0], 30, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 255);
            label3.Text = "Az Itelet\nLabirintusa";
            


            button1.Text = "Új Játék Indítás";

            button2.BackColor = Color.FromArgb(21, 255, 255);
            button2.Text = "Kilépés";

            label1.ForeColor = Color.FromArgb(255, 255, 255);
            label1.Font = new Font("Arial", 7, FontStyle.Regular);
            label1.Text = "Készítette Nagy Gábor, Bodri Dávid és Szalkai-Szabó Ádám";

            label2.ForeColor = Color.FromArgb(255, 255, 255);
            label2.Font = new Font("Arial", 7, FontStyle.Regular);
            label2.Text = "2023";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
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
