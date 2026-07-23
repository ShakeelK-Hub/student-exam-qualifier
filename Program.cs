class Program
{
    static void Main(string[] args)
    {
        // This list remembers each student's result so we can show them later.
        List<string> allStudents = new List<string>();

        while (true)
        {
            ShowMenu();

            // Read the choice as a whole number instead of text.
            int choice;

            try
            {
                choice = int.Parse(Console.ReadLine()!);
            }
            catch
            {
                Console.WriteLine("\nPlease enter a valid number.\n");
                continue; // Goes back to the menu.
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
                    return; // Ends the program immediately.

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

        // Save a summary line so it can be viewed later.
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