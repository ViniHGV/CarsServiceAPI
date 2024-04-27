using CarServiceAPI.Domain.Entities;
using CommerceHubAPI.Infra.Repositories;

namespace CarServiceAPI.Domain.UseCases
{
    public class DeleteCarUSeCase(GenericRepository<Car> genericRepository)
    {
        private readonly GenericRepository<Car> _genericRepository = genericRepository;

        public async Task<string> execute(int id)
        {
            var carById = await _genericRepository.GetAsync(car => car.Id == id);

            if (carById == null)
                throw new Exception("Carro não encontrado!");

            await _genericRepository.RemoveAsync(carById);

            return "Carro deletado com sucesso!";
        }
    }
}