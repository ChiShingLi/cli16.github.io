### Homework 4

### Razer Code

## Post Method(View)
the "FormMethod.Post" is when the form submits, it submit as an POST method
```
@using (Html.BeginForm("ColorChooser", "Color", FormMethod.Post)) {

    @Html.TextBox("firstColorHex", null, htmlAttributes: new
{
    @class = "form-control",
    type = "text"
    })
	
}
```

to use the passed value, do this in controller
```
[HttpPost] //when clicked submit
public ActionResult ColorChooser(string firstColorHex, string secondColorHex) {}
```

##---

Check if the form is POST, if true, do something... (declared in View)
```
If (IsPost) {}
```

### submit using GET method 
to get the value submitted, use QueryString.(in controller)
```
Request.QueryString["miles"];
```


## ActionLink
ActionLink(<text>,<view>,<controller>)
```
<a class="btn btn-default" @Html.ActionLink("Try it out >>", "converter", "Home") </a></p>
``` 

## getCurrentTime
```
        //get timestamp
        public DateTime GetCurrentTime = DateTime.Now;

        public DateTime CurrentTime
        {
            set { GetCurrentTime = value; }
            get { return GetCurrentTime; }

        }
```


### Restore DB
open up SQL server management -> login -> (LocalDb)\MSSQLLocalDB -> from device -> Add -> choose .BAK file -> restore

ON VS.net:
```
choose -> right click on model -> new item -> ADO.NET -> code first from database -> new connection -> data source	 = (LocalDb)\MSSQLLocalDB -> 	next 
```

database uses a data type (DbGeography) for locations that is not installed by default in an MVC app. 
You'll need to use Nuget to add **Microsoft.SqlServer.Types** to your project. 
use nuget type : **Install-Package Microsoft.SqlServer.Types**
In addition you'll need to add these lines to your Global.asax.cs:

```
using System.Data.Entity.SqlServer;
using Microsoft.SqlServer.Types;
```

## include model reference in view:
** make sure to import entity library when using dbContext**
```
using hw6.Models;
using hw6.DAL;
```

include this in the header of the view model, but it's also auto added when you add view in controller
```
@model hw6.Models.Person
```
if it'sa list object use this with **IEnumberable**:
```
@model IEnumerable<hw6.Models.Person>
```




## Debugging
```
Debug.WriteLine
```

use in javascript:
```
Console.log()
```


