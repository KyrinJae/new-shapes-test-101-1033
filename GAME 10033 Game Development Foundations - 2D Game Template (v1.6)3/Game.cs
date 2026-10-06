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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {Window.SetSize(400, 400);
            Window.SetTitle("Mohawk Game 2D");
            
            

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.LightGray);
            Draw.FillColor = Color.Red;
            Draw.Circle(new Vector2(200, 200), 170);
            Draw.FillColor = Color.OffWhite;
            Draw.Circle(new Vector2(200, 200), 150);
            Draw.FillColor = Color.Red;
            Draw.Circle(new Vector2(200, 200), 115);
            Draw.FillColor = Color.Blue;
            Draw.Circle(new Vector2(200, 200), 90);


            Draw.FillColor = Color.Blue;
            Draw.Circle(new Vector2(200, 200), 60);

            Draw.FillColor = Color.White;
            Draw.Triangle(new Vector2(200, 145), new Vector2(186, 181), new Vector2(214, 181));
            Draw.Triangle(new Vector2(252, 183), new Vector2(214, 181), new Vector2(222, 207));
            Draw.Triangle(new Vector2(232, 244), new Vector2(222, 207), new Vector2(200, 223));
            Draw.Triangle(new Vector2(168, 244), new Vector2(200, 223), new Vector2(178, 207));
            Draw.Triangle(new Vector2(148, 183), new Vector2(178, 207), new Vector2(186, 181));

            Draw.Triangle(new Vector2(200, 200), new Vector2(214, 181), new Vector2(222, 207));
            Draw.Triangle(new Vector2(200, 200), new Vector2(222, 207), new Vector2(200, 223));
            Draw.Triangle(new Vector2(200, 200), new Vector2(200, 223), new Vector2(178, 207));
            Draw.Triangle(new Vector2(200, 200), new Vector2(178, 207), new Vector2(186, 181));
            Draw.Triangle(new Vector2(200, 200), new Vector2(186, 181), new Vector2(214, 181));



            Draw.FillColor = Color.Black;
            if (Input.IsKeyboardKeyDown(KeyboardKey.Enter)) Draw.Circle(new Vector2(200, 200), 170);
            Draw.FillColor = Color.Red;
            if (Input.IsKeyboardKeyDown(KeyboardKey.Enter)) Draw.Circle(new Vector2(200, 200), 150);
            Draw.FillColor = Color.OffWhite;
            if (Input.IsKeyboardKeyDown(KeyboardKey.Enter)) Draw.Circle(new Vector2(200, 200), 115);
            Draw.FillColor = Color.Black;
            if (Input.IsKeyboardKeyDown(KeyboardKey.Enter)) Draw.Circle(new Vector2(200, 200), 90);

























































            
            




















        }

        }
    }


