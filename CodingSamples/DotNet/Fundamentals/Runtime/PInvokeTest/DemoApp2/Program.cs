using System.Runtime.InteropServices;

namespace DemoApp;

class Program
{
    delegate double DepreciationWrapper(int life, int after);

    static void Main(string[] args)
    {
        Console.Write("Original cost: ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Useful life  : ");
        int l = int.Parse(Console.ReadLine());
        nint assetLib = NativeLibrary.Load(args[0]);
        nint depreciationPtr = NativeLibrary.GetExport(assetLib, "depreciation");
        DepreciationWrapper depreciationWpr = Marshal.GetDelegateForFunctionPointer<DepreciationWrapper>(depreciationPtr);
        for(int n = 1; n < l; ++n)
        {
            double d = depreciationWpr.Invoke(l, n);
            Console.WriteLine("{0, -6}{1, 12:0.00}", n, p * (1 - d));
        }
        NativeLibrary.Free(assetLib);
    }
}
