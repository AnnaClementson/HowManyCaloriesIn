using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyCaloriesIn.Models
{
    [Table("tblNutrients")]
    public partial class Nutrients
    {
        [Key]
        public int Id { get; set; }
        public int Calories { get; set; }
        public double Fat { get; set; }
        public double SaturatedFat { get; set; }
        public double Sugars { get; set; }
        public double Salt { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
