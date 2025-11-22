using System;

namespace Lesson04.集合类
{
    class GameMap
    {
        enum MapElement
        {
            Road,
            Wall,
            Grass,
            Tree,
        }
        int row;
        int col;
        int[,] arr;

        public GameMap(int _row, int _col)
        {
            row = _row;
            col = _col;
            arr = new int[row, col];
        }
        /// <summary>
        /// 初始化地图，四周是墙，其他是路
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || j == 0 || i == row - 1 || j == col - 1)
                    {
                        arr[i, j] = (int)MapElement.Wall;
                    }
                    else
                    {
                        arr[i, j] = (int)MapElement.Road;
                    }
                }
            }
            arr[2, 3] = (int)MapElement.Tree;
            arr[4, 5] = (int)MapElement.Grass;
            arr[6, 7] = (int)MapElement.Grass;
            arr[8, 9] = (int)MapElement.Tree;
            arr[2, 7] = (int)MapElement.Tree;
            arr[5, 3] = (int)MapElement.Grass;
        }
        public void PrintMap() {
            for (int i=0; i<row; i++) {
                for (int j=0; j<col; j++) {
                    switch ((MapElement)arr[i, j]) {
                        case MapElement.Road:
                            Console.Write("  ");
                            break;
                        case MapElement.Wall:
                            Console.Write("██");
                            break;
                        case MapElement.Grass:
                            Console.Write("::");
                            break;
                        case MapElement.Tree:
                            Console.Write("♠♠");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
        




    }
}