using System.ComponentModel.DataAnnotations.Schema;

namespace HowManyCaloriesIn.Models
{
	[Table("tblItem")]
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemSize { get; set; }

        public virtual Nutrients Nutrients { get; set; }
    }
}
