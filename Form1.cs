using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rileks2
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Form1();
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximizeBox = false;
        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {
            _obj = this;
            UCHalo home = new UCHalo();
           
            home.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(home);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
