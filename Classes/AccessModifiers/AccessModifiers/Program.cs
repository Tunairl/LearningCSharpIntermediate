namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(2002, 9, 10));

            Console.WriteLine(person.GetBirthdate());
        }
    }
}