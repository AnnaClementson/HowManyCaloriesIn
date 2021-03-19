using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyCaloriesIn.Models
{
    [Table("tblNutrients")]
    public class Nutrients
    {
        public int ID { get; set; }
        public int Item_ID { get; set; }
        public int Calories { get; set; }

        public int Fat { get; set; }

        public int SaturatedFat { get; set; }
        public int Sugars { get; set; }
        public int Salt { get; set; }
    }
}
