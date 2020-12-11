using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Post
    {
        private int id;
        private string content;
        private int upvotes;
        private int userId;
        private List<User> upvoteUsersId;



        #region Properties

        public List<User> UpvoteUsersId
        {
            get { return upvoteUsersId; }
            set { upvoteUsersId = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public int Upvotes
        {
            get { return upvotes; }
            set { upvotes = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        } 
        #endregion

        public Post(string content, int userId, int id)
        {
            this.content = content;
            this.upvotes = 0;
            this.userId = userId;
            this.id = id;
            this.upvoteUsersId = new List<User>();
        }
    }
}
