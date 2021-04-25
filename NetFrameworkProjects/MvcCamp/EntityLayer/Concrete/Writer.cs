using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Writer /* Yazar */
    {
        public long WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        /* Heading tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Heading> Headings { get; set; }

        /* Content tablosu ile 1 - n ilişki tanımlama */
        public ICollection<Content> Contents { get; set; }
    }
}
