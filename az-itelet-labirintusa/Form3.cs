using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace az_itelet_labirintusa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Az Ítélet Labirintusa - Háttértörténet";
            ClientSize = new Size(870, 790);
            Width = 870;
            Height = 790;
            //this.BackColor = Color.FromArgb(0, 0, 0);
            this.BackColor = Color.FromArgb(255, 255, 255);


            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("MedievalSharp-Regular.ttf");  //Bitmgothic.ttf
            label2.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            label1.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            label1.Text = "HÁTTÉRTÖRTÉNET";
            //label3.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(0, 0, 00);

            label2.Visible = false; 

            textBox1.Font = new Font("Courier New", 12, FontStyle.Regular);

            button2.Text = "Tovább";
            button2.Font = new Font("Courier New", 8, FontStyle.Regular);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
        }
    }
}
