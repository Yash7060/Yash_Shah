using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace Column1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();
            Beam myBeam = new Beam();
            myBeam.StartPoint = new Point(11988.789 + 6359.525, 23844.25, 2248.74);
            myBeam.EndPoint = new Point(11988.789 + 6359.525, 12192, 2248.74);
            myBeam.Profile.ProfileString = "NCI_8_3.5Z12";
            myBeam.Material.MaterialString = "A653";
            myBeam.Class = "8";
            myBeam.Position.Plane = Position.PlaneEnum.LEFT;
            myBeam.Position.Rotation = Position.RotationEnum.BACK;
            myBeam.Position.Depth = Position.DepthEnum.MIDDLE;
            myBeam.Insert();
            myModel.CommitChanges();
        }
    }
}
