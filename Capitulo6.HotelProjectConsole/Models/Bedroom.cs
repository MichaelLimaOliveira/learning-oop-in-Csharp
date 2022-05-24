using Capitulo6.HotelProjectConsole.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.HotelProjectConsole.Models
{
    public class Bedroom
    {
        public int Id { get; protected set; }
        public int Number { get; protected set; }
        public int MaxOccupationCapacity { get; protected set; }
        public decimal DiaryPrice { get; protected set; }
        public bool IsActive { get; protected set; }
        public List<Rent> Rents { get; protected set; }

        public Bedroom(int id, int number, int maxOccupationCapacity, decimal diaryPrice, bool isActive)
        {
            Id = id;
            Number = number;
            MaxOccupationCapacity = maxOccupationCapacity;
            DiaryPrice = diaryPrice;
            IsActive = isActive;
            Rents = new List<Rent>();
        }

        public bool SetActiveStatus(bool active) => IsActive = active;

        public bool IsOccupied() => Rents.Any(r => r.IsActive());

        public void SetDiaryPrice(decimal price) => DiaryPrice = price;

        public void SetMaxOccupationCapacity(int quantity) => MaxOccupationCapacity = quantity;

        public void AddRent(Rent rent)
        {
            if (Rents.Any(e => e.IsActive()))
                throw new Exception("Room is currently occuppied");

            Rents.Add(rent);
        }

        public override string ToString()
        {
            var toString = !IsOccupied() 
                           ? 
                           $"Numero do quarto: {Number}\n" +
                           $"Capacidade do quarto: {MaxOccupationCapacity}\n" +
                           $"Preço da diaria: ${DiaryPrice:F2}\n" +
                           $"Status: {(IsActive ? "Ativo" : "Inativo")}\n" +
                           $"Disponibilidade: {(IsOccupied() ? "Alugado" : "Disponivel")}" 
                           :
                           $"Numero do quarto: {Number}\n" +
                           $"Cliente: {Rents.FirstOrDefault().Customer.Name}\n"
                           ;

            return toString;

        }
    }
}
