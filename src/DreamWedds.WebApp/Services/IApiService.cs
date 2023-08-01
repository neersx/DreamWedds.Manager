using DreamWedds.Manager.Application.Common.Models;
using DreamWedds.Manager.Application.Template;
using Newtonsoft.Json;

namespace DreamWedds.WebApp.Services;

public interface IApiService
{
    Task<PaginationResponse<TemplateDto>> GetWeddingTemplatesAsync(SearchTemplateRequest request);
}

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://localhost:5001/v1");
    }
    public async Task<PaginationResponse<TemplateDto>> GetWeddingTemplatesAsync(SearchTemplateRequest request)
    {
        try
        {
            var response = await _httpClient.GetAsync("https://localhost:5001/v1/template/search");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<PaginationResponse<TemplateDto>>(responseContent);
            return apiResponse;
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error calling third-party API.", ex);
        }
    }
}
