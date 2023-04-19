using System.ComponentModel.DataAnnotations;

namespace BooksList.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название книги")]
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Укажите имя автора")]
        [Display(Name = "Автор")]
        public string Author { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
