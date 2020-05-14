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
    public partial class UCQuest2 : UserControl
    {

        private UCQuest9 q9;
        public static int jawaban;
        public static int Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }
        public UCQuest2()
        {
            InitializeComponent();
            q9 = new UCQuest9(this);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest3"))
            {
                UCQuest3 quest3 = new UCQuest3();
                quest3.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest3);
                Jawaban = trackBar1.Value;

            }
            Form1.Instance.PnlContainer.Controls["UCQuest3"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCQuest1"].BringToFront();
        }

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
