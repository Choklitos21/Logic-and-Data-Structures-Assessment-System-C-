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
Option 0: Exit

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
                Calculator();
                break;
            case "5":
                NumericalAnalysis();
                break;
            case "6":
                TaskManagement();
                break;
            case "7":
                ArraysAndSearch();
                break;
            case "8":
                ObjectCollections();
                break;
            case "0":
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

// Level 1
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

// Level 2
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

// Level 3
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

// Level 4
void Calculator()
{
    double num1;
    double num2;
    
    Console.Write("\nSelect an operation\n| + (add)\n| - (subtract)\n| * (multiply)\n| / (divide)\n| Choose: ");
    string operation = Console.ReadLine() ?? "";
    while (operation == "" || operation != "+" || operation != "-" || operation != "*" || operation != "/")
    {
        Console.Write("Type one of the available options: ");
        operation = Console.ReadLine() ?? "";
    }
    
    Console.Write("\nType the first number: ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Type only numbers: ");
    }
    
    Console.Write("\nType the second number: ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Type only numbers: ");
    }

    switch (operation)
    {
        case "+":
            Console.WriteLine($"The result of {num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"The result of {num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"The result of {num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Cannot divide by 0");
                return;
            }
            Console.WriteLine($"The result of {num1} / {num2} = {num1 / num2}");
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
    
    
}

// Level 5
void NumericalAnalysis()
{
    int count = 0;
    List<double> numbersList = new List<double>();
    
    while (count < 5)
    {
        double num;
        Console.Write($"\n#{count + 1} Type a number: ");
        while (!double.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Type only numbers: ");
        }
        numbersList.Add(num);
        count++;
    }

    Console.WriteLine($"The higher numbers is {numbersList.Max()}");
    Console.WriteLine($"The lower numbers is {numbersList.Min()}");
    Console.WriteLine($"The sum off all numbers is {numbersList.Sum()}");
}

// Level 6
void TaskManagement()
{
    const string taskMenu = @"
    --- Technical Training Center ---

    Option 1: List all tasks
    Option 2: Add a new Task
    Option 3: Delete a Task by ID
    Option 0: Exit Task Management menu

    Select an option: ";

    List<string> taskList = new List<string>();

    bool taskFlag = true;
    while (taskFlag == true)
    {
        Console.WriteLine(taskMenu);
        string taskOption = Console.ReadLine() ?? "";
        switch (taskOption)
        {
            case "1":
                foreach (var task in taskList)
                {
                    Console.WriteLine($"\n***Task with ID: {taskList.IndexOf(task)}***\nDescription: {task}");
                }
                break;
            case "2":
                Console.WriteLine("Type the description for the new task: ");
                string newTask = Console.ReadLine() ?? "";
                while ( newTask == "")
                {
                    Console.WriteLine("Cannot be empty: ");
                    newTask = Console.ReadLine() ?? "";
                }
                taskList.Add(newTask);
                break;
            case "3":
                Console.WriteLine("Type the ID of the task to delete: ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Type only numbers: ");
                }

                if ((taskList.Count + 1) < id)
                {
                    Console.WriteLine("ID not found in the list");
                }
                
                taskList.RemoveAt(id);
                Console.WriteLine("Task deleted successfully");
                break;
            case "0":
                Console.WriteLine("Out from Task Management");
                taskFlag = false;
                break;
            default:
                Console.WriteLine("Option not valid, try again");
                break;
        }
    }
}

// Level 7
void ArraysAndSearch()
{
    string[] cities = new string[] { "medellin", "bogota", "cali", "barranquilla", "cartagena" };
    
    Console.WriteLine("Type the name of a city to search: ");
    string city = Console.ReadLine() ?? "";
    while ( city == "")
    {
        Console.WriteLine("Cannot be empty: ");
        city = Console.ReadLine() ?? "";
    }

    for (int i = 0; i < cities.Length; i++)
    {
        if (city == cities[i])
        {
            Console.WriteLine("City found!");
            return;
        }
    }

    Console.WriteLine("City not found :c");
    
}

// Level 8
void ObjectCollections()
{
    List<Student.Student> studentsList = new List<Student.Student>();

    const string studentsMenu = @"
    --- Technical Training Center ---

    Option 1: Register a Students
    Option 2: List all Students
    Option 3: Delete a Student
    Option 0: Exit Students menu

    Select an option: ";

    bool studentsFlag = true;
    while (studentsFlag)
    {
        Console.WriteLine(studentsMenu);
        string option = Console.ReadLine() ?? "";
        while (option == "")
        {
            Console.WriteLine("Cannot be empty: ");
            option = Console.ReadLine() ?? "";
        }

        switch (option)
        {
            case "1":
                Console.WriteLine("What's the student name?: ");
                string name = Console.ReadLine() ?? "";
                while (name == "")
                {
                    Console.WriteLine("Cannot be empty: ");
                    name = Console.ReadLine() ?? "";
                }
                
                Console.WriteLine("What's his/her age?: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Cannot be empty and must be a number");
                }
                
                studentsList.Add(new Student.Student(name, age));
                Console.WriteLine("Student registered successfully!");
                break;
            case "2":
                foreach (var student in studentsList)
                {
                    student.ShowStudent();
                }
                break;
            case "3":
                Console.WriteLine("Type the name of the Student you wish to remove: ");
                string removeName = Console.ReadLine() ?? "";
                bool found = false;
                foreach (var student in studentsList)
                {
                    if (student.Name.ToLower() == removeName.ToLower())
                    {
                        studentsList.Remove(student);
                        Console.WriteLine("Student removed successfully!");
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("Student not found, no one was removed");
                break;
            case "0":
                Console.WriteLine("Exit Students menu");
                studentsFlag = false;
                break;
            default:
                Console.WriteLine("");
                break;
        }
    }
}

StartMenu();

namespace Student
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"***Student***\nName: {Name}\nAge: {Age}");
        }
    }
}