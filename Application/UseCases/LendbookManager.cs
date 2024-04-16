using AutoMapper;
using Domain.Repositoryes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO;
using Domain.Entities;

namespace Application.UseCases
{
    public class LendbookManager
    {
        private readonly IClientRepository _clientRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public LendbookManager(IClientRepository clientRepository, IBookRepository bookRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public bool lendBook(int idbook, int idclient)
        {
            var client = _clientRepository.Get(idclient);
            var book = _bookRepository.Get(idbook);

            if (client == null || book == null) return false;

            client.Books.Add(book);
            return true;
        }
    }
}
