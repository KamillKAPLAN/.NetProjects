using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Category /* Kategori */
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        /* Heading tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Heading> Headings { get; set; }
    }
}
