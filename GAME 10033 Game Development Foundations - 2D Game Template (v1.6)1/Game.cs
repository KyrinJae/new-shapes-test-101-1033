// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Draw 
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Mohawk Game 2D");
            Window.ClearBackground(Color.White);
           Draw.FillColor= Color.Red;
            Draw.Circle(200, 200, 100);
            Draw.FillColor = Color.Blue;
            Draw.Circle(200, 200, 50);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }

}
