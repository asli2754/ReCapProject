using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //attribute,imzalama yöntemi (javada annotation). bu class bir kontrollördür.
    
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);//200 - Ok
            }
            return BadRequest(result.Message);//400

        }

        //public List<Product> Get()
        //{
        //    //return new List<Product>
        //    //{
        //    //    new Product{ProductID=1, ProductName="Elma"},
        //    //    new Product{ProductID=2, ProductName="Armut"}
        //    //};

        //    //dependency chain--
        //    //IProductService productService = new ProductManager(new EfProductDal());
        //    var result = _productService.GetAll();
        //    return result.Data;

        //}

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
