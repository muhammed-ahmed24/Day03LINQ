using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03LINQ.Models
{
    public class Book
    {

        //Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
        //A1: In Entity Framework, by convention, a property named "Id" or "<ClassName>Id" is automatically recognized as the primary key of the entity.

        //Q2: Why is "Country" nullable in the database while "Price" is not?
        //A2: The "Country" property is defined as a nullable string (string?) in the Author class, which allows it to be null in the database. In contrast,
        //"Price" is defined as a non-nullable decimal, meaning it must have a value and cannot be null in the database.
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }

    }
}
