using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6.HotelProjectConsole.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bedroom> Bedrooms { get; set; }
    }
}
