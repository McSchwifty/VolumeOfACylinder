// Andrew Mackinnon
// Nov 5 2015
// ICS3UR
// Finds the volume of a cylinder
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeOfACylinder
{
    public partial class frmCylinder : Form
    {
        public double Volume(double radius, double height)
        {
            // Variable

            double answer;

            answer = Math.PI * Math.Pow(radius, 2) * height;



            return answer;
        }
        public frmCylinder()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            double radius;
            double height;
            double answer;
            
            // Input
            radius = Convert.ToDouble(this.txtRadius.Text);
            height = Convert.ToDouble(this.txtRadius.Text);

            // process

            answer = Volume(radius, height);

            // output

            this.lblInfo.Text = ("The answer is: " + Convert.ToString(answer));
        }
    }
}
