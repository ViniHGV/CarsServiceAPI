using CarServiceAPI.Application.DTOs;
using CarServiceAPI.Domain.Entities;
using CommerceHubAPI.Infra.Repositories;

namespace CarServiceAPI.Domain.UseCases
{
    public class UpdateCarUseCase(GenericRepository<Car> genericRepository)
    {
        private readonly GenericRepository<Car> _genericRepository = genericRepository;

        public async Task<Car> execute(int id, CarRequestDTO requestDTO)
        {
            var carById = await _genericRepository.GetAsync(car => car.Id == id);
            carById.Email = requestDTO.Email;
            carById.Name = requestDTO.Name;

            if (carById == null)
                throw new ArgumentException("Carro inserido é inválido!");

            await _genericRepository.Update(carById);

            return carById;
        }
    }
}