using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact /* Iletisim */
    {
        [Key]
        public long ContactId { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactMail { get; set; }

        [StringLength(50)]
        public string ContactSubject { get; set; }

        public string ContactMessage { get; set; }
    }
}