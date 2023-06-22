using System.ComponentModel.DataAnnotations;

namespace asp_net_core_zoomir.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Opisanie { get; set; }
        public string? Img { get; set; }
        public int Cena { get; set; }
        public string? PunctVedache { get; set; }
        public string Nalichie { get; set; }
        public string? Skidka { get; set; }
    }
}
