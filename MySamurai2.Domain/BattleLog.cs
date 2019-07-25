using System;
using System.Collections.Generic;
using System.Text;

namespace MySamurai2.Domain
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BattleId { get; set; }
        public Battle Battle { get; set; }

        public List<BattleEvent> BattleEvents { get; set; }
    }
}
