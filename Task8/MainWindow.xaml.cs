using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "0";
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "1";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "2";
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textBoxProcess.Text += "9";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && textBoxResult.Text.Trim() != String.Empty)
                textBoxHistory.Text = $"{textBoxProcess.Text} = {textBoxResult.Text}";
            textBoxProcess.Text = String.Empty;
            textBoxResult.Text = String.Empty;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('.'))
                textBoxProcess.Text += ".";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('+'))
                textBoxProcess.Text += "+";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('-'))
                textBoxProcess.Text += "-";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('*'))
                textBoxProcess.Text += "*";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('÷'))
                textBoxProcess.Text += "÷";
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProcess.Text.Trim() != String.Empty && !textBoxProcess.Text.EndsWith('%'))
                textBoxProcess.Text += "%";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = textBoxProcess.Text;
                if (expression.Contains('÷'))
                {
                    expression = expression.Replace('÷', '/');
                }
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                textBoxResult.Text = Math.Round(double.Parse((string)row["expression"]), 4).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены данные", "Ошибка");
                return;
            }  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnPowerOffInGrid_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
