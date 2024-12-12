using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilatovDK.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double temp_res;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + 1 == 0)
                {
                    temp_res = 0;
                    cnt++;
                }
                else
                {
                    temp_res = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1), 2);
                    res[cnt] = temp_res;
                    cnt++;
                }
            }
            return res;
        }
    }
}