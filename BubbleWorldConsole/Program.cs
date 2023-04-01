Console.CursorVisible = false;

Random rnd = new Random();

while(true)
{
    Console.SetCursorPosition(rnd.Next(0, 120), rnd.Next(0, 28));
    int Colornum = rnd.Next(0, 7);
    switch (Colornum)
    {
        case 0: Console.ForegroundColor = ConsoleColor.Red; break;
        case 1: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
        case 2: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
        case 4: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
        case 5: Console.ForegroundColor = ConsoleColor.DarkGray; break;
        case 6: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
    }
    Console.WriteLine('o');
    Thread.Sleep(100);
    //Console.Clear();
}