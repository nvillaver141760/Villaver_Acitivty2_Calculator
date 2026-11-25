using System;
using System.Globalization;

namespace Villaver_Activity2_Calculator
{
    internal sealed class Calculator
    {
        private enum EntryState { Entering, WaitingForOperand, ShowingResult, Error }

        private const string NumberFormat = "0.############################";
        private static readonly CultureInfo DisplayCulture = CultureInfo.InvariantCulture;

        private EntryState state;
        private decimal leftOperand;
        private string pendingOperator;

        public string Display { get; private set; } = "0";
        public string Expression { get; private set; } = "";

        public void Press(string key)
        {
            bool isNumber = key == "." || (key.Length == 1 && char.IsDigit(key[0]));

            if (key == "C" || (state == EntryState.Error && key == "CE"))
            {
                Clear();
                return;
            }

            if (state == EntryState.Error)
            {
                if (!isNumber)
                    return;

                Clear();
            }

            try
            {
                if (isNumber)
                {
                    EnterNumber(key);
                    return;
                }

                switch (key)
                {
                    case "+": case "−": case "×": case "÷": SetOperator(key); break;
                    case "=": Evaluate(); break;
                    case "CE": ClearEntry(); break;
                    case "⌫": Backspace(); break;
                    case "±": ChangeSign(); break;
                    case "%": case "1/x": case "x²": case "√x": ApplyFunction(key); break;
                }
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero");
            }
            catch (OverflowException)
            {
                ShowError("Number is too large");
            }
        }

        private decimal Value => decimal.Parse(Display, DisplayCulture);

        private static string Format(decimal value)
        {
            return value.ToString(NumberFormat, DisplayCulture);
        }

        private void EnterNumber(string key)
        {
            if (state != EntryState.Entering)
                ClearEntry();

            if (key == ".")
            {
                if (!Display.Contains("."))
                    Display += ".";

                return;
            }

            if (Display == "0" || Display == "-0")
                Display = Display == "0" ? key : "-" + key;
            else if (Display.Replace(".", "").Replace("-", "").Length < 16)
                Display += key;
        }

        private void SetOperator(string operation)
        {
            if (pendingOperator != null && state != EntryState.WaitingForOperand)
                Evaluate();

            leftOperand = Value;
            pendingOperator = operation;
            Expression = Format(leftOperand) + " " + operation;
            state = EntryState.WaitingForOperand;
        }

        private void Evaluate()
        {
            if (pendingOperator == null)
                return;

            decimal rightOperand = Value;
            decimal result;

            switch (pendingOperator)
            {
                case "+": result = leftOperand + rightOperand; break;
                case "−": result = leftOperand - rightOperand; break;
                case "×": result = leftOperand * rightOperand; break;
                case "÷": result = leftOperand / rightOperand; break;
                default: throw new InvalidOperationException("Unknown operator.");
            }

            Expression = Format(leftOperand) + " " + pendingOperator + " " + Format(rightOperand) + " =";
            Display = Format(result);
            pendingOperator = null;
            state = EntryState.ShowingResult;
        }

        private void ApplyFunction(string function)
        {
            decimal value = Value;
            decimal result;

            switch (function)
            {
                case "1/x":
                    result = 1 / value;
                    break;
                case "x²":
                    result = value * value;
                    break;
                case "√x":
                    if (value < 0)
                    {
                        ShowError("Invalid square root");
                        return;
                    }

                    result = (decimal)Math.Sqrt((double)value);
                    break;
                case "%":
                    result = value / 100;
                    if (pendingOperator == "+" || pendingOperator == "−")
                        result *= leftOperand;
                    break;
                default:
                    throw new InvalidOperationException("Unknown function.");
            }

            if (pendingOperator == null)
                Expression = "";

            Display = Format(result);
            state = EntryState.ShowingResult;
        }

        private void ChangeSign()
        {
            if (state == EntryState.WaitingForOperand)
                ClearEntry();

            if (pendingOperator == null)
                Expression = "";

            Display = Display.StartsWith("-", StringComparison.Ordinal)
                ? Display.Substring(1)
                : "-" + Display;
        }

        private void Backspace()
        {
            if (state != EntryState.Entering)
                return;

            Display = Display.Substring(0, Display.Length - 1);
            if (Display == "" || Display == "-")
                Display = "0";
        }

        private void ClearEntry()
        {
            Display = "0";
            state = EntryState.Entering;

            if (pendingOperator == null)
                Expression = "";
        }

        private void Clear()
        {
            pendingOperator = null;
            ClearEntry();
        }

        private void ShowError(string message)
        {
            pendingOperator = null;
            Expression = "";
            Display = message;
            state = EntryState.Error;
        }
    }
}
