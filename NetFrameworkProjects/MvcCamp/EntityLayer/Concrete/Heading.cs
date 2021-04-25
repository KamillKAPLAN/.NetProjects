using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Heading /* Baslik */
    {
        /* Access Modify : Erişim Belirleyici Turu */
        public long HeadingId { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        /* Category tablosundaki ilişkili oldugu CategoryId değerini almak için tanımlandı. */
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        /* Content tablosu ile 1 -n ilişki tanımlama */
        public ICollection<Content> Contents { get; set; }
    }
}
