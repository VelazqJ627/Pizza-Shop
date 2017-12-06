using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzeria.Models;
using System.Data;
using Microsoft.AspNet.Identity;


namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {

        DbConnection aConnection = new DbConnection();



        [Authorize]
        public ActionResult Index()
        {

            return View();
        }
        [Authorize]
        public ActionResult InsertOrders(bool DelOpt, int SizeId, int ChId, int SaId, bool Pepperoni, bool Mushrooms, bool Onion, bool Bacon, bool Peppers, bool Steak, bool Ham, bool Sausage, bool Chicken, bool Tomatoes, double OTotal, string Id)
        {
            
            //Adding up prices for bools 
            //Delivery Optio
            double PizzaPrice = 0;
            int Time = 0;
            if (DelOpt == true)
            { PizzaPrice += 3; Time += 10; }
            else { }

            //Size
            if (SizeId == 1)
            { PizzaPrice += 7.45; Time += 20; }
            else if (SizeId == 2)
            { PizzaPrice += 10.45; Time += 25; }
            else
            { PizzaPrice += 13.45; Time += 30; }

            //Cheesee
            if (ChId == 1)
            { PizzaPrice += 0; }
            else if (ChId == 2)
            { PizzaPrice += 0; }
            else
            { PizzaPrice += 2; }

            //Sauce
            if (SaId == 1)
            { PizzaPrice += 0; }
            else if (SaId == 2)
            { PizzaPrice += 0; }
            else
            { PizzaPrice += 1; }

            //Peppers
            if (Peppers == true)
            { PizzaPrice += 1; }
            else { PizzaPrice += 0; }

            //pepperoni
            if (Pepperoni == true)
            { PizzaPrice += 3; }
            else { PizzaPrice += 0; }

            //mushrooms
            if (Mushrooms == true)
            { PizzaPrice += 1; }
            else { PizzaPrice += 0; }

            //Onion
            if (Onion == true)
            { PizzaPrice += 1; }
            else { PizzaPrice += 0; }

            //Bacon
            if (Bacon == true)
            { PizzaPrice += 3; }
            else { PizzaPrice += 0; }

            //Steak
            if (Steak == true)
            { PizzaPrice += 3; }
            else { PizzaPrice += 0; }

            //Ham
            if (Ham == true)
            { PizzaPrice += 3; }
            else { PizzaPrice += 0; }

            //Sausage
            if (Sausage == true)
            { PizzaPrice += 3; }
            else { PizzaPrice += 0; }

            //Chicken
            if (Chicken == true)
            { PizzaPrice += 1; }
            else { PizzaPrice += 0; }

            //Tomatoes
            if (Tomatoes == true)
            { PizzaPrice += 1; }
            else { PizzaPrice += 0; }

            var UserId = User.Identity.GetUserId();
                        



            ViewBag.DelOpt = DelOpt;
            ViewBag.SizeId = SizeId;
            ViewBag.ChId = ChId;
            ViewBag.SaId = SaId;
            ViewBag.Pepperoni = Pepperoni;
            ViewBag.Mushrooms = Mushrooms;
            ViewBag.Onion = Onion;
            ViewBag.Bacon = Bacon;
            ViewBag.Peppers = Peppers;
            ViewBag.Steak = Steak;
            ViewBag.Ham = Ham;
            ViewBag.Sausage = Sausage;
            ViewBag.Chicken = Chicken;
            ViewBag.Tomatoes = Tomatoes;
            ViewBag.Id = UserId;
            ViewBag.Time = Time;
            //ViewBag.OrderId 

            ViewBag.OTotal = PizzaPrice;


            DbConnection aConnection = new DbConnection();

            aConnection.InsertOrders( DelOpt, SizeId, ChId, SaId, Pepperoni, Mushrooms, Onion, Bacon, Peppers, Steak, Ham, Sausage, Chicken, Tomatoes, PizzaPrice, UserId);
            string aSQL = "INSERT INTO Orders( DelOpt, SizeId, ChId, SaId, Pepperoni, Mushrooms, Onion, Bacon, Peppers, Steak, Ham, Sausage, Chicken, Tomatoes, OTotal, ID)";

            aSQL = aSQL + "VALUES('" + DelOpt + "','" + SizeId + "','" + ChId + "', '" + SaId + "','" + Pepperoni + "','" + Mushrooms + "', '" + Onion + "','" + Bacon + "','" + Peppers + "','" + Steak + "', '" + Ham + "','" + Sausage + "','" + Chicken + "', '" + Tomatoes + "','" + OTotal + "','" + Id + "') ";

           

            



            ViewBag.SQL = aSQL;
            return View();
        }
        [Authorize]
        public ActionResult InsertOrderForm()
        {
            return View();
        }

        public ActionResult GetOrders()
        {
            List<Orders> aListOfOrders = new List<Orders>();
            aListOfOrders = aConnection.GetOrders();

            ViewBag.ListOfOrders = aListOfOrders;
            return View();
        }





        [Authorize]
        public ActionResult About()
        {
            List<Orders> aListOfOrders = new List<Orders>();

            aListOfOrders = aConnection.GetOrders();

            ViewBag.ListOfOrders = aListOfOrders;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}