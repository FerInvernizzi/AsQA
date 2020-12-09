using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Answer : Post
    {

        public Answer(string content, int upvotes, int userId) : base(content, upvotes, userId)
        {
        }
    }
}
