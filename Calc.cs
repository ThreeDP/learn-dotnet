using System;

namespace WebApp {

    public class Calc
    {
        static private bool _parserValues(ref int a, ref int b, string sa, string sb) {
            if (int.TryParse(sa, out a) && int.TryParse(sb, out b)) {
                return true;
            }
            return false;
        }

        static public int Sum(string a, string b) {
            int numA = 0;
            int numB = 0;
            _parserValues(ref numA, ref numB, a, b);
            return numA + numB;
        }

        static public int Minus(string a, string b) {
            int numA = 0;
            int numB = 0;
            _parserValues(ref numA, ref numB, a, b);
            return numA - numB;
        }

        static public int Div(string a, string b) {
            int numA = 0;
            int numB = 0;
            _parserValues(ref numA, ref numB, a, b);
            return numA / numB;
        }

        static public int Mul(string a, string b) {
            int numA = 0;
            int numB = 0;
            _parserValues(ref numA, ref numB, a, b);
            return numA * numB;
        }
    };

};