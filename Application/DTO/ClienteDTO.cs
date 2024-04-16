using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookEntity> Books { get; set; }
    }
}
