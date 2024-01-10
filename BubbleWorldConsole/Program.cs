using BubbleWorldConsole;

Console.Title = "World of Bubbles";

Console.Write(
    "Enter the pattern:\r\n" +
    "1. World Map (type 'world')\r\n" +
    "2. Bubbles (type whatever you want)\r\n" +
    ">");

string userInput = Console.ReadLine().ToLower().Trim();

if (userInput == "world")
{
    World.DrawWorld();
}
else
{
    Bubbles.DrawBubbles();
}
