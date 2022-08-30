using Microsoft.VisualBasic;
using StudentCard.SharedLibrary;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace StudentCard.SharedLibrary.Services;

public class RestService<TDto> : IRestService<TDto>
{
    private HttpClient _client;
    private JsonSerializerOptions _serializerOptions;

    public List<TDto>? Items { get; private set; }

    public RestService()
    {
        _client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
    }

    public async Task<List<TDto>> RefreshDataAsync()
    {
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        Items = new List<TDto>();

        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonSerializer.Deserialize<List<TDto>>(content, _serializerOptions)
                    ?? throw new NullReferenceException();
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
        return Items;
    }

    public async Task SaveAsync(TDto item, bool isNewItem)
    {
        Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

        try
        {
            string json = JsonSerializer.Serialize(item, _serializerOptions);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            if (isNewItem)
                response = await _client.PostAsync(uri, content);
            else
                response = await _client.PutAsync(uri, content);

            if (response.IsSuccessStatusCode)
                Debug.WriteLine(@"\tTodoItem successfully saved.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }
    public async Task DeleteAsync(int id)
    {
        Uri uri = new Uri(string.Format(Constants.RestUrl, id));

        try
        {
            HttpResponseMessage response = await _client.DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
                Debug.WriteLine(@"\tTodoItem successfully deleted.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
    }
}
