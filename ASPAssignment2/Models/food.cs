using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPAssignment2.Models
{
    
    public class food
    {
        public food()
        {

        }
        public food(int foodID,string Name,double price,string shortDescription,string Description)
        {
            this.FoodID = FoodID;
            this.Name = Name;
            this.Price = Price;
            this.shortDescription = shortDescription;
            this.Description = Description;

        }
        public int FoodID { get; set; }
        public string foodImageUrl { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string shortDescription { get; set;}
        public string Description { get; set; }


    }
}