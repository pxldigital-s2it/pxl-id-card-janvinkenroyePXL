namespace StudentCard.SharedLibrary.Services;

public interface IRestService<TModel>
{
    Task<List<TModel>> RefreshDataAsync();

    Task SaveAsync(TModel item, bool isNewItem);

    Task DeleteAsync(int id);
}
