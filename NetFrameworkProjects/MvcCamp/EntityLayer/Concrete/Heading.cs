using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Heading /* Baslik */
    {
        /* Access Modify : Erişim Belirleyici Turu */
        [Key]
        public long HeadingId { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        
        public DateTime HeadingDate { get; set; }

        /* Category tablosundaki ilişkili oldugu CategoryId değerini almak için tanımlandı. */
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        /* Writer tablosundaki ilişkili oldugu WriterId değerini almak için tanımlandı. */
        public long WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        /* Content tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Content> Contents { get; set; }
    }
}