
using BusinessLogic;
using System.Windows;
using System.Windows.Controls;

namespace WPFApplication {
    /// <summary>
    /// Interaction logic for MainWindow.xaml Adding comment
    /// </summary>
    public partial class MainWindow : Window {

        CalculatorLogic calculator = new CalculatorLogic();

        public MainWindow() {
            InitializeComponent();
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e) {
            string name = ((Button)sender).Name;
            OutputTextBlock.Text = calculator.AddNumberToOutput(name);
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Equal();
            OutputTextBlock.Text = calculator.GetOutput();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Plus();
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Times();
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Divide();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Minus();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e) {
            calculator.Clear();
            OutputTextBlock.Text = calculator.GetOutput();
        }
    }
}