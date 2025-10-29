using Microsoft.AspNetCore.Mvc;

namespace Help.NetExemples.IActionResultXActionResult
{
    public class ActionResultVSIActionResult : ControllerBase
    {
        private readonly IServiceActionResult _service;
        public ActionResultVSIActionResult() { }

        // Better with ActionResult<T>
        public ActionResult<ProductDto> GetProduct(string id)
        {
            var product = _service.FindById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // Better with IActionResult
        public IActionResult CreateUser(UserDto input)
        {
            if (input == null || string.IsNullOrWhiteSpace(input.Email))
                return BadRequest("Invalid input data.");

            if (_service.EmailExists(input.Email))
                return Conflict("E-mail already registered.");

            var user = _service.Create(input);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
        private object GetUser()
        {
            throw new NotImplementedException();
        }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string? Email { get; internal set; }
    }

    internal interface IServiceActionResult
    {
        bool EmailExists(object email);
        ActionResult<ProductDto> FindById(string id);
        UserDto Create(UserDto input);
    }

    public class ProductDto
    {
    }
}
