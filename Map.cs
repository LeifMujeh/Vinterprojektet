using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


// This class represents the game map.

public class Map
{
   
    // The map data, represented as a two-dimensional array of integers.
    private int[,] tileMap = new int[11, 11]
    {
        { 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0 }, // Map data for the first row
        { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
        { 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
        { 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
        { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
        { 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0 },
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
        { 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0 }
    };

    
    // Draws the map to the screen.
    public void Draw()
    {
        // Iterate over each tile in the map
        for (int row = 0; row < tileMap.GetLength(0); row++)
        {
            for (int col = 0; col < tileMap.GetLength(1); col++)
            {
                Rectangle tileRect = new Rectangle(col * 75, row * 75, 75, 75); // Create a rectangle for the current tile

                // Draw the tile based on its value
                if (tileMap[row, col] == 1)
                {
                    Raylib.DrawRectangleRec(tileRect, Color.DarkGreen); // Draw a dark green tile
                }
                else
                {
                    Raylib.DrawRectangleRec(tileRect, Color.Green); // Draw a green tile
                }
            }
        }
    }
}
