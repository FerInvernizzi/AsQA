# AsQA

This is a web app project made for fun and also as some great content for my online portfolio.

This will be a Quota/Yahoo type app where people will be able to ask a question and get x amount of answers from other users.

For this app I'm using:

- C#
- MVC
- Razor
- HTML (.cshtml)
- JavaScript
- CSS
- Bootstrap
- Git
- GitHub
- FileZilla for deployment on my FTP (maravillas.eu/codigo/...)

#### I'm not working with a database for this project, every piece of information will be pre-loaded into a Singleton admin object as lists (users, posts, etc).

## Functions I want to implement into this program (v1.0):

### Design and display:

- [] Display for every view
- [] Overall design pattern and color palette picked

## Color list once picked:

    *
    *
    *

### Domain issues v1.0

- [x] Creation of all the classes needed
  - [x] Admin
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
- [] Login
  - [] Validation
  - [] Actual login

### Main features:

- [] Q & A Display's as articles in main feed
- [] Random question button

#### While Logged In:

- [] Posting a question
- [] Answering questions
- [] Upvoting system
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
