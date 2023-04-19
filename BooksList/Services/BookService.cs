﻿using BooksList.Data;
using BooksList.Models;

namespace BooksList.Services
{
    public class BookService
    {
        private readonly AppDbContext context;
        public BookService(AppDbContext context)
        {
            this.context = context;
        }
        

        public List<Book> GetBooks()
        {
            var books = context.Book.ToList();
            return books;
        }
    }
}