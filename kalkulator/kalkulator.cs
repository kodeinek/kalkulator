using System;
using System.Collections.Generic;
using System.Linq;

namespace kalkulator
{
    public class Kalkulator
    {
        public long Value { get; set; } = 0;
        public long Value2 { get; set; } = 0;
        public string TextValue { get; set; } = "0";
        public string HelpTextValue { get; set; } = "0000  0000";

        private long MemoryValue { get; set; } = 0; // Pamięć kalkulatora

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

        // Zamiana +/− (zmiana znaku liczby)
        public void ChangeSign()
        {
            Value = -Value;
            ConvertTextValue();
        }

        // Operacje pamięci
        public void MemoryClear()
        {
            MemoryValue = 0;
        }

        public void LoadMemory()
        {
            Value = MemoryValue;
            ConvertTextValue();
        }

        public void SaveMemory()
        {
            MemoryValue = Value;
        }

        public void MemoryAdd()
        {
            MemoryValue += Value;
        }

        public void MemorySubtract()
        {
            MemoryValue -= Value;
        }

        // Operacja Modulo
        public long Modulo()
        {
            if (Value2 == 0)
            {
                throw new DivideByZeroException("Nie można wykonać modulo z zerem.");
            }
            return Value % Value2;
        }

        // Operacja Backspace (usuwa ostatni znak z bieżącego wpisu)
        public void RemoveLastCharacter()
        {
            if (TextValue.Length > 1)
            {
                TextValue = TextValue.Substring(0, TextValue.Length - 1);
                ParseInput(TextValue);
            }
            else
            {
                TextValue = "0";
                Value = 0;
            }
        }

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

        public void ParseInput(string input)
        {
            try
            {
                switch (ValueType)
                {
                    case KalkulatorType.bin:
                        if (input.All(c => c == '0' || c == '1'))
                        {
                            Value = Convert.ToInt64(input, 2);
                        }
                        else
                        {
                            throw new FormatException("Wartość binarna może zawierać tylko cyfry 0 i 1.");
                        }
                        break;

                    case KalkulatorType.oct:
                        if (input.All(c => c >= '0' && c <= '7'))
                        {
                            Value = Convert.ToInt64(input, 8);
                        }
                        break;

                    case KalkulatorType.hex:
                        if (input.All(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                        {
                            Value = Convert.ToInt64(input, 16);
                        }
                        else
                        {
                            throw new FormatException("Wartość szesnastkowa może zawierać tylko cyfry od 0 do 9 oraz litery A-F.");
                        }
                        break;

                    case KalkulatorType.dec:
                    default:
                        if (input.All(c => c >= '0' && c <= '9'))
                        {
                            Value = Convert.ToInt64(input, 10);
                        }
                        else
                        {
                            throw new FormatException("Wartość dziesiętna może zawierać tylko cyfry od 0 do 9.");
                        }
                        break;
                }

                ConvertTextValue();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                Value = 0;
                TextValue = "Błąd";
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

            ulong binaryRepresentation = (ulong)value & ((1UL << wordLength) - 1);
            string binary = Convert.ToString((long)binaryRepresentation, 2).PadLeft(wordLength, '0');

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

        public long sum()
        {
            return Value + Value2;
        }

        public long multiply()
        {
            return Value * Value2;
        }

        public long sub()
        {
            return Value - Value2;
        }

        public long dev()
        {
            if (Value2 == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero.");
            }
            return Value / Value2;
        }

        public long BitwiseNot()
        {
            return ~Value;
        }

        public long BitwiseAnd()
        {
            return Value & Value2;
        }

        public long BitwiseOr()
        {
            return Value | Value2;
        }

        public long BitwiseXor()
        {
            return Value ^ Value2;
        }

        public long ShiftLeft(int shift)
        {
            return Value << shift;
        }

        public long ShiftRight(int shift)
        {
            return Value >> shift;
        }
    }
}
