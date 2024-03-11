namespace AwesomeCalculator
{
    public partial class Form1 : Form
    {
        private Calculator _calculator;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            _calculator = new Calculator();
            _calculator.OnUpdateDisplayValue += (str) => inout.Text = str;
            _calculator.OnUpdatePreviousValue += (str) => prevExp.Text = str;
        }

        private void OnOperationButtonClick(object sender, EventArgs e)
        {
            var opBtn = sender as OperationButton;
            if (opBtn == null)
                throw new Exception("DONT USE THIS FUNC ON NOT OPERATIONBUTTON");

            switch (opBtn.OperationType)
            {
                case OperationButton.Types.Clear:
                    _calculator.Clear();
                    break;
                case OperationButton.Types.Plus:
                    _calculator.AddOperation(Operations.Plus);
                    break;
                case OperationButton.Types.Minus:
                    _calculator.AddOperation(Operations.Minus);
                    break;
                case OperationButton.Types.Multiplication:
                    _calculator.AddOperation(Operations.Multiplication);
                    break;
                case OperationButton.Types.Sqrt:
                    _calculator.AddOperation(Operations.Sqrt);
                    break;
                case OperationButton.Types.Opposite:
                    _calculator.AddOperation(Operations.Inverse);
                    break;
                case OperationButton.Types.Equel:
                    _calculator.Evaluate();
                    break;
                case OperationButton.Types.Dot:
                    _calculator.AddDot();
                    break;
                case OperationButton.Types.Num1:
                    _calculator.AddNumber(1);
                    break;
                case OperationButton.Types.Num2:
                    _calculator.AddNumber(2);
                    break;
                case OperationButton.Types.Num3:
                    _calculator.AddNumber(3);
                    break;
                case OperationButton.Types.Num4:
                    _calculator.AddNumber(4);
                    break;
                case OperationButton.Types.Num5:
                    _calculator.AddNumber(5);
                    break;
                case OperationButton.Types.Num6:
                    _calculator.AddNumber(6);
                    break;
                case OperationButton.Types.Num7:
                    _calculator.AddNumber(7);
                    break;
                case OperationButton.Types.Num8:
                    _calculator.AddNumber(8);
                    break;
                case OperationButton.Types.Num9:
                    _calculator.AddNumber(9);
                    break;
                case OperationButton.Types.Num0:
                    _calculator.AddNumber(0);
                    break;
                case OperationButton.Types.MemPlus:
                    _calculator.MemoryPlus();
                    break;
                case OperationButton.Types.MemRead:
                    _calculator.ReadMemory();
                    break;
                case OperationButton.Types.MemClear:
                    _calculator.ClearMemory();
                    break;
                case OperationButton.Types.Del:
                    _calculator.RemoveLast();
                    break;
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    _calculator.Clear();
                    break;
                case Keys.Oemplus:
                    _calculator.AddOperation(Operations.Plus);
                    break;
                case Keys.Add:
                    _calculator.AddOperation(Operations.Plus);
                    break;
                case Keys.OemMinus:
                    _calculator.AddOperation(Operations.Minus);
                    break;
                case Keys.Subtract:
                    _calculator.AddOperation(Operations.Minus);
                    break;
                case Keys.Multiply:
                    _calculator.AddOperation(Operations.Multiplication);
                    break;
                case Keys.S:
                    _calculator.AddOperation(Operations.Sqrt);
                    break;
                case Keys.I:
                    _calculator.AddOperation(Operations.Inverse);
                    break;
                case Keys.E:
                    _calculator.Evaluate();
                    break;
                case Keys.Decimal:
                    _calculator.AddDot();
                    break;
                case Keys.Oemcomma:
                    _calculator.AddDot();
                    break;
                case Keys.OemPeriod:
                    _calculator.AddDot();
                    break;

                case Keys.D1:
                    _calculator.AddNumber(1);
                    break;
                case Keys.NumPad1:
                    _calculator.AddNumber(1);
                    break;
                case Keys.D2:
                    _calculator.AddNumber(2);
                    break;
                case Keys.NumPad2:
                    _calculator.AddNumber(2);
                    break;
                case Keys.D3:
                    _calculator.AddNumber(3);
                    break;
                case Keys.NumPad3:
                    _calculator.AddNumber(3);
                    break;
                case Keys.D4:
                    _calculator.AddNumber(4);
                    break;
                case Keys.NumPad4:
                    _calculator.AddNumber(4);
                    break;
                case Keys.D5:
                    _calculator.AddNumber(5);
                    break;
                case Keys.NumPad5:
                    _calculator.AddNumber(5);
                    break;
                case Keys.D6:
                    _calculator.AddNumber(6);
                    break;
                case Keys.NumPad6:
                    _calculator.AddNumber(6);
                    break;
                case Keys.D7:
                    _calculator.AddNumber(7);
                    break;
                case Keys.NumPad7:
                    _calculator.AddNumber(7);
                    break;
                case Keys.D8:
                    _calculator.AddNumber(8);
                    break;
                case Keys.NumPad8:
                    _calculator.AddNumber(8);
                    break;
                case Keys.D9:
                    _calculator.AddNumber(9);
                    break;
                case Keys.NumPad9:
                    _calculator.AddNumber(9);
                    break;
                case Keys.D0:
                    _calculator.AddNumber(0);
                    break;
                case Keys.NumPad0:
                    _calculator.AddNumber(0);
                    break;
                case Keys.Back:
                    _calculator.RemoveLast();
                    break;
            }
        }
    }
}
