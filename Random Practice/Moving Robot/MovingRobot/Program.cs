namespace MovingRobot;

class Program
{
    static void Main(string[] args)
    {
        int [,] random = {
            {0,0,0,0},
            {0,1,0,0},
            {0,1,1,0},
            {0,0,0,0},
            {0,0,1,0}};

        int [,] random1 = {
            {0,0,1},
            {0,0,0},
            {1,0,1}};

        int answer = Solution(random1);

        Console.WriteLine(answer);
        // for (int i = 0; i < random.GetLength(0); i++)
        // {
        //     for (int j = 0; j < random.GetLength(1); j++)
        //     {
        //         Console.Write(random[i, j]);
        //     }
        //     Console.WriteLine();
        // }
    }

    static int Solution(int[,] grid)
    {
        int total_rows = grid.GetLength(0);
        int total_columns = grid.GetLength(1);

        int [,] solution_grid = new int [total_rows, total_columns];

        for (int row = 0; row < total_rows; row++)
        {
            for (int column = 0; column < total_columns; column++)
            {
                // Starting position automatically assigned value of 1 in solution grid
                if (row == 0 && column == 0)
                {
                    solution_grid[row, column] = 1;
                    continue;
                }

                // Pass over obstacles
                if (grid[row, column] == 1)
                {
                    solution_grid[row, column] = 0;
                    continue;
                }

                int unique_paths = 0;

                // check row above current position in solution grid for number of unique paths
                if (row - 1 >= 0)
                {
                    unique_paths += solution_grid[row - 1, column];
                }

                // check column to the left of current position in solution grid for number of unique paths
                if (column - 1 >= 0)
                {
                    unique_paths += solution_grid[row, column - 1];
                }

                solution_grid[row, column] = unique_paths;
            }
        }

        int total_unique_paths = solution_grid[total_rows - 1, total_columns - 1];
        return total_unique_paths;
    }
}
