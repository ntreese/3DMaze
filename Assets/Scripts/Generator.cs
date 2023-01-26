using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Aldous-Broder C# implementation. 
 * Code based on Prof. Dr. Mathias Lux JavaScript implementation
 * Original Sourcecode : https://github.com/dermotte/AdvancedTopicsCG-WS2022/blob/master/PCG/04%20Mazes/03%20Aldous-Broder%20Algorithm/sketch.js
 */
public static class Generator
{
    private static int[,] maze = null;

    struct Cell
    {
        public int x, y;
    }

    public static int[,] GenerateMaze(int sizeX, int sizeY)
    {
        int visited = 0;
        int steps = 100000;
        
        maze = new int[sizeX * 2 - 1, sizeY * 2 - 1];

        for (int i = 0; i < sizeX * 2 - 1; i++)
        {
            for (int j = 0; j < sizeY * 2 - 1; j++)
            {
                maze[i, j] = 1;
            }
        }

        Cell cell;
        cell.x = 0;
        cell.y = 0;

        maze[cell.x, cell.y] = 0;

        while( (visited < sizeX * sizeY) && (--steps > 0) )
        {
            //Random neighbor
            List <Cell> neighbors = new List<Cell>();
            int count = 0;

            if (cell.x + 2 < sizeX * 2 - 1)
            {
                Cell n1;
                n1.x = cell.x + 2;
                n1.y = cell.y;
                neighbors.Add(n1);
                count++;
            }
            if (cell.y + 2 < sizeY * 2 - 1)
            {
                Cell n1;
                n1.x = cell.x;
                n1.y = cell.y + 2;
                neighbors.Add(n1);
                count++;
            }
            if (cell.x > 0)
            {
                Cell n1;
                n1.x = cell.x - 2;
                n1.y = cell.y;
                neighbors.Add(n1);
                count++;
            }
            if (cell.y > 0)
            {
                Cell n1;
                n1.x = cell.x;
                n1.y = cell.y - 2;
                neighbors.Add(n1);
                count++;
            }
            //Debug.Log("Count " + count);
            int v = (int)Mathf.Floor(Random.Range(0, count));
            Cell n = neighbors[v];
            //Debug.Log("Nx " + n.x);
            //Debug.Log("Ny " + n.y);

            if (maze[n.x, n.y] == 1)
            {
                maze[n.x, n.y] = 0;
                maze[(n.x + cell.x) / 2, (n.y + cell.y) / 2] = 0;

                visited++;
            }

            cell = n;
        }


        for (int i = 1; i < sizeX * 2 - 1; i += 2)
        {
            for (int j = 1; j < sizeY * 2 - 1; j += 2)
            {
                maze[i, j] = 1;
                int count = 0;
                List <Cell> neighbors = new List<Cell>();

                if(maze[i, j-1] == 1){
                    Cell n1;
                    n1.x = i;
                    n1.y = j-1;
                    neighbors.Add(n1);
                    count ++;
                }
                if(maze[i -1, j] == 1){
                    Cell n1;
                    n1.x = i - 1;
                    n1.y = j;
                    neighbors.Add(n1);
                    count ++;
                }
                if(maze[i, j+1] == 1){
                    Cell n1;
                    n1.x = i;
                    n1.y = j+1;
                    neighbors.Add(n1);
                    count ++;
                }
                if(maze[i+1, j] == 1){
                    Cell n1;
                    n1.x = i+1;
                    n1.y = j;
                    neighbors.Add(n1);
                    count ++;
                }

                if (count > 2) {
                    int v = (int)Mathf.Floor(Random.Range(0, count));
                    Cell n = neighbors[v];
                    maze[n.x, n.y] = 0;
                }

            }
        }

        
        
        //Debug.Log(maze[0,0]);
        //Debug.Log(maze[5, 5]);
        return maze;
    }
}
