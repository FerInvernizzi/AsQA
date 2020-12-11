using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin
    {
        private static Admin instance;
        private List<User> users;
        private List<Question> questions;
        private User loggedUser;

        #region Properties


        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }


        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public static Admin Instance
        {
            get
            {
                if (instance == null) instance = new Admin();
                return instance;
            }
        }
        #endregion


        public User LoggedUser
        {
            get { return loggedUser; }
            set { loggedUser = value; }
        }


        #region Constructor 
        private Admin() {
            this.users = LoadUsers();
            this.questions = LoadQuestions();
            this.loggedUser = Users[0];
        }
        #endregion

        #region Pre-Load Methods

        private List<User> LoadUsers()
        {
            List<User> ret = new List<User>();
            ret.Add(CreateUser("null", "null"));
            ret.Add(CreateUser("Fernando", "Password1"));
            ret.Add(CreateUser("Natalia", "Nat_nat1805"));
            ret.Add(CreateUser("Hector", "Kung_fu84"));
            ret.Add(CreateUser("William", "WillTheBest00"));
            ret.Add(CreateUser("Franco", "ChorizitoPicado37"));

            return ret;
        }

        private List<Question> LoadQuestions()
        {
            List<Question> ret = new List<Question>();

            #region Question 1
            Question q1 = CreateQuestion("¿How do I make Visual Studio work when it closes down by itself?", Users[2].Id);
            q1.Answers.Add(CreateAnswer("I think you should try to reboot, once that's done, try n run it", Users[1].Id));
            q1.Answers.Add(CreateAnswer("You should re-install the app, it's a pretty common error", Users[4].Id));
            q1.Upvotes += 5;
            ret.Add(q1);
            #endregion

            #region Question 2
            Question q2 = CreateQuestion("¿How do I clean paint from a pair of trousers?", Users[1].Id);
            q2.Answers.Add(CreateAnswer("I heard lemmon may do the job! GL", Users[3].Id));
            q2.Answers.Add(CreateAnswer("OMG how did u get paint on your trousers lol!!", Users[4].Id));
            q2.Answers.Add(CreateAnswer("You should try gettin a new pair!", Users[2].Id));
            q2.Upvotes += 2;
            ret.Add(q2);
            #endregion

            #region Question 3
            Question q3 = CreateQuestion("¿Any tips for a neewbie goalkeeper?", Users[4].Id);
            q3.Answers.Add(CreateAnswer("You should get used to jumping or rather falling frequently.", Users[1].Id));
            q3.Upvotes += 1;
            ret.Add(q3);
            #endregion

            return ret;
        }

        #endregion

        #region Creation Methods

        public User CreateUser(string username, string password)
        {
            User ret = new User(username, password);
            return ret;
        }

        public Question CreateQuestion(string content, int userId)
        {
            Question ret = new Question(content, userId);
            return ret;

        }

        public Answer CreateAnswer(string content, int userId)
        {
            Answer ret = new Answer(content, userId);
            return ret;
        }

        #endregion

        #region 'Adding' Methods

        public void AddUser(string username, string password)
        {
            User u = CreateUser(username, password);
            users.Add(u);
            return;
        }

        public void AddQuestion(string content, int userId)
        {
            List<Answer> answers = new List<Answer>();
            Question q = CreateQuestion(content, userId);
            questions.Add(q);
            return;
        }

        public void AddAnswer(string content, int userId, int qId)
        {
            foreach(Question q in questions)
            {
                if(q.Id == qId)
                {
                    q.Answers.Add(CreateAnswer(content, userId));
                }
            }
            return;
        }
        #endregion

        #region Specific Methods

        public void UpvoteQuestion(int qId, int uId)
        {
            foreach(Question q in questions)
            {
                if(q.Id == qId)
                {
                    q.Upvotes++;
                    foreach (User u in users)
                    {
                        if (u.Id == q.UserId)
                        {
                            u.Reputation++;
                        }
                        if(u.Id == uId)
                        {
                            q.UpvoteUsersId.Add(u);
                        }
                    }
                }
            }
            
            return;
        }

        public void UpvoteAnswer(int qId, int aId, int uId)
        {
            foreach (Question q in questions)
            {
                if (q.Id == qId)
                {
                    foreach(Answer a in q.Answers)
                    {
                        if(a.Id == aId)
                        {
                            a.Upvotes++;
                            foreach (User u in users)
                            {
                                if (u.Id == a.UserId)
                                {
                                    u.Reputation += 10;
                                }
                                if(u.Id == uId)
                                {
                                    a.UpvoteUsersId.Add(u);
                                }
                            }
                        }
                    }
                }
            }
            return;

        }

        public void Login(int id)
        {
            foreach(User u in users)
            {
                if(u.Id == id)
                {
                    Admin.instance.LoggedUser = u;
                    return;
                }
            }
            return;
        }

        public void Logout()
        {
            Admin.Instance.LoggedUser = users[0];
            return;
        }
        
        #endregion
    }
}
