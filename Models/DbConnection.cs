using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Pizzeria.Models
{
    public class DbConnection
    {

        private List<Orders> aListOfOrders = new List<Orders>();


        //Start of GetOrders Method
        
        public List<Orders> GetOrders()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT OrderId, DelOpt, SizeId, ChId, SaId, Pepperoni, Mushrooms, Onion, Bacon, Peppers, Steak, Ham, Sausage, Chicken, Tomatoes, OTotal, Id FROM Orders;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=MSI;Initial Catalog=Pizzeria;Integrated Security=SSPI";
            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aOrderId = (int)aReader["OrderId"];
                bool aDelOpt = (bool)aReader["DelOpt"];
                int aSizeId = (int)aReader["SizeId"];
                int aChId = (int)aReader["ChId"];
                int aSaId = (int)aReader["SaId"];
                bool aPepperoni = (bool)aReader["Pepperoni"];
                bool aMushrooms = (bool)aReader["Mushrooms"];
                bool aOnion = (bool)aReader["Onion"];
                bool aBacon = (bool)aReader["Bacon"];
                bool aPeppers = (bool)aReader["Peppers"];
                bool aSteak = (bool)aReader["Steak"];
                bool aHam = (bool)aReader["Ham"];
                bool aSausage = (bool)aReader["Sausage"];
                bool aChicken = (bool)aReader["Chicken"];
                bool aTomatoes = (bool)aReader["Tomatoes"];
                double aOTotal = (double)aReader["OTotal"];
                string aId = (string)aReader["Id"];

                Orders aOrder = new Orders();

                aOrder.OrderId = aOrderId;
                aOrder.DelOpt = aDelOpt;
                aOrder.SizeId = aSizeId;
                aOrder.ChId = aChId;
                aOrder.SaId = aSaId;
                aOrder.Pepperoni = aPepperoni;
                aOrder.Mushrooms = aMushrooms;
                aOrder.Onion = aOnion;
                aOrder.Bacon = aBacon;
                aOrder.Peppers = aPeppers;
                aOrder.Steak = aSteak;
                aOrder.Ham = aHam;
                aOrder.Sausage = aSausage;
                aOrder.Chicken = aChicken;
                aOrder.Tomatoes = aTomatoes;
                aOrder.OTotal = aOTotal;
                aOrder.Id = aId;

                aListOfOrders.Add(aOrder);
            }
            aConnection.Close();

            return aListOfOrders;
        }

        public bool InsertOrders(bool DelOpt,int SizeId,int ChId,int SaId,bool Pepperoni,bool Mushrooms,bool Onion,bool Bacon,bool Peppers,bool Steak,bool  Ham,bool Sausage, bool Chicken,bool Tomatoes, double OTotal, string Id)
            
        {

            bool aFlag = false;
            string aSQL = "INSERT INTO Orders (DelOpt, SizeId, ChId, SaId, Pepperoni, Mushrooms, Onion, Bacon, Peppers, Steak, Ham, Sausage, Chicken, Tomatoes, OTotal, Id )";
            aSQL = aSQL + "VALUES('" + DelOpt + "','" + SizeId + "','" + ChId + "', '" + SaId + "','" + Pepperoni + "','" + Mushrooms + "', '" + Onion + "','" + Bacon + "','" + Peppers + "','" + Steak + "', '" + Ham + "','" + Sausage + "','" + Chicken + "', '" + Tomatoes + "','" + OTotal + "','" + Id + "') ";
          
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=MSI;Initial Catalog=Pizzeria;Integrated Security=SSPI";
            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        



    }
    
}