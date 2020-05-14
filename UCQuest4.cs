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
    public partial class UCQuest4 : UserControl
    {
        public static int jawaban;
        public static int Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }

        private UCQuest9 q9;
        public UCQuest4()
        {
            InitializeComponent();
            q9 = new UCQuest9(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest5"))
            {
                UCQuest5 quest5 = new UCQuest5();
                quest5.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest5);
                Jawaban = trackBar1.Value;
            }
            Form1.Instance.PnlContainer.Controls["UCQuest5"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCQuest3"].BringToFront();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
