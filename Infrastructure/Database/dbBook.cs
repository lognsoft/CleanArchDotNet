using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.Repositoryes;

namespace Infrastructure.Database
{
    public class dbBook : IBookRepository
    {
        private readonly ICollection<BookEntity> _bookEntities;
        private readonly IMapper _mapper;
        private int fakeid;

        public dbBook(IMapper mapper)
        {
            _mapper = mapper;
            _bookEntities = new List<BookEntity>();
        }

        public void Create(BookEntity bookEntity)
        {
            bookEntity.Id = ++fakeid;
            _bookEntities.Add(bookEntity);
        }

        public void Update(BookEntity bookEntity)
        {
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public BookEntity Get(int id)
        {
            var findedBook = _bookEntities.FirstOrDefault(x => x.Id == id);

            if (findedBook == null) return null;

            return findedBook;
        }

        public ICollection<ClientEntity> GetAll()
        {
            return new List<ClientEntity>();
        }
    }
}
