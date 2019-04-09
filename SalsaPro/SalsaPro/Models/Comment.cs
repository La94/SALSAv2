using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalsaPro.Models
{
    public class Comment
    {
            public int CommentId { get; set; }
            public DateTime CommentDate { get; set; }
            public string CommentBody { get; set; }
            public bool IsVisibility { get; set; }
            public bool IsAnonymous { get; set; }

            // ForeignKey("User")]
            public virtual User Users { get; set; }

            //ForeignKey("idea")]
            public virtual Idea Ideas { get; set; }
        }
    }