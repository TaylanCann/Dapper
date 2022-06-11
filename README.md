# Dapper

When developing a project, there are many ways to manage the project's database connections and processes. However, many of these methods are new and slower than the old ones. Therefore, we need to learn these methods well and use the appropriate one.
<br>
<br>
First of all, if newer ones are slower, why do we use them? Because they are more readable, away from clutter. Now let's briefly look at new and old technologies and compare them.
<br> 
<br>
Oldest : Ado.Net 
<br>
Newest : ORM
<br> <br>
<h3> Ado.Net </h3>
<br>
Ado.Net, which stands for "ActiveX Data Objects.NET", was made by Microsoft to act as a bridge between our applications and databases. Adding, deleting, updating and listing operations can be done in the database by writing SQL queries and commands to the application.
<br>
<h3> ORM </h3>
<br>
ORM is a technique that can access the database, make changes to the data and make queries using object-oriented programming languages. The ORM technique, which is a layer between the database and the project, actually serves the SOLID principles by separating the two jobs.
