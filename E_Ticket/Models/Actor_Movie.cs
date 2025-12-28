using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticket.Models;

namespace E_Ticket.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
