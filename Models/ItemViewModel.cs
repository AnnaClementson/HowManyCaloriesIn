using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyCaloriesIn.Models
{
    public class ItemViewModel
    {
        //public IEnumerable<Item> Items { get; set; }
        //public IEnumerable<Nutrients> Nutrients { get; set; }

        public Item  Id { get; set; }
        public Item  ItemName { get; set; }
        public Item  ItemSize { get; set; }
        public Nutrients Calories { get; set; }
        public Nutrients Fat { get; set; }
        public Nutrients SaturatedFat { get; set; }
        public Nutrients Sugars { get; set; }
        public Nutrients Salt { get; set; }
    }
}
