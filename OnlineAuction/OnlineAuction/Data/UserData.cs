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
                    user.Id = (int)dt["Id"];
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
                    user.Id = (int)dt["Id"];
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

        public bool insertUser(UsersDto user)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InserUser", "User");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                //command.Parameters.Add("@ClassName", SqlDbType.NVarChar).Value = @class.ClassName;
                //command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = @class.Note;

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
                //command.Parameters.Add("@ClassId", SqlDbType.Int).Value = @class.ClassId;
                //command.Parameters.Add("@ClassName", SqlDbType.NVarChar).Value = @class.ClassName;
                //command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = @class.Note;

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