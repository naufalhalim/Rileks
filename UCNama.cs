using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rileks2
{
    public partial class UCNama : UserControl
    {
      public  static string jawaban;
        public static string Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }

        private UCHasil hasil1;
        private UCGrafik grafik;


        public UCNama()
        {
            InitializeComponent();
            hasil1 = new UCHasil(this);
            grafik = new UCGrafik(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
                MessageBox.Show("Tolong masukkan namamu lebih dulu ya :)");
            else
            {
                try
                {
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCRule"))
                    {
                        UCRule rule = new UCRule();
                        rule.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(rule);
                    }
                    Form1.Instance.PnlContainer.Controls["UCRule"].BringToFront();
                    Jawaban = textBox1.Text;
                    UCHasil hsl = new UCHasil();
                    hsl.textBox1.Text = textBox1.Text;

                }
                catch (Exception)
                {
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCRule"))
                    {
                        UCRule rule = new UCRule();
                        rule.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(rule);
                    }
                    Form1.Instance.PnlContainer.Controls["UCRule"].BringToFront();
                    Jawaban = textBox1.Text;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
