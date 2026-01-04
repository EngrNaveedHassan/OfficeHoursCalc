using System.ComponentModel.DataAnnotations;

namespace OfficeHoursCalc.Entities
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateOnly DateOnly { get; set; }
        [Required]
        public string Day { get; set; } = string.Empty ;
        [Required]
        public TimeOnly CheckIn { get; set; }
        [Required]
        public TimeOnly CheckOut { get; set; }
        [Required]
        public TimeOnly TotalTime { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
