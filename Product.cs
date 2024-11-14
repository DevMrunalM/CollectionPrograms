using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPrograms
{
    internal class Product: IComparable<Product>
    {
        private int id {  get; set; }
        private string name { get; set; }
        private double price { get; set; }

        public Product()
        {

        }

       public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"ID: {id}  Name: {name}  Price: {price}";
        }

        public int CompareTo(Product other)
        {
            Product p = (Product)other;
            if(this.price > p.price) 
                return 1 ;
            else if(this.price < p.price)
                return -1 ;
            else
                return 0 ;
        }

    }
}
