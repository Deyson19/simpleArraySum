using simpleArraySum;

public class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Ingresa una cantidad de números \nSeparados por espacio");
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();

        int result = ResultProvider.simpleArraySum(arr);
        Console.WriteLine(result);
    }

}