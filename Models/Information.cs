using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Information
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Forename { get; set; }
        [Required(ErrorMessage = "Select a gender")]
        public string Gender { get; set; }
        [MinLength(5)]
        public string Address { get; set; }
        public string Town { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression("\\d{5}")]
        public int ZipCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        public string Training { get; set; }
        public string? CobolRev { get; set; }
        public string? TrainRev { get; set; }
    }
}
