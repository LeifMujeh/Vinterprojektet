using System;
using Raylib_cs;

public class Game
{
    private Map map;

    public Game()
    {
        this.map = new Map();
    }

    public void Run()
    {
        const int screenWidth = 800;
        const int screenHeight = 600;

        Raylib.InitWindow(screenWidth, screenHeight, "Map for plant v zombie"); // Initialize the window after Raylib initialization

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            map.Draw();

            Raylib.EndDrawing();
        }
    }
}

