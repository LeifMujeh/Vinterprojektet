using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Raylib");
Raylib.SetTargetFPS(60);




while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    
    Raylib.EndDrawing();
}