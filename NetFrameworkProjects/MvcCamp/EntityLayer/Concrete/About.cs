using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About /* Hakkinda */
    {
        [Key]
        public long AboutId { get; set; }

        [StringLength(1000)]
        public string AboutDetail1 { get; set; }

        [StringLength(1000)]
        public string AboutDetail2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}