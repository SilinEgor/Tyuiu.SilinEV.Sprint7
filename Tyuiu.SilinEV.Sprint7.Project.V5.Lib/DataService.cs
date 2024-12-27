namespace Tyuiu.SilinEV.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public double FindMiddleValue(double[] matrix)
        {
            int count = 0;
            double temp = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                temp += matrix[i];

                count++;
            }

            return Math.Round(temp / count, 2);
        }

        public double FindMaxValue(double[] matrix)
        {
            double max = matrix[0];

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] > max) max = matrix[i];
            }

            return max;
        }

        public double FindMinValue(double[] matrix)
        {
            double min = matrix[0];

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] < min) min = matrix[i];
            }

            return min;
        }

        public double FindSumValue(double[] matrix)
        {
            double sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i];
            }

            return sum;
        }
    }
}
