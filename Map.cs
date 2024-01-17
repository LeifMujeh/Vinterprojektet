using System;
using System.Runtime.InteropServices;
using Raylib_cs;

public class Map
{
 int[,] tileMap = {
  {1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
  {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
  {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
  {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
  {0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0},
  {1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
  {0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
};


    //Texture2D floorTexture;
    //Texture2D wallTexture;

    public Map()
    {
        // Load textures after Raylib initialization
        //  floorTexture = Raylib.LoadTexture("Resources/grass.png");
        // wallTexture = Raylib.LoadTexture("Resources/Zombie1.png");
    }

    public void Draw()
    {
        for (int y = 0; y < tileMap.GetLength(0); y++)
{
    for (int x = 0; x < tileMap.GetLength(1); x++)
    {
        Rectangle tileRect = new Rectangle(x * 75, y * 75, 75, 75); // Adjust tile size to 70x70 to fit screen ratio

        if (tileMap[y, x] == 0)
        {
            Raylib.DrawRectangleRec(tileRect, Color.GREEN);
        }
        else if (tileMap[y, x] == 1)
        {
            Raylib.DrawRectangleRec(tileRect, Color.LIME);
        }
        }

    }
}
}
