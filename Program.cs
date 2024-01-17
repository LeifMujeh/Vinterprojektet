using System;
using System.Net.Mail;
using Raylib_cs;

class Program
{
    const int screenWidth = 800;
    const int screenHeight = 600;


    static void Main()
    {
        Raylib.InitWindow(screenWidth, screenHeight, "Map for plant v zombie");// Initialize Raylib first

        Game game = new Game();
        game.Run();

        Raylib.CloseWindow(); // Close the window and free resources
    }
}

