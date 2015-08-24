using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BMI.Model;
using System.Windows;


namespace BMI.ViewModel
{
    public class Presenter : Object
    {
        private Calculator _Calculator = new Calculator();
        private string _stringHeight, _stringWeight;
        private string _result, _analysis, _analysiscol;

        public string Height
        {
            get { return _stringHeight; }
            set
            {
                _stringHeight = value;
                PropertyChangedEvent("Height");
            }
        }
        public string Weight
        {
            get { return _stringWeight; }
            set
            {
                _stringWeight = value;
                PropertyChangedEvent("Weight");
            }
        }

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                PropertyChangedEvent("Result");
            }
        }

        public string Analysis
        {
            get { return _analysis; }
            set
            {
                _analysis = value;
                PropertyChangedEvent("Analysis");
            }
        }
        public string AnalysisCol
        {
            get { return _analysiscol; }
            set
            {
                _analysiscol = value;
                PropertyChangedEvent("AnalysisCol");
            }
        }

        public ICommand CalculateBMI
        {
            get { return new Command(WriteBMI); }
        }

        private void WriteBMI()
        {
            if (Height == null || Weight == null || Weight == "" || Weight == "")
            {
                //You must write something!
                MessageBox.Show("You must add both a weight and a height.", "Values Missing", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (Height == "0")
            {
                //Avoid division by zero!
                MessageBox.Show("You must be really short! (Or was that a typo?)", "Tyrion Lannister Checking In!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (TryFormat())
            {
                Result = _Calculator.Calculated(Height, Weight).ToString();
                Analysis = _Calculator.Analysed();
                AnalysisCol = _Calculator.Colour(Analysis);
            }
            
        }

        /* 
         * Avoiding errors in string format in a not-so-clever way.
         */
        private bool TryFormat()
        {
            bool mode = true;

            try
            {
                double.Parse(Weight); // Might be a bit odd to do this twice.
                double.Parse(Height);
            }
            catch (FormatException)
            {
                MessageBox.Show("Some format error happened. Maybe wrong kind of decimal sign, or not using numbers only?", "Faulty Format", MessageBoxButton.OK, MessageBoxImage.Warning);
                mode = false;
            }

            return mode;

        }
    }
}
