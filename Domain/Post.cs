using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Post
    {
        private string id;
        private string content;
        private int userId;
        private List<Upvote> upvotes;



        #region Properties

        public List<Upvote> Upvotes
        {
            get { return upvotes; }
            set { upvotes = value; }
        }


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        } 
        #endregion

        public Post(string content, int userId, string id)
        {
            this.content = content;
            this.userId = userId;
            this.id = id;
            this.upvotes = new List<Upvote>();
        }
    }
}
