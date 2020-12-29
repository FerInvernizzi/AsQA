using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Upvote
    {
        private string postId;
        private int userId;

        #region Properties


        public string PostId
        {
            get { return postId; }
            set { postId = value; }
        }


        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        } 
        #endregion

        public Upvote(string postId, int userId)
        {
            this.postId = postId;
            this.userId = userId;
        }
    }
}
