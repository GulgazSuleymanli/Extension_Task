using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task.Models
{
    internal abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public static double TotalInCome { get; set; }

        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Sell(int num);
        public abstract void ShowInfo();
    }
}
