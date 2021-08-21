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
    public class CategoryData
    {
        DBconnection connection = new DBconnection();
        QueryManager QueryManager = new QueryManager();

        public List<CategoryDto> GetCategoryList()
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetCategoryList", "Category");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                List<CategoryDto> categories = new List<CategoryDto>();
                foreach (DataRow dt in table.Rows)
                {
                    CategoryDto category = new CategoryDto();
                    category.CategoryId = (int)dt["CategoryID"];
                    category.CategoryName = (string)dt["Name"];
                    categories.Add(category);
                }

                return categories;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public CategoryDto GetCategory(int Id)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("GetCategory", "Category");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                CategoryDto category = new CategoryDto();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dt in table.Rows)
                    {
                        category.CategoryId = (int)dt["CategoryID"];
                        category.CategoryName = (string)dt["Name"];
                    }
                }
                return category;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveCategory(CategoryDto category)
        {
            try
            {
                string query = QueryManager.LoadSqlFile("InsertCategory", "Category");
                SqlCommand command = new SqlCommand(query, connection.GetConnection());
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = category.CategoryName;

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