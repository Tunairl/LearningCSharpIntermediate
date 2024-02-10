namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(1000);
            //sw.Stop();
            Console.WriteLine(sw.Stop());
        }
    }
}