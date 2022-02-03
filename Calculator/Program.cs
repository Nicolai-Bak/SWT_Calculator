
Calculator.Calculator c = new Calculator.Calculator();
double a, b;

Console.WriteLine("Test Add");
Console.Write("\ttwo positive numbers\t");
a = 4;
b = 5;
Console.WriteLine(c.Add(a, b));
Console.Write("\ttwo negative numbers\t");
a = -4;
b = -5;
Console.WriteLine(c.Add(a, b));

Console.Write("\tOne positve, one negative\t");
a = 4;
b = -5;
Console.WriteLine(c.Add(a, b));

Console.WriteLine("Test Subtract");
Console.Write("\ttwo positive numbers \t");
a = 4;
b = 5;
Console.WriteLine(c.Subtract(a, b));


Console.Write("\ttwo negative numbers\t");
a = -4;
b = -5;
Console.WriteLine(c.Subtract(a, b));

Console.Write("\tOne positve, one negative\t");
a = 4;
b = -5;
Console.WriteLine(c.Subtract(a, b));

Console.Write("\tOne negative, one positive\t");
a = -4;
b = 5;
Console.WriteLine(c.Subtract(a, b));

Console.WriteLine("Test Multiply");
Console.Write("\ttwo positive numbers\t");
a = 4;
b = 5;
Console.WriteLine(c.Multiply(a, b));

Console.Write("\ttwo negative numbers\t");
a = -4;
b = -5;
Console.WriteLine(c.Multiply(a, b));

Console.Write("\tOne positve, one negative\t");
a = 4;
b = -5;
Console.WriteLine(c.Multiply(a, b));

Console.Write("One negative, one positive");
a = -4;
b = 5;
Console.WriteLine(c.Multiply(a, b));

Console.Write("Zero");
a = 4;
b = 0;
Console.WriteLine(c.Multiply(a, b));

Console.WriteLine("Test Power");
Console.Write("\ttwo positive numbers\t");
a = 4;
b = 5;
Console.WriteLine(c.Power(a, b));


//      two negative numbers
a = -4;
b = -5;
Console.WriteLine(c.Power(a, b));

//      One positve, one negative
a = 4;
b = -5;
Console.WriteLine(c.Power(a, b));

//      One negative, one positive
a = -4;
b = 5;
Console.WriteLine(c.Power(a, b));

//      Zero x
a = 0;
b = 5;
Console.WriteLine(c.Power(a, b));

//      Zero exp
a = 4;
b = 0;
Console.WriteLine(c.Power(a, b));



//using System;

//namespace Calculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator c = new Calculator();
//            double a, b;

//            Console.WriteLine("Test Add()");
//            Console.WriteLine("two positive numbers");
//            a = 4; 
//            b = 5;
//            Console.WriteLine(c.Add(a, b));
//            Console.WriteLine("two negative numbers");
//            a = -4;
//            b = -5;
//            Console.WriteLine(c.Add(a, b));

//            Console.WriteLine("One positve, one negative");
//            a = 4;
//            b = -5;
//            Console.WriteLine(c.Add(a, b));

//            //      Test Subtract
//            //      two positive numbers
//            a = 4;
//            b = 5;
//            Console.WriteLine(c.Subtract(a, b));


//            //      two negative numbers
//            a = -4;
//            b = -5;
//            Console.WriteLine(c.Subtract(a, b));

//            //      One positve, one negative
//            a = 4;
//            b = -5;
//            Console.WriteLine(c.Subtract(a, b));

//            //      One negative, one positive
//            a = -4;
//            b = 5;
//            Console.WriteLine(c.Subtract(a, b));


//            //      Test Multiply
//            //      two positive numbers
//            a = 4;
//            b = 5;
//            Console.WriteLine(c.Multiply(a, b));


//            //      two negative numbers
//            a = -4;
//            b = -5;
//            Console.WriteLine(c.Multiply(a, b));

//            //      One positve, one negative
//            a = 4;
//            b = -5;
//            Console.WriteLine(c.Multiply(a, b));

//            //      One negative, one positive
//            a = -4;
//            b = 5;
//            Console.WriteLine(c.Multiply(a, b));

//            //      Zero
//            a = 4;
//            b = 0;
//            Console.WriteLine(c.Multiply(a, b));

//            //      Test Power
//            //      two positive numbers
//            a = 4;
//            b = 5;
//            Console.WriteLine(c.Power(a, b));


//            //      two negative numbers
//            a = -4;
//            b = -5;
//            Console.WriteLine(c.Power(a, b));

//            //      One positve, one negative
//            a = 4;
//            b = -5;
//            Console.WriteLine(c.Power(a, b));

//            //      One negative, one positive
//            a = -4;
//            b = 5;
//            Console.WriteLine(c.Power(a, b));

//            //      Zero x
//            a = 0;
//            b = 5;
//            Console.WriteLine(c.Power(a, b));

//            //      Zero exp
//            a = 4;
//            b = 0;
//            Console.WriteLine(c.Power(a, b));


//        }



//    }
//}