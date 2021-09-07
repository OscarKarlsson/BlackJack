using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DTO
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public int CurrentValue { get; set; }
        public int Cash { get; set; }
    }
}
