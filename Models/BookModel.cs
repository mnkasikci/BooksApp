using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }

        public string AuthorFullName => Author.FirstName + " " + Author.LastName;


        private AuthorModel _author = new AuthorModel();

        public AuthorModel Author
        {
            get { return _author; }
            set { _author = value; }
        }

        


    }
}
