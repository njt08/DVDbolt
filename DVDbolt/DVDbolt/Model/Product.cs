using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDbolt.Model
{
    public class Product
    {
        public Product() {   }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }

        public Product(string title, string genre, int price, string type, int length)
        {
            Title = title;
            Genre = genre;
            Price = price;
            Type = type;
            Length = length;
        }

    }
}
