using System.Threading;

const string menu = @"
--- Technical Training Center ---

Level 1: Summation and Numerical Validation
Level 2: Calculations and Conditional Statements
Level 3: String Manipulation
Level 4: Logical Operations (Calculator)
Level 5: Numerical Analysis (Integer Lists)
Level 6: Task Management (String Lists)
Level 7: Arrays and Searching
Level 8: Object-Oriented Programming (Classes)
Level 9: Object CRUD (Object Lists)
Option 10: Exit

Select a level to begin: ";

void StartMenu()
{
    bool flag = true;
    
    while (flag)
    {
        Console.Write(menu);
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                AddingTwoNumbers();
                break;
            case "2":
                AverageGrade();
                break;
            case "3":
                JoinStrings();
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "7":
                break;
            case "8":
                break;
            case "9":
                break;
            case "10":
                flag = false;
                Console.WriteLine("\n++++++++++Good bye! C: ++++++++++");
                break;
            default:
                Console.WriteLine("\n++++++++++Option not valid, use one of the menu++++++++++");
                Thread.Sleep(3000); 
                break;
        }
    }
    
}

void AddingTwoNumbers()
{
    int num1;
    int num2;
    
    Console.Write("\nType the first integer: ");
    string? input1 = Console.ReadLine();
    
    Console.Write("\nType the second integer: ");
    string? input2 = Console.ReadLine();
    
    if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
    {
        Console.WriteLine("\n++++++++++Cannot be empty, try again++++++++++");
        Thread.Sleep(3000); 
        return;
    } else if (int.TryParse(input1, out int out1) && int.TryParse(input2, out int out2))
    {
        num1 = out1;
        num2 = out2;
    }
    else
    {   
        Console.WriteLine("\n++++++++++Must be a number++++++++++");
        Thread.Sleep(3000); 
        return;
    }
    Console.WriteLine($"\nThe sum of them is {num1 + num2}");
    Thread.Sleep(3000); 
}

void AverageGrade()
{
    double num1;
    double num2;
    double num3;
    
    Console.Write("\nType the first grade: ");
    string? input1 = Console.ReadLine();
    
    Console.Write("\nType the second grade: ");
    string? input2 = Console.ReadLine();
    
    Console.Write("\nType the third grade: ");
    string? input3 = Console.ReadLine();
    
    if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3))
    {
        Console.WriteLine("\n++++++++++Cannot be empty, try again++++++++++");
        Thread.Sleep(3000); 
        return;
    } else if (double.TryParse(input1, out double out1) && double.TryParse(input2, out double out2) && double.TryParse(input3, out double out3))
    {
        num1 = out1;
        num2 = out2;
        num3 = out3;
        
        if (num1 > 5.0 || num1 < 0 || num2 > 5.0 || num2 < 0 || num3 > 5.0 || num3 < 0)
        {
            Console.WriteLine("\n++++++++++ Cannot be higher than 5.0 or less than 0 ++++++++++");
            Thread.Sleep(3000); 
            return;
        }
        
    }
    else
    {   
        Console.WriteLine("\n++++++++++Must be a number++++++++++");
        Thread.Sleep(3000); 
        return;
    }

    double average = (num1 + num2 + num3) / 3.0;

    if (average < 3.0)
    {
        Console.WriteLine($"\nFailed with: {average}");
        Thread.Sleep(3000);
        return;
    }
    
    Console.WriteLine($"\nPassed with: {average:F1}");
    Thread.Sleep(3000);
}

void JoinStrings()
{
    Console.Write("\nType your first name: ");
    string? name= Console.ReadLine();
    
    Console.Write("\nType your last name: ");
    string? lastName = Console.ReadLine();

    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Don't leave empty the fields");
        Thread.Sleep(3000);
        return;
    }
    
    Console.WriteLine($"Hi " + name + " " + lastName + "\nHave a good day!");
    Thread.Sleep(3000);
}

void Calculator()
{
    double num1;
    double num2;
    
    Console.Write("\nSelect an operation\n| + (add)\n| - (subtract)\n| * (multiply)\n| / (divide)\n| Choose: ");
    string? operation = Console.ReadLine();
    
    Console.Write("\nType the first number: ");
    string? input1 = Console.ReadLine();
    
    Console.Write("\nType the second number: ");
    string? input2 = Console.ReadLine();

    if (double.TryParse(input1, out double out1))
    {
        
    }
}

StartMenu();