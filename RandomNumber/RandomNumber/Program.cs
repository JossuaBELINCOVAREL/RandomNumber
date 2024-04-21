internal class Program
{
    private static void Main(string[] args)
    {
        int j = 0; j++;
        Random rnd = new Random();
        while (true)
        {
            Thread.Sleep(3000);
            Console.WriteLine(rnd.Next(1,100));
        }
    }
}