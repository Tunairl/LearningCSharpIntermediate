namespace Indexers
{

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Tuna";
            Console.WriteLine(cookie["name"]);
        }
    }
}