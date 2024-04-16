using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositoryes;

namespace Application.UseCases
{
    public class BookManager
    {
        private readonly IBookRepository _bookrepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookrepository = bookRepository;
        }

        public void CreateBook(string name)
        {
            _bookrepository.Create(new BookEntity(name, true));
        }
    }
}
