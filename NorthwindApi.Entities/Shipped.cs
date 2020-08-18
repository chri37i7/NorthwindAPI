using System;

namespace NorthwindApi.Entities
{
    public class Shipped
    {
        protected DateTime shippedDate;

        public Shipped(DateTime shippedDate)
        {
            ShippedDate = shippedDate;
        }

        public DateTime ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                shippedDate = value;
            }
        }
    }
}