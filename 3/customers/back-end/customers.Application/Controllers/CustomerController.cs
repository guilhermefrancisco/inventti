using customers.Domain.DTOs;
using customers.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace customers.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceCustomer _serviceCustomer;
        public CustomerController(IServiceCustomer serviceCustomer) => _serviceCustomer = serviceCustomer;

        [HttpPost]
        [Route("Insert")]
        public IActionResult Create([FromBody]CreateCustomerDTO createCustomer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _serviceCustomer.Insert(createCustomer);

                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }            
        }

        [HttpGet("{id}")]
        public IActionResult RecoverById([FromRoute]int id)
        {
            try
            {
                return Ok(_serviceCustomer.RecoverById(id));
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

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            try
            {
                _serviceCustomer.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody]UpdateCustomerDTO updateCustomer)
        {
            try
            {
                return Ok(_serviceCustomer.Update(updateCustomer));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
