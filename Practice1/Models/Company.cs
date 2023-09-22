using System.ComponentModel.DataAnnotations;

namespace Practice1.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }
        public DateTime DateFounded { get; set; }

        public  int CompanyPhoneNum { get; set; }

    }
}
