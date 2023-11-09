using Workshop.Api.Dal.Entities;

namespace Workshop.Api.Bll.Services.Interfaces;

public interface IGoodsService
{
    IEnumerable<GoodEntity> GetGoods();
}