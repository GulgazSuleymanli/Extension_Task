using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task.Models
{
    internal class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        static int id;

        public Book(string name, double price, string authorName, int pageCount):base(name, price)
        {
            AuthorName = authorName;
            PageCount = pageCount;
            id++;
            Id=id;
        }

        public override void Sell(int num)
        {
            Count -= num;
            TotalInCome += (num*Price);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Author name: {AuthorName}, Price: {Price}, Page count: {PageCount}, Count: {Count}");
        }
    }
}
