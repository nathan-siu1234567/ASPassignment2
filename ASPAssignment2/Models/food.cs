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
        public virtual int FoodID { get; set; }
        public virtual string foodImageUrl { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual string shortDescription { get; set;}
        public virtual string Description { get; set; }


    }
}