using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositoryes
{
    public interface IBookRepository
    {
        void Create(BookEntity bookEntity);
        void Update(BookEntity bookEntity);
        void Delete(int id);
        BookEntity Get(int id);
        ICollection<ClientEntity> GetAll();
    }
}
