using Lab9.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class PiramidaController
    {
        private PiramidaModel model;

        public PiramidaController()
        {
            model = new PiramidaModel();
        }

        public void SetPrismDimensions(double sideA, double sideB, double height, double height2, double height3)
        {
            model.SideA = sideA;
            model.SideB = sideB;
            model.Height = height;
            model.Height2 = height2;
            model.Height3 = height3;

        }

        public double CalculateVolume()
        {
            return model.CalculateVolume();
        }

        public double CalculateSurfaceArea()
        {
            return model.CalculateSurfaceArea();
        }
    }

}
