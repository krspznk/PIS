using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Domain
{
    public class PiramidaModel : IPiramidaModel
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }
        public double Height2 { get; set; }
        public double Height3 { get; set; }


        public PiramidaModel()
        {
        }

        public PiramidaModel(double a, double b, double h, double d, double e)
        {
            SideA = a;
            SideB = b;
            Height = h;
            Height2=d;
            Height3=e;
        }

        public double CalculateVolume()
        {
            double num = (SideA*SideB*Height)/3;
            return num;
        }

        public double CalculateSurfaceArea()
        {
            double areaOfBase = SideA * SideB;
            double lateralSurfaceArea = SideA * Height2 + SideB*Height3;
            return areaOfBase + lateralSurfaceArea;
        }
    }
}