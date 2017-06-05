using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;
using CRMdemo.Models;


namespace CRMdemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "Users", "Id", "Login", autoCreateTables: true);
            //ImportGoods.getImportedProductList();
            //ImportClient.GetImportedAgentList();
            //ImportUnits.GetAll();
            //CompanyType.BaseInitializeCompanyTypes();


            // Roles.AddUserToRole("sdf", "Admin");
            //if (!Roles.RoleExists("Admin"))
            //    Roles.CreateRole("Admin");
            //if (!Roles.RoleExists("User"))
            //    Roles.CreateRole("User");
            // WebSecurity.CreateUserAndAccount("Admin", "qwerty");
            //  WebSecurity.Logout();
        }
    }
}
