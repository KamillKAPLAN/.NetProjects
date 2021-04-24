using System;

namespace EntityLayer.Concrete
{
    public class Heading /* Baslik */
    {
        /* Access Modify : Erişim Belirleyici Turu */
        public long HeadingId { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
    }
}
