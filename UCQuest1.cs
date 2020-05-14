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
    public partial class UCQuest1 : UserControl
    {
        private UCQuest9 q9;
        public UCQuest1()
        {
            InitializeComponent();
            q9 = new UCQuest9(this);
        }

        public static int jawaban;
        public static int Jawaban
        {
            get { return jawaban; }
            set { jawaban = value; }
        }
   


        private void button2_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest2"))
            {
                UCQuest2 quest2 = new UCQuest2();
                quest2.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest2);
                Jawaban = trackBar10.Value;
               
            }
            Form1.Instance.PnlContainer.Controls["UCQuest2"].BringToFront();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
