### Homework 6: MVC & Existing Database
For this assignment, we were asked to create an interactive MVC search engine application where the search result come from an existing database.

## Files
* [HW6 Code](https://github.com/cli16/cli16.github.io/tree/master/CS460/hw6)
* [CS460 repo](https://github.com/cli16/cli16.github.io/tree/master/CS460)

### Getting Started
For this assignment, we were asked to use only Viusal Studio Community 2017 IDE. I downloaded the IDE by going to [Visual Studio IDE](https://visualstudio.microsoft.com/downloads/) . After I installed Visual Studio, I created my program by choosing the "Web -> ASP.NET Web Application(.NET FrameWork)" option and then I choose the MVC option.
The second tool that we need is to install [LINQPad](https://www.linqpad.net/), which is very helpful for testing out the lamba commands and the existing database. I also installed Microsoft SQL Server Management Studio and use it to restore and further examinate the existing database.

### First Step
The first step is getting the existing database to work on local server. In this step I didn't install any of the SQL servers like the Microsoft SQL Server Express. I just used my computer local server by using this connection string:
```
(LocalDB)\MSSQLLocalDB
```

### getting the database data
After I restored the existing database using the Microsoft SQL Server Management Studio and created my MVC application using the default template. I implement the app to work with the existing database by going to Model->(Right click)-> Add -> New Item -> ADO.NET Entity Data Model -> Code First From database, and add in the above connection string.
After I added the existing database, I added in the code below, to call and extract the data from the database.
```
      public EFWideWorldImportersContext database = new EFWideWorldImportersContext();
```
the code above works great for the first part of the assignment, since we only need to extract data from one table.

### Search function
For the search page and its function, I write a form that take in the user input and send the data to the server using the POST method since I thinkk that hte url is clear to read without the QueryStrings in the url. I then in the HomeCotroller.cs I write the following code:
Search page 's HomeController Code:
```C#

        //default get page
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        //POST method page when user submit something, use the passed in input (clientName)
        [HttpPost]
        public ActionResult Search(string clientName)
        {
            //check if the list is empty, display error if it is
            var clientResultCheck = database.People.Where(person => person.FullName.Contains(clientName)).ToList();
            if (clientResultCheck.Count() == 0)
            {
                ViewBag.resultText = "I'm sorry, your search returned no results.";
            }

            //check & see did user have inputted seomthing or not, by looking at the length of the input variable
            if (clientName.Length > 0 && clientResultCheck.Count() != 0)
            {
                //found atleast one record, client is not empty 
                ViewBag.clientNameIsEmpty = false;

                //set the result text
                ViewBag.resultText = "Names matching your search: " + "\"" + clientName + "\"";

                //query to get check if a record contains clientName in the People table & convert it into a list
                var clientResult = database.People.Where(person => person.FullName.Contains(clientName)).ToList();


                //pass back the result Model into the View
                //use var, since if don't know/easier what type is returning back    
                return View(clientResult);
            }
            return View();
        }

```

Search View Page Code:
```C#
@model IEnumerable<hw6.Models.Person>

@{
    ViewBag.Title = "Search";
}

<h2>Client Search</h2>

<body background="~/Content/Background/world-bg.jpg">
</body>

@*when user submited the query, use POST instead of GET to hide the query show from the user*@
@*using razer code to create the form for inputs *@
@using (Html.BeginForm("Search", "Home", FormMethod.Post))
{
    @*clientName obj to send to server*@
    @Html.TextBox("clientName", null, htmlAttributes: new
{
   @class = "form-control",
   type = "text",
   placeholder = "Search by client name"
   })

    @* submit button to post the inputs to the server *@
    <button type="submit" display="inline-block" class="btn btn-danger">Search</button>
}


@*if method is POSTed(user submitted), and result is empty display no results found ViewBag*@
@if (IsPost && Model == null)
{

    @ViewBag.resultText
}

@*if method is POSTed(user submitted), and clientName is false (aka, is not empty)*@
@if (IsPost && ViewBag.clientNameIsEmpty == false)
{
    @ViewBag.resultText

    //using var for easier data handling & loop thru each object in the result model
    foreach (var personObject in Model)
    {
        <br>
        //@url.Action to return an url instead of HTML tags

        //search buttom with client preferred name
        <a class="btn btn-default" href="@Url.Action("Person", "Home", new { id=personObject.PersonID })">@personObject.FullName (@personObject.PreferredName) </a>
    }

}
```
 
 