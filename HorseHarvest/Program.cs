using HorseHarvest;

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Ingrese ubicación de los frutos: ");
Console.ResetColor();
string fruitsInput = (Console.ReadLine() ?? string.Empty).Trim();

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Ingrese posición inicial del caballo: ");
Console.ResetColor();
string startInput = (Console.ReadLine() ?? string.Empty).Trim();

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Ingrese los movimientos del caballo: ");
Console.ResetColor();
string movesInput = (Console.ReadLine() ?? string.Empty).Trim();

var board = Board.FromNotation(fruitsInput);
var startingPosition = Position.Parse(startInput);
var knight = new Knight(startingPosition);

string[] moveCodes = movesInput.Split(',', StringSplitOptions.RemoveEmptyEntries);

var simulator = new HarvestSimulator(board, knight);
List<char> collectedFruits = simulator.Harvest(moveCodes);

string result = string.Join(" ", collectedFruits);
Console.Write("Los frutos recogidos son: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(result);
Console.ResetColor();