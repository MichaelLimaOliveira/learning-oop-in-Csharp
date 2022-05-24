using Capitulo6.HotelProjectConsole.Models;
using Capitulo6.HotelProjectConsole.Models.Interface;
using Capitulo6.HotelProjectConsole.Repositories.Interfaces;

namespace Capitulo6.HotelProjectConsole.Repositories
{
    public class BedroomRepository : IBedroomRepository
    {
        private readonly IRentRepository rentRepository;

        private List<Bedroom> MockBedrooms { get; set; }

        public BedroomRepository()
        {
            GenerateData();
            this.rentRepository = rentRepository;
        }

        private void GenerateData()
        {
            MockBedrooms = new List<Bedroom>();
            int baseRoomNumber = 100;
            decimal diary = 250.00m;
            bool active = true;
            int maxOccupationCapacity = 4;

            for (int i = 1; i <= 30; i++)
            {
                MockBedrooms.Add(new Bedroom(i, baseRoomNumber, maxOccupationCapacity, diary, active));
                baseRoomNumber++;
                if (baseRoomNumber % 10 == 0)
                {
                    baseRoomNumber = baseRoomNumber + 100 - 10;
                }
            }
        }

        public async Task Delete(long id)
        {
            var bedroomToDelete = MockBedrooms.Where(e => e.Id == id).FirstOrDefault();

            if (bedroomToDelete is null)
            {
                throw new Exception("Bedroom not found!");
            }

            MockBedrooms.Remove(bedroomToDelete);
        }

        public async Task DeleteRange(IEnumerable<long> idList)
        {
            var bedroomsToDelete = MockBedrooms.Where(e => idList.Contains(e.Id)).ToList();

            if (!bedroomsToDelete.Any())
            {
                throw new Exception("Bedrooms not found!");
            }

            bedroomsToDelete.ForEach(e =>
            {
                MockBedrooms.Remove(e);
            });
        }

        public async Task<IEnumerable<Bedroom>> Get()
        {
            return MockBedrooms;
        }

        public async Task<Bedroom> GetById(long id)
        {
            var bedroom = MockBedrooms.FirstOrDefault(e => e.Id == id);

            if (bedroom is null)
            {
                throw new Exception("Bedroom not found!");
            }

            return bedroom;
        }

        public async Task<Bedroom> GetByRoomNumber(int number)
        {
            var bedroom = MockBedrooms.FirstOrDefault(e => e.Number == number);

            if (bedroom is null)
            {
                throw new Exception("Bedroom not found!");
            }

            return bedroom;
        }

        public async Task Insert(Bedroom entity)
        {
            if (entity is null)
            {
                throw new Exception("Cannot insert null Bedroom!");
            }

            MockBedrooms.Add(entity);
        }

        public async Task InsertRange(IEnumerable<Bedroom> entityList)
        {
            if (entityList is null)
            {
                throw new Exception("Cannot insert null Bedrooms!");
            }

            if (!entityList.Any())
            {
                throw new Exception("Cannot insert empty Bedroom List!");
            }

            MockBedrooms.AddRange(entityList);
        }

        public async Task Update(Bedroom entity)
        {
            if (entity is null)
                throw new Exception("Cannot update null Bedroom!");

            var dbBedroom = await GetById(entity.Id);

            dbBedroom.UpdateObject(entity);
        }

        public async Task UpdateRange(IEnumerable<Bedroom> entity)
        {
            if (entity is null)
                throw new Exception("Cannot update null Bedrooms!");

            foreach (var entityItem in entity)
            {
                await Update(entityItem);
            };
        }
    }
}
