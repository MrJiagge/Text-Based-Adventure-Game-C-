using System;

class Program

{

  static int menu(string options, int currentSquare) {

    Console.WriteLine("Available Moves:");

    foreach(char c in options)
	{
		switch (c) {
			case 'N':
				Console.WriteLine("N: Move North");
				break;
			case 'E':
				Console.WriteLine("E: Move East");
				break;
			case 'S':
				Console.WriteLine("S: Move South");
				break;
			case 'W':
				Console.WriteLine("W: Move West");
				break;
			case 'B':
				Console.WriteLine("B: Open Backpack");
				break;
			case'-':
				// Do nothing for separator
				break;
		}
	
	}

	string choice;
	do {
		Console.WriteLine("Choose your move wisely: ");
		choice = Console.ReadLine().ToUpper().Trim();
	} while (!options.Contains(choice));

	int nextSquare = currentSquare;

	if (choice == "N"){
		nextSquare = currentSquare - 4;
	} else if (choice == "E"){
		nextSquare = currentSquare + 1;
	} else if (choice == "S"){
		nextSquare = currentSquare + 4;
	} else if (choice == "W"){
		nextSquare = currentSquare - 1;
	} else if (choice == "B"){
		Console.WriteLine("You opened your backpack. It's empty for now.");
	}	

	return nextSquare;

  }



  static int Square1()

  {
	int squareNumber = 1;
    string message = "This is square number 1. You are at the entrace of a mysterious castle.\nYou can see huge walls looming over you.";

    Console.WriteLine(message);

    int nextSquare = menu("B-SE", squareNumber);

    return nextSquare;

  }

  static int Square2()

  {
	int squareNumber = 2;

    string message = "This is square number 2. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-ESW", squareNumber);

    return nextSquare;

  }

  static int Square3()

  {
	int squareNumber = 3;

    string message = "This is square number 3. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-ESW", squareNumber);

    return nextSquare;

  }

  static int Square4()

  {
	int squareNumber = 4;

    string message = "This is square number 4. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-SW", squareNumber);

    return nextSquare;

  }

  static int Square5()

  {
	int squareNumber = 5;

    string message = "This is square number 5. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NES", squareNumber);

    return nextSquare;

  }

  static int Square6()

  {
	int squareNumber = 6;

    string message = "This is square number 6. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NESW", squareNumber);

    return nextSquare;

  }

  static int Square7()

  {
	int squareNumber = 7;

    string message = "This is square number 7. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NESW", squareNumber);

    return nextSquare;

  }

  static int Square8()

  {
	int squareNumber = 8;

    string message = "This is square number 8. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NSW", squareNumber);

    return nextSquare;

  }

  static int Square9()

  {
	int squareNumber = 9;

    string message = "This is square number 9. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NES", squareNumber);

    return nextSquare;

  }

  static int Square10()

  {
	int squareNumber = 10;

    string message = "This is square number 10. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NESW", squareNumber);

    return nextSquare;

  }

  static int Square11()

  {
	int squareNumber = 11;

    string message = "This is square number 11. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NESW", squareNumber);

    return nextSquare;

  }

  static int Square12()

  {
	int squareNumber = 12;

    string message = "This is square number 12. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-ESW", squareNumber);

    return nextSquare;

  }

  static int Square13()

  {
	int squareNumber = 	13;

    string message = "This is square number 13. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NE", squareNumber);

    return nextSquare;

  }

  static int Square14()

  {
	int squareNumber = 14;

    string message = "This is square number 14. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NEW",	 squareNumber);

    return nextSquare;

  }

  static int Square15()

  {
	int squareNumber = 15;

    string message = "This is square number 15. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NEW", squareNumber);

    return nextSquare;

  }

  static int Square16()

  {
	int squareNumber = 16;

    string message = "This is square number 16. You are at the entrace of a mysterious castle.";

    Console.WriteLine(message);

    int nextSquare = menu("B-NW", squareNumber);

    return nextSquare;

  }

  static void Main() {

	string[[]] items_in_square_list = new string[16][] {
		new string[] {"Key", "Map"},
		new string[] {"Flashlight"},
		new string[] {},
		new string[] {"Rope"},
		new string[] {"Potion"},
		new string[] {},
		new string[] {"Sword"},
		new string[] {},
		new string[] {"Shield"},
		new string[] {},
		new string[] {"Helmet"},
		new string[] {},
		new string[] {"Boots"},
		new string[] {},
		new string[] {"Gloves"},
		new string[] {}
	};
	
	string[] backpack = new string[10];
















	int nextSquare = Square1();
	while (true)
	{
		switch (nextSquare) {
			case 1:
				nextSquare = Square1();
				break;
			case 2:
				nextSquare = Square2();
				break;
			case 3:
				nextSquare = Square3();
				break;
			case 4:
				nextSquare = Square4();
				break;
			case 5:
				nextSquare = Square5();
				break;
			case 6:
				nextSquare = Square6();
				break;
			case 7:
				nextSquare = Square7();
				break;
			case 8:
				nextSquare = Square8();
				break;
			case 9:
				nextSquare = Square9();
				break;
			case 10:
				nextSquare = Square10();
				break;
			case 11:
				nextSquare = Square11();
				break;
			case 12:
				nextSquare = Square12();
				break;
			case 13:
				nextSquare = Square13();
				break;
			case 14:
				nextSquare = Square14();
				break;
			case 15:
				nextSquare = Square15();
				break;
			case 16:
				nextSquare = Square16();
				break;
		}
	}



  }

}
