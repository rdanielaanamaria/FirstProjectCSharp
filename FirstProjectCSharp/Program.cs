// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("I am waiting for the debugger");
Console.ReadLine();
Console.WriteLine();*/


/*write 
 * int BoxA;
BoxA = 34;
BoxA = 99;
Console.WriteLine(BoxA);*/


//read int from console
int BoxA;
BoxA = int.Parse(Console.ReadLine());
Console.WriteLine(BoxA);

//double type
double BoxB;
BoxB = double.Parse(Console.ReadLine());
Console.WriteLine(BoxB);


//string type
string BoxC;
BoxC = Console.ReadLine();
Console.WriteLine(BoxB);

// operations
int BoxE, BoxF, BoxG;
BoxE = 34;
BoxF = 4;
BoxG = BoxE + BoxF;
Console.WriteLine(BoxG);


int BoxH, BoxI, BoxJ, BoxK, BoxL;
BoxH = 34;
BoxI = 4;
BoxJ = BoxH - BoxI;
BoxK = BoxH * BoxI;
BoxL = BoxH / BoxI;
Console.WriteLine(BoxJ);
Console.WriteLine(BoxK);
Console.WriteLine(BoxL);