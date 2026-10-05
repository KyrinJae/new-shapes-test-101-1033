// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using MohawkGame2D;
using Raylib_cs;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {    
         /// <summary>
         ///     Setup runs once before the game loop begins.
         /// </summary>
        public void Setup()
        {Window.SetTitle("Mohawk Game 2D");
            Window.SetSize(600, 600);

            
           
            

            
            


            

            


            

            
            
            
           
            
            
            
            
            
            
            
            
            
               
            {

                // Toggle between Normal and Battle-Damaged/Scratched states using the Space Bar


                {
                    // State 1: Battle-Damaged / Scratched U.S. Agent Shield

                    // Outer black rim
                    Draw.FillColor = Color.Black;
                    Draw.Circle(new Vector2(200, 200), 120);

                    // Outer red ring with damage/scratches
                    Draw.FillColor = Color.Red;
                    Draw.Circle(new Vector2(200, 200), 110);

                    // White ring
                    Draw.FillColor = Color.White;
                    Draw.Circle(new Vector2(200, 200), 85);

                    // Inner black ring (distinctive to U.S. Agent's shield)
                    Draw.FillColor = Color.Black;
                    Draw.Circle(new Vector2(200, 200), 60);

                    // Center blue disc
                    Draw.FillColor = Color.Blue;
                    Draw.Circle(new Vector2(200, 200), 45);

                    // White Star
                    Draw.FillColor = Color.White;
                    Draw.Triangle(new Vector2(200, 168), new Vector2(193, 190), new Vector2(207, 190));
                    Draw.Triangle(new Vector2(225, 191), new Vector2(207, 190), new Vector2(213, 209));
                    Draw.Triangle(new Vector2(214, 230), new Vector2(213, 209), new Vector2(200, 216));
                    Draw.Triangle(new Vector2(186, 230), new Vector2(200, 216), new Vector2(187, 209));
                    Draw.Triangle(new Vector2(175, 191), new Vector2(187, 209), new Vector2(193, 190));
                    Draw.Triangle(new Vector2(200, 200), new Vector2(207, 190), new Vector2(213, 209));
                    Draw.Triangle(new Vector2(200, 200), new Vector2(213, 209), new Vector2(200, 216));
                    Draw.Triangle(new Vector2(200, 200), new Vector2(200, 216), new Vector2(187, 209));
                    Draw.Triangle(new Vector2(200, 200), new Vector2(187, 209), new Vector2(193, 190));
                    Draw.Triangle(new Vector2(200, 200), new Vector2(193, 190), new Vector2(207, 190));

                    // Deep battle scratch marks (dark gouges across the shield)







                }


                }


                {

                {
                        
                        
        }
                
                        
                    
                    {
                        
                        
                    }
                    
                    {
                        
                        
                    }
            
            {
                     
                   
                    
                    ;







                }













            }

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            






    }
}


}


