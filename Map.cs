using System;
using System.Runtime.InteropServices;
using Raylib_cs;

public class Map
{
    int[,] tileMap = {
        {1, 1, 1, 1, 1},
        {1, 0, 0, 0, 1},
        {1, 0, 1, 0, 1},
        {1, 0, 0, 0, 1},
        {1, 1, 1, 1, 1}
    };

    Texture2D floorTexture;
    Texture2D wallTexture;

    public Map()
    {
        floorTexture = Raylib.LoadTexture("./Resources/grass2.png");
        //wallTexture = Raylib.LoadTexture("./Resources/Zombie2.png");
    }

    public void Draw()
    {
        for (int y = 0; y < tileMap.GetLength(0); y++)
        {
            for (int x = 0; x < tileMap.GetLength(1); x++)
            {
                Rectangle destRect = new Rectangle(x * 50, y * 50, 50, 50);

                if (tileMap[y, x] == 0)
                {
                    Raylib.DrawTexture(floorTexture, (int)destRect.X, (int)destRect.Y, Color.WHITE);
                }
                else if (tileMap[y, x] == 1)
                {
                    Raylib.DrawTexture(wallTexture, (int)destRect.X, (int)destRect.Y, Color.WHITE);
                }
            }
        }
    }
}