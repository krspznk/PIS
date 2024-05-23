using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab9.Domain;

namespace Lab9MVVM
{
    class MainVM : INotifyPropertyChanged
    {
        private double side1;
        private double side2;
        private double height;
        private double height2;
        private double height3;

        private string result = "";


        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
                OnPropertyChanged("Result");
            }
        }

        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
                OnPropertyChanged("Result");
            }
        }


        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                OnPropertyChanged("Result");
            }
        }

        public double Height2
        {
            get
            {
                return height2;
            }
            set
            {
                height2 = value;
                OnPropertyChanged("Result");
            }
        }

        public double Height3
        {
            get
            {
                return height3;
            }
            set
            {
                height3 = value;
                OnPropertyChanged("Result");
            }
        }

        public string Result
        {
            get
            {
                var prism = new PiramidaModel(Side1, Side2, Height, Height2, Height3);
                var info = $"Площа = {prism.CalculateSurfaceArea()}; Об'єм = {prism.CalculateVolume()}";
                return info;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
