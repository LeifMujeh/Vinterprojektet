using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

public class Map
{
    private int[,] tileMap = new int[8, 11] {
        {1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0,},
        {0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
        {0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0},
        {1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1},
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0},
    };


    //Texture2D floorTexture;
    //Texture2D wallTexture;

    public Map()
    {
        // Load textures after Raylib initialization
        //  floorTexture = Raylib.LoadTexture("Resources/grass.png");
        // wallTexture = Raylib.LoadTexture("Resources/Zombie1.png");
        for (var i = 0; i < 100; i++)
        {


        }

    }

    public void Draw()
    {
        //    for (int y = 0; y < tileMap.GetLength(0); y++){
        //for (int x = 0; x < tileMap.GetLength(1); x++){

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 11; col++)
            {
                Rectangle tileRect = new Rectangle(row * 75, col * 75, 75, 75);
                if (this.tileMap[row, col] == 1)
                {
                    Raylib.DrawRectangleRec(tileRect, Color.Black);
                }

                else
                    Raylib.DrawRectangleRec(tileRect, Color.Green);
            }
        }
    }

}
