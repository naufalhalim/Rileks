using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using WMPLib;

namespace Rileks2
{
    public partial class UCMusik : UserControl
    {
        public UCMusik()
        {
            InitializeComponent();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCHalo"].BringToFront();
            player.controls.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.Instance.PnlContainer.Controls["UCGrafik"].BringToFront();
            player.controls.stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public void button1_Click(object sender, EventArgs e)
        {
            player.URL = "meditasi.mp3";
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
