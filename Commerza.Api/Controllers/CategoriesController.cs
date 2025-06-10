using Azure.Messaging;
using Commerza.Core.DTO;
using Commerza.Core.Entities.Product;
using Commerza.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Commerza.Api.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(IUnitOfWork work) : base(work)
        {
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> get()
        {
            try
            {
                var category = await work.CategoryRepositry.GetAllAsync();
                if (category is null)
                    return BadRequest();
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> getbyId(int id)
        {
            try
            {
                var category = await work.CategoryRepositry.GetByIdAsync(id);
                if (category is null)
                    return BadRequest();
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest (ex.Message);
            }
        }
        [HttpPost("add-category")]
        public async Task<IActionResult> add(CategoryDTO categoryDTO)
        {
            try
            {
                var category = new Category()
                {
                    Name = categoryDTO.Name,
                    Description = categoryDTO.Description
                };
                await work.CategoryRepositry.AddAsync(category);
                return Ok(new { message = "Item has been Added" });
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
