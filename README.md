Assignment: CRUD API
Description
Task is to implement simple CRUD API using SQL Server database.
Technical requirements
------------------------------------------------------------------------------------------------------------------
 Task can be implemented .net core or latest .net framework
 Prefer asynchronous API whenever possible
 Upload your code to GitHub, GitLab, BitBucket with full commit history
 Requirements 1-6 are mandatory
 Complete Requirements 7-11 for bonus points
 Users are stored as objects that have following properties:
o id - unique identifier (string, uuid) generated on server side
o username - user&#39;s name (string, required)
o password – alphanumeric (string, required)
o isAdmin – to identify whether the user is Admin or normal user (bool default
false)
o age - user&#39;s age (number, required)
o hobbies — user&#39;s hobbies (array of strings or empty array, required)
 Errors on the server side that occur during the processing of a request should be handled
and processed correctly (server should answer with status code 500 and corresponding
human-friendly message)
----------------------------------------------------------------------------------------------------------------------
Implementation details
1. POST is used to login user
a. JWT Token for authentication
b. All endpoints except login must be authorized
2. GET is used to get all persons (Access only for Admin User)
a. Server should answer with status code 200 and all users records
3. GET single user
a. Server should answer with status code 200 and record with id === userId if
it exists
b. Server should answer with status code 400 and corresponding message if
userId is invalid (not uuid)
c. Server should answer with status code 404 and corresponding message if
record with id === userId doesn&#39;t exist

4. POST is used to create record about new user (Access only for Admin Users)
a. Server should answer with status code 201 and newly created record
b. Server should answer with status code 400 and corresponding message if
request body does not contain required fields

5. PUT is used to update existing users
a. Server should answer with status code 200 and updated record
b. Server should answer with status code 400 and corresponding message if
userId is invalid (not uuid)
c. Server should answer with status code 404 and corresponding message if
record with id === userId doesn&#39;t exist
d. If the logged-in user is an admin, they can update any user data. However, if the
logged-in user is a non-admin, they cannot change other users&#39; data.
6. DELETE is used to delete existing user from database (Access only for Admin Users)
a. Server should answer with status code 204 if the record is found and deleted
b. Server should answer with status code 400 and corresponding message if
userId is invalid (not uuid)
c. Server should answer with status code 404 and corresponding message if
record with id === userId doesn&#39;t exist
-----------------------------------------------------------------------------------------------------------------------------

POSTMAN
GET - https://localhost:7082/users with 200 ok status.
-----------------------------------------------------------------------------------------------------------------------------
