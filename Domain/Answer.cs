using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Answer : Post
    {
        private static int lastAId = 1;

        public Answer(string content, int userId) : base(content, userId, "a" + lastAId)
        {
            lastAId++;
        }
    }
}
