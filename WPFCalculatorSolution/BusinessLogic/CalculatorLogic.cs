namespace BusinessLogic {
    public class CalculatorLogic {

        public string MyCalculatorMethod() {
            return "hey calculator";
        }

        public string clickNumber(string name, string output) {
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
