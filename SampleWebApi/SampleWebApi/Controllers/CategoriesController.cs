using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        public List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();
            SqlConnection connection = new SqlConnection("Data Source=RS-WPC;Initial Catalog = Sample;User ID=sa;Password=Newuser@123");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Categories]", connection);
            //connection.Open();
            ////using (SqlDataReader reader = cmd.ExecuteReader())
            ////{
            ////    if (reader.HasRows)
            ////    {
            ////        while (reader.Read())
            ////        {
            ////            Categories objCategories = new Categories();/     
            ////            objCategories.CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId"));
            ////            objCategories.CategoryName = reader.GetString(reader.GetOrdinal("CategoryName"));
            ////            categories.Add(objCategories);
            ////        }
            ////    }
            ////}
            categories.Add(new Categories() { CategoryId = 1, CategoryName = "Car" });
            categories.Add(new Categories() { CategoryId = 2, CategoryName = "Truck" });
            categories.Add(new Categories() { CategoryId = 3, CategoryName = "Motorcycle" });
            return categories;
        }
    }
}
