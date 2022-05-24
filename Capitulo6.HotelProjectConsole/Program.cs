// See https://aka.ms/new-console-template for more information
using Capitulo6.HotelProjectConsole.Models;
using Capitulo6.HotelProjectConsole.Repositories;

var bedroomRepository = new BedroomRepository();

bool active = true;

var bedrooms = await bedroomRepository.Get();

var estevao = new Customer(0, "Estevao Alves", "pomrtewrgma@gmail.com");
var alugar = bedrooms.FirstOrDefault(e => !e.IsOccupied());
alugar.AddRent(new Rent(0, alugar, estevao));
while (active)
{
    Print("O que deseja fazer?");
    Print("1: Visualizar quartos");
    Print("2: Visualizar quartos alugados");
    Print("3: Dar baixa no quarto");

    bool correctInput = int.TryParse(Console.ReadLine(), out int option);

    if (!correctInput)
    {
        Console.WriteLine("Opção incorreta!");
        WaitResponse();
        continue;
    }   
    switch (option)
    {
        case 1:
            var availableRooms = bedrooms.Where(e => !e.IsOccupied());
            availableRooms.ToList().ForEach(bedroom =>
            {
                Print(bedroom.ToString());
                Print();
            });
        break;
        case 2:
            var occupiedRooms = bedrooms.Where(e => e.IsOccupied());
            occupiedRooms.ToList().ForEach(bedroom =>
            {
                Print(bedroom.ToString());
                Print();
            });
        break;
        case 3:
            await RoomCheckout();
        break;
    }

    WaitResponse();
}

static void WaitResponse()
{
    PrintInLine("Digite alguma tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

static void Print(string message = null)
{
    Console.WriteLine(message);
}

static void PrintInLine(string message = null)
{
    Console.Write(message);
}

async Task RoomCheckout()
{
    bool processFinished = false;
    while (!processFinished)
    {
        Print("Digite o número do quarto a ser dado baixa:");
        bool correctInput = int.TryParse(Console.ReadLine(), out int roomNumber);

        if(!correctInput)
        {
            Console.WriteLine("Valor incorreto!");
            WaitResponse();
        }

        try
        {
            var bedrooms = await bedroomRepository.GetByRoomNumber(roomNumber);
            bedrooms.Rents.FirstOrDefault(e => e.IsActive())?.EndRent();
            processFinished = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            WaitResponse();
        }
    }
}