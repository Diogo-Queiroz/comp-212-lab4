using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE_301082193__Comp212_Lab4
{
    public partial class ctlClock: UserControl
    {
        private Color colBColor;

        public Color ClockBackColor
        {
            get => colBColor;
            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }

        public ctlClock()
        {
            InitializeComponent();
        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
