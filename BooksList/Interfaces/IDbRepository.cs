using BooksList.Models;

namespace BooksList.Interfaces
{
    public interface IDbRepository
    {
        public List<Book> GetBooks();
        public void AddBook(Book book);
    }
}
