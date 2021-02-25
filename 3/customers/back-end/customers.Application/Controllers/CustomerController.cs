using customers.Domain.DTOs;
using customers.Domain.Entities;
using customers.Domain.Interfaces;
using customers.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace customers.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceCustomer _serviceCustomer;
        public CustomerController(IServiceCustomer serviceCustomer) => _serviceCustomer = serviceCustomer;

        [HttpPost]
        public IActionResult Create([FromBody]CreateCustomerDTO createCustomer)
        {
            try
            {
                _serviceCustomer.Insert(createCustomer);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }            
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_serviceCustomer.RecoverAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
