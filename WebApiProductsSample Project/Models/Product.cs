using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProductsSample_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Categorie { get; set; }
        public int  Price { get; set; }

    }
}