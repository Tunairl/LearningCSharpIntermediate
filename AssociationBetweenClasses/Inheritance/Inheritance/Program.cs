namespace Inheritance
{
    // Inheritance used for 1. code reuse, 2. polymorphic behavior
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();

        }
    }
}