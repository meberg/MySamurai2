using System.ComponentModel.DataAnnotations;

namespace MySamurai2.Domain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        [StringLength(1000)]
        public string Summary { get; set; }
        public string Description { get; set; }
    }
}