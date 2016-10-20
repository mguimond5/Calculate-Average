/**

 *

 * Marsha 

 * Mr.Hardman

 * Assignment #2, Program #3

 * Date Last Modified: October 19, 2016

 *

 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkAssignment
{
    public partial class frmCalculateAverage : Form
    {
        public frmCalculateAverage()
        {
            InitializeComponent();
        }

        private void lblMarkFive_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            double markone;
            double marktwo;
            double markthree;
            double markfour;
            double markfive;
            double totalAverage;

            markone = Convert.ToDouble(txtMarkOne.Text);
            marktwo = Convert.ToDouble(txtMarkTwo.Text);
            markthree = Convert.ToDouble(txtMarkThree.Text);
            markfour = Convert.ToDouble(txtMarkFour.Text);
            markfive = Convert.ToDouble(txtMarkFive.Text);

            totalAverage = (markone + marktwo + markthree + markfour + markfive) / (5.0);

            lblDisplay.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n\n{10,10}{11,15}", "Grade 1:", markone, "Grade 2:", marktwo, "Grade 3:", markthree, "Grade 4:", markfour, "Grade 5:", markfive, "Average:", totalAverage);
          



        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
