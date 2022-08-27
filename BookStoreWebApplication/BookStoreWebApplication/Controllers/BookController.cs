using BookStoreWebApplication.Models;
using BookStoreWebApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApplication.Controllers
{
    public class BookController : Controller
    {
        // custom action methods

        //public String GetAllBooks()
        //{
        //    return "All Books";
        //}

        //// passing a single parameter in action method
        //// How to call it from browser -> http://localhost:7312/book/getbooks/1
        //public String GetBook(int id)
        //{
        //    return $"Book with id = {id}";
        //}

        //// passing a multiple parameter in action method
        //// How to call it from browser -> http://localhost:7312/book/searchbooks?bookName=JavaBook&authorName=Herbert
        //public String SearchBooks(string bookName, string authorName)
        //{
        //    return $"Book with Name = {bookName} and Author = {authorName}";
        //}

        //  action method for access data from dataSource via models... and adata is travel in forms of model
        private readonly BookRepository _bookRepository = null;

        //constructor
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //public List<BookModel> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}

        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SharchBook(bookName, authorName);
        }

    }
}
