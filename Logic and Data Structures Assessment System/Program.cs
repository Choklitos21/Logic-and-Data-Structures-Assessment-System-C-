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
                break;
            case "3":
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
    Console.WriteLine($"The sum of them is {num1 + num2}");
}


StartMenu();