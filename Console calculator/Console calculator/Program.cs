// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool exit = false;

while (!exit) {
    Console.WriteLine("Welcome to console calculator!");
    Console.WriteLine("______________________________");
    Console.WriteLine("Enter first number.");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter action (+, -, *, /): ");
    char operation = Console.ReadLine()[0];
    Console.WriteLine("Enter second number.");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;
    switch (operation) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else {
                Console.WriteLine("Mistake! Division by zero!");
                continue;
            }
            break;
        default:
            Console.WriteLine("Mistake!Unknown operation!");
            continue;
    }
    Console.WriteLine($"Result: {result}");
    Console.WriteLine("Want to continue? (y/n)");
    char choice = Console.ReadLine()[0];
    if (choice == 'n' || choice == 'N')
    {
        exit = true;
    }
}