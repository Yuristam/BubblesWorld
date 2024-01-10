namespace BubbleWorldConsole
{
    public static class Helper
    {
        private static Random rnd = new Random();

        public static void SetRandomColor()
        {
            int colorNum = rnd.Next(0, 15);

            switch (colorNum)
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
        }

        public static void SetChosenColor(string userInput)
        {
            switch (userInput)
            {
                case "dark blue": Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case "dark green": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case "dark cyan": Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case "dark red": Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case "dark magenta": Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case "dark yellow": Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case "gray": Console.ForegroundColor = ConsoleColor.Gray; break;
                case "dark gray": Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case "blue": Console.ForegroundColor = ConsoleColor.Blue; break;
                case "green": Console.ForegroundColor = ConsoleColor.Green; break;
                case "cyan": Console.ForegroundColor = ConsoleColor.Cyan; break;
                case "red": Console.ForegroundColor = ConsoleColor.Red; break;
                case "magenta": Console.ForegroundColor = ConsoleColor.Magenta; break;
                case "yellow": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "white": Console.ForegroundColor = ConsoleColor.White; break;
                case "random": break;
                default: Console.WriteLine("Sorry, there is no such color"); break;
            }
        }
    }
}
