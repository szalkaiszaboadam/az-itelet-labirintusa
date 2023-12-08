using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace az_itelet_labirintusa
{
    public partial class Form3 : Form
    {

        public static string valasztott = "";

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
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            var pfc = new PrivateFontCollection();
            pfc.AddFontFile("MedievalSharp-Regular.ttf");  //Bitmgothic.ttf
            label2.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            label1.Font = new Font(pfc.Families[0], 34, FontStyle.Bold);
            label1.Text = "HÁTTÉRTÖRTÉNET";
            //label3.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(0, 0, 00);

            label2.Visible = false; 

            textBox1.Font = new Font("Courier New", 9, FontStyle.Regular);

            button2.Text = "Tovább";
            button2.Font = new Font("Courier New", 8, FontStyle.Regular);


            textBox2.Visible = false; 
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            label3.Visible = false;
            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;

            label3.Visible = true;

            textBox2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;

            button1.Visible = true;
            button1.Text = "Kalandra fel";
            button1.Font = new Font("Courier New", 8, FontStyle.Regular);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Az Ítélet Labirintusa";
            ClientSize = new Size(870, 560);
            Width = 870;
            Height = 560;
            //this.BackColor = Color.FromArgb(0, 0, 0);
            this.BackColor = Color.FromArgb(255, 255, 255);

            checkBox1.ForeColor = Color.FromArgb(60, 32, 22);
            checkBox2.ForeColor = Color.FromArgb(60, 32, 22);
            checkBox3.ForeColor = Color.FromArgb(60, 32, 22);
            textBox2.ForeColor = Color.FromArgb(60, 32, 22);
            textBox1.ForeColor = Color.FromArgb(60, 32, 22);
            label3.ForeColor = Color.FromArgb(60, 32, 22);
            label2.ForeColor = Color.FromArgb(60, 32, 22);
            label1.ForeColor = Color.FromArgb(60, 32, 22);
            button2.ForeColor = Color.FromArgb(60, 32, 22);
            button1.ForeColor = Color.FromArgb(60, 32, 22);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked))
            {
                const string szoveg = "Nem választottál a megadott lehetőségek közül, kérjük próbáld újra!";
                const string fejlec = "";//"Hibás érték";
                /*var msgBox = */MessageBox.Show(szoveg, fejlec,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);

                /* if (msgBox == DialogResult.OK)
                 {
                    //Application.Exit();
                    new Form3().ShowDialog();
                }*/
            }

            else if ((checkBox1.Checked && checkBox2.Checked && checkBox3.Checked) || (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked) || (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked) || (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked))
            {
                const string szoveg = "Csak egyet választhasz a megadott lehetőségek közül, kérjük próbáld újra!";
                const string fejlec = "";//"Figyelmeztetés";
                MessageBox.Show(szoveg, fejlec,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            else if (checkBox1.Checked)
            {
                //ugyesseg
                valasztott = "Ügyesség";
                new Form2().ShowDialog();
            }

            else if (checkBox2.Checked)
            {
                //eletero
                valasztott = "Életerő";
                new Form2().ShowDialog();
            }

            else if (checkBox3.Checked)
            {
                //szerencse
                valasztott = "Szerencse";
                new Form2().ShowDialog();
            }
        }
    }
}
