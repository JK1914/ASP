using BooksList.Models;
using BooksList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksList.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly BookService _bookService;
        public AddBookModel(BookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(Book book)
        {
            _bookService.AddBook(book);
            return RedirectToPage("Index");
        }
    }
}
