class Program

{

	static int Menu(string options, int currentSquare)
	{

		Console.WriteLine("Available Moves:");

		foreach (char c in options)
		{
			switch (c)
			{
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
				case 'P':
					Console.WriteLine("P: Pick up item");
					break;
				case '-':
					// Do nothing for -
					break;
			}

		}

		string choice;
		do
		{
			Console.WriteLine("Choose your move wisely: ");
			choice = (Console.ReadLine() ?? "").ToUpper().Trim();
		} while (!options.Contains(choice));

		int nextSquare = currentSquare;

		if (choice == "N")
		{
			nextSquare = currentSquare - 4;
		}
		else if (choice == "E")
		{
			nextSquare = currentSquare + 1;
		}
		else if (choice == "S")
		{
			nextSquare = currentSquare + 4;
		}
		else if (choice == "W")
		{
			nextSquare = currentSquare - 1;
		}
		else if (choice == "B")
		{
			// For simplicity, we won't implement actual backpack logic here
			Console.WriteLine("You opened your backpack. It's empty for now.");
		}
		else if (choice == "P")
		{
			// For simplicity, we won't implement actual item pickup logic here
			Console.WriteLine("You picked up an item.");
		}

		return nextSquare;

	}



	static int Square1()

	{
		int squareNumber = 1;
		string message = "Square 1 — Perimeter Gate: You stand by an access gate leading into a covert compound. Floodlights sweep the road and a guard booth sits to the east.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-SE", squareNumber);

		return nextSquare;

	}

	static int Square2()

	{
		int squareNumber = 2;

		string message = "Square 2 — Guard Booth: A concrete post with radios and a tired sentry. Camera feeds point toward the gate and the east corridor.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-ESW", squareNumber);

		return nextSquare;

	}

	static int Square3()

	{
		int squareNumber = 3;

		string message = "Square 3 — Outer Corridor: A dim corridor lined with security doors and motion sensors. Footsteps echo farther east.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-ESW", squareNumber);

		return nextSquare;

	}

	static int Square4()

	{
		int squareNumber = 4;

		string message = "Square 4 — Surveillance Room: A bank of monitors and a technician's console. Feeds from around the base flicker across the screens.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-SW", squareNumber);

		return nextSquare;

	}

	static int Square5()

	{
		int squareNumber = 5;

		string message = "Square 5 — Loading Yard: Cargo crates and a delivery ramp. A service elevator shaft leads down to restricted areas.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NES", squareNumber);

		return nextSquare;

	}

	static int Square6()

	{
		int squareNumber = 6;

		string message = "Square 6 — Briefing Room: A circular table with mission boards and a mounted map of city routes. Coffee stains give it a lived-in look.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NESW", squareNumber);

		return nextSquare;

	}

	static int Square7()

	{
		int squareNumber = 7;

		string message = "Square 7 — Armory Antechamber: Lockers and equipment racks line the walls. A reinforced door to the east leads deeper into the armory.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NESW", squareNumber);

		return nextSquare;

	}

	static int Square8()

	{
		int squareNumber = 8;

		string message = "Square 8 — Armory: Racks of secured weapons and gadgets. A biometric scanner controls access to the storage vault.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NSW", squareNumber);

		return nextSquare;

	}

	static int Square9()

	{
		int squareNumber = 9;

		string message = "Square 9 — Server Corridor: Cool air hums from server racks behind glass. Network cables snake toward the comms room.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NES", squareNumber);

		return nextSquare;

	}

	static int Square10()

	{
		int squareNumber = 10;

		string message = "Square 10 — Communications Hub: Antennas and encryption nodes. A headset waits on the operator's station.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NESW", squareNumber);

		return nextSquare;

	}

	static int Square11()

	{
		int squareNumber = 11;

		string message = "Square 11 — Laboratory Entrance: White tiles and chemical cabinets. Hazard signs warn of experimental equipment.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NESW", squareNumber);

		return nextSquare;

	}

	static int Square12()

	{
		int squareNumber = 12;

		string message = "Square 12 — Research Lab: Workbenches strewn with prototypes and a whiteboard full of formulas and schematics.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-ESW", squareNumber);

		return nextSquare;

	}

	static int Square13()

	{
		int squareNumber = 13;

		string message = "Square 13 — Medical Bay: A compact infirmary with a row of beds and a locked supply cabinet. The air smells of antiseptic.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NE", squareNumber);

		return nextSquare;

	}

	static int Square14()

	{
		int squareNumber = 14;

		string message = "Square 14 — Vault Ante: A security foyer with keypad and retinal scanner. Thick walls muffle distant noise from the core.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NEW", squareNumber);

		return nextSquare;

	}

	static int Square15()

	{
		int squareNumber = 15;

		string message = "Square 15 — Vault Core: The facility's secured vault with an armored safe and evidence lockers. Everything here is under heavy security.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NEW", squareNumber);

		return nextSquare;

	}

	static int Square16()

	{
		int squareNumber = 16;

		string message = "Square 16 — Control Tower: An elevated control platform with a panoramic view of the compound. An emergency exit leads to the roof and a zipline escape.";

		Console.WriteLine(message);

		int nextSquare = Menu("B-P-NW", squareNumber);

		return nextSquare;

	}

	static void Main()
	{

		// each index starts from 0, so square 1 is index 0 and square 16 is index 15
		string[][] items_in_each_square = [
		["Key", "Map"],
		["Flashlight"],
		[],
		["Rope"],
		["Potion"],
		[],
		["Sword"],
		[],
		["Shield"],
		[],
		["Helmet"],
		[],
		["Boots"],
		[],
		["Gloves"],
		[]
	];

		string[] backpack = new string[10];

		int nextSquare = Square1();
		while (true)
		{
			switch (nextSquare)
			{
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
