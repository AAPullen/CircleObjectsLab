using CircleObjectsLab;

string loop;
int circlesCreated = 0;

Console.WriteLine("Welcome to the Circle Tester\n");

do
{
	loop = null;
	double userRadius = 0;
    bool isValidRadius = false;

	while (isValidRadius == false)
	{
		Console.Write("Enter a radius: ");
		try
		{
			userRadius = double.Parse(Console.ReadLine());
			isValidRadius = true;
		}
		catch (Exception)
		{
			Console.WriteLine("\nI'm sorry, that is not a valid input.\n");
		}
	}

	Circle userCircle = new Circle(userRadius);

	double userCircumference = Circle.CalculateCircumference(userCircle);
	string circumferenceString = Circle.CalculateFormattedCircumference(userCircumference);
	Console.WriteLine($"Circumference: {circumferenceString}");

	double userArea = Circle.CalculateArea(userCircle);
	string areaString = Circle.CalculateFormattedArea(userArea);
	Console.WriteLine($"Area: {areaString}");

	while (loop != "y" && loop != "n")
	{
		Console.Write("Continue? (y/n): ");
		loop = Console.ReadLine().ToLower();
		Console.WriteLine();
	}

	circlesCreated++;


} while (loop == "y");

Console.WriteLine($"Goodbye. You created {circlesCreated} Circle object(s).");