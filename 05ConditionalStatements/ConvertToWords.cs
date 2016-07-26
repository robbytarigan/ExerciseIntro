using System;

namespace ConditionalStatements {
    public static class ConvertToWords {
        public static void Start() { 
            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("{0,3} -> {1}", i, Convert(i));
            }
        }

        private static string Convert(int value) {
            if (value < 0 || value > 999) {
                return "????";
            } else if (value > 99) {
                return ThreeDigits(value);
            } else if (value > 9) {
                return TwoDigits(value);
            } else {
                return OneDigit(value);
            }            
        }

        private static string ThreeDigits(int value) {
            if (value > 900)
                return "nine hundred and " + TwoDigits(value%900);
            
            if (value == 900)
                return "nine hundred";

            if (value > 800)
                return "eight hundred and " + TwoDigits(value%800);

            if (value == 800)
                return "eight hundred";

            if (value > 700)
                return "seven hundred and " + TwoDigits(value%700);

            if (value == 700)
                return "seven hundred";

            if (value > 600)
                return "six hundred and " + TwoDigits(value%600);

            if (value == 600)
                return "six hundred";

            if (value > 500)
                return "five hundred and " + TwoDigits(value%500);

            if (value == 500)
                return "five hundred";

            if (value > 400)
                return "four hundred and " + TwoDigits(value%400);

            if (value == 400)
                return "four hundred";

            if (value > 300)
                return "three hundred and " + TwoDigits(value%300);

            if (value == 300)
                return "three hundred";

            if (value > 200)
                return "two hundred and " + TwoDigits(value%200);

            if (value == 200)
                return "two hundred";

            if (value > 100)
                return "one hundred and " + TwoDigits(value%100);
            
            if (value == 100)
                return "one hundred";
            
            return "???";
        }

        private static string TwoDigits(int value) {
            switch (value) {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fiveteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 21:
                case 22: 
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                    return "twenty " + OneDigit(value%20);
                case 30: 
                    return "thirty";
                case 31:
                case 32: 
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39: 
                    return "thirty " + OneDigit(value%30);
                case 40: 
                    return "forty";
                case 41:
                case 42: 
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49: 
                    return "forty " + OneDigit(value%40);
                case 50:
                    return "fifty";
                case 51:
                case 52: 
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                    return "fifty " + OneDigit(value%50);
                case 60:
                    return "sixty";
                case 61:
                case 62: 
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                    return "sixty " + OneDigit(value%60);
                case 70:
                    return "seventy";
                case 71:
                case 72: 
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                    return "seventy " + OneDigit(value%70);
                case 80:
                    return "eighty";
                case 81:
                case 82: 
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                    return "eighty " + OneDigit(value%80);
                case 90:
                    return "ninety";
                case 91:
                case 92: 
                case 93:
                case 94:
                case 95:
                case 96:
                case 97:
                case 98:
                case 99:
                    return "ninety " + OneDigit(value%90);
                default:
                    return OneDigit(value);
            }
        }

        private static string OneDigit(int value) {
            switch (value) {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";                
                default: return "?";
            }
        }
    }
}