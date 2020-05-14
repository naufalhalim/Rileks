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
    public partial class UCHalo : UserControl
    {
        public UCHalo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNama"))
            {
                UCNama nama = new UCNama();
                nama.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(nama);
            }
            Form1.Instance.PnlContainer.Controls["UCNama"].BringToFront();
        }
    }
}
