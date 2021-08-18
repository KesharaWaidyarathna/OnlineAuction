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
    public class ItemData
    {
        DBconnection connection = new DBconnection();
        QueryManager QueryManager = new QueryManager();

        public List<ItemDto> GetItemList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemList", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemDto> Items = new List<ItemDto>();
                foreach (DataRow dt in table.Rows)
                {
                    ItemDto item = new ItemDto();
                    item.ItemId = (int)dt["ItemId"];
                    item.CategoryId = (int)dt["CategoryId"];
                    item.ItemName = (string)dt["ItemName"];
                    item.CategoryName = (string)dt["CategoryName"];
                    item.ItemDiscription = (string)dt["ItemDiscription"];
                    item.ItemValue = (decimal)dt["ItemValue"];
                    item.InitalBid = (decimal)dt["InitalBid"];
                    item.Image1 = (byte[])dt["Image1"];
                    item.Image2 = (byte[])dt["Image2"];
                    item.Image3 = (byte[])dt["Image3"];
                    item.Image4 = (byte[])dt["Image4"];
                    item.Image5 = (byte[])dt["Image5"];
                    item.Video = (byte[])dt["Video"];
                    item.Location = (string)dt["Location"];
                    item.SoldPrice = (decimal)dt["SoldPrice"];
                    item.SoldDate = (DateTime)dt["SoldDate"];
                    item.IsSold = (bool)dt["IsSold"];

                }

                return Items;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ItemDto GetItem(int id)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItem", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                ItemDto item = new ItemDto();
                foreach (DataRow dt in table.Rows)
                {
                    item.ItemId = (int)dt["ItemId"];
                    item.CategoryId = (int)dt["CategoryId"];
                    item.ItemName = (string)dt["ItemName"];
                    item.CategoryName = (string)dt["CategoryName"];
                    item.ItemDiscription = (string)dt["ItemDiscription"];
                    item.ItemValue = (decimal)dt["ItemValue"];
                    item.InitalBid = (decimal)dt["InitalBid"];
                    item.Image1 = (byte[])dt["Image1"];
                    item.Image2 = (byte[])dt["Image2"];
                    item.Image3 = (byte[])dt["Image3"];
                    item.Image4 = (byte[])dt["Image4"];
                    item.Image5 = (byte[])dt["Image5"];
                    item.Video = (byte[])dt["Video"];
                    item.Location = (string)dt["Location"];
                    item.SoldPrice = (decimal)dt["SoldPrice"];
                    item.SoldDate = (DateTime)dt["SoldDate"];
                    item.IsSold = (bool)dt["IsSold"];
                }

                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool SaveItem(ItemDto item)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InserUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = item.CategoryId;
                command.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;
                command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = item.CategoryName;
                command.Parameters.Add("@ItemDiscription", SqlDbType.NVarChar).Value = item.ItemDiscription;
                command.Parameters.Add("@ItemValue", SqlDbType.Decimal).Value = item.ItemValue;
                command.Parameters.Add("@InitalBid", SqlDbType.Decimal).Value = item.InitalBid;
                command.Parameters.Add("@Image1", SqlDbType.VarBinary).Value = item.Image1;
                command.Parameters.Add("@Image2", SqlDbType.VarBinary).Value = item.Image2;
                command.Parameters.Add("@Image3", SqlDbType.VarBinary).Value = item.Image3;
                command.Parameters.Add("@Image4", SqlDbType.VarBinary).Value = item.Image4;
                command.Parameters.Add("@Image5", SqlDbType.VarBinary).Value = item.Image5;
                command.Parameters.Add("@Video", SqlDbType.VarBinary).Value = item.Video;
                command.Parameters.Add("@Location", SqlDbType.NVarChar).Value = item.Location;
                command.Parameters.Add("@SoldPrice", SqlDbType.Decimal).Value = item.SoldPrice;
                command.Parameters.Add("@SoldDate", SqlDbType.DateTime).Value = item.SoldDate;
                command.Parameters.Add("@IsSold", SqlDbType.Bit).Value = item.IsSold;

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



    }
}