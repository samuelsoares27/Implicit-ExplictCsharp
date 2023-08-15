

int valueInteger = 10;
//This explict casting is something temporary
double valueDouble = (double)valueInteger;
Console.WriteLine(valueDouble);

// This is implicit casting because the compiler know the double
// have more space to receive the integer, it's automatic
double valueDoubleImplicitCompiler = valueInteger;
Console.WriteLine(valueDoubleImplicitCompiler);

double valueDoubleimplicitFunction = Convert.ToDouble(valueInteger);
Console.WriteLine(valueDoubleimplicitFunction);

