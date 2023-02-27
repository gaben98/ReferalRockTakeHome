using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReferralRock;

public class BasicHttpClient
{
    private HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    public BasicHttpClient(HttpClient client, IConfiguration configuration) => 
    (_httpClient, _configuration) = (client, configuration);

    public async Task<T?> GetAsync<T>(string requestURI)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://api.referralrock.com" + requestURI);
        SetAuthentication(ref request);
        var response = await _httpClient.SendAsync(request);
        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<T?> PostAsync<T, U>(string requestURI, U content)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "https://api.referralrock.com" + requestURI);
        SetAuthentication(ref request);
        request.Content = JsonContent.Create(content);
        var response = await _httpClient.SendAsync(request);
        return await response.Content.ReadFromJsonAsync<T>();
    }

    private void SetAuthentication(ref HttpRequestMessage message)
    {
        var authenticationString = $"{_configuration["API:PublicKey"]}:{_configuration["API:PrivateKey"]}";
        var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString));
        message.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
    }
}
