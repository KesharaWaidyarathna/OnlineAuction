using OnlineAuction.Data;
using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineAuction.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        CategoryData categoryData = new CategoryData();
        [Route("api/Category/GetCategoryList")]
        [HttpGet]
        public HttpResponseMessage GetCategoryList()
        {

            try
            {
                List<CategoryDto> categories = categoryData.GetCategoryList();
                if (categories.Count > 0)
                    return Request.CreateResponse(HttpStatusCode.OK, categories);

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "No categories to load");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Category/GetCategory")]
        [HttpGet]
        public HttpResponseMessage GetItem([FromBody] CategoryDto category)
        {
            try
            {
                CategoryDto categories = categoryData.GetCategory(category.CategoryId);
                if (categories != null)
                    return Request.CreateResponse(HttpStatusCode.OK, categories);


                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Invalid CategoryId");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Category/SaveCategory")]
        [HttpPost]
        public HttpResponseMessage SaveItem([FromBody] CategoryDto category)
        {
            try
            {
                if (categoryData.SaveCategory(category))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Category Save Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Category not save ");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}