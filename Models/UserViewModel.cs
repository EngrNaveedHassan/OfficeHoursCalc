using OfficeHoursCalc.Entities;
using System.ComponentModel.DataAnnotations;

namespace OfficeHoursCalc.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    }
}
