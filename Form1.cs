using System;
using System.Windows.Forms;

namespace teorVer_3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            panelInput.Focus();
        }

        private double _upperLimit, _lowerLimit;
        private int _countSteps;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _upperLimit = Convert.ToDouble(UpperLimit.Text.Replace(".", ","));
                _lowerLimit = Convert.ToDouble(LowerLimit.Text.Replace(".", ","));
                _countSteps = Convert.ToInt32(CountSteps.Text);
            } catch
            {
                MessageBox.Show("Введите все поля!");
            }

            ResultMonteKarlo.Text = "Метод Монте-Карло: " + MethodMonteKarlo(_lowerLimit, _upperLimit, _countSteps);
            ResultAnalitics.Text = "Аналитический метод: " + MethodAnalitics(_lowerLimit, _upperLimit);
        }

        private static double MethodAnalitics(double lowerLimit, double upperLimit)
        {
            // Расчет интеграла: cos(x) - x = sin(x) - (x*x)/2 + С
            return Math.Round((Math.Sin(upperLimit) - (upperLimit * upperLimit) / 2) - (Math.Sin(lowerLimit) - (lowerLimit * lowerLimit) / 2), 6);
        }

        private static double MethodMonteKarlo(double lowerLimit, double upperLimit, int countSteps) 
        {
            Random r = new Random();
            double sigma = 0;

            for (int i = 0; i < countSteps; i++)
            {
                double y = r.NextDouble();
                double x = lowerLimit + (upperLimit - lowerLimit) * y;
                sigma += Function(x);
            }

            return Math.Round((((upperLimit - lowerLimit) / countSteps) * sigma), 6);
        }
        
        private static double Function(double x)
        {
            return Math.Cos(x) - x;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UpperLimit.Text = string.Empty;
            LowerLimit.Text = string.Empty;
            CountSteps.Text= string.Empty;

            ResultMonteKarlo.Text = "Метод Монте-Карло:";
            ResultAnalitics.Text = "Аналитический метод:";
        }

        private void UpperLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // цифры, клавиша BackSpace и запятая с точкой
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void LowerLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // цифры, клавиша BackSpace и запятая с точкой
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void CountSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // цифры, клавиша BackSpace
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
