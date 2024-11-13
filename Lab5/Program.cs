using System;

public class Calculator
{
    // Приватні методи для виконання арифметичних операцій
    private double Add(double a, double b)
    {
        return a + b;
    }

    private double Subtract(double a, double b)
    {
        return a - b;
    }

    private double Multiply(double a, double b)
    {
        return a * b;
    }

    private double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            return 0;
        }
        return a / b;
    }

    private double Modulus(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
            return 0;
        }
        return a % b;
    }

    private double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    // Публічний метод для виконання операцій за вибором
    public double ExecuteOperation(int choice, double a, double b)
    {
        switch (choice)
        {
            case 1:
                return Add(a, b);
            case 2:
                return Subtract(a, b);
            case 3:
                return Multiply(a, b);
            case 4:
                return Divide(a, b);
            case 5:
                return Modulus(a, b);
            case 6:
                return Power(a, b);
            default:
                Console.WriteLine("Невідомий вибір операції.");
                return 0;
        }
    }
}

public class UserInterface
{
    // Виведення вибору операції
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

    // Введення операнда
    public static double GetOperand(string operandName)
    {
        Console.Write($"Введіть {operandName} операнд: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    // Виведення результату
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

        // Виконання операції через публічний метод ExecuteOperation
        double result = myCalculator.ExecuteOperation(choice, operand1, operand2);
        UserInterface.ShowResult(result);
    }
}
