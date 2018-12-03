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


### SelectList ViewBag
//ViewBag. Item is a SelectList 
//viewBag for droplist
//getting data from database
//aka: ViewBag.Item = new SelectList(<database.table>, <"property value">, <"Property name that user sees">)
ViewBag.Item = new SelectList(db.Items, "ID", "ID");
```

## binding
those are the inputs that user input
```
public ActionResult Bid([Bind(Include = "ID,Item,Buyer,Price,Timestamp")] Bid BidObject)
```

```
 [HttpPost]
        public ActionResult Bid([Bind(Include = "ID,Item,Buyer,Price,Timestamp")] Bid BidObject)
        {
            EFdbContext db = new EFdbContext();
            db.Bids.Add(BidObject);
            db.SaveChanges();

            //return a different page or error
            return View("Index");
        }
```


##delete table with foreign & primary key
```
        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //when removing primary key linked with foreign key....
            //need to remove the foreign key first

            //get all the list with the id that contains an primary key
            var bidList = db.Bids.Where(x => x.Item == id)
                .Select(y => y.ID).ToList();

            for (int counter = 0; counter < bidList.Count; counter++)
            {
                //loop thru and remove all FK records
                Bid removeBid = db.Bids.Find(bidList[counter]);
                db.Bids.Remove(removeBid);
                db.SaveChanges();
            }

            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
```

## adding javascript
```
@section PageScripts
{
    <script type="text/javascript" src="~/Scripts/core.js"></script>
}
```
then add render in _layout
```
    @RenderSection("scripts", required: false)
    @*load the PageScripts, but is NOT required to exist.*@
    @RenderSection("PageScripts", required: false)
```

### infinite loop message (API)
```
  db.Configuration.ProxyCreationEnabled = false; //turn it off, to avoid infinite loop error message
            var result = db.Bids.Where(x => x.Item == id) //use Equals for other stuff, == for id
                .OrderByDescending(y => y.Price)//order by price, highest bid first
                .ToList(); //return as a list

            return Json(result, JsonRequestBehavior.AllowGet);
```

## Debugging
```
Debug.WriteLine
```

use in javascript:
```
Console.log()
```


