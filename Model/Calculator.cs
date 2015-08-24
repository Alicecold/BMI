using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BMI.Model
{
    public class Calculator
    {
        private double _calc;
        private Dictionary<string, string> _analysis = new Dictionary<string,string>();

        public Calculator()
        {
            _analysis.Add("Underweight", "Blue");
            _analysis.Add("Normal", "Green");
            _analysis.Add("Overweight", "Chocolate");
            _analysis.Add("Obese", "Red");

        }

        public double Calculated(string height, string weight)
        {
            double _weight = double.Parse(weight);
            double _height = double.Parse(height) / 100.0; //to meters
            _calc = Math.Round(_weight / Math.Pow(_height,2),1);
            return _calc;
        }

        public string Analysed()
        {
            if (_calc <= 18.5)
                return "Underweight";
            else if (_calc <= 25)
                return "Normal";
            else if (_calc <= 30)
                return "Overweight";
            else
                return "Obese";
        }

        public string Colour(string analysis)
        {
            return _analysis[analysis];
        }
    }
}
