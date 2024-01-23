using System;
using System.Net.Mail;
using Raylib_cs;

//This class represents the main game logic.
class Game
{
    private const int screenWidth = 800;
    private const int screenHeight = 600;

    private Map map;

    //Initializes the game and starts the main game loop.
    public static void Main() 
    {

        Raylib.InitWindow(screenWidth, screenHeight, "Map for plant v zombie");  // Initialize Raylib

        Game game = new Game(); // Create a new game instance

        game.Run(); // Run the game loop


        Raylib.CloseWindow(); // Close the window and free resources
    }

    
    //Runs the main game loop. 
    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            // Update the game state
            // ...
            
            Raylib.BeginDrawing(); // Begin the drawing process

            Raylib.ClearBackground(Color.White);  // Clear the background to white

            map.Draw(); // Draw the map

            
            Raylib.EndDrawing(); // End the drawing process
        }
    }
}
