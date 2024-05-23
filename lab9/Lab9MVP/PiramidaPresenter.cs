using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9.Domain;

namespace Lab9MVP
{
    public class PiramidaPresenter
    {
        private readonly IPiramidaModel _prismModel;
        private readonly IPiramidaView _prismView;

        public PiramidaPresenter(IPiramidaView prismView, IPiramidaModel prismModel)
        {
            _prismModel = prismModel;
            _prismView = prismView;
        }

        public void LoadPrism(double sideA, double sideB, double height, double height2, double height3)
        {
            var prism = new PiramidaModel(sideA, sideB, height, height2, height3);
            _prismView.SetSurfaceArea(prism.CalculateSurfaceArea());
            _prismView.SetVolume(prism.CalculateVolume());
        }
    }
}
