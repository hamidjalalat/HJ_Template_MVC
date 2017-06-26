using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Web.Security;
using System.Data.Common;

namespace HJ_Template_MVC.App_Code
{
    public class CustomRolesProvider : System.Web.Security.RoleProvider
       
    {
        private DataBaseContext db=new DataBaseContext();
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            //var Roles = db.Users.Where(C => C.Name == "adminadmin").Select(C => C.Roles.Select(current => current.Name));
            //string ro=string.Empty; 
            //foreach (var item in Roles)
            //{
            //    ro += item+",";
            //}
            //var   RolesString = ro.Split(',');
            string[] dd = { "admin" };
            return dd;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}