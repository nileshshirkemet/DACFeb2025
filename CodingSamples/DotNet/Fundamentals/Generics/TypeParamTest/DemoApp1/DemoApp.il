
//  .NET IL Disassembler.  Version 8.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 9:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 9:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 39 2E 30 01 00 54 0E 14   // ersion=v9.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 08 2E 4E 45 54 20 39 2E 30 )          // Name..NET 9.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {f2105d60-37b5-4dd5-b3a2-febc7c10dbe8}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0x7fc3c273c000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit DemoApp.Program
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 01 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = ( 01 00 00 00 00 ) 
  .method private hidebysig static !!T  Select<T>(int32 index,
                                                  !!T first,
                                                  !!T second) cil managed
  {
    .param type T 
      .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = ( 01 00 02 00 00 ) 
    // Code size       21 (0x15)
    .maxstack  2
    .locals init (bool V_0,
             !!T V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldc.i4.2
    IL_0003:  rem
    IL_0004:  ldc.i4.1
    IL_0005:  ceq
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  brfalse.s  IL_000f

    IL_000b:  ldarg.1
    IL_000c:  stloc.1
    IL_000d:  br.s       IL_0013

    IL_000f:  ldarg.2
    IL_0010:  stloc.1
    IL_0011:  br.s       IL_0013

    IL_0013:  ldloc.1
    IL_0014:  ret
  } // end of method Program::Select

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       126 (0x7e)
    .maxstack  3
    .locals init (bool V_0,
             int32 V_1,
             string V_2,
             float64 V_3,
             valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_4)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldlen
    IL_0003:  ldc.i4.0
    IL_0004:  cgt.un
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_007d

    IL_000a:  nop
    IL_000b:  ldarg.0
    IL_000c:  ldc.i4.0
    IL_000d:  ldelem.ref
    IL_000e:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_0013:  stloc.1
    IL_0014:  ldloc.1
    IL_0015:  ldstr      "Tuesday"
    IL_001a:  ldstr      "Thursday"
    IL_001f:  call       !!0 DemoApp.Program::Select<string>(int32,
                                                             !!0,
                                                             !!0)
    IL_0024:  stloc.2
    IL_0025:  ldstr      "Selected string = "
    IL_002a:  ldloc.2
    IL_002b:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0030:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0035:  nop
    IL_0036:  ldloc.1
    IL_0037:  ldc.r8     23.399999999999999
    IL_0040:  ldc.r8     43.200000000000003
    IL_0049:  call       !!0 DemoApp.Program::Select<float64>(int32,
                                                              !!0,
                                                              !!0)
    IL_004e:  stloc.3
    IL_004f:  ldloca.s   V_4
    IL_0051:  ldc.i4.s   18
    IL_0053:  ldc.i4.1
    IL_0054:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32,
                                                                                                                               int32)
    IL_0059:  ldloca.s   V_4
    IL_005b:  ldstr      "Selected double = "
    IL_0060:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0065:  nop
    IL_0066:  ldloca.s   V_4
    IL_0068:  ldloc.3
    IL_0069:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float64>(!!0)
    IL_006e:  nop
    IL_006f:  ldloca.s   V_4
    IL_0071:  call       instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_0076:  call       void [System.Console]System.Console::WriteLine(string)
    IL_007b:  nop
    IL_007c:  nop
    IL_007d:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class DemoApp.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
