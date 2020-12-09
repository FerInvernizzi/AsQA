using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Question : Post
    {
        private List<Answer> answers;

        #region Properties

        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        } 
        #endregion

        public Question (List<Answer> answers, string content, int upvotes, int userId) : base(content, upvotes, userId)
        {
            this.answers = answers; 
        }

    }
}
