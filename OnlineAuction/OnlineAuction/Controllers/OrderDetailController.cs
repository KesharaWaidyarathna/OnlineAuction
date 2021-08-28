﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using OnlineAuction.Data;
using OnlineAuction.DTO;
using OnlineAuction.Models;

namespace OnlineAuction.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrderDetailController : ApiController
    {
        OrderData OrderData = new OrderData();

        [Route("api/OrderDetail/GetOrderDetailsList")]
        [HttpGet]
        public HttpResponseMessage GetOrderDetailsList()
        {
            try
            {
                List<OrderDetailsDto> orders = OrderData.GetOrdersList();
                return Request.CreateResponse(HttpStatusCode.OK, orders);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/OrderDetail/GetOrderDetail")]
        [HttpGet]
        public HttpResponseMessage GetOrderDetail([FromBody] int id)
        {
            try
            {
                OrderDetailsDto order = OrderData.GetOrder(id);
                return Request.CreateResponse(HttpStatusCode.OK, order);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/OrderDetail/SaveOrder")]
        [HttpPost]
        public HttpResponseMessage SaveOrder([FromBody] OrderDto orderDto)
        {
            try
            {
                if (OrderData.SaveOrderDetail(orderDto.OrderDetailsDto))
                {
                    OrderDetailsDto order = OrderData.GetOrder(orderDto.OrderDetailsDto.UserId, orderDto.OrderDetailsDto.ItemId);

                    if (order != null)
                    {
                        orderDto.OrderPaymentDetailsDto.OrderId = order.Id;
                        if (OrderData.SaveOrderPaymentDetail(orderDto.OrderPaymentDetailsDto))
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, order, "Order Save Successfully");
                        }
                    }
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Order not save Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Order not save Successfully");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/OrderDetail/GetOrderPaymentDetail")]
        [HttpGet]
        public HttpResponseMessage GetOrderPaymentDetail([FromBody] int OrderId)
        {
            try
            {
                OrderPaymentDetailsDto OrderPaymentDetail = OrderData.GetOrderPaymentDetail(OrderId);
                return Request.CreateResponse(HttpStatusCode.OK, OrderPaymentDetail);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}