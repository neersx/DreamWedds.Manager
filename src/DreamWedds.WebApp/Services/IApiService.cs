using DreamWedds.Manager.Application.Blogs;
using DreamWedds.Manager.Application.Common.Models;
using DreamWedds.Manager.Application.Contact;
using DreamWedds.Manager.Application.FaqModel;
using DreamWedds.Manager.Application.Template;
using Newtonsoft.Json;
using System.Text;

namespace DreamWedds.WebApp.Services;

public interface IApiService
{
    Task<PaginationResponse<TemplateDto>> GetWeddingTemplatesAsync(SearchTemplateRequest request);
    Task<TemplateDto> GetTemplateByNameAsync(string name);
    Task<PaginationResponse<BlogDto>> GetBlogsAsync(SearchBlogRequest request);
    Task<BlogDto> GetBlogByNameAsync(string name);
    Task<Guid> SubmitContactUsRequest(ContactUsRequest request);
    Task<PaginationResponse<FaqDto>> GetFaqsAsync(SearchFaqRequest request);
}

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://localhost:5001/api");
    }
    public async Task<PaginationResponse<TemplateDto>> GetWeddingTemplatesAsync(SearchTemplateRequest request)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_httpClient.BaseAddress}/v1/templates/search", content);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PaginationResponse<TemplateDto>>(responseContent);
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error calling third-party API.", ex);
        }
    }

    public async Task<PaginationResponse<BlogDto>> GetBlogsAsync(SearchBlogRequest request)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_httpClient.BaseAddress}/v1/blogs/search", content);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PaginationResponse<BlogDto>>(responseContent);
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error getting blogs data.", ex);
        }
    }

    public async Task<BlogDto> GetBlogByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}/v1/blogs/{name}");
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BlogDto>(responseContent);
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error getting blogs data.", ex);
        }
    }

    public async Task<TemplateDto> GetTemplateByNameAsync(string name)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}/v1/templates/{name}");
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TemplateDto>(responseContent);
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error getting blogs data.", ex);
        }
    }

    public Task<DefaultIdType> SubmitContactUsRequest(ContactUsRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<PaginationResponse<FaqDto>> GetFaqsAsync(SearchFaqRequest request)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_httpClient.BaseAddress}/v1/faq/search", content);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PaginationResponse<FaqDto>>(responseContent);
        }
        catch (HttpRequestException ex)
        {
            // Handle API call exception
            throw new Exception("Error getting blogs data.", ex);
        }
    }
}
