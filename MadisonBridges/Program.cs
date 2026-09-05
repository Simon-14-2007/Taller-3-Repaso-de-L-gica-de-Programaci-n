using MadisonBridges;

var validator = new BridgeValidator();

PrintHeader();

while (true)
{
    Console.WriteLine(new string('-', 40));

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write("Ingrese el puente: ");
    Console.ResetColor();

    string? input = Console.ReadLine();

    input = input?.Trim() ?? string.Empty;

    if (string.IsNullOrEmpty(input))
    break;;

    var bridge = new Bridge(input);
    bool isValid = validator.IsValid(bridge);

    PrintResult(isValid);
}

Console.WriteLine(new string('-', 40));
Console.WriteLine("Programa finalizado.");

void PrintHeader()
{
    Console.WriteLine(new string('=', 40));
    Console.WriteLine("   VALIDADOR DE PUENTES DE MADISON");
    Console.WriteLine(new string('=', 40));
}

void PrintResult(bool isValid)
{
    Console.ForegroundColor = isValid ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine($"Resultado: {(isValid ? "VALIDO" : "INVALIDO")}");
    Console.ResetColor();
}