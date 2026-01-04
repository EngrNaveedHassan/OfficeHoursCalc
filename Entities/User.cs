using System.ComponentModel.DataAnnotations;

namespace OfficeHoursCalc.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    }
}
