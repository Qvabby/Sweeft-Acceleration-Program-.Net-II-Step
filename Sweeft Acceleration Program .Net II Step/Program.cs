using Sweeft_Acceleration_Program_.Net_II_Step;
//1-5 დავალებები.
InternTasks internTasks = new InternTasks();

//Task 1. (IsPalindrome function)
Console.WriteLine("1. Checking IsPalindrome function:\n");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\tmalayalam - {internTasks.IsPalindrome("malayalam")}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\tmala - {internTasks.IsPalindrome("mala")}\n\n");
Console.ResetColor();

//Task 2. (MinSplit function)
Console.WriteLine("2. Check Minimal amount of coins for Tetrebi:\n");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"\t4 Tetri - {internTasks.MinSplit(4)} coins minimal amount");
Console.WriteLine($"\t40 Tetri - {internTasks.MinSplit(40)} coins minimal amount");
Console.WriteLine($"\t60 Tetri - {internTasks.MinSplit(60)} coins minimal amount\n\n");
Console.ResetColor();

//Task 3 (NotContains).
Console.WriteLine("3. Check Minimal value which is not contained in array and is more than 0:\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\t [1, 2, 3, 4, 5, 9, 14, 1236, 6] - {internTasks.NotContains([1, 2, 3, 4, 5, 9, 14, 1236, 6])}");
Console.WriteLine($"\t [1, 3] - {internTasks.NotContains([1, 3])}");
Console.WriteLine($"\t [1, 2,3,7,4,5,9,14,1200, 6] - {internTasks.NotContains([1, 2, 3, 7, 4, 5, 9, 14, 1200, 6])}\n\n");
Console.ResetColor();

//Task 4 (IsProperly).
Console.WriteLine("4. Check if sequence of parentheses is properly:\n");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\t \\\"„(„ და „“\\\" - {internTasks.IsProperly("„(„ და „“")}");
Console.WriteLine($"\t )()()( - {internTasks.IsProperly(")()()(")}");
Console.WriteLine($"\t ()(()) - {internTasks.IsProperly("()(())")}\n");
Console.ResetColor();

//Task 5 (ways to go up n stairs.)
Console.WriteLine("5. Check ways to go up n stairs:\n");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\t7 stairs -> {internTasks.CountVariants(7)}");
Console.WriteLine($"\t5 stairs -> {internTasks.CountVariants(5)}");
Console.WriteLine($"\t2 stairs -> {internTasks.CountVariants(2)}");
Console.ResetColor();