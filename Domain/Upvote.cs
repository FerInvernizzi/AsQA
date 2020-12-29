using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Upvote
    {
        private int postId;
        private int userId;

        #region Properties


        public int PostId
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

        public Upvote(int postId, int userId, string type)
        {
            this.postId = postId;
            this.userId = userId;
        }
    }
}
