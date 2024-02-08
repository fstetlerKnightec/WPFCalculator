
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
            OutputTextBlock.Text = calculator.addNumberToOutput(name);
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e) {
            calculator.equal();
            OutputTextBlock.Text = calculator.getOutput();
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e) {
            calculator.plus();
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e) {
            calculator.times();
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e) {
            calculator.divide();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e) {
            calculator.minus();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e) {
            calculator.clear();
            OutputTextBlock.Text = calculator.getOutput();
        }
    }
}