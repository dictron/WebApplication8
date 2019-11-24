using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : ControllerBase
    {
        private static readonly string[,] Summaries = new[,]
        {
            {"Шоколадка", "0"}, {"Печенька", "1"}, {"Сковородка", "2" }, {"Карандаш", "3" }, {"Коврик", "4" }, {"Брелок", "5" }
        };

        private readonly ILogger<ProductListController> _logger;

        public ProductListController(ILogger<ProductListController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<ProductList> Get()
        {
            return Enumerable.Range(0, 5).Select(index => new ProductList
            {
                ProductName = Summaries[index,0],
                ProductID = Summaries[index, 1]
            })
            .ToArray();
        }



        [HttpPost]
        public void Post(InputModel[] model)
        {
            ShopBasket Basket = new ShopBasket();
            foreach(var idzakaz in model)
            {
                Basket.ChangeList(idzakaz.Id, idzakaz.Count);
            }

        }

    }
}
