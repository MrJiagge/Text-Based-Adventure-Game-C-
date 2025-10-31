using System;

class Program
{
	// all possible directions
	const string NORTH = "North";
	const string SOUTH = "South";
	const string EAST = "East";
	const string WEST = "West";

	// each function returns what the user sees in the square
	static string Square1()
	{
		string message = "This is square number 1. You are at the entrace of a mysterious castle.";
		return message;
	}

	static string Square2()
	{
		string message = "This is square number 2. You are in a dark room with spooky portraits hanging on the walls.";
		return message;
	}

	static string Square3()
	{
		string message = "This is square number 3. You find yourself approaching a spiral staircase";
		return message;
	}

	static string Square4()
	{
		string message = "This is square number 4. You enter a grand room filled with ancient artifacts.";
		return message;
	}

	static string Square5()
	{
		string message = "This is square number 5. You have reached the castle's tower with a breathtaking yet eerie view.";
		return message;
	}

	static string Square6()
	{
		string message = "This is square number 6. You are in the castle's dungeon, surrounded by cold stone walls.";
		return message;
	}

	static string Square7()
	{
		string message = "This is square number 7. You find yourself in a lavish dining hall with a long table set for a feast.";
		return message;
	}

	static string Square8()
	{
		string message = "This is square number 8. You are in a quiet library filled with dusty old books.";
		return message;
	}

	static string Square9()
	{
		string message = "This is square number 9. You have entered a secret garden with overgrown plants and a mysterious fountain.";
		return message;
	}



	/* 
	Grid:
		1 2 3
		4 5 6
		7 8 9
	*/

	// any square not on the top row has a value greater than 3 therefore they can move north
	// returns true if north is possible
	static bool CanMoveNorth(int position)
	{
		return position > 3;
	}

	// any square NOT on the bottom row has a value less than 7 therefore they can move south
	// returns true if south is possible
	static bool CanMoveSouth(int position)
	{
		return position < 7;
	}

	// squares NOT on the right column have a non-zero remainder when divided by 3 therefore they can move east
	// returns true if east is possible
	static bool CanMoveEast(int position)
	{
		return position % 3 != 0;
	}

	// squares NOT on the left column have a remainder of 2 or 0 when divided by 3 therfore they can move west
	// returns true if west is possible
	static bool CanMoveWest(int position)
	{
		return position % 3 != 1;
	}

	// updating the current position and returning its new value after moving
	static int CalculateNewPosition(int currentPosition, string direction)
	{
		if (direction == NORTH || direction == "N") return currentPosition - 3;
		if (direction == SOUTH || direction == "S") return currentPosition + 3;
		if (direction == EAST || direction == "E") return currentPosition + 1;
		if (direction == WEST || direction == "W") return currentPosition - 1;
		return currentPosition;
	}

	// output menu
	static void DisplayAvailableMoves(int position)
	{
		Console.WriteLine("\nAvailable moves:");
		if (CanMoveNorth(position)) Console.WriteLine($"- {NORTH}");
		if (CanMoveSouth(position)) Console.WriteLine($"- {SOUTH}");
		if (CanMoveEast(position)) Console.WriteLine($"- {EAST}");
		if (CanMoveWest(position)) Console.WriteLine($"- {WEST}");
	}

	// returns true if the move is valid based on current position
	static bool IsValidMove(string move, int position)
	{
		return move switch
		{
			_ when move == NORTH || move == "N" => CanMoveNorth(position),
			_ when move == SOUTH || move == "S" => CanMoveSouth(position),
			_ when move == EAST || move == "E" => CanMoveEast(position),
			_ when move == WEST || move == "W" => CanMoveWest(position),
			_ => false
		};
	}

	// returns the description of the current square
	static string GetSquareDescription(int position)
	{
		return position switch
		{
			1 => Square1(),
			2 => Square2(),
			3 => Square3(),
			4 => Square4(),
			5 => Square5(),
			6 => Square6(),
			7 => Square7(),
			8 => Square8(),
			9 => Square9(),
			_ => "Invalid position"
		};
	}

	// returns player input or empty string if no input
	static string GetPlayerMove()
	{
		Console.Write("\nWhat is your move? (or press 'Enter' to stay where you are): ");
		return Console.ReadLine()?.Trim().ToUpper() ?? "";
	}

	static void Main()
	{
		// starting at square 1 (top left)
		int currentPosition = 1;

		while (true)
		{
			// output current square environment
			Console.WriteLine("\n" + GetSquareDescription(currentPosition));

			DisplayAvailableMoves(currentPosition);

			string move = GetPlayerMove();

			// if user didnt move
			if (string.IsNullOrEmpty(move))
			{
				Console.WriteLine("\nYou chose not to move, you are still in the same square...");
				break; // change to continue later
			}

			if (IsValidMove(move, currentPosition))
			{
				currentPosition = CalculateNewPosition(currentPosition, move);
			}
			else
			{
				Console.WriteLine("\nInvalid move. Please try again.");
			}
		}
	}
}
