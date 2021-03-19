using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyCaloriesIn.Models
{
    [Table("tblItem")]
    public class Item
    {
        
        public int ID { get; set; }
        public string ItemName { get; set; }

        public string ItemSize { get; set; }

        public Item()
        {
                    
        }

    }
}
