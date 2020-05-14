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
    public partial class UCQuest3 : UserControl
    {
        private UCQuest9 q9;
        public static int jawaban;
        public static int Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }
        public UCQuest3()
        {
            InitializeComponent();
            q9 = new UCQuest9(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest4"))
            {
                UCQuest4 quest4 = new UCQuest4();
                quest4.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest4);
                Jawaban = trackBar1.Value;
            }
            Form1.Instance.PnlContainer.Controls["UCQuest4"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCQuest2"].BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
