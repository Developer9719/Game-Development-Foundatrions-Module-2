// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Color orangeColor = new Color(255, 127, 0, 255); // Creates a custom color

            // Window
            Window.SetTitle();
            Window.SetSize(width, height);
            Window.TargetFPS = 60;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.LineColor = orangeColor; // This is how you use your custom color

            // Window
            Window.ClearBackground(Color.OffWhite); // Clears the window each frame

            // Drawing Shape Properties
            Draw.FillColor = Color.Red; // Fills the shape with the predefined red color
            Draw.LineColor = orangeColor; // Draws the lines using the orange custom color
            Draw.LineSize = 5; // Lines will be 5 pixels thick

            // Drawing Shapes
            //      Lines
            //      Circle
            Draw.Circle(centerXposition, centerYPosition, radius);
            //      Rectangle and Square
            Draw.Rectangle(originUpperLeftXPosition, originUpperLeftYPosition, width, height);
            Draw.Square(originUpperLeftXPosition, originUpperLeftYPosition, widthAndHeight);
            //      Triangle
            Draw.Triangle(trianglePoint1XAndY, trianglePoint2XAndY, trianglePoint3XAndY);
            //      Quadrangle
            Draw.Quad(quadPoint1XAndY, quadPoint2XAndY, quadPoint3XAndY, quadPoint4XAndY);

            // Inputs
            //      Mouse
            Input.GetMousePosition();
            Input.GetMouseX();
            Input.GetMouseY();
            //      Keyboard
            Input.IsKeyboardKeyDown(KeyboardInput.Space); // Is true when space key is held down
            Input.IsKeyboardKeyPressed(KeyboardInput.Space); // Is true if the space key is pressed during the current frame only
            Input.IsKeyboardKeyReleased(KeyboardInput.Space); // Is true if the space key is released during the current frame only
            Input.IsKeyboardKeyUp(KeyboardInput.Space); // Is true when the space key is not held down

            // Functions
            /*      - reusable code that completes one action
             *      - take in arguments and returns a result
             *      console.writeLine();
             *      - console is the class
             *      - writeLine is the function
             */
            // Declaring a function
            void functionName(inputArguments)
            {
                // void means it doesnt return a variable
            }
            // Calling a function
            functionName();
        }
    }
}

/* 2D Graphics
 * - 2D Coordinates
 *      - (x,y)
 *      - x is left to right
 *      - y is top to bottom
 *      
 *      - Vectors
 *          - can represent a displacement (going from one position to another on the grid)
 *          - origin point is always (0,0)
 * - Digitial Colors
 * 
 * - API Reference 
 *      - Application Programming Interface
 *      - the documentation a programmer consults to know what code exists and how to use it
 */