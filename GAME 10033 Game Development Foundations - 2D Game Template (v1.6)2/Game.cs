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
            
            Draw.FillColor= Color.Red;
           
            Draw.Circle(new Vector2(300, 300), 250);

            Draw.FillColor = Color.OffWhite;
            Draw.Circle(new Vector2(300, 300), 200);


            Draw.FillColor = Color.Red;

            Draw.Circle(new Vector2(300, 300), 150);


            Draw.FillColor = Color.Blue;

            Draw.Circle(new Vector2(300, 300), 100);
            /// Draw a star in the middle of the circle, have it stay within the bounds of the circle, and have it be white in color.make sure the star is centered in the circle and has five points.
            Draw.FillColor=Color.OffWhite;
            Draw.Triangle(new Vector2(300, 250), new Vector2(275, 325), new Vector2(325, 325));
            /// put triange on the bottom of the other triangle to make it a star, and make sure the second triangle is also white in color and centered in the circle.
            Draw.Triangle(new Vector2(300, 350), new Vector2(275, 275), new Vector2(325, 275));
            /// put triange to the right of the other triangle to make it a star, and make sure the second triangle is also white in color and centered in the circle.
            
            {



            }


            {

                {
                        
                        
        }
                
                        
                    
                    {
                        
                        
                    }
                    
                    {
                        
                        
                    }
            
            {
                    ///change color of outer color when input key is pressed
                    Draw.FillColor = Color.OffWhite;
                    Input.IsKeyboardKeyPressed(KeyboardKey.Space);



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
