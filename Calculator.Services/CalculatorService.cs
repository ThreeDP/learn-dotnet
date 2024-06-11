namespace Calculator.Services;

public class Calc
{
    static private bool parserValues(ref decimal a, ref decimal b, string sa, string sb) {
        if (decimal.TryParse(sa, out a) && decimal.TryParse(sb, out b)) {
            return true;
        }
        return false;
    }

    static public string PerformOperation(string na, string opt, string nb) {
        decimal numA = 0;
        decimal numB = 0;
        decimal res = 0;
    
        if (parserValues(ref numA, ref numB, na, nb)) {
            switch (opt.Trim()) 
            {
                case "+":
                    res = Calc.Sum(numA, numB);
                    break;
                case "-":
                    res = Calc.Minus(numA, numB);
                    break;
                case "*":
                    res = Calc.Mul(numA, numB);
                    break;
                case "/":
                    res = Calc.Div(numA, numB);
                    break;
                default:
                    return "Error - pattern.";
            }
            return Convert.ToString(res);
        }
        return "Error - no numeric.";
    }

    static protected decimal Sum(decimal a, decimal b) {
        return a + b;
    }

    static protected decimal Minus(decimal a, decimal b) {
        return a - b;
    }

    static protected decimal Div(decimal a, decimal b) {
        return a / b;
    }

    static protected decimal Mul(decimal a, decimal b) {
        return a * b;
    }
};