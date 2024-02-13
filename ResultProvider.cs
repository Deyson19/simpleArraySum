
namespace simpleArraySum
{
    public static class ResultProvider
    {
        /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */
        public static int simpleArraySum(List<int> values)
        {
            int sum = 0;
            foreach (var item in values)
            {
                var counter = item;
                sum += item;
            }
            return sum;
        }
    }
}