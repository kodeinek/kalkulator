

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public class Kalkulator
    {

        public long Value { get; set; } = 0;
        public string TextValue { get; set; } = "0";
        public string HelpTextValue { get; set; } = "0000  0000";


        public enum KalkulatorType
        {
            dec,
            bin,
            oct,
            hex
        }
        public KalkulatorType ValueType { get; set; } = KalkulatorType.dec;



        public enum WordSize
        {
            byte_,
            word_,
            dword_,
            qword_
        }
        public WordSize word_size { get; set; } = WordSize.qword_;

public void ConvertTextValue(bool helpValue = false)
{
    switch (ValueType)
    {
        case KalkulatorType.bin:
            TextValue = Convert.ToString(Value, 2);
            break;
        case KalkulatorType.oct:
            TextValue = Convert.ToString(Value, 8);
            break;
        case KalkulatorType.hex:
            TextValue = Convert.ToString(Value, 16).ToUpper();
            break;
        case KalkulatorType.dec:
        default:
            TextValue = Value.ToString();
            break;
    }

    if (helpValue)
    {
        HelpTextValue = GenerateHelpText(Value);
    }
}

        private string GenerateHelpText(long value)
        {
            int wordLength;
            switch (word_size)
            {
                case WordSize.byte_:
                    wordLength = 8;
                    break;
                case WordSize.word_:
                    wordLength = 16;
                    break;
                case WordSize.dword_:
                    wordLength = 32;
                    break;
                case WordSize.qword_:
                    wordLength = 64;
                    break;
                default:
                    wordLength = 0;
                    break;
            }

            // Obsługa wartości ujemnych (uzupełnienie do dwóch)
            long maxValue = (1L << (wordLength - 1)) - 1;
            long minValue = -(1L << (wordLength - 1));
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentOutOfRangeException($"Value {value} is out of range for {word_size},{maxValue}, {minValue}.");
            }

            // Konwersja do uzupełnienia do dwóch (dla wartości ujemnych)
            string binary = value >= 0
                ? Convert.ToString(value, 2).PadLeft(wordLength, '0')
                : Convert.ToString(value & maxValue, 2).PadLeft(wordLength, '0');

            // Grupowanie co 4 bity dla lepszej czytelności
            return string.Join(" ", binary.Reverse()
                .Select((c, i) => new { c, i })
                .GroupBy(x => x.i / 4)
                .Select(g => new string(g.Select(x => x.c).Reverse().ToArray()))
                .Reverse());
        }
        public bool RepresentWord()
        {
            switch (word_size)
            {
                case WordSize.byte_:
                    return (Value >= -128 && Value <= 127);

                case WordSize.word_:
                    return (Value >= -32768 && Value <= 32767);

                case WordSize.dword_:
                    return (Value >= -2147483648 && Value <= 2147483647);

                case WordSize.qword_:

                    double minDouble = -Math.Pow(2, 63);
                    double maxDouble = Math.Pow(2, 63) - 1;
                    return (Value >= minDouble && Value <= maxDouble);


                default:
                    return false;
            }
        }


        public int sum(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int dev(int a, int b)
        {
            return a / b;
        }

        public int BitwiseNot(int a)
        {
            return ~a;
        }

        public int BitwiseAnd(int a, int b)
        {
            return a & b;
        }

        public int BitwiseOr(int a, int b)
        {
            return a | b;
        }

        public int BitwiseXor(int a, int b)
        {
            return a ^ b;
        }

        public int ShiftLeft(int a, int shift)
        {
            return a << shift;
        }

        public int ShiftRight(int a, int shift)
        {
            return a >> shift;
        }

    }
}

