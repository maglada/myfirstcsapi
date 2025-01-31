using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Book
{
  public class BookDto
  {
    public int BookId { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public int AuthorId { get; set; }
    public Models.Author Author { get; set; }
  }
}
