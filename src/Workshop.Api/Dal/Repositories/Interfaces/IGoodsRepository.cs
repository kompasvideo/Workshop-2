using Workshop.Api.Dal.Entities;

namespace Workshop.Api.Dal.Repositories.Interfaces;

public interface IGoodsRepository
{
    void AddOrUpdate(GoodEntity entity);
    ICollection<GoodEntity> GetAll();
    GoodEntity Get(int id);
}