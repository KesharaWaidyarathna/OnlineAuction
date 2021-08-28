using OnlineAuction.DTO;
using OnlineAuction.XML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static OnlineAuction.DTO.PublicEnum;

namespace OnlineAuction.Data
{
    public class UserData
    {
        DBconnection connection = new DBconnection();
        QueryManager QueryManager = new QueryManager();

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
                    user.Password = (string)dt["Password"];
                    user.IsApproved = (bool)dt["IsApproved"];
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
                    user.Password = (string)dt["Password"];
                    user.IsApproved = (bool)dt["IsApproved"];
                }

                return user;

            }
            catch (Exception ex)
            {
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
                command.Parameters.Add("@IsApproved", SqlDbType.Bit).Value = user.IsApproved;

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
                command.Parameters.Add("@IsApproved", SqlDbType.Bit).Value = user.IsApproved;
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
                command.Parameters.Add("@InspectionDate", SqlDbType.DateTime).Value = userBid.InspectionDate;
                command.Parameters.Add("@BidValue", SqlDbType.Decimal).Value = userBid.BidValue;

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
                        user.Password = (string)dt["Password"];
                        user.IsApproved = (bool)dt["IsApproved"];
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

        public bool SwitchToSeller (int UserID)
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
                        user.Password = (string)dt["Password"];
                        user.IsApproved = (bool)dt["IsApproved"];
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
                        user.Password = (string)dt["Password"];
                        user.IsApproved = (bool)dt["IsApproved"];
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
    }
}