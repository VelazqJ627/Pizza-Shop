using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models
{
    public class Orders
    {
        //private

        private int orderId = 0;
        private bool delOpt = false;
        private int sizeId = 0;
        private int chId = 0;
        private int saId = 0;
        private bool pepperoni = false;
        private bool mushrooms = false;
        private bool onion = false;
        private bool bacon = false;
        private bool peppers = false;
        private bool steak = false;
        private bool ham = false;
        private bool sausage = false;
        private bool chicken = false;
        private bool tomatoes = false;
        private double oTotal = 0;
        private string id = "n/a";

        //gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }
        public bool DelOpt { get { return this.delOpt; } set { this.delOpt = value; } }
        public int SizeId { get { return this.sizeId; } set { this.sizeId = value; } }
        public int ChId { get { return this.chId; } set { this.chId = value; } }
        public int SaId { get { return this.saId; } set { this.saId = value; } }
        public bool Pepperoni { get { return this.pepperoni; } set { this.pepperoni = value; } }
        public bool Mushrooms { get { return this.mushrooms; } set { this.mushrooms = value; } }
        public bool Onion { get { return this.onion; } set { this.onion = value; } }
        public bool Bacon { get { return this.bacon; } set { this.bacon = value; } }
        public bool Peppers { get { return this.peppers; } set { this.peppers = value; } }
        public bool Steak { get { return this.steak; } set { this.steak = value; } }
        public bool Ham { get { return this.ham; } set { this.ham = value; } }
        public bool Sausage { get { return this.sausage; } set { this.sausage = value; } }
        public bool Chicken { get { return this.chicken; } set { this.chicken = value; } }
        public bool Tomatoes { get { return this.tomatoes; } set { this.tomatoes = value; } }
        public double OTotal { get { return this.oTotal; } set { this.oTotal = value; } }
        public string Id { get { return this.id; } set { this.id = value; } }
        //ToString

        public override string ToString()
        {

            string aMessage = "n/a";
            aMessage = aMessage + "OrderId = " + OrderId + "<br />";

            aMessage = aMessage + "DelOpt = " + DelOpt + "<br />";
            aMessage = aMessage + "SizeId = " + SizeId + "<br />";
            aMessage = aMessage + "ChId = " + ChId + "<br />";
            aMessage = aMessage + "SaId = " + SaId + "<br />";
            aMessage = aMessage + "Pepperoni = " + Pepperoni + "<br />";
            aMessage = aMessage + " Mushrooms= " + Mushrooms + "<br />";
            aMessage = aMessage + "Onion = " + Onion + "<br />";
            aMessage = aMessage + "Bacon = " + Bacon + "<br />";
            aMessage = aMessage + "Peppers = " + Peppers + "<br />";
            aMessage = aMessage + "Steak = " + Steak + "<br />";
            aMessage = aMessage + "Chicken = " + Chicken + "<br />";
            aMessage = aMessage + "Tomatoes = " + Tomatoes + "<br />";
            aMessage = aMessage + "Total= " + OTotal + " <br />";
            aMessage = aMessage + "User Id = " + Id + "<br />";
            return aMessage;
        }

        //Constructors

        public Orders() { }

        public Orders(int aOrderId,bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam, bool aSausage, bool aChicken, bool aTomatoes, double aOTotal, string aId)
        {
            this.OrderId = aOrderId;
            this.DelOpt = aDelOpt;
            this.SizeId = aSizeId;
            this.ChId = aChId;
            this.SaId = aSaId;
            this.Pepperoni = aPepperoni;
            this.Mushrooms = aMushrooms;
            this.Onion = aOnion;
            this.Bacon = aBacon;
            this.Peppers = aPeppers;
            this.Steak = aSteak;
            this.Ham = aHam;
            this.Sausage = aSausage;
            this.Chicken = aChicken;
            this.Tomatoes = aTomatoes;
            this.OTotal = aOTotal;
            this.Id = aId;
        }
        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam, bool aSausage, bool aChicken, bool aTomatoes, int aOTotal)
: this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, aSteak, aHam, aSausage, aChicken, aTomatoes, aOTotal, "n/a") { }


        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam, bool aSausage, bool aChicken, bool aTomatoes)
    : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, aSteak, aHam, aSausage, aChicken, aTomatoes, 0.0, "n/a") { }


        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam, bool aSausage, bool aChicken)
            : this(aOrderId, aDelOpt,aSizeId,aChId,aSaId,aPepperoni,aMushrooms,aOnion,aBacon,aPeppers,aSteak,aHam,aSausage,aChicken, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam, bool aSausage)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, aSteak, aHam, aSausage, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak, bool aHam)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, aSteak, aHam, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers, bool aSteak)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, aSteak, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon, bool aPeppers)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, aPeppers, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion, bool aBacon)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, aBacon, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms, bool aOnion)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, aOnion, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni, bool aMushrooms)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, aMushrooms, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId, bool aPepperoni)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, aPepperoni, false, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId, int aSaId)
            : this(aOrderId, aDelOpt, aSizeId, aChId, aSaId, false, false, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId, int aChId)
            : this(aOrderId, aDelOpt, aSizeId, aChId, 0, false, false, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt, int aSizeId)
            : this(aOrderId, aDelOpt, aSizeId, 0, 0, false, false, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId, bool aDelOpt)
            : this(aOrderId, aDelOpt, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, 0, "n/a") { }

        public Orders(int aOrderId)
            : this(aOrderId, false, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, 0, "n/a") { }



    }
}