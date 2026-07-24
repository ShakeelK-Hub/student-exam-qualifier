class Program
{
    static void Main(string[] args)
    {
        // This list stores each student's result so we can display them later.
        List<string> allStudents = new List<string>();

        while (true)
        {
            ShowMenu();

            
            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine()!);
            }
            catch
            {
                Console.WriteLine("\nPlease enter a valid number.\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    EnterStudent(allStudents);
                    break;

                case 2:
                    ViewStudents(allStudents);
                    break;

                case 3:
                    Console.WriteLine("\nAll entries have been captured.\nThank you & goodbye.\n");
                    return;

                default:
                    Console.WriteLine("\nInvalid option. Please choose 1, 2 or 3.\n");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("     EXAM QUALIFICATION CALCULATOR");
        Console.WriteLine("========================================\n");
        Console.WriteLine(" 1. Enter a new student");
        Console.WriteLine(" 2. View all students");
        Console.WriteLine(" 3. Exit");
        Console.WriteLine("\n----------------------------------------\n");
        Console.Write(" Choose an option: ");
    }



    // Handles entering one student's marks and showing their result.
    static void EnterStudent(List<string> allStudents)
    {
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine("           NEW STUDENT ENTRY");
        Console.WriteLine("----------------------------------------");

        Console.Write("\n Student's name: ");
        string name = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("\nName cannot be empty.\n");
            return;
        }

        // Check if the name is actually a number - if it can be parsed as one, reject it
        bool nameIsANumber = double.TryParse(name, out double unusedValue);

        if (nameIsANumber)
        {
            Console.WriteLine("\nName cannot be a number. Student entry cancelled.\n");
            return;
        }

        int test1;
        try
        {
            Console.Write(" Test 1 score (30%): ");
            test1 = int.Parse(Console.ReadLine()!);
        }
        catch
        {
            Console.WriteLine("\nInvalid entry. Please enter a numerical value.\n");
            return;
        }

        if (test1 < 0 || test1 > 100)
        {
            Console.WriteLine("\nMarks must be between 0 and 100.\n");
            return;
        }

        int test2;
        try
        {
            Console.Write(" Test 2 score (50%): ");
            test2 = int.Parse(Console.ReadLine()!);
        }
        catch
        {
            Console.WriteLine("\nInvalid mark. Student entry cancelled.\n");
            return;
        }

         if (test2 < 0 || test2 > 100)
        {
            Console.WriteLine("\nMarks must be between 0 and 100.\n");
            return;
        }

        int assignment1;
        try
        {
            Console.Write(" Assignment 1 score (10%): ");
            assignment1 = int.Parse(Console.ReadLine()!);
        }
        catch
        {
            Console.WriteLine("\nInvalid mark. Student entry cancelled.\n");
            return;
        }

         if (assignment1 < 0 || assignment1 > 100)
        {
            Console.WriteLine("\nMarks must be between 0 and 100.\n");
            return;
        }

        int project;
        try
        {
            Console.Write(" Project score (10%): ");
            project = int.Parse(Console.ReadLine()!);
        }
        catch
        {
            Console.WriteLine("\nInvalid mark. Student entry cancelled.\n");
            return;
        }

         if (project < 0 || project > 100)
        {
            Console.WriteLine("\nMarks must be between 0 and 100.\n");
            return;
        }

        // Calculate the weighted average.
        double average = (test1 * 0.30) + (test2 * 0.50) + (assignment1 * 0.10) + (project * 0.10);

        string result;

        if (average >= 50)
        {
            result = "QUALIFIES";
        }
        else
        {
            result = "DOES NOT QUALIFY";
        }

        Console.WriteLine("\n----------------------------------------\n");
        Console.WriteLine($" Name:              {name}");
        Console.WriteLine($" Weighted Average:  {average:F2}");
        Console.WriteLine($" Result:            {result}");
        Console.WriteLine("\n----------------------------------------\n");

        // Format and store record in the master list for persistent session viewing
        allStudents.Add($"{name,-20} {average,6:F2}%   {result}");
    }



    // Displays every student entered so far.
    static void ViewStudents(List<string> allStudents)
    {
        Console.WriteLine("\n---------------------------------------------------------");
        Console.WriteLine("             ALL STUDENTS");
        Console.WriteLine("---------------------------------------------------------");

        if (allStudents.Count == 0)
        {
            Console.WriteLine(" No students have been entered yet.");
        }
        else
        {
            foreach (string entry in allStudents)
            {
                Console.WriteLine(" " + entry);
            }
        }

        Console.WriteLine("---------------------------------------------------------");
    }
}