using BooksList.Interfaces;
using BooksList.Models;
using BooksList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDbRepository _bookService;
        public List<Book> booksList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, BookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public IActionResult OnGet()
        {
            booksList = _bookService.GetBooks();
            return Page();

        }
    }
}