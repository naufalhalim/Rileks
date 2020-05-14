using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rileks2
{
    public partial class UCHasil : UserControl
    {
       
      

        private UCNama nama1;
        private UCQuest9 q9;
        public UCHasil()
        {
            InitializeComponent();
            textBox1.Text = NamaPasien + ", Kamu Mengalami";
            textBox3.Text = ""+JenisDepresi;
        }
       
        public UCHasil(UCNama nama1)
        {
            InitializeComponent();
            this.nama1 = nama1;
        }
        public UCHasil(UCQuest9 q9)
        {
            InitializeComponent();
            this.q9 = q9;
        }


        string NamaPasien = UCNama.jawaban;
        string JenisDepresi = UCQuest9.jenisDepresi;



        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCGrafik"))
            {
                UCGrafik grafik = new UCGrafik();
                grafik.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(grafik);
            }
            Form1.Instance.PnlContainer.Controls["UCGrafik"].BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
