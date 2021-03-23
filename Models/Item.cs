using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HowManyCaloriesIn.Models
{
	[Table("Item")]
    public partial class Item
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemSize { get; set; }

        public virtual Nutrients Nutrients { get; set; }
    }
}
