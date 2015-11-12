using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bill.Models
{
    public enum SubscriptionType
    {
        TV = 1,
        Talk = 2,
        Broadband = 3
    }

    public enum StoreType
    {
        Rental = 1,
        BuyAndKeep = 2
    }

    public class Bill
    {
        public Statement Statement { get; set; }
        public CallCharges CallCharges { get; set; }
        public Package Package { get; set; }
        public SkyStore SkyStore { get; set; }
        public decimal Total { get; set; }
    }

    public class Statement
    {
        public DateTime Generated { get; set; }
        public DateTime Due { get; set; }
        public Period Period { get; set; }
    }

    public class Period
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }

    public class CallCharges
    {
        public List<Call> Calls {get;set;}
        public decimal Total { get; set; }
    }

    public class Call
    {
        public string Called { get; set; }
        public string duration { get; set; }
        public decimal Cost { get; set; }
    }

    public class Package
    {
        public List<Subscription> Subscriptions { get; set; }
        public decimal Total { get; set; }
    }

    public class Subscription
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }

    public class SkyStore
    {
        public List<Rental> Rentals { get; set; }
        public List<BuyAndKeep> BuyAndKeep { get; set; }
        public decimal Total { get; set; }
    }

    public abstract class Store
    {
        public abstract string Title { get; set; }
        public abstract decimal Cost { get; set; }
    }

    public class Rental : Store
    {
        public override string Title { get; set; }
        public override decimal Cost { get; set; }
    }

    public class BuyAndKeep : Store
    {
        public override string Title { get; set; }
        public override decimal Cost { get; set; }
    }
}
