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
    public partial class UCQuest9 : UserControl
    {
        private UCQuest1 q1;
        private UCQuest2 q2;
        private UCQuest3 q3;
        private UCQuest4 q4;
        private UCQuest5 q5;
        private UCQuest6 q6;
        private UCQuest7 q7;
        private UCQuest8 q8;

      

        public static int jawaban;
        public static string jenisDepresi;
        public static int point;
        public static int Hasil
        {
            get { return jawaban; }
            set { jawaban = value; }
        }
        public static int Point
        {
            get { return point; }
            set { point = value; }
        }

        public static string JenisDepresi
        {
            get { return jenisDepresi; }
            set { jenisDepresi = value; }
        }

        private UCHasil hasil;
        private UCGrafik grafik;

        public UCQuest9()
        {
            InitializeComponent();
            hasil = new UCHasil(this);
            grafik = new UCGrafik(this);
        }
       
        public UCQuest9(UCQuest1 q1)
        {
            InitializeComponent();
            this.q1 = q1;
        }

        public UCQuest9(UCQuest2 q2)
        {
            InitializeComponent();
            this.q2 = q2;
        }

        public UCQuest9(UCQuest3 q3)
        {
            InitializeComponent();
            this.q3 = q3;
        }

        public UCQuest9(UCQuest4 q4)
        {
            InitializeComponent();
            this.q4 = q4;
        }

        public UCQuest9(UCQuest5 q5)
        {
            InitializeComponent();
            this.q5 = q5;
        }

        public UCQuest9(UCQuest6 q6)
        {
            InitializeComponent();
            this.q6 = q6;
        }

        public UCQuest9(UCQuest7 q7)
        {
            InitializeComponent();
            this.q7 = q7;
        }

        public UCQuest9(UCQuest8 q8)
        {
            InitializeComponent();
            this.q8 = q8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Hasil = UCQuest1.jawaban + UCQuest2.jawaban + UCQuest3.jawaban + UCQuest4.jawaban + UCQuest5.jawaban + UCQuest6.jawaban + UCQuest7.jawaban + UCQuest8.jawaban + trackBar1.Value;
            if (Hasil >= 0 && Hasil <= 4)
            {
                JenisDepresi = "No depression";
                Point = 1;
            }
            else if (Hasil >= 5 && Hasil <= 9)
            {
                JenisDepresi = "Mild depression";
                Point = 2;
            }
            else if (Hasil >= 10 && Hasil <= 14)
            {
                JenisDepresi = "Moderate depression";
                Point = 3;
            }
            else if (Hasil >= 15 && Hasil <= 19)
            {
                JenisDepresi = "Moderately severe depression";
                Point = 4;
            }
            else if (Hasil >= 20 && Hasil <= 27)
            {
                JenisDepresi = "Severe depression";
                Point = 5;
            }

            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCHasil"))
            {
                UCHasil hasil = new UCHasil();
                hasil.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(hasil);
            }
            Form1.Instance.PnlContainer.Controls["UCHasil"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCQuest8"].BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
