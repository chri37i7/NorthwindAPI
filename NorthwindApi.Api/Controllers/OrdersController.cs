using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindApi.DataAccess;
using NorthwindApi.Entities;

namespace NorthwindApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet("all/{customerID}")]
        public List<Order> GetAll(string customerId)
        {
            return new Repository().GetAllOrders(customerId);
        }

        [HttpGet("pending/{customerID}")]
        public List<Order> GetAllPending(string customerID)
        {
            return new Repository().GetPendingOrders(customerID);
        }

        [HttpGet("completed/{customerID}")]
        public List<Order> GetAllCompleted(string customerID)
        {
            return new Repository().GetCompletedOrders(customerID);
        }
    }
}