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

        #region Constructor 
        private Admin() {
            this.users = LoadUsers();
            this.questions = LoadQuestions();
        }
        #endregion

        #region Pre-Load Methods

        private List<User> LoadUsers()
        {
            List<User> ret = new List<User>();
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
            List<Answer> answers1 = new List<Answer>();
            answers1.Add(CreateAnswer("I think you should try to reboot, once that's done, try n run it", Users[1].Id));
            answers1.Add(CreateAnswer("You should re-install the app, it's a pretty common error", Users[0].Id));
            Question q1 = CreateQuestion(answers1, "¿How do I make Visual Studio work when it closes down by itself?", Users[2].Id);
            q1.Upvotes += 5;
            ret.Add(q1);
            #endregion

            #region Question 2
            List<Answer> answers2 = new List<Answer>();
            answers2.Add(CreateAnswer("I heard lemmon may do the job! GL", Users[3].Id));
            answers2.Add(CreateAnswer("OMG how did u get paint on your trousers lol!!", Users[4].Id));
            answers2.Add(CreateAnswer("You should try gettin a new pair!", Users[2].Id));
            Question q2 = CreateQuestion(answers2, "¿How do I clean paint from a pair of trousers?", Users[1].Id);
            q2.Upvotes += 2;
            ret.Add(q2);
            #endregion

            #region Question 3
            List<Answer> answers3 = new List<Answer>();
            answers3.Add(CreateAnswer("You should get used to jumping or rather falling frequently.", Users[0].Id));
            Question q3 = CreateQuestion(answers3, "¿Any tips for a neewbie goalkeeper?", Users[4].Id);
            q2.Upvotes += 1;
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

        public Question CreateQuestion(List<Answer> answers, string content, int userId)
        {
            Question ret = new Question(answers, content, userId);
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
            Question q = CreateQuestion(answers, content, userId);
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
        public void UpvoteQuestion(int id)
        {
            foreach(Question q in questions)
            {
                if(q.Id == id)
                {
                    q.Upvotes++;
                }
            }
            return;
        }

        public void UpvoteAnswer(int qId, int aId)
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
                        }
                    }
                }
            }
        }
        
        #endregion
    }
}
