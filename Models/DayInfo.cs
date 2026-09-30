using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baitapmvc.Models
{
    [Table("NgayTrongTuan")]
    public class DayInfo
    {
        [Key]
        public int DayNumber { get; set; }

        public string DayName { get; set; } = string.Empty;

        public bool IsWeekend { get; set; }
    }
}