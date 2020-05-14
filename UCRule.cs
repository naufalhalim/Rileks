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
    public partial class UCRule : UserControl
    {
        public UCRule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCQuest1"))
            {
                UCQuest1 quest1 = new UCQuest1();
                quest1.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(quest1);
            }
            Form1.Instance.PnlContainer.Controls["UCQuest1"].BringToFront();
        }
    }
}
