import java.lang.foreign.FunctionDescriptor;
import java.lang.foreign.Linker;
import java.lang.foreign.SymbolLookup;
import java.lang.foreign.ValueLayout;
import java.lang.invoke.MethodHandle;
import java.util.Scanner;

class Program {

    public static void main(String[] args) throws Throwable {
        Scanner input = new Scanner(System.in);
        System.out.print("Original Price: ");
        double p = input.nextDouble();
        System.out.print("Useful Life   : ");
        int l = input.nextInt();
        //looks up for the platform specific library file corresponding
        //to the specified name in each location assigned to java.library.path
        //property of JVM
        System.loadLibrary(args[0]);
        //downcallHandle is a restricted method and can only be called
        //if --enable-native-access=ALL-UNNAMED option is passed to JVM
        MethodHandle depreciationHandle = Linker.nativeLinker().downcallHandle(
            SymbolLookup.loaderLookup().find("depreciation").get(), 
            FunctionDescriptor.of(ValueLayout.JAVA_DOUBLE, ValueLayout.JAVA_INT, ValueLayout.JAVA_INT)
        );
        for(int n = 1; n < l; ++n){
            double d = (double)depreciationHandle.invokeExact(l, n);
            System.out.printf("%-6d%12.2f%n", n, p * (1 - d));
        }
        input.close();
    }
}