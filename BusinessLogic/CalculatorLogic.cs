namespace BusinessLogic {
    public class CalculatorLogic {

        string output = "";

        double temp = 0;

        string operation = "";

        public void clear() {
            output = "";
        }

        public string getOutput() {
            return output;
        }

        public void equal() {
            double outputTemp;
            switch (operation) {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    break;
                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    break;
                case "Times":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    break;
                case "Divide":
                    outputTemp = temp / double.Parse(output);
                    output = outputTemp.ToString();
                    break;
            }
        }

        public void plus() {
            if (output != "") {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        public void times() {
            if (output != "") {
                temp = double.Parse(output);
                output = "";
                operation = "Times";
            }
        }

        public void divide() {
            if (output != "") {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        public void minus() {
            if (output != "") {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }
        // still working on strings
        public string addNumberToOutput(string name) {
            switch (name) {
                case "OneBtn":
                    output += "1";
                    break;
                case "TwoBtn":
                    output += "2";
                    break;

                case "ThreeBtn":
                    output += "3";
                    break;

                case "FourBtn":
                    output += "4";
                    break;

                case "FiveBtn":
                    output += "5";
                    break;

                case "SixBtn":
                    output += "6";
                    break;

                case "SevenBtn":
                    output += "7";
                    break;

                case "EightBtn":
                    output += "8";
                    break;

                case "NineBtn":
                    output += "9";
                    break;

                case "ZeroBtn":
                    output += "0";
                    break;
            }
            return output;
        }
    }
}
