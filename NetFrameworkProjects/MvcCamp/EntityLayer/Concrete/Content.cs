using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Content /* Icerik */
    {
        [Key]
        public long ContentId { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        
        public DateTime ContentDate { get; set; }

        /* Heading tablosundaki ilişkili oldugu HeadingId değerini almak için tanımlandı. */
        public long HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        /* Writer tablosundaki ilişkili oldugu WriterId değerini almak için tanımlandı. */
        public long? WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}