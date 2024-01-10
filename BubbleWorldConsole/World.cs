namespace BubbleWorldConsole;

public class World
{
    public static void DrawWorld()
    {
        while (true)
        {
            Console.Clear();
            Console.Write(
                "Choose color:\r\n" +
                "1. Random\r\n" +
                "2. DarkBlue\r\n" +
                "3. DarkGreen\r\n" +
                "4. DarkCyan\r\n" +
                "5. DarkRed\r\n" +
                "6. DarkMagenta\r\n" +
                "7. DarkYellow\r\n" +
                "8. Gray\r\n" +
                "9. DarkGray\r\n" +
                "10. Blue\r\n" +
                "11. Green\r\n" +
                "12. Cyan\r\n" +
                "13. Red\r\n" +
                "14. Magenta\r\n" +
                "15. Yellow\r\n" +
                "16. White\r\n" +
                ">");

            string userInput = Console.ReadLine().ToLower().Trim();

            Helper.SetChosenColor(userInput);

            string world = @"                                                                                                                        
                                                                                                                        
                                     oooooooooooooooo                                                                   
                       o                  oooooooo                                oooooo                                
        oooooooooooooooo ooo oooo  ooo   ooooo                ooooooo  ooooooo oooooooooooooooooooooooooooooooooo       
    ooooooooooooooooooooooo     oo        o                oooo ooooooooooooooooooooooooooooooooooooooooooo  ooo        
             oooooooooooooooo ooooooo                           ooooooooooooooooooooooooooooooooooooooo       oo        
             ooooooooooooooooooo                        oooooooooooooooooooooooooooooooooooooooooooooooooo              
           oooooooooooooooooooo                      oo ooo oo oooooooooooooooooooooooooooooooooooooooooo               
          oooooooooooooooooo                         ooo           oooooooooooooooooooooooooooooooooo   oo              
            ooooooooooooo                            oooooooooo oo   oooooooooooooooooooooooooooooooooo                 
            oooooo      o                          ooooooooooooooooooo ooooo  ooooooooooooooooooooooooo                 
              oooo  oo                            ooooooooooooooooooooo ooooooo       ooooo  ooooo  o                   
                   oooo                          oooooooooooooooooooooooo oo          oo        oooo                    
                      o  ooooooo                   oooooooooooooooooooooooooo          o          o                     
                         ooooooooooo                        ooooooooooooooo                    o      oo                
                        oooooooooooooooo                    ooooooooooooo                        oo  oo         o       
                        oooooooooooooooooo                    oooooooooo                                         o o    
                          ooooooooooooooo                    oooooooooooo                                   ooo  o      
                             ooooooooooo                     ooooooooo    oo                            ooooooooooo     
                             oooooooo                         oooooooo    o                          ooooooooooooooo    
                             oooooooo                          ooooo                                 ooooooooooooooo    
                             oooooo                                                                           ooo       
                              ooo                                                                                       
                              ooo                                                                                       
";

            world.ToCharArray();

            Console.Clear();

            for (int i = 0; i < world.Length; i++)
            {

                if (world[i] == ' ')
                {
                    Console.Write(world[i]);
                }
                else
                {
                    if (userInput == "random")
                    {
                        Helper.SetRandomColor();
                    }
                    Console.Write(world[i]);
                    Thread.Sleep(5);
                }

            };

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}