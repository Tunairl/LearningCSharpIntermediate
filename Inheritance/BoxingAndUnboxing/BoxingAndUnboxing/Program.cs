using System.Collections;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing is NOT an ideal operation performance-wise. 
            // Boxing has a performance penalty.

            var list = new ArrayList(); // ArrayList is NOT a TYPE SAFE list.

            list.Add(1); // Boxing happens because of 1 being a value type.
            list.Add("Tuna"); // String is a reference type so Boxing DOESN'T HAPPEN.
            list.Add(DateTime.Today); // Boxing happens because of DateTime being a value type.

            var number = (int)list[1];

            // We can use generic lists instead. They're type safe.
            var anotherList = new List<int>();
            var names = new List<string>(); // Type safety and NO boxing.
            // It's better to use a generic implementation of that class if exists.
        }
    }
}