using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    /// <summary>
    /// Represents a product for sale.
    /// </summary>
    public class Product
    {
        // constructor that forces name to be passed in 
        //public Product(string n)
        //{
        //    Name = n;
        //}
        /// <summary>
        /// A unique identifier for the product.
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// The user-facing name of the product 
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Manufacturers suggested retail price. 
        /// </summary>
        /// 

        /// <summary>   
        /// The price we are selling said product for.
        /// </summary>    

        public double SalesPrice { get; set; }
        public double MSRP { get; set; }

        /// <summary>
        /// The number of units of said product in stock. 
        /// Quanity is newly added, wasn't previously part of the checklist on GitHub.
        /// Check the GitHub issue for more details.
        /// </summary>
        public int Quantity { get; set; }
    }
}
