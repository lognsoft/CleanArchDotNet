using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class ClientEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
        public ICollection<BookEntity> Books { get; set; }

        public ClientEntity(string name)
        {
            Name = name;
        }
    }
}
