using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2007_s2016_Lesson2C_Part2
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addActiveClass();
        }

        /*
         * This method adds clas of "active" to list items in the navbar.
         */
        private void addActiveClass()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;

                case "Products":
                    products.Attributes.Add("class", "active");
                    break;

                case "Services":
                    services.Attributes.Add("class", "active");
                    break;

                case "About Us":
                    about.Attributes.Add("class", "active");
                    break;

                case "Contact Us":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}