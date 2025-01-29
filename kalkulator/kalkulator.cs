using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace kalkulator
{
    public class Kalkulator
    {
        public long Value { get; set; } = 0;
        public long Value2 { get; set; } = 0;
        public string TextValue { get; set; } = "0";
        public string HelpTextValue { get; set; } = "0000  0000";

        private long MemoryValue { get; set; } = 0;
        private long PreviousValue { get; set; } = 0;

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

        public void ChangeSign()
        {
            Value = -Value;
            ConvertTextValue();
        }

        public void MemoryClear() => MemoryValue = 0;

        public void LoadMemory()
        {
            Value = MemoryValue;
            ConvertTextValue();
        }

        public void SaveMemory() => MemoryValue = Value;

        public void MemoryAdd() => MemoryValue += Value;

        public void MemorySubtract() => MemoryValue -= Value;

        public long Modulo()
        {
            if (Value2 == 0) throw new DivideByZeroException("Nie można wykonać modulo z zerem.");
            return Value % Value2;
        }

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
                            Value = Convert.ToInt64(input, 2);
                        else
                            throw new FormatException("Wartość binarna może zawierać tylko cyfry 0 i 1.");
                        break;
                    case KalkulatorType.oct:
                        if (input.All(c => c >= '0' && c <= '7'))
                            Value = Convert.ToInt64(input, 8);
                        break;
                    case KalkulatorType.hex:
                        if (input.All(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                            Value = Convert.ToInt64(input, 16);
                        else
                            throw new FormatException("Wartość szesnastkowa może zawierać tylko cyfry od 0 do 9 oraz litery A-F.");
                        break;
                    case KalkulatorType.dec:
                    default:
                        if (input.All(c => c >= '0' && c <= '9'))
                            Value = Convert.ToInt64(input, 10);
                        else
                            throw new FormatException("Wartość dziesiętna może zawierać tylko cyfry od 0 do 9.");
                        break;
                }
                ConvertTextValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
                Value = 0;
                TextValue = "Błąd";
            }
        }

        private string GenerateHelpText(long value)
        {
            int wordLength = word_size switch
            {
                WordSize.byte_ => 8,
                WordSize.word_ => 16,
                WordSize.dword_ => 32,
                WordSize.qword_ => 64,
                _ => 0
            };

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
            return word_size switch
            {
                WordSize.byte_ => Value >= sbyte.MinValue && Value <= sbyte.MaxValue,
                WordSize.word_ => Value >= short.MinValue && Value <= short.MaxValue,
                WordSize.dword_ => Value >= int.MinValue && Value <= int.MaxValue,
                WordSize.qword_ => Value >= long.MinValue && Value <= long.MaxValue,  // Ensure it remains within `long`
                _ => false
            };
        }
        public bool sum()
        {
            PreviousValue = Value;
            try
            {
                switch (word_size)
                {
                    case WordSize.byte_:
                        checked
                        {
                            sbyte temp = (sbyte)Value;
                            Value = (sbyte)(temp + (sbyte)Value2);
                        }
                        break;
                    case WordSize.word_:
                        checked
                        {
                            short temp = (short)Value;
                            Value = (short)(temp + (short)Value2);
                        }
                        break;
                    case WordSize.dword_:
                        checked
                        {
                            int temp = (int)Value;
                            Value = (int)(temp + (int)Value2);
                        }
                        break;
                    case WordSize.qword_: // QWORD = long, brak przepełnienia
                        checked
                        {
                            long temp = Value;
                            Value = temp + Value2; // long obsługuje cały zakres, nie będzie wyjątku
                        }
                        break;
                }
            }
            catch (OverflowException)
            {
                //MessageBox.Show("Sum exceeded the allowed range for the current word size.");
                Value = PreviousValue;
                return false;
            }
            return true;
        }

        public bool sub()
        {
            PreviousValue = Value;
            try
            {
                switch (word_size)
                {
                    case WordSize.byte_:
                        checked
                        {
                            sbyte temp = (sbyte)Value;
                            Value = (sbyte)(temp - (sbyte)Value2);
                        }
                        break;
                    case WordSize.word_:
                        checked
                        {
                            short temp = (short)Value;
                            Value = (short)(temp - (short)Value2);
                        }
                        break;
                    case WordSize.dword_:
                        checked
                        {
                            int temp = (int)Value;
                            Value = (int)(temp - (int)Value2);
                        }
                        break;
                    case WordSize.qword_: // QWORD = long, brak przepełnienia
                        checked
                        {
                            long temp = Value;
                            Value = temp - Value2; // long obsługuje cały zakres, nie będzie wyjątku
                        }
                        break;
                }
            }
            catch (OverflowException)
            {
                //MessageBox.Show("Subtraction exceeded the allowed range for the current word size.");
                Value = PreviousValue;
                return false;
            }
            return true;
        }

        public bool multiply()
        {
            PreviousValue = Value;
            try
            {
                switch (word_size)
                {
                    case WordSize.byte_:
                        checked { Value = (sbyte)Value * (sbyte)Value2; }
                        break;
                    case WordSize.word_:
                        checked { Value = (short)Value * (short)Value2; }
                        break;
                    case WordSize.dword_:
                        checked { Value = (int)Value * (int)Value2; }
                        break;
                    case WordSize.qword_:
                        checked { Value = Value * Value2; }
                        break;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Multiplication exceeded the allowed range for the current word size.");
                Value = PreviousValue;
                return false;
            }
            return true;
        }

        public bool dev()
        {
            PreviousValue = Value;
            if (Value2 == 0)
            {
                MessageBox.Show("Division by zero is not allowed.");
                return false;
            }
            try
            {
                switch (word_size)
                {
                    case WordSize.byte_:
                        checked { Value = (sbyte)Value / (sbyte)Value2; }
                        break;
                    case WordSize.word_:
                        checked { Value = (short)Value / (short)Value2; }
                        break;
                    case WordSize.dword_:
                        checked { Value = (int)Value / (int)Value2; }
                        break;
                    case WordSize.qword_:
                        checked { Value = Value / Value2; }
                        break;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Division resulted in overflow.");
                Value = PreviousValue;
                return false;
            }
            return true;
        }

        public long BitwiseNot() => ~Value;

        public long BitwiseAnd() => Value & Value2;

        public long BitwiseOr() => Value | Value2;

        public long BitwiseXor() => Value ^ Value2;

        public long ShiftLeft(int shift) => Value << shift;

        public long ShiftRight(int shift) => Value >> shift;
    }
}
