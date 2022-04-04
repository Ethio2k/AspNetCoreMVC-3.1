using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temesgen.BookStore.Repository;
using Temesgen.BookStore.Models;

namespace Temesgen.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public IActionResult GetBookById(int id)
        {
            var data = _bookRepository.GetBookById(id);

            return View();
        }

        public IActionResult SearchBook(string bookName, string authorName)
        {
            var data = _bookRepository.SearchBook(bookName, authorName);
            return View();
        }
    }
}
