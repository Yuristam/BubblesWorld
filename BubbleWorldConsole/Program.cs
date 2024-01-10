Console.Title = "Bubbles";
Console.CursorVisible = false;

for (int i = 0; i < 3600; i++)
{
    // uncomment below if you want background color to be white
    //Console.BackgroundColor = ConsoleColor.White;
    Console.Write(' ');
}
Random rnd = new Random();

while (true)
{
    Console.SetCursorPosition(rnd.Next(0, 120), rnd.Next(0, 28));
    int Colornum = rnd.Next(0, 15);
    switch (Colornum)
    {
        case 0: Console.ForegroundColor = ConsoleColor.Black; break;
        case 1: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
        case 2: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
        case 3: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
        case 4: Console.ForegroundColor = ConsoleColor.DarkRed; break;
        case 5: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        case 6: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
        case 7: Console.ForegroundColor = ConsoleColor.Gray; break;
        case 8: Console.ForegroundColor = ConsoleColor.DarkGray; break;
        case 9: Console.ForegroundColor = ConsoleColor.Blue; break;
        case 10: Console.ForegroundColor = ConsoleColor.Green; break;
        case 11: Console.ForegroundColor = ConsoleColor.Cyan; break;
        case 12: Console.ForegroundColor = ConsoleColor.Red; break;
        case 13: Console.ForegroundColor = ConsoleColor.Magenta; break;
        case 14: Console.ForegroundColor = ConsoleColor.Yellow; break;
        case 15: Console.ForegroundColor = ConsoleColor.White; break;
    }
    Console.Write('o'); // change the symbol
    Thread.Sleep(100);  // change the speed
}