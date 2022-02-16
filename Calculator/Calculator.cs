namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b) {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp) { 
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Accumulator = 0;
                throw new ArgumentOutOfRangeException("Can't divide by zero");
            }
            Accumulator = dividend / divisor;
            return Accumulator;
        }
        public void Clear()
        {
            Accumulator = 0;
        }
    }
}