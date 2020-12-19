using Codeboxx_Stack_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codeboxx_Stack_Demo.Controllers
{
    public class WierdNameController : Controller
    {
        public ActionResult Index()
        {
            //This will return the view with the same method name in the case 'Index'.
            return View();
        }







        [HttpGet]
        public ActionResult CreateNewPerson()
        {
            //In this method we want to specify the [HttpGet] because lower we want to use the same method name for our post action
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNewPerson(Person person)
        {
            //The view will post the person object in the params so we can use it

            //we can then check if the model is valid
            if (ModelState.IsValid)
            {
                //Do stuff
                //Insert in our database (I will not display how to do this)


                //This will call the method 'Index' in our controller
                return RedirectToAction("Index");
            }


            return View(person);
        }


        [HttpGet]
        public ActionResult TooManyParamsCommingFromAForm()
        {
            return View();
        }


        [HttpPost]
        public ActionResult TooManyParamsCommingFromAForm(string param1, string param2, string param3, string param4, string param5)
        {
            //This is an example on what not to do. Keep in mind, passing parameters is not bad but in this case, i would have used a class to keep the code 
            //clean and readable. These params are all valid params. They will all get a value if the user insert some value in the fields. Params get pass to the
            //method on a post action where the name of the input is given. ex: if i have a view with this input => `<input type="text" name="blobName" />` and
            //i have a method with this param => public ActionResult MethodName(string blobName). the blobName string will have the value of the input field when 
            //the post will be done


            return View();
        }




        public ActionResult SpecifiedReturn()
        {
            //You can also chose to return a specific view. You only need to pass the name of the view in this case 'Index' as a string for parameter
            return View("Index");
        }
    }
}
