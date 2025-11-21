using System; 

  

class Program 

{ 

  

/* 1  2   3   4 

5  6   7   8 

9  10  11 12 

13 14  15  16 

*/ 

static int menu(string options) { 

Console.WriteLine("Possible Directions:"); 

  

foreach (char c in options) 

{ 

if (c == 'N'){ 

Console.WriteLine("- North"); 

} 

} 

return 0; 

} 

  

  

static void backpack(){} 

  

static int Square1() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("SE"); 

return nextSquare; 

} 

  

static int Square2() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("ESW"); 

return nextSquare; 

} 

  

static int Square3() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("ESW"); 

return nextSquare; 

} 

  

static int Square4() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("SW"); 

return nextSquare; 

} 

  

static int Square5() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NES"); 

return nextSquare; 

} 

  

static int Square6() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NESW"); 

return nextSquare; 

} 

  

static int Square7() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NESW"); 

return nextSquare; 

} 

  

static int Square8() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NSW"); 

return nextSquare; 

} 

  

static int Square9() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NES"); 

return nextSquare; 

} 

  

static int Square10() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NESW"); 

return nextSquare; 

} 

  

static int Square11() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NESW"); 

return nextSquare; 

} 

  

static int Square12() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("ESW"); 

return nextSquare; 

} 

  

static int Square13() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NE"); 

return nextSquare; 

} 

  

static int Square14() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NEW"); 

return nextSquare; 

} 

  

static int Square15() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NEW"); 

return nextSquare; 

} 

static int Square16() 

{ 

string message = "This is square number 1. You are at the entrace of a mysterious castle."; 

Console.WriteLine(message); 

int nextSquare = menu("NW"); 

return nextSquare; 

} 

  

static void Main(){ 

Square1(); 

} 

  

} 

} 