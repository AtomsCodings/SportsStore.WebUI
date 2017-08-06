using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository productRespository)
        {
            this.repository = productRespository;
           // public int PageSize = 4;
        }

        public ViewResult List()
        {
            return View(repository.Products);
              //  .OrderBy(p => p.ProductID)
              //  .Skip(page -1) * PageSize)
              //  .Take(PageSize);
        }
    }
}
