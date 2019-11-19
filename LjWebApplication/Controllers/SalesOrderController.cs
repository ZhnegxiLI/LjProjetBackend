﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using LjData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    public class SalesOrderController : Controller
    {
        private readonly ISalesOrderRepository _saleOrderRepository;

        public SalesOrderController(ISalesOrderRepository salesOrderRepository)
        {
            _saleOrderRepository = salesOrderRepository;
        }
        // GET: SalesOrder
        [HttpGet]
        public JsonResult GetSalesOrderByUserId(string userId)
        {
            var result = _saleOrderRepository.GetSalesOrderByUserId(userId);
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetSalesOrderByOrderId(string orderId)
        {
            var result = _saleOrderRepository.GetSalesOrderListByOrderId(orderId);
            //string output = JsonConvert.SerializeObject(result);
            return Json(result);
        }
   

        public JsonResult InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products)
        {

            //dynamic status = _saleOrderRepository.InsertSalesOrderByOrderId(orderInfo, products);
            return Json(orderInfo);
        }


    }
}