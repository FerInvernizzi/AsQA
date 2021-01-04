# AsQA

This project started: 08/12/2020

This is a web app project made for fun and also as some great content for my online portfolio.

This will be a Quota/Yahoo type app where people will be able to ask a question and get x amount of answers from other users.

For this app I'm using:

- C#
- MVC
- Razor
- HTML (.cshtml)
- JavaScript
- CSS
- Git
- GitHub
- FileZilla for deployment on my FTP (maravillas.eu/codigo/...)

#### I'm not working with a database for this project, every piece of information will be pre-loaded into a Singleton admin object as lists (users, posts, etc).

## Functions I want to implement into this program (v1.0):

### Design and display:

- [] Display for every view
  - [x] Nav
  - [x] Question display
- [x] Overall design pattern and color palette picked

## Color list once picked:

    * rgb(215, 56, 94)
    * rgb(235, 235, 235)

### Domain issues v1.0

- [x] Creation of all the classes needed
  - [x] Admin
    - [x] Pre-Loads
    - [x] Methods for creation
    - [x] Methods for addition
    - [x] Methods for upvoting
  - [x] User
  - [x] abstract Post
    - [x] Question
    - [x] Answer

### User related stuff:

- [x] CreateUser function
  - username
  - password
  - it's given an automatic ID
  - starts in reputation = 0
- [x] Pre-loading some test users
- [x] Login
  - [x] Validation
  - [x] Actual login

### Main features:

- [x] Q & A Display's as articles in main feed

#### While Logged In:

- [] Random question button
- [] Posting a question
- [] Answering questions
- [x] Upvoting system
- [] Faving questions
- [] Profile
- [] Display favorite questions
- [] Selecting the best answer

A breef summary of how I'm doing some of this stuff:

- All pre-loading will be done with pre-load methods in an administrator class (Admin), so every data will be stored in a Singleton instance Admin object.

- User creating validation will be done with the 'onsubmit' method for forms, so I'll be using some JavaScript on those.

- Post will be an abstract class consisting of ID, content, userId and upVotes
  These will then be inherited by:

##### Question : Post

Question having an extra "List<Answer> answers" atribute and being basically the main feature of a post

##### and

##### Answer : Post

- The reputation system will be based around people liking your answers mainly, also upvotes in questions may add reputation as it means it's a useful question.

  - Upvoted question = +1 rep.
  - Upvoted answer = +10 rep.

- The random question button will literally pop-up a random question for the user to answer, EDITABLE: extra reputation may be added if the random question is given an answer and this answer is given an upvote.

  - Upvoted random answer = +15 rep.

- When an answer is selected as the best by the user asking a question, this answer shall be pinned to the top of all answers and have some kind of visual indication hinting it's the most useful answer.

UPDATE (09/12/2020) null user

- I will manage the logged user by creating a "null" user and basing my comprobations around it whenever there's no actual user logged in.

UPDATE (11/12/2020) UpVote class, login and posts ID

I haven't touch the actual code since morning, but a couple
ideas actually popped up:

1. Login

- I need to learn in detail how viewbag actually works, I may
  use a viewbag login boolean in order not to display the nav
  during login process.
  I actually tried to use another layout view (\_LayoutNavless.cshtml), but I now think that might be overcomplicating stuff way too much, needlesly.

- Thinking about the actual login process itself, made me realize it might be better to have loggedUser be the actual user object rather than the ID, so I can easily access the atributes from anywhere.

2. Upvote class

- I pretty much decided to make upvotes their own class so I can store important data such as the user upvoting, the user who's post was upvoted, etc.
  This means the upvote atribute in the post class, will become a List of Upvotes.

3. Posts ID

- I've come to a realization that just asigning auto-generated numbers from 1 on, may be rather confusing while working with posts ID's when upvoting, giving parameters for the existing methods, etc.

Solution:
ID's will now be strings and "q" or "a" will be added to the start of the string so I instantly get to know what type of object it is. The idea sounds useful for the upvoting system and it may make some things easier as the project grows bigger.

ANNOTATION - This last commit will include the \_LayoutNavless.csthml stuff I talked about in the login part, reverts for this won't be made for a completely transparent and honest devlog.

I'm also feeling highly motivated and this project actually has made my mind way more active, trying to find solutions for the problems that show up and making me an overall better programmer by forcing me out of my comfort zone, I'm really enjoying this experience!

UPDATE (12/12/2020) Cache issue

- I just understood some of the problems cache was giving me while trying to edit some of the styles on the webpage. The browser was "cacheing" my recent changes when changing views, so they won't show up.

UPDATE (30/12/2020) Upvote Questions

- Finally I made this system work! It's kind of a messy way of doing it, but it functions correctly so I am sticking to it, for now at least.

Solution:
I used the onClick="" function on the upvote svg so that, when you click it, the ID of the question gets sent to the UpvoteQ JavaScript function via
args, then I implemented an Ajax Post method in order to send that data (question ID and user ID) to my back controller. This decision may sound
weird, but the main reason the Ajax method was used is that I didn't want the page to refresh at all while surfing the index.
This data then is converted into an actual Upvote object using one of the addUpvote methods in the Admin class (still using Singleton, so the variable system) and added to the upvote list of that particular question. You can also REMOVE the upvote and a similar action takes place, in which the upvote is removed from the upvote list, rather than added.
You can login and out and posts you liked while logged in with that account, will appear just as you left them last time you where in.

Pretty proud of myself for pulling this gimmick off, I've been stressing out about this way of handling upvotes for quite a few days by now, but hopefully, progress will speed up a little bit from now on. Still highly motivated, really love seeing this project become bigger and bigger as time goes by.

UPDATE (04/01/2021) Register

- You can finally register a new user. Again, in order not to refresh the whole page every time you try to submit, I made the verification progress in a JS script so that I could show a pop-up whenever sth goes wrong. I used the ViewBag.users in JS by doing this:

let list = @Html.raw(Json.Encode( C# < List >));

Every element becomes an object so it's easy to work with this method.
