// Configurar serviços e obter ServiceProvider
using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = DependencyInjection.ConfigureServices();

// Resolver os serviços necessários
var bookManager = serviceProvider.GetRequiredService<BookManager>();
var clientManager = serviceProvider.GetRequiredService<ClientManager>();
var lendBookManager = serviceProvider.GetRequiredService<LendbookManager>();

// Realizar operações utilizando os serviços
clientManager.CreateClient("bruno");

bookManager.CreateBook("teletubies1");
bookManager.CreateBook("teletubies2");
bookManager.CreateBook("teletubies3");

lendBookManager.lendBook(1, 1);
lendBookManager.lendBook(2, 1);
lendBookManager.lendBook(3, 1);

// Obter e exibir os detalhes do cliente e dos livros emprestados
var res = clientManager.GetClient(1);

Console.WriteLine($"{res.Id} | {res.Name}");

foreach (var book in res.Books)
{
    Console.WriteLine(book.Name);
}