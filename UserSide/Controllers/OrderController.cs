﻿using Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.AuthenticationClasses;
using Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IUnitofWork unitOfWork;
        IModelRepo<Order> orderRepo;
        IModelRepo<Customer> customerRepo;
        Helper helper;

        public OrderController(IUnitofWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            orderRepo = unitOfWork.GetOrderRepo();
            customerRepo = unitOfWork.GetCustomerRepo();
            helper = new Helper(unitOfWork);
        }
        [HttpGet]
        [Authorize(Roles =UserRoles.Customer)]
        [Route("get")]
        public IActionResult getOrdersByCustomerID(Status? status,DateTime? start
            ,DateTime? end,int? minPrice,int? maxPrice)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var id = customerRepo.Read().Where(c => c.profileID == userId).Select(c => c.Id).FirstOrDefault();
            IQueryable<Order> orders = orderRepo.Read().Where(o => o.CustomerId == id);
            if (status != null)
            {
                orders = orders.Where(order => order.status == status);
            }
            if (start != null)
            {
                orders = orders.Where(order => order.OrderDate >= start);
            }
            if (end != null)
            {
                orders = orders.Where(order => order.OrderDate <= end);
            }
            if (minPrice != null)
            {
                orders = orders.Where(order => order.TotalPrice >= minPrice);
            }
            if (maxPrice != null)
            {
                orders = orders.Where(order => order.TotalPrice <= maxPrice);
            }
            return Ok(orders.ToList());
        }
        [HttpPost]
        [Authorize(Roles = UserRoles.Customer)]
        [Route("add")]


        public IActionResult addOrder(List<OrderProduct> list,string address)

        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "Id").Value;
            var custID = customerRepo.Read().Where(c => c.profileID == userId).Select(c => c.Id).FirstOrDefault();
            response res = helper.checkProducts(list);
            if (res.errors > 0)
            {
                return NotFound(res.message);
            }
            var tPrice = helper.getTotalPrice(list);
            Order o = new Order();
            o.OrderAddress = address;
            o.CustomerId = custID;
            o.OrderDate = DateTime.Now;
            o.EstimatedDeliveryDate = DateTime.Now.AddDays(10);
            o.TotalPrice = tPrice + 5;
            o.orderproduct = list;
            orderRepo.Create(o);
            unitOfWork.Save();
            return Ok();

        }
        [HttpGet("getDetails")]
        public IActionResult getOrderDetails(int id)
        {
            return Ok(orderRepo.Read().Where(o => o.Id == id).Select(o => o.orderproduct).ToList());
        }
    }
}

