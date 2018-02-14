using System;

namespace Fisher.Bookstore.Api.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string NotableWork { get; set; }
    }
}