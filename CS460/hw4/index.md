### Homework 4
For this assignment, we were asked to write a MVC application using ASP.net. In this assignment, we are required to use GET and POST methods when creating the color mixer and converter page. 



## Files
* [HW4 Code](https://github.com/cli16/cli16.github.io/tree/master/CS460/hw4)
* [CS460 repo](https://github.com/cli16/cli16.github.io/tree/master/CS460)

### Getting Started
For this assignment, we were asked to use only Viusal Studio Community 2017 IDE. I downloaded the IDE by going to [Visual Studio IDE](https://visualstudio.microsoft.com/downloads/) . After I installed Visual Studio, I created my program by choosing the "Web -> ASP.NET Web Application(.NET FrameWork)" option and then I choose the MVC option.

### Code: Index.cshtml
For the Index.cshtml(index page), I just modified the text and the url for buttons from the default template.
Note that the razer html code the format of is: @Html.AcionLink(<text>, <ViewsName>,<controllersName>) 

```
@{
    ViewBag.Title = "Homework 4 | Home Page";
}

<div class="jumbotron">
    <h1>CS460 Homework 4</h1>
    <p class="lead">Homework 4 is all about learning the basics of GET, POST, Query Strings and MVC.</p>
    
</div>

<div class="row">
    <div class="col-md-6">
        <h2>Mile to Metric Converter</h2>
        <p>
            Want to know how many milemeters there are in 26 miles? This calculator
            is for you. Using query strings to send form data to the server, which performs the calculation
            and returns the answer in the requested page.
        </p>
        <p><a class="btn btn-default" @Html.ActionLink("Try it out >>", "converter", "Home") </a></p>
    </div>
    <div class="col-md-6">
        <h2>Color Chooser</h2>
        <p>Typical online color choosers are way too useful. We wanted something fun and completely useless. This form POST's the data to the server.</p>
        <p><a class="btn btn-default" @Html.ActionLink("Try it out >>", "ColorChooser", "Color") </a></p>
    </div>
</div>
```
