using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Writer /* Yazar */
    {
        [Key]
        public long WriterId { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }

        /* Heading tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Heading> Headings { get; set; }

        /* Content tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Content> Contents { get; set; }
    }
}
