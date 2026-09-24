// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using MohawkGame2D;

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

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
            {
                Draw.FillColor = Color.Green;
                Draw.Circle(new Vector2(300, 300), 50);
            }

            /// change circle color to gray when the spacebar is clicked and have it stay blue until the mouse is clicked again, then change it back to red.
            if (Input.IsMouseButtonDown(MouseButton.Left))
            {
                Window.ClearBackground(Color.White);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);




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
