using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalsaPro.Models
{
    public class IdeaVote
    {

        public int IdeaVoteId { get; set; }
        public string IsLike { get; set; }
        public string Unlike { get; set; }

    }
}