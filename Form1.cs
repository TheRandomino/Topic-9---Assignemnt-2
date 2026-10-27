using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___Assignemnt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPlusHover(object sender, EventArgs e)
        {
            lblAddition.Visible = true;
        }

        private void lblMinusHover(object sender, EventArgs e)
        {
            lblSubtraction.Visible = true;
        }

        private void lblMultiplyHover(object sender, EventArgs e)
        {
            lblMultiplication.Visible = true;
        }

        private void lblDivideHover(object sender, EventArgs e)
        {
            lblDivision.Visible = true;
        }

        private void lblPlusLeave(object sender, EventArgs e)
        {
            lblAddition.Visible = false;
        }

        private void lblMinusLeave(object sender, EventArgs e)
        {
            lblSubtraction.Visible = false;
        }

        private void lblMultiplyLeave(object sender, EventArgs e)
        {
            lblMultiplication.Visible = false;
        }

        private void lblDivideLeave(object sender, EventArgs e)
        {
            lblDivision.Visible = false;
        }
    }
}
