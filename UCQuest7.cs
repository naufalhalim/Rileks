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
    public partial class UCQuest7 : UserControl
    {
        public static int jawaban;
        public static int Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }

        private UCQuest9 q9;
        public UCQuest7()
        {
            InitializeComponent();
            q9 = new UCQuest9(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest8"))
            {
                UCQuest8 quest8 = new UCQuest8();
                quest8.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest8);
                Jawaban = trackBar1.Value;
            }
            Form1.Instance.PnlContainer.Controls["UCQuest8"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCQuest6"].BringToFront();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
