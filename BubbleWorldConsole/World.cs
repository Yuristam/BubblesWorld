namespace BubbleWorldConsole;

public class World
{
    public static void DrawWorld()
    {
        Console.Clear();

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
        
        for (int i = 0; i < world.Length; i++)
        {
         
            if (world[i] == ' ')
            {
                Console.Write(world[i]);
            }
            else
            {
                Helper.SetRandomColor();
                Console.Write(world[i]);
                Thread.Sleep(5);
            }

        };

        Console.ResetColor();
        Console.ReadKey();
    }
}
