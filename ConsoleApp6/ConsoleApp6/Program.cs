using System;

namespace ConsoleApp6
{

    class Program
    {
        static void Main(string[] args)
        {

            int main()
            {
                double alpha, z1, z2, pi = 3.14;
                cout << endl << "Vvedite alpha" << endl;
                cin >> alpha;
                z1 = sin(pi / 2 + 3 * alpha) / 1 - sin(3 * alpha - pi);
                z2 = 1 / tan(5 / 4 * pi + 3 / 2 * alpha);
                cout << " z1: " << z1 << ", z2: " << z2 << endl;
                return 0;
            }
        }
    }
}
