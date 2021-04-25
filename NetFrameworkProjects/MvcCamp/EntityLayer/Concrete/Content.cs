using System;

namespace EntityLayer.Concrete
{
    public class Content /* Icerik */
    {
        public long ContentId { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        /* Heading tablosundaki ilişkili oldugu HeadingId değerini almak için tanımlandı. */
        public long HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
