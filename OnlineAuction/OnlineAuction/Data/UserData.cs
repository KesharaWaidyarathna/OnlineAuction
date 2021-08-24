using OnlineAuction.DTO;
using OnlineAuction.XML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Net.Mail;
using static OnlineAuction.DTO.PublicEnum;
using System.Net;
using System.Diagnostics;

namespace OnlineAuction.Data
{
    public class UserData
    {
        DBconnection connection = new DBconnection();
        QueryManager QueryManager = new QueryManager();
        ItemData itemData = new ItemData();
        public List<UsersDto> GetUsersList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetUserList", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }

                return Users;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<UsersDto> GetBuyersList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetBuyersList", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }

                return Users;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<UsersDto> GetSellersList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetSellersList", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }
                return Users;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<UsersDto> GetBuyersPendingList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetBuyersPendingList", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }

                return Users;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<UsersDto> GetSellersPendingList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetSellersPendingList", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }

                return Users;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public UsersDto GetUser(int id)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                }

                return user;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ApproveUser(UsersDto user)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("ApproveUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.Id;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    UsersDto usersDto = this.GetUser(user.Id);

                    using SmtpClient email = new SmtpClient
                    {
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential("aseonlineauction@gmail.com", "onlineauction"),
                        EnableSsl = true,
                        Host = "smtp.gmail.com",
                        Port = 587,
                    };
                    try
                    {
                        email.Send("aseonlineauction@gmail.com", usersDto.Email, "N E X T BID - Your Registration Approved!", "Your acount is now approved!! Please settle registration fee to continue.");
                    }
                    catch (Exception ex)
                    {
                        connection.closeConnection();
                        return true;
                    }
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

        public bool RejectUser(UsersDto user)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("RejectUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.Id;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    UsersDto usersDto = this.GetUser(user.Id);

                    using SmtpClient email = new SmtpClient
                    {
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential("aseonlineauction@gmail.com", "onlineauction"),
                        EnableSsl = true,
                        Host = "smtp.gmail.com",
                        Port = 587,
                    };
                    try
                    {
                        email.Send("aseonlineauction@gmail.com", usersDto.Email, "N E X T BID - Your Registration Rejected!", "Sorry, Your acount is rejected!! Try contact us.");
                    }
                    catch (Exception ex)
                    {
                        connection.closeConnection();
                        return true;
                    }
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


        public bool SaveUser(UsersDto user)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InsertUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserType", SqlDbType.Int).Value = user.UserType;
                command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.LastName;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = user.City;
                command.Parameters.Add("@DOB", SqlDbType.DateTime).Value = user.DOB;
                command.Parameters.Add("@ContactNumber", SqlDbType.Int).Value = user.ContactNumber;
                command.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = user.DepositAmount;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                command.Parameters.Add("@IsApproved", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@IsBlacklisted", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@IsRegisterationFeePaid", SqlDbType.Int).Value = 0;

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

        public bool updateUser(UsersDto user)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("UpdateUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserType", SqlDbType.Int).Value = user.UserType;
                command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.LastName;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = user.City;
                command.Parameters.Add("@DOB", SqlDbType.DateTime).Value = user.DOB;
                command.Parameters.Add("@ContactNumber", SqlDbType.Int).Value = user.ContactNumber;
                command.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = user.DepositAmount;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                command.Parameters.Add("@IsApproved", SqlDbType.Int).Value = user.IsApproved;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.Id;

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

        public bool SaveUserBid(UserBiddingDetailsDto userBid)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InsertUserBid", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = userBid.ItemId;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userBid.UserId;
                //command.Parameters.Add("@InspectionDate", SqlDbType.DateTime).Value = userBid.InspectionDate;
                command.Parameters.Add("@BidValue", SqlDbType.Decimal).Value = userBid.BidValue;
                command.Parameters.Add("@ReserveAmount", SqlDbType.Decimal).Value = userBid.ReserveAmount;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.closeConnection();

                    ItemBiddingDetailsDto itemBidding = new ItemBiddingDetailsDto();
                    itemBidding.ItemId = userBid.ItemId;
                    itemBidding.HighestBid = userBid.BidValue;
                    bool isUpdatedHighestBid = itemData.UpdateItemBiddingHighestBid(itemBidding);

                    UserPaymentDTO userPaymentDTO = new UserPaymentDTO();
                    userPaymentDTO.UserId = userBid.UserId;
                    userPaymentDTO.DepositAmount = userBid.ReserveAmount;
                    return this.UserWalletReserve(userPaymentDTO) && isUpdatedHighestBid;
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


        public bool CancelUserBid(UserBiddingDetailsDto userBid)
        {
            try
            {
                UserBiddingDetailsDto userBiddingDetails = this.GetUserBidsByItem(userBid);
                Debug.WriteLine(userBiddingDetails.BidValue);
                string query = QueryManager.LoadSqlFile("CancelUserBid", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = userBid.ItemId;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userBid.UserId;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    Debug.WriteLine("sadasd");
                    connection.closeConnection();


                    ItemBiddingDetailsDto itemBiddingDetails = itemData.GetHighestBid(userBid.ItemId);

                    Debug.WriteLine(Decimal.Compare(itemBiddingDetails.HighestBid, userBiddingDetails.BidValue));
                    if(Decimal.Compare(itemBiddingDetails.HighestBid, userBiddingDetails.BidValue) != -1)
                    {
                        // UPDATE HIGHEST BID TO SECOND USER
                        UserBiddingDetailsDto userBidDetail = new UserBiddingDetailsDto();
                        userBidDetail.ItemId = userBid.ItemId;
                        UserBiddingDetailsDto userBiddingDetailsDto = this.GetHighestPlacedBidByItem(userBidDetail);

                        Debug.WriteLine(userBiddingDetailsDto.BidValue.Equals(Decimal.Zero));

                        ItemBiddingDetailsDto itemBidding = new ItemBiddingDetailsDto();
                        itemBidding.ItemId = userBid.ItemId;
                        if (userBiddingDetailsDto.BidValue.Equals(Decimal.Zero))
                        {
                            ItemBiddingDetailsDto itemBiddingDetailsDto = itemData.GetItemBiddingDetailsByItemId(userBid.ItemId);
                            itemBidding.HighestBid = itemBiddingDetailsDto.StartingBid;
                        }
                        else
                        {
                            itemBidding.HighestBid = userBiddingDetailsDto.BidValue;
                        }

                       
                        itemData.UpdateItemBiddingHighestBid(itemBidding);
                    }

                    UserPaymentDTO userPaymentDTO = new UserPaymentDTO();
                    userPaymentDTO.UserId = userBid.UserId;
                    userPaymentDTO.DepositAmount = userBiddingDetails.ReserveAmount;

                    return this.UserWalletTopUp(userPaymentDTO);

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
        public UsersDto UserLogin(UsersDto Auth)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("UserLogin", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Auth.Email;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Auth.Password;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
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
                        //user.Password = (string)dt["Password"];
                        user.IsApproved = (int)dt["IsApproved"];
                        user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                        user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    }
                }
                connection.closeConnection();
                return user;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public bool SwitchToSeller(int UserID)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("SwitchToSeller", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                command.Parameters.Add("@UserType", SqlDbType.Int).Value = (int)UserType.Seller;

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

        public bool ConfirmRegistrationPayment(int UserID)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("ConfirmRegistrationPayment", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

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

        public bool UserWalletReserve(UserPaymentDTO paymentDTO)
        {
            try
            {
                UsersDto user = this.GetUser(paymentDTO.UserId);
                string query = QueryManager.LoadSqlFile("UserWalletTopUp", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = Decimal.Subtract(user.DepositAmount, paymentDTO.DepositAmount);
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = paymentDTO.UserId;

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

        public bool UserWalletTopUp(UserPaymentDTO paymentDTO)
        {
            try
            {
                UsersDto user = this.GetUser(paymentDTO.UserId);
                string query = QueryManager.LoadSqlFile("UserWalletTopUp", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@DepositAmount", SqlDbType.Decimal).Value = Decimal.Add(paymentDTO.DepositAmount, user.DepositAmount);
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = paymentDTO.UserId;

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

        public bool SaveBlackListUser(BlacklistUsersDto blacklistUser)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("SaveBlackListUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = blacklistUser.UserId;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = blacklistUser.Email;
                command.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = blacklistUser.Reason;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.closeConnection();
                    return this.UpdateUserBlacklisting(blacklistUser.UserId, true);

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

        public bool UpdateUserBlacklisting(int UserID, bool IsBlacklisted)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("UpdateUserBlacklisting", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@IsBlacklisted", SqlDbType.Bit).Value = IsBlacklisted;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

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

        public UsersDto CheckBlacklist(string Eamil)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("CheckBlacklist", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Eamil;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
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
                        //user.Password = (string)dt["Password"];
                        user.IsApproved = (int)dt["IsApproved"];
                        user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                        user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    }
                }
                connection.closeConnection();
                return user;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public UsersDto CheckAccountApproval(string Eamil)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("CheckAccountApproval", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Eamil;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
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
                        //user.Password = (string)dt["Password"];
                        user.IsApproved = (int)dt["IsApproved"];
                        user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                        user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    }
                }
                connection.closeConnection();
                return user;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public UsersDto CheckSettleRegistartionFee(string Eamil)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("CheckSettleRegistartionFee", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Eamil;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
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
                        //user.Password = (string)dt["Password"];
                        user.IsApproved = (int)dt["IsApproved"];
                        user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                        user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    }
                }
                connection.closeConnection();
                return user;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }

        }

        public string EmailValidation(string Eamil)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("EmailValidation", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Eamil;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UsersDto user = new UsersDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
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
                        //user.Password = (string)dt["Password"];
                        user.IsApproved = (int)dt["IsApproved"];
                        user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                        user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    }
                }
                connection.closeConnection();
                return user.Email;

            }
            catch (Exception ex)
            {
                connection.closeConnection();
                throw ex;
            }
        }

        public List<UsersDto> GetBlackListedUsers()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetBlackListedUsers", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<UsersDto> Users = new List<UsersDto>();
                foreach (DataRow dt in table.Rows)
                {
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
                    //user.Password = (string)dt["Password"];
                    user.IsApproved = (int)dt["IsApproved"];
                    user.IsBlacklisted = (bool)dt["IsBlacklisted"];
                    user.IsRegisterationFeePaid = (bool)dt["IsRegisterationFeePaid"];
                    Users.Add(user);
                }

                return Users;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserBiddingDetailsDto GetUserBidsByItem(UserBiddingDetailsDto userBid)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetUserBidsByItem", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userBid.UserId;
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = userBid.ItemId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UserBiddingDetailsDto userBiddingDetailsDto = new UserBiddingDetailsDto();
                foreach (DataRow dt in table.Rows)
                {
                    userBiddingDetailsDto.Id = (int)dt["UserBiddingDetailId"];
                    userBiddingDetailsDto.ItemId = (int)dt["ItemID"];
                    userBiddingDetailsDto.UserId = (int)dt["UserID"];
                    userBiddingDetailsDto.BidDate = (DateTime)dt["BidDate"];
                    userBiddingDetailsDto.BidValue = (decimal)dt["BidValue"];
                    userBiddingDetailsDto.ReserveAmount = (decimal)dt["ReserveAmount"];
                }

                return userBiddingDetailsDto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserBiddingDetailsDto GetHighestPlacedBidByItem(UserBiddingDetailsDto userBid)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetHighestPlacedBidByItem", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@ItemID", SqlDbType.Int).Value = userBid.ItemId;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                UserBiddingDetailsDto userBiddingDetailsDto = new UserBiddingDetailsDto();
                foreach (DataRow dt in table.Rows)
                {
                    userBiddingDetailsDto.ItemId = (int)dt["ItemID"];
                    userBiddingDetailsDto.BidValue = (decimal)dt["BidValue"];
                }

                return userBiddingDetailsDto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveBlackListUser(BlacklistUsersDto blacklistUser)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("RemoveBlackListUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = blacklistUser.UserId;

                connection.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {

                    connection.closeConnection();
                    return this.UpdateUserBlacklisting(blacklistUser.UserId, false);

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