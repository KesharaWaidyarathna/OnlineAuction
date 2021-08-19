using OnlineAuction.DTO;
using OnlineAuction.XML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineAuction.Data
{
    public class OrderData
    {
        DBconnection connection = new DBconnection();
        QueryManager QueryManager = new QueryManager();

        public List<OrderDetailsDto> GetOrdersList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetOrdersList", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<OrderDetailsDto> orders = new List<OrderDetailsDto>();
                foreach (DataRow dt in table.Rows)
                {
                    OrderDetailsDto order = new OrderDetailsDto();
                    order.Id = (int)dt["OrderID"];
                    order.UserId = (int)dt["UserID"];
                    order.ItemId = (int)dt["ItemID"];
                    order.Price = (decimal)dt["Price"];
                    order.SoldDate = (DateTime)dt["Date"];
                    order.DispatchDate = (DateTime)dt["DispatchDate"];
                    order.DeliveryAddress = (string)dt["DeliveryAddress"];
                    order.DeliveryCharge = (decimal)dt["DeliveryCharge"];
                    order.City = (string)dt["City"];
                    order.PickupAddress = (string)dt["PickupAddress"];
                    order.IsDispatch = (bool)dt["IsDispatch"];
                    order.IsFullPaid = (bool)dt["IsFullPaid"];
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public OrderDetailsDto GetOrder(int id)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetOrder", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                OrderDetailsDto order = new OrderDetailsDto();
                foreach (DataRow dt in table.Rows)
                {
                    order.Id = (int)dt["OrderID"];
                    order.UserId = (int)dt["UserID"];
                    order.ItemId = (int)dt["ItemID"];
                    order.Price = (decimal)dt["Price"];
                    order.SoldDate = (DateTime)dt["Date"];
                    order.DispatchDate = (DateTime)dt["DispatchDate"];
                    order.DeliveryAddress = (string)dt["DeliveryAddress"];
                    order.DeliveryCharge = (decimal)dt["DeliveryCharge"];
                    order.City = (string)dt["City"];
                    order.PickupAddress = (string)dt["PickupAddress"];
                    order.IsDispatch = (bool)dt["IsDispatch"];
                    order.IsFullPaid = (bool)dt["IsFullPaid"];
                }
                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveOrderDetail(OrderDetailsDto order)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InserOrderDetail", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = order.UserId;
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = order.ItemId;
                command.Parameters.Add("@Price", SqlDbType.VarChar).Value = order.Price;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = order.SoldDate;
                command.Parameters.Add("@DispatchDate", SqlDbType.DateTime).Value = order.DispatchDate;
                command.Parameters.Add("@DeliveryAddress", SqlDbType.NVarChar).Value = order.DeliveryAddress;
                command.Parameters.Add("@DeliveryCharge", SqlDbType.Decimal).Value = order.DeliveryCharge;
                command.Parameters.Add("@City", SqlDbType.VarChar).Value = order.City;
                command.Parameters.Add("@PickupAddress", SqlDbType.NVarChar).Value = order.PickupAddress;
                command.Parameters.Add("@IsDispatch", SqlDbType.Bit).Value = order.IsDispatch;
                command.Parameters.Add("@IsFullPaid", SqlDbType.Bit).Value = order.IsFullPaid;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public OrderDetailsDto GetOrder(int UserId,int ItemId)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetOrderByUserIdItemId", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserId;
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                OrderDetailsDto order = new OrderDetailsDto();
                foreach (DataRow dt in table.Rows)
                {
                    order.Id = (int)dt["OrderID"];
                    order.UserId = (int)dt["UserID"];
                    order.ItemId = (int)dt["ItemID"];
                    order.Price = (decimal)dt["Price"];
                    order.SoldDate = (DateTime)dt["Date"];
                    order.DispatchDate = (DateTime)dt["DispatchDate"];
                    order.DeliveryAddress = (string)dt["DeliveryAddress"];
                    order.DeliveryCharge = (decimal)dt["DeliveryCharge"];
                    order.City = (string)dt["City"];
                    order.PickupAddress = (string)dt["PickupAddress"];
                    order.IsDispatch = (bool)dt["IsDispatch"];
                    order.IsFullPaid = (bool)dt["IsFullPaid"];
                }
                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveOrderPaymentDetail(OrderPaymentDetailsDto orderPayment)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InserOrderPaymentDetail", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@OrderID", SqlDbType.Int).Value = orderPayment.OrderId;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = orderPayment.UserId;
                command.Parameters.Add("@PaymentAmount", SqlDbType.VarChar).Value = orderPayment.Amount;
                command.Parameters.Add("@PaymentDate", SqlDbType.DateTime).Value = orderPayment.PaymentDate;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public OrderPaymentDetailsDto GetOrderPaymentDetail(int OrderID)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetOrderPaymentDetail", "Order");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                OrderPaymentDetailsDto orderPayment = new OrderPaymentDetailsDto();
                foreach (DataRow dt in table.Rows)
                {
                    orderPayment.Id = (int)dt["PaymetID"];
                    orderPayment.OrderId = (int)dt["OrderID"];
                    orderPayment.UserId = (int)dt["UserID"];
                    orderPayment.Amount = (decimal)dt["PaymentAmount"];
                    orderPayment.PaymentDate = (DateTime)dt["PaymentDate"];
                }
                return orderPayment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}