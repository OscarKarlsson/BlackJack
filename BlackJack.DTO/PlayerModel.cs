using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DTO
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentCardValue { get; set; }
        public int Cash { get; set; }
    }
}
