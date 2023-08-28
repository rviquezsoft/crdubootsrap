namespace CRUDBLAZOR.Services
{
    public interface IFillMockData
    {
        Task<List<Elemento>> FillData();
    }
}