using System.ComponentModel.DataAnnotations;

namespace PersonInfoApp.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string StageName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int Bust { get; set; }

        [Required]
        public int Waist { get; set; }

        [Required]
        public int Hips { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        public int WorkYears { get; set; }

        [Required]
        public string Talents { get; set; }

        [Required]
        public int CanDrink { get; set; }
        [Required]
        public byte[] Photos { get; set; }
        [Required]
        public byte[] Videos { get; set; }
        [Required]
        public int Sex { get; set; }
    }
}
