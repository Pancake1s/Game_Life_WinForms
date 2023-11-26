using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class GameEngine
    {
        private bool[,] field;
        private readonly int rows;
        private readonly int cols;
        Random random = new Random();

        public GameEngine(int density, int rows, int cols)
        { 
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }
        }
    }
}
