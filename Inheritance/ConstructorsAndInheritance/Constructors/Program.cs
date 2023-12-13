using System.Threading.Channels;

namespace Constructors
{

    class Program
    {
        static void Main(string[] args)
        {

            //Constructor of the BASE CLASS is ALWAYS executed first.
            var car = new Car("XYZ1234"); 
        }
    }

}
