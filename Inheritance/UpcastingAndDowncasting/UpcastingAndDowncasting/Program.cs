using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Casting
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text) shape;
        }
    }
}