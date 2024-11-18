using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.Patterns.Behavioral.HelperClass
{
    public class TicketChange
    {
        public int Amount { get; private set; }
        public int ArtistId { get; private set; }

        public TicketChange(int artistId, int amount)
        {
            ArtistId = artistId;
            Amount = amount;
        }

    }
}
