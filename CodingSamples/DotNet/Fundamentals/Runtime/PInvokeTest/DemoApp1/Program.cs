using System.Runtime.InteropServices;

namespace DemoApp;

//C# allows usage of non-verifiable pointer types only in a statement 
//block marked with unsafe keyword (because CLR cannot ensure safe 
//execution of corresponding IL code) and this keyword is available 
//only in projects which allow unsafe blocks (see DemoApp.csproj)
unsafe class Program
{
    [DllImport("dijkstra", EntryPoint = "gcd")]
    private static extern nint GreatestDivisor(nint first, nint second);

    [DllImport("native/libprimes.so", EntryPoint = "primes_fetch")]
    private static extern void FetchPrimes(ulong start, int count, ulong* selected, delegate*<ulong, bool> selector);

    private static bool IsFavorite(ulong num) => (num - 1) % 4 == 0;

    static void Main(string[] args)
    {
        if(args[0] == "gcd")
        {
            nint m = nint.Parse(args[1]);
            nint n = nint.Parse(args[2]);
            Console.WriteLine("G.C.D = {0}", GreatestDivisor(m, n));
        }
        else if(args[0] == "prime")
        {
            ulong m = ulong.Parse(args[1]);
            if(args.Length < 3)
            {
                FetchPrimes(m, 1, &m, null);
                Console.WriteLine("First prime = {0}", m);
            }
            else
            {
                int n = int.Parse(args[2]);
                ulong[] primes = new ulong[n];
                //a pointer is initialized in a fixed statement block
                //with address of a value enclosed within reference type
                //data on the heap to prevent relocation of this data 
                //during garbage collection
                fixed(ulong* first = &primes[0]) //pinning primes
                {
                    FetchPrimes(m, n, first, &IsFavorite);
                }//unpinning primes 
                Console.WriteLine("Favroite primes");
                foreach(ulong prime in primes)
                    Console.WriteLine(prime);
            }
        }
    }
}
