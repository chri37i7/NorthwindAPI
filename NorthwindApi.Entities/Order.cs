using System;

namespace NorthwindApi.Entities
{
    public class Order
    {
        #region Fields
        protected string customerID;
        protected DateTime orderDate;
        protected DateTime requiredDate;
        protected DateTime shippedDate;
        protected string shipAddress;
        protected string shipCountry;
        #endregion

        #region Constructors
        public Order(string customerID, DateTime orderDate, DateTime requiredDate, DateTime shippedDate, string shipAddress, string shipCountry)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipAddress = shipAddress;
            ShipCountry = shipCountry;
        }
        #endregion

        #region Properties
        public virtual string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                if(customerID != value)
                {
                    customerID = value; 
                }
            }
        }

        public virtual DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                if(orderDate != value)
                {
                    orderDate = value; 
                }
            }
        }

        public virtual DateTime RequiredDate
        {
            get
            {
                return requiredDate;
            }
            set
            {
                if(requiredDate != value)
                {
                    requiredDate = value; 
                }
            }
        }

        public virtual DateTime ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                if(shippedDate != value)
                {
                    shippedDate = value; 
                }
            }
        }

        public virtual string ShipAddress
        {
            get
            {
                return shipAddress;
            }
            set
            {
                if(shipAddress != value)
                {
                    shipAddress = value; 
                }
            }
        }

        public virtual string ShipCountry
        {
            get
            {
                return shipCountry;
            }
            set
            {
                if(shipCountry != value)
                {
                    shipCountry = value; 
                }
            }
        }
        #endregion
    }
}