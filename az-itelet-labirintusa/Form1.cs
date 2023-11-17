using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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


            button1.Text = "Indítás";
            button2.Text = "Kilépés";

            label1.Text = "Készítette Nagy Gábor, Bodri Dávid és Szalkai-Szabó Ádám";
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
