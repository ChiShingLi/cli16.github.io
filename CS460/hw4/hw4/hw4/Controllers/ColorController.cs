using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;

namespace hw4.Controllers
{
    public class ColorController : Controller
    {
        [HttpGet] //when page loads
        public ActionResult ColorChooser()
        {
            // ViewBag.testing = firstColor;

            return View();
        }

        [HttpPost] //when clicked submit
        public ActionResult ColorChooser(string firstColorHex, string secondColorHex)
        {
            //convert to gba then calculates and then convert back to hex
            Color firstColor = ColorTranslator.FromHtml(firstColorHex);
            Color secondColor = ColorTranslator.FromHtml(secondColorHex);



            //ViewBag.testing = ColorTranslator.ToHtml(Color.Red);
            Color resultColorRGB = Color.FromArgb(firstColor.A, 11, 255, 255);

            int resultColorR = 0;
            int resultColorG = 0;
            int resultColorB = 0;

            //color mixing R
            if (firstColor.R + secondColor.R > 255)
            {
                resultColorR = 255;
            }
            else
            {
                resultColorR = firstColor.R + secondColor.R;
            }

            //G
            if (firstColor.G + secondColor.G > 255)
            {
                resultColorG = 255;
            }
            else
            {
                resultColorG = firstColor.G + secondColor.G;
            }

            //G
            if (firstColor.B + secondColor.B > 255)
            {
                resultColorB = 255;
            }
            else
            {
                resultColorG = firstColor.B + secondColor.B;
            }

            resultColorRGB = Color.FromArgb(firstColor.A, resultColorR, resultColorG, resultColorB);

            //convert back to hex
            string resultColorHex = string.Format("{0:X2}{1:X2}{2:X2}", resultColorR, resultColorG, resultColorB);



            ViewBag.firstColor = firstColorHex;
            ViewBag.secondColor = secondColorHex;
            ViewBag.resultColor = "#" + resultColorHex;
            //ViewBag.result = "#"+ colorHex;


            return View();
        }
    }
}

