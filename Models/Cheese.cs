using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models
{
    public class Cheese
    {
        //private
        private int chId = 0;
        private string chName = "n/a";
        private decimal chPrice = 0;

        //gets and sets

        public int ChId
        {
            get { return this.chId; }
            set { this.chId = value; }
        }
        public string ChName
        {
            get { return this.chName; }
            set { this.chName = value; }
        }
        public decimal ChPrice
        {
            get { return this.chPrice; }
            set { this.chPrice = value; }
        }

        //ToString

        public override string ToString()
        {
            string aMessage = "n/a";
            aMessage = aMessage + "Cheese Id = " + ChId + "<br />";
            aMessage = aMessage + "Cheese Name = " + ChName + "<br />";
            aMessage = aMessage + "Chesee Price = " + ChPrice + " <br />";
            return aMessage;
        }

        //constructors

        public Cheese() { }
        public Cheese(int aChID, string aChName, decimal aChPrice)
        {
            this.ChId = aChID;
            this.ChName = aChName;
            this.ChPrice = aChPrice;
        }
        public Cheese(int aChId, string aChName)
            :this(aChId, aChName, 0) { }
        public Cheese(int aChId)
            :this(aChId, "n/a", 0) { }

    }
}