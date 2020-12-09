using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Post
    {
        private static int lastId = 1;
        private int id;

        private string content;
        private int upvotes;
        private int userId;


        #region Properties
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

        public Post(string content, int upvotes, int userId)
        {
            this.content = content;
            this.upvotes = upvotes;
            this.userId = userId;
            this.id = lastId;
            lastId++;
        }
    }
}
