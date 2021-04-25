using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category /* Kategori */
    {
        [Key]
        public long CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        /* Heading tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Heading> Headings { get; set; }
    }
}
