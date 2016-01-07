using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using CRUD.Objetos;

namespace CRUD.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Predio predio = new Predio();
            predio.RecuperarApartamento("C:\\Users\\DanielSales\\Desktop\\CRUD\\CRUD.Web\\App_Data\\");
            Application["Predio"] = predio;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            Predio predio = (Predio)Application["Predio"];
            predio.SalvarApartamentos("C:\\Users\\DanielSales\\Desktop\\CRUD\\CRUD.Web\\App_Data\\");
        }
    }
}