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
            List<string> numbersAsWords = new List<string>() {
                "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"
            };

            string buttonValue = name.Substring(0, name.IndexOf("B"));

            output += numbersAsWords.IndexOf(buttonValue).ToString();

            return output;
        }
    }
}
