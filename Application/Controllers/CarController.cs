using CarServiceAPI.Application.DTOs;
using CarServiceAPI.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceAPI.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController(ListAllCarsUseCase listAllCarsUseCase,
     CreateCarUseCase createCarUseCase,
      DeleteCarUSeCase deleteCarUSeCase,
      UpdateCarUseCase updateCarUseCase) : ControllerBase
    {
        private readonly ListAllCarsUseCase _listAllCarsUseCase = listAllCarsUseCase;
        private readonly CreateCarUseCase _createCarUseCase = createCarUseCase;
        private readonly DeleteCarUSeCase _deleteCarUSeCase = deleteCarUSeCase;
        private readonly UpdateCarUseCase _updateCarUseCase = updateCarUseCase;

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var listAllCarsUseCase = await _listAllCarsUseCase.execute();
            return Ok(listAllCarsUseCase);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CarRequestDTO requestDTO)
        {
            await _createCarUseCase.execute(requestDTO);
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            try
            {
                return Ok(await _deleteCarUSeCase.execute(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar([FromRoute] int id, [FromBody] CarRequestDTO requestDTO)
        {
            try
            {
                return Ok(await _updateCarUseCase.execute(id, requestDTO));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}