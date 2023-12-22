using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC__.NET_6_.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public DateTime CreatedDatetime { get; set; } = DateTime.Now;
       
    }
}
