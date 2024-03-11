using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AwesomeCalculator
{
    public enum Operations
    {
        Multiplication,
        Plus,
        Minus,
        Inverse,
        Sqrt,
        Divide
    }

    public class Calculator
    {
        public event Action<string>? OnUpdatePreviousValue;
        public event Action<string>? OnUpdateDisplayValue;

        private StringBuilder _currentExpression = new StringBuilder("0");
        private string _memoryExpression = string.Empty;

        public void RemoveLast()
        {
            if (_currentExpression.Length > 0)
            {
                if (_currentExpression[_currentExpression.Length - 1] == '0' && _currentExpression.Length == 1)
                    return;
                else
                {
                    var exp = _currentExpression.ToString();
                    int index;
                    bool removed = false;

                    Regex regex = new Regex(@"sqrt\((\d+(\.\d+)?)\)\s*$");

                    // Находим последнее вхождение "sqrt(x)"
                    Match match = regex.Match(exp);

                    if (match.Success)
                    {
                        // Удаляем найденный фрагмент из строки
                        _currentExpression = _currentExpression.Remove(match.Index, match.Length);
                        removed = true;
                    }

                    if ((index = exp.LastIndexOf("(")) != -1 && !removed)
                    {
                        int openBraceIndex = index + 1;
                        int closeBraceIndex = exp.LastIndexOf(")");
                        if (closeBraceIndex != -1)
                        {
                            _currentExpression.Remove(index, closeBraceIndex - index + 1);
                            removed = true;
                        }
                    }

                    if (!removed)
                    {
                        for (int i = _currentExpression.Length - 1; i >= 0; i--)
                        {
                            if (char.IsDigit(_currentExpression[i]) || _currentExpression[i] == '.')
                            {
                                _currentExpression.Remove(i, 1);
                                break;
                            }
                        }
                    }
                }
            }

            if (_currentExpression.Length == 0)
                _currentExpression.Append("0");

            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        public void Clear()
        {
            _currentExpression.Clear();
            _currentExpression.Append("0");
            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        public void ReadMemory()
        {
            if (_memoryExpression == string.Empty)
                return;
            var (t, i) = FindArgForFuc();
            _currentExpression.Remove(i, t.Length);
            _currentExpression.Append(_memoryExpression);
            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        public void MemoryPlus()
        {
            var (t, i) = FindArgForFuc();
            if (i == 0)
                _memoryExpression = _currentExpression.ToString();
            else
                _memoryExpression = t;
        }

        public void ClearMemory()
        {
            _memoryExpression = string.Empty;
        }


        public void AddDot()
        {
            var (t, _) = FindArgForFuc();
            if (_currentExpression.Length > 0 && !t.Contains('.'))
                _currentExpression.Append(".");

            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        public void AddNumber(int num)
        {
            _currentExpression.Append(num);
            var t = _currentExpression.ToString();
            _currentExpression.Clear();
            _currentExpression.Append(Regex.Replace(t, @"\b0+(\d+\.\d+|\d+)(?!\d)", "$1"));
            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        public void Evaluate()
        {
            var exp = _currentExpression.ToString();
            _currentExpression.Clear();
            var (left, op, right, ok) = ParseInput(exp);
            if (ok)
            {
                _currentExpression.Append(EvaluateExpression(exp).ToString());
            }
            else if (IsSqrt(exp))
                _currentExpression.Append(EvaluateSqrt(exp).ToString());
            else if (IsInverse(exp))
                _currentExpression.Append(EvaulateInverse(exp).ToString());
            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
            OnUpdatePreviousValue?.Invoke(exp + " =");
        }

        public double EvaluateExpression(string exp)
        {
            var (left, op, right, ok) = ParseInput(exp);
            left = Simplify(left);
            right = Simplify(right);
            var leftValue = double.Parse(left.ToString());
            var rightValue = double.Parse(right.ToString());
            switch (op)
            {
                case "+": return leftValue + rightValue;
                case "-": return leftValue - rightValue;
                case "*": return leftValue * rightValue;
                case "/": return leftValue / rightValue;
                default: throw new NotImplementedException();
            }

        }

        private double EvaluateSqrt(string exp)
        {
            var t = exp.Replace("sqrt(", "").Replace(")", "");
            return Math.Sqrt(double.Parse(t));
        }

        private double EvaulateInverse(string exp)
        {
            var t = exp.Replace("(1/", "").Replace(")", "");
            return 1 / double.Parse(t);
        }

        private bool IsInverse(string exp) => exp.Contains("(1/");
        private bool IsSqrt(string exp) => exp.Contains("sqrt(");

        private string Simplify(string exp)
        {
            if (IsInverse(exp))
                return EvaulateInverse(exp).ToString();
            else if (IsSqrt(exp))
                return EvaluateSqrt(exp).ToString();
            else
                return exp;
        }

        public void AddOperation(Operations operation)
        {
            if (_currentExpression.Length > 0 && _currentExpression[_currentExpression.Length - 1] == ' ')
                return;


            switch (operation)
            {
                case Operations.Multiplication:
                    _currentExpression.Append(" * ");
                    break;
                case Operations.Plus:
                    _currentExpression.Append(" + ");
                    break;
                case Operations.Minus:
                    _currentExpression.Append(" - ");
                    break;
                case Operations.Divide:
                    _currentExpression.Append(" / ");
                    break;
                case Operations.Sqrt:
                    var (x, i) = FindArgForFuc();
                    _currentExpression.Remove(i != 0 ? i + 1 : i, x.Length);
                    x = Simplify(x);
                    _currentExpression.Append($"sqrt({x}) ");
                    break;
                case Operations.Inverse:
                    (x, i) = FindArgForFuc();
                    _currentExpression.Remove(i != 0 ? i + 1 : i, x.Length);
                    x = Simplify(x);
                    _currentExpression.Append($"(1/{x}) ");
                    break;
                default:
                    throw new NotImplementedException();
            }
            OnUpdateDisplayValue?.Invoke(_currentExpression.ToString());
        }

        private (string, int) FindArgForFuc()
        {
            var t = _currentExpression.ToString().TrimEnd();

            var i = t.LastIndexOf(' ');
            var r = t.Substring(i + 1);
            return (r, i == -1 ? 0 : i);
        }
        private (string, string, string, bool) ParseInput(string input)
        {
            string[] a = input.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            if (a.Length == 3)
                return (a[0], a[1], a[2], true);
            else
                return ("", "", "", false);
        }
    }
}
