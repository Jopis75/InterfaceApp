
using InterfaceApp;
using InterfaceApp.Interfaces;

var program1 = new Program1();
var program2 = new Program2();

//program1.Run();
//program2.Go();
program1.Start();
program2.Start();

// Vad är fördelen med interfacet jämfört med hur det var från början?
// Kod som använder sig utav ett interface kan då köras av alla klasser som implementerar interfacet.
//
// Denna metod kan anropas av alla klasser som implementerar interfacet IProgram. 
//
//static void DoStart(IProgram program)
//{
//    program.Start();
//}

program1.Extend();

IRunner1 runner1 = new DoIt();
IRunner2 runner2 = new DoIt();

runner1.Run();
runner2.Run();

Console.ReadLine();
