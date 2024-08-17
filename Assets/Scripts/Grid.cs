using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    public int width;
    public int height;
    public TileType[,] tiles;
    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.tiles = new TileType[width, height];
    }
    public static Grid generateTestLevel()
    {
        //Generate Simple Level for Testing
        int width = 20;
        int height = 10;
        Grid lvl = new Grid(width, height);

        for (int x = 0; x < lvl.width; x++)
        {
            for (int y = 0; y < lvl.height; y++)
            {
                lvl.tiles[x, y] = TileType.Grass;
            }
        }

        for (int y = 0; y <= 4; y++)
        {
            lvl.tiles[8, y] = TileType.Rail;
        }
        for (int x = 8; x <= 10; x++)
        {
            lvl.tiles[x, 4] = TileType.Rail;
        }
        for (int y = 4; y < height; y++)
        {
            lvl.tiles[10, y] = TileType.Rail;
        }

        lvl.tiles[16, 8] = TileType.Stone;
        lvl.tiles[3, 3] = TileType.Stone;
        lvl.tiles[18, 4] = TileType.Stone;

        return lvl;
    }
}