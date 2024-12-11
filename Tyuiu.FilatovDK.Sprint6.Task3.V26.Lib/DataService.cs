using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilatovDK.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[2, j] % 2 == 0)
                    {
                        matrix[2, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}