using CarServiceAPI.Domain.Entities;
using CommerceHubAPI.Infra.Repositories;

namespace CarServiceAPI.Domain.UseCases
{
    public class ListAllCarsUseCase(GenericRepository<Car> genericRepository)
    {
        private readonly GenericRepository<Car> _genericRepository = genericRepository;

        public async Task<List<Car>> execute()
        {
            var cars = await _genericRepository.GetAllAsync();
            return cars;
        }
    }
}