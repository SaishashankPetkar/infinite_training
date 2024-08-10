using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Que2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imgpath;
            switch (DL1.SelectedValue)
            {
                case "Lamborghini":
                    imgpath = "Lambo.jpg";
                    break;
                case "Bugatti":
                    imgpath = "Bugatti.jpg";
                    break;
                case "Bentley":
                    imgpath = "Bentley.jpg";
                    break;
                default:
                    imgpath = string.Empty;
                    break;
            }

            Image1.ImageUrl = $"~/{imgpath}";
        }

        protected void BtnGetPrice_Click(object sender, EventArgs e)
        {
            string selectedCar = DL1.SelectedValue;
            double price;

            switch (selectedCar)
            {
                case "Lamborghini":
                    price = 40000000; 
                    break;
                case "Bugatti":
                    price = 100000000;
                    break;
                case "Bentley":
                    price = 70000000;
                    break;
                default:
                    price = 0;
                    break;
            }
            if(price != 0)
            {
                Label1.Text = $"Price of {selectedCar} is : {price}";
            }
            else
            {
                Label1.Text = "Please Select A Car First";
            }
        }
    }
}