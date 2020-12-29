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

        public Question (string content, int userId) : base(content, userId, "q" + lastQId.ToString())
        {
            this.answers = new List<Answer>();
            lastQId++;
        }

    }
}
