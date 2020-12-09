using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Question : Post
    {
        private static int lastQId = 1;
        private List<Answer> answers;

        #region Properties

        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        } 
        #endregion

        public Question (List<Answer> answers, string content, int userId) : base(content, 0, userId, lastQId)
        {
            this.answers = answers;
            lastQId++;
        }

    }
}
