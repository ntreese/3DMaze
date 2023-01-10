using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRenderer : MonoBehaviour
{
    private int sizeX = 35;
    private int sizeY = 35;
    [SerializeField] private Transform wallPrefab = null;

    int[,] maze;
    
    void Start()
    {
        maze = Generator.GenerateMaze(sizeX, sizeY);

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                var cell = maze[x, y];
                var position = new Vector3(-sizeX / 2 + x, 0, -sizeY / 2 + y);

                // Render wall if cell is set to 1
                if (cell == 1)
                {
                    var wall = Instantiate(wallPrefab, transform) as Transform;
                    wall.position = position;
                    wall.localScale = new Vector3(1, wall.localScale.y, wall.localScale.z);
                }
            }
        }
    }
}
