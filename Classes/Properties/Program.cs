namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2002, 09, 10));
            Console.WriteLine(person.Age);
        }
    }
}
