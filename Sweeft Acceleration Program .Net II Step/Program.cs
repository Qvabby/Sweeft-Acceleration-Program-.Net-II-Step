using Sweeft_Acceleration_Program_.Net_II_Step;

InternTasks internTasks = new InternTasks();

//Task 1. (IsPalindrome function)
Console.WriteLine("Checking IsPalindrome function:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\tmalayalam - {internTasks.IsPalindrome("malayalam")}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\tmala - {internTasks.IsPalindrome("mala")}\n\n");
Console.ResetColor();


//Task 2. (MinSplit function)
Console.WriteLine("Check Minimal amount of coins for Tetrebi:");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\t4 Tetri - {internTasks.MinSplit(4)} coins minimal amount");
Console.WriteLine($"\t40 Tetri - {internTasks.MinSplit(40)} coins minimal amount");
Console.WriteLine($"\t60 Tetri - {internTasks.MinSplit(60)} coins minimal amount\n\n");
Console.ResetColor();

//Task 3 (NotContains).
Console.WriteLine("Check Minimal value which is not contained in array and is more than 0:");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\t[1, 2, 3, 4, 5, 9, 14, 1236, 6] - {internTasks.NotContains([1, 2, 3, 4, 5, 9, 14, 1236, 6])}");
Console.WriteLine($"\t[1, 3] - {internTasks.NotContains([1, 3])}");
Console.WriteLine($"\t[4, 6, 5, 4] - {internTasks.NotContains([4, 6, 5, 4])}");
Console.ResetColor();