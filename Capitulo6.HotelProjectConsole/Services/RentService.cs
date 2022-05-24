using Capitulo6.HotelProjectConsole.Models;
using Capitulo6.HotelProjectConsole.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.HotelProjectConsole.Services
{
    public class RentService : IRepository<Rent, long>
    {
        public RentService()
        {

        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange(IEnumerable<long> id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Rent>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Rent> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void ImprimirNaTela(string mensagem)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Rent entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertRange(IEnumerable<Rent> entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Rent entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRange(IEnumerable<Rent> entity)
        {
            throw new NotImplementedException();
        }
    }
}
