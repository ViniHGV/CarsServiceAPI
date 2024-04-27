using CarServiceAPI.Application.DTOs;
using CarServiceAPI.Domain.Entities;
using CommerceHubAPI.Infra.Repositories;

namespace CarServiceAPI.Domain.UseCases
{
    public class CreateCarUseCase(GenericRepository<Car> genericRepository)
    {
        private readonly GenericRepository<Car> _genericRepository = genericRepository;

        public async Task<Car> execute(CarRequestDTO requestDTO)
        {
            var car = new Car
            {
                Email = requestDTO.Email,
                Name = requestDTO.Name
            };

            await _genericRepository.CreateAsync(car);

            return car;
        }
    }
}