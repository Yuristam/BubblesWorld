using BubbleWorldConsole;

Console.Title = "World of Bubbles";

if (Console.ReadLine() == "world")
{
    World.DrawWorld();
}

else
{
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

        Helper.SetRandomColor();

        Console.Write('o'); // change the symbol
        Thread.Sleep(100);  // change the speed
    }
}
