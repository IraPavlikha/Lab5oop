using System;

public class Calculator
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

public class UserInterface
{
    public static int GetChoice()
    {
        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додавання");
        Console.WriteLine("2. Віднімання");
        Console.WriteLine("3. Множення");
        Console.WriteLine("4. Ділення");
        Console.WriteLine("5. Залишок від ділення");
        Console.WriteLine("6. Піднесення до степеня");
        Console.Write("Ваш вибір: ");
        
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 1 || choice > 6)
        {
            Console.WriteLine("Неправильний вибір операції.");
            Environment.Exit(0);
        }
        return choice;
    }

    public static double GetOperand(string operandName)
    {
        Console.Write($"Введіть {operandName} операнд: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static void ShowResult(double result)
    {
        Console.WriteLine("Результат: " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator myCalculator = new Calculator();
        int choice = UserInterface.GetChoice();

        double operand1 = UserInterface.GetOperand("перший");
        double operand2 = UserInterface.GetOperand("другий");

        switch (choice)
        {
            case 1:
                UserInterface.ShowResult(myCalculator.Add(operand1, operand2));
                break;
            case 2:
                UserInterface.ShowResult(myCalculator.Subtract(operand1, operand2));
                break;
            case 3:
                UserInterface.ShowResult(myCalculator.Multiply(operand1, operand2));
                break;
            case 4:
                UserInterface.ShowResult(myCalculator.Divide(operand1, operand2));
                break;
            case 5:
                UserInterface.ShowResult(myCalculator.Modulus(operand1, operand2));
                break;
            case 6:
                UserInterface.ShowResult(myCalculator.Power(operand1, operand2));
                break;
        }
    }
}
