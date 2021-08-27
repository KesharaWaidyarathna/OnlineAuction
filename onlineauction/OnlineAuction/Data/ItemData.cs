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
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemDto item = new ItemDto();
                        item.ItemId = (int)dt["ItemId"];
                        item.CategoryId = (int)dt["CategoryId"];
                        item.ItemName = (string)dt["Name"];
                        item.ItemDiscription = (string)dt["Description"];
                        item.ItemValue = (decimal)dt["Value"];
                        item.Image1 = (string)dt["Image1"];
                        item.Image2 = (string)dt["Image2"];
                        item.Image3 = (string)dt["Image3"];
                        item.Video = (string)dt["Video"];
                        item.Location = (string)dt["Location"];
                        item.SoldPrice = (decimal)dt["SoldPrice"];
                        item.SoldDate = (DateTime)dt["SoldDate"];
                        item.IsSold = (bool)dt["IsSold"];
                        Items.Add(item);
                    }

                }
                connection.closeConnection();
                return Items;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public List<ItemDto> GetItemListByUserId(ItemDto itemDto)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemListByUserId", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = itemDto.UserId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemDto> Items = new List<ItemDto>();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemDto item = new ItemDto();
                        item.ItemId = (int)dt["ItemId"];
                        item.CategoryId = (int)dt["CategoryId"];
                        item.ItemName = (string)dt["Name"];
                        item.ItemDiscription = (string)dt["Description"];
                        item.ItemValue = (decimal)dt["Value"];
                        item.Image1 = (string)dt["Image1"];
                        item.Image2 = (string)dt["Image2"];
                        item.Image3 = (string)dt["Image3"];
                        item.Video = (string)dt["Video"];
                        item.Location = (string)dt["Location"];
                        item.SoldPrice = (decimal)dt["SoldPrice"];
                        item.SoldDate = (DateTime)dt["SoldDate"];
                        item.IsSold = (bool)dt["IsSold"];
                        Items.Add(item);
                    }

                }
                connection.closeConnection();
                return Items;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public List<ItemDto> GetItemListByUserBidded(UserBiddingDetailsDto userBiddingDetailsDto)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemListByUserBidded", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userBiddingDetailsDto.UserId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemDto> Items = new List<ItemDto>();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemDto item = new ItemDto();
                        item.ItemId = (int)dt["ItemId"];
                        item.CategoryId = (int)dt["CategoryId"];
                        item.ItemName = (string)dt["Name"];
                        item.ItemDiscription = (string)dt["Description"];
                        item.ItemValue = (decimal)dt["Value"];
                        item.Image1 = (string)dt["Image1"];
                        item.Image2 = (string)dt["Image2"];
                        item.Image3 = (string)dt["Image3"];
                        item.Video = (string)dt["Video"];
                        item.Location = (string)dt["Location"];
                        item.SoldPrice = (decimal)dt["SoldPrice"];
                        item.SoldDate = (DateTime)dt["SoldDate"];
                        item.IsSold = (bool)dt["IsSold"];
                        Items.Add(item);
                    }

                }
                connection.closeConnection();
                return Items;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public List<ItemBiddingDetailsDto> GetItemBiddingDetalList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemBiddingList", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemBiddingDetailsDto> itemBiddings = new List<ItemBiddingDetailsDto>();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                        itemBiddin.Id = (int)dt["ItemBiddingDetailId"];
                        itemBiddin.ItemId = (int)dt["ItemID"];
                        itemBiddin.StartingBid = (decimal)dt["StartingBid"];
                        itemBiddin.BidStartDate = (DateTime)dt["StartingDate"];
                        itemBiddin.BidEndDate = (DateTime)dt["EndingDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionStartDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionEndDate"];
                        itemBiddin.HighestBid = (decimal)dt["HighestBid"];
                        itemBiddings.Add(itemBiddin);
                    }
                }
                connection.closeConnection();
                return itemBiddings;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public List<ItemBiddingDetailsDto> GetItemBiddingDetalListByUser(ItemDto itemDto)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemBiddingListByUser", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = itemDto.UserId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemBiddingDetailsDto> itemBiddings = new List<ItemBiddingDetailsDto>();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                        itemBiddin.Id = (int)dt["ItemBiddingDetailId"];
                        itemBiddin.ItemId = (int)dt["ItemID"];
                        itemBiddin.StartingBid = (decimal)dt["StartingBid"];
                        itemBiddin.BidStartDate = (DateTime)dt["StartingDate"];
                        itemBiddin.BidEndDate = (DateTime)dt["EndingDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionStartDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionEndDate"];
                        itemBiddin.HighestBid = (decimal)dt["HighestBid"];
                        itemBiddings.Add(itemBiddin);
                    }
                }
                connection.closeConnection();
                return itemBiddings;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public List<ItemBiddingDetailsDto> GetItemBiddingListByUserBidded(UserBiddingDetailsDto userBiddingDetailsDto)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemBiddingListByUserBidded", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userBiddingDetailsDto.UserId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ItemBiddingDetailsDto> itemBiddings = new List<ItemBiddingDetailsDto>();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                        itemBiddin.Id = (int)dt["ItemBiddingDetailId"];
                        itemBiddin.ItemId = (int)dt["ItemID"];
                        itemBiddin.StartingBid = (decimal)dt["StartingBid"];
                        itemBiddin.BidStartDate = (DateTime)dt["StartingDate"];
                        itemBiddin.BidEndDate = (DateTime)dt["EndingDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionStartDate"];
                        itemBiddin.InspectionEndDate = (DateTime)dt["InspectionEndDate"];
                        itemBiddin.HighestBid = (decimal)dt["HighestBid"];
                        itemBiddings.Add(itemBiddin);
                    }
                }
                connection.closeConnection();
                return itemBiddings;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
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
                    item.ItemName = (string)dt["Name"];
                    item.ItemDiscription = (string)dt["Description"];
                    item.ItemValue = (decimal)dt["Value"];
                    item.Image1 = (string)dt["Image1"];
                    item.Image2 = (string)dt["Image2"];
                    item.Image3 = (string)dt["Image3"];
                    item.Video = (string)dt["Video"];
                    item.Location = (string)dt["Location"];
                    item.SoldPrice = (decimal)dt["SoldPrice"];
                    item.SoldDate = (DateTime)dt["SoldDate"];
                    item.IsSold = (bool)dt["IsSold"];
                }

                connection.closeConnection();
                return item;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public bool SaveItem(ItemDto item)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InsertItem", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = item.CategoryId;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = item.ItemName;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = item.ItemDiscription;
                command.Parameters.Add("@Value", SqlDbType.Decimal).Value = item.ItemValue;
                command.Parameters.Add("@Image1", SqlDbType.NVarChar).Value = item.Image1;
                command.Parameters.Add("@Image2", SqlDbType.NVarChar).Value = item.Image2;
                command.Parameters.Add("@Image3", SqlDbType.NVarChar).Value = item.Image3;
                command.Parameters.Add("@Video", SqlDbType.NVarChar).Value = item.Video;
                command.Parameters.Add("@Location", SqlDbType.NVarChar).Value = item.Location;
                command.Parameters.Add("@SoldPrice", SqlDbType.Decimal).Value = 0;
                command.Parameters.Add("@SoldDate", SqlDbType.DateTime).Value = Convert.ToDateTime("1/1/1753 12:01:00 AM");
                command.Parameters.Add("@IsSold", SqlDbType.Bit).Value = item.IsSold;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = item.UserId;


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

        public bool SaveItemBiddingDetail(ItemBiddingDetailsDto itemBidding)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InsertItemBiddingDetail", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemBidding.ItemId;
                command.Parameters.Add("@StartingBid", SqlDbType.Decimal).Value = itemBidding.StartingBid;
                command.Parameters.Add("@StartingDate", SqlDbType.DateTime).Value = itemBidding.BidStartDate;
                command.Parameters.Add("@EndingDate", SqlDbType.DateTime).Value = itemBidding.BidEndDate;
                command.Parameters.Add("@InspectionStartDate", SqlDbType.DateTime).Value = itemBidding.InspectionStartDate;
                command.Parameters.Add("@InspectionEndDate", SqlDbType.DateTime).Value = itemBidding.InspectionEndDate;
                command.Parameters.Add("@HighestBid", SqlDbType.Decimal).Value = itemBidding.StartingBid;

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

        public bool UpdateItemBiddingHighestBid(ItemBiddingDetailsDto itemBidding)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("UpdateItemBiddingHighestBid", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemBidding.ItemId;
                command.Parameters.Add("@HighestBid", SqlDbType.Decimal).Value = itemBidding.HighestBid;

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

        public ItemBiddingDetailsDto GetHighestBid(int itemId)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetHighestBid", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        itemBiddin.HighestBid = (decimal)dt["HighestBid"];
                    }
                }
                connection.closeConnection();
                return itemBiddin;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public bool ReadyToDispatch(int itemId)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("ReadyToDispatch", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;


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

        public ItemBiddingDetailsDto GetItemBiddingDetailsByItemId(int itemId)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetHighestBid", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        itemBiddin.StartingBid = (decimal)dt["StartingBid"];
                        itemBiddin.HighestBid = (decimal)dt["HighestBid"];
                    }
                }
                connection.closeConnection();
                return itemBiddin;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public List<UserBiddingDetailsDto> GetItemAllBids(int ItemID)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetItemAllBids", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UserBiddingDetailsDto> Bids = new List<UserBiddingDetailsDto>();
                foreach (DataRow dt in table.Rows)
                {
                    UserBiddingDetailsDto userBidding = new UserBiddingDetailsDto();
                    userBidding.Id = (int)dt["UserBiddingDetailId"];
                    userBidding.ItemId = (int)dt["ItemID"];
                    userBidding.UserId = (int)dt["UserID"];
                    userBidding.BidDate = (DateTime)dt["BidDate"];
                    userBidding.BidCount = (int)dt["BidCount"];
                    userBidding.InspectionDate = (DateTime)dt["InspectionDate"];
                    userBidding.BidValue = (decimal)dt["BidValue"];
                    userBidding.IsIncpectionApproved = (bool)dt["IsInspectionApproved"];
                    userBidding.IsCancelled = (bool)dt["IsCanceled"];
                    Bids.Add(userBidding);
                }
                connection.closeConnection();
                return Bids;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public List<ReadyToDispatchItemDto> GetReadyToDispatchList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetReadyToDispatchList", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<ReadyToDispatchItemDto> readyToDispatchItems = new List<ReadyToDispatchItemDto>();
                foreach (DataRow dt in table.Rows)
                {
                    ReadyToDispatchItemDto readyToDispatchItem = new ReadyToDispatchItemDto();

                    ItemDto item = new ItemDto();
                    item.ItemId = (int)dt["ItemId"];
                    item.CategoryId = (int)dt["CategoryId"];
                    item.ItemName = (string)dt["Name"];
                    item.ItemDiscription = (string)dt["Description"];
                    item.ItemValue = (decimal)dt["Value"];
                    item.Image1 = (string)dt["Image1"];
                    item.Image2 = (string)dt["Image2"];
                    item.Image3 = (string)dt["Image3"];
                    item.Video = (string)dt["Video"];
                    item.Location = (string)dt["Location"];
                    item.SoldPrice = (decimal)dt["SoldPrice"];
                    item.SoldDate = (DateTime)dt["SoldDate"];
                    item.IsSold = (bool)dt["IsSold"];

                    readyToDispatchItem.Item = item;

                    ItemBiddingDetailsDto itemBiddin = new ItemBiddingDetailsDto();
                    itemBiddin.Id = (int)dt["ItemBiddingDetailId"];
                    itemBiddin.ItemId = (int)dt["ItemID"];
                    itemBiddin.StartingBid = (decimal)dt["StartingBid"];
                    itemBiddin.BidStartDate = (DateTime)dt["StartingDate"];
                    itemBiddin.BidEndDate = (DateTime)dt["EndingDate"];
                    itemBiddin.InspectionEndDate = (DateTime)dt["InspectionStartDate"];
                    itemBiddin.InspectionEndDate = (DateTime)dt["InspectionEndDate"];
                    itemBiddin.HighestBid = (decimal)dt["HighestBid"];

                    readyToDispatchItem.ItemBidding = itemBiddin;

                    UsersDto user = new UsersDto();
                    user.Id = (int)dt["UserID"];
                    user.UserType = (int)dt["UserType"];
                    user.FirstName = (string)dt["FirstName"];
                    user.LastName = (string)dt["LastName"];
                    user.Address = (string)dt["Address"];
                    user.City = (string)dt["City"];
                    user.DOB = (DateTime)dt["DOB"];
                    user.ContactNumber = (int)dt["ContactNumber"];
                    user.DepositAmount = (decimal)dt["DepositAmount"];
                    user.Email = (string)dt["Email"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];

                    readyToDispatchItem.User = user;

                    readyToDispatchItems.Add(readyToDispatchItem);
                }
                connection.closeConnection();
                return readyToDispatchItems;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public ItemDto GetLastItemId()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetLastItemId", "Item");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                ItemDto item = new ItemDto();
                foreach (DataRow dt in table.Rows)
                {
                    item.ItemId = (int)dt["ItemId"];
                    item.CategoryId = (int)dt["CategoryId"];
                    item.ItemName = (string)dt["Name"];
                    item.ItemDiscription = (string)dt["Description"];
                    item.ItemValue = (decimal)dt["Value"];
                    item.Image1 = (string)dt["Image1"];
                    item.Image2 = (string)dt["Image2"];
                    item.Image3 = (string)dt["Image3"];
                    item.Video = (string)dt["Video"];
                    item.Location = (string)dt["Location"];
                    item.SoldPrice = (decimal)dt["SoldPrice"];
                    item.SoldDate = (DateTime)dt["SoldDate"];
                    item.IsSold = (bool)dt["IsSold"];
                }

                connection.closeConnection();
                return item;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }


    }
}