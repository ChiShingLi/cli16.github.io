using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data;
using System.Data.Entity;
using hw7.DAL;
using hw7.Models;
namespace hw7.Controllers
{
    public class APIController : Controller
    {
        private InfoContext db = new InfoContext();

        //press in the word to translate in to gif  
        //get data from gifhy

        //use "id" to get userinput
        public JsonResult Translate(string id)
        {
            //setup the structure of the api url
            string api_Key = "dBDE5ZszbbqJ5iqpZoFxUKruZpT4mn1w";
            string api_Url = ("https://api.giphy.com/v1/stickers/translate?api_key=" + api_Key + "&s=" + id);

            //get the data from the url
            var jsonData = new WebClient().DownloadString(api_Url);

            //convert the string downloaded into json format
            var jsonSerialize = new System.Web.Script.Serialization.JavaScriptSerializer();
            var testing = jsonSerialize.DeserializeObject(jsonData);

            //--save to database--
            //create an Infos stucture
            Info DatabaseObj = new Info();
            DatabaseObj.WordSearched = id;
            DatabaseObj.currentDate = DateTime.Now;
            DatabaseObj.IpAddress = Request.UserHostAddress;
            DatabaseObj.BrowserAgent = Request.UserAgent;
            db.Infos.Add(DatabaseObj);

            db.SaveChanges();
            

            //return back the json data 
            return Json(testing, JsonRequestBehavior.AllowGet);
        }
    }
}