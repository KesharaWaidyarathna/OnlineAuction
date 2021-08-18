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

        public List<ItemDto> GetUsersList()
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

    }
}