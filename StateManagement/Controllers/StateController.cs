using Microsoft.AspNetCore.Mvc;

public class StateController: Controller
{
    public ViewResult First ()
    {
        //statemanagement
        //1.Client Side
        //1.1 Cookies
        var name ="Anjali Neupane";
        Response.Cookies.Append ("user", name);

        return View ();
    }
     //1.2 Query Strings (Query Parameters)
    [HttpGet]
    public ViewResult Second (string name, int age)
    {

        return View();
    }
    [HttpPost]
     public bool Second (string collegeName)
    {
        return true;
    }
}