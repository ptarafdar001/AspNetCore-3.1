using BookStoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApplication.Repository
{
    public class BookRepository
    {

        // action method for access data from datasource
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SharchBook(string title, string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        // datasource for the model, latar we use any database for datasouce
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Prabir"},
                new BookModel(){Id = 2, Title = "Dot Net Core", Author = "Ayan"},
                new BookModel(){Id = 3, Title = "C#", Author = "Rahul"},
                new BookModel(){Id = 4, Title = "Java", Author = "Imran"},
                new BookModel(){Id = 5, Title = "CP", Author = "Sougata"},
            };
        }
    }
}
