using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolAreaCalculator
{
    public partial class AreaVolumeCalculator : Form
    {
        public AreaVolumeCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void RectAreaButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(RectAreaTxt1.Text, out double Rectlength) && double.TryParse(RectAreaTxt2.Text, out double Rectwidth))
            {
                double RectArea = Rectlength * Rectwidth;

                
            }
        }

        private void TriAreaButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(TriAreaTxt1.Text, out double Trilength) && double.TryParse(TriAreaTxt2.Text, out double Triwidth))
            {
                double TriArea = (Trilength * Triwidth) / 2;

            }
        }

        private void CircleAreaButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(CircleAreaTxt1.Text, out double CircleRadius))
            {
                double CircleArea = Math.PI* (CircleRadius * CircleRadius);

            }
        }

        private void CuboidVolButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(CuboidVolTxt1.Text, out double Cuboidheight) && double.TryParse(CuboidVolTxt2.Text, out double Cuboidlength)
                && double.TryParse(CuboidVolTxt3.Text, out double Cuboiddepth))
            {
                double CuboidVolume = Cuboidheight * Cuboiddepth * Cuboidlength;

            }
        }

        private void PyramidVolButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(PyramidVolTxt1.Text, out double Pyramidheight) && double.TryParse(PyramidVolTxt2.Text, out double Pyramidlength)
                && double.TryParse(PyramidVolTxt3.Text, out double Pyramiddepth))
            {
                double PyramidVolume = (Pyramidheight * Pyramiddepth * Pyramidlength) / 3;

            }
        }

        private void SphereVolButton_Click(object sender, EventArgs e)
        {
            if(double.TryParse(SphereVolTxt1.Text, out double Sphereradius))
            {
                double SphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(Sphereradius, 3);

            }
        }
    }
}
