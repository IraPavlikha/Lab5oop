using System;

class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            return 0;
        }
        return a / b;
    }
    public double Modulus(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            return 0;
        }
        return a % b;
    }
    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator myCalculator = new Calculator();
        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додавання");
        Console.WriteLine("2. Віднімання");
        Console.WriteLine("3. Множення");
        Console.WriteLine("4. Ділення");
        Console.WriteLine("5. Остача від ділення (Modulus)");
        Console.WriteLine("6. Піднесення до степеня (Power)");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть перший операнд: ");
        double operand1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть другий операнд: ");
        double operand2 = Convert.ToDouble(Console.ReadLine());
        switch (choice)
        {
            case 1:
                double sumResult = myCalculator.Add(operand1, operand2);
                Console.WriteLine("Результат: " + sumResult);
                break;
            case 2:
                double subResult = myCalculator.Subtract(operand1, operand2);
                Console.WriteLine("Результат: " + subResult);
                break;
            case 3:
                double mulResult = myCalculator.Multiply(operand1, operand2);
                Console.WriteLine("Результат: " + mulResult);
                break;
            case 4:
                double divResult = myCalculator.Divide(operand1, operand2);
                Console.WriteLine("Результат: " + divResult);
                break;
            case 5:
                double modResult = myCalculator.Modulus(operand1, operand2);
                Console.WriteLine("Результат: " + modResult);
                break;
            case 6:
                double powerResult = myCalculator.Power(operand1, operand2);
                Console.WriteLine("Результат: " + powerResult);
                break;
            default:
                Console.WriteLine("Неправильний вибір операції.");
                break;
        }
    }
}