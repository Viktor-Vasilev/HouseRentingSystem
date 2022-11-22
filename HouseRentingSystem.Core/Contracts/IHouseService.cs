using HouseRentingSystem.Core.Models.House;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseHomeModel>> LAstThreeHouses();

        Task<IEnumerable<HouseCategoryModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(HouseModel model, int agentId);

        Task<HousesQueryModel> All(
            string? category = null,
            string? searchTerm = null,
            HouseSorting sorting = HouseSorting.Newest,
            int curentPage = 1,
            int housesPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();
    }
}
