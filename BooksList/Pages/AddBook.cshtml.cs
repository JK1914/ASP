using BooksList.Interfaces;
using BooksList.Models;
using BooksList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksList.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly IDbRepository _bookService;
        [BindProperty]
        public Book book { get; set; }
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _bookService.AddBook(book);
            return RedirectToPage("Index");
        }
    }
}
