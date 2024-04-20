using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForm
{
    public static class API
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string?> GetCountryName(string countryCode)
        {
            try
            {
                var content = new StringContent($"countryCode={countryCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getCountryName", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public static async Task<string?> GetHarborName(string countryCode, string harborCode)
        {
            try
            {
                var content = new StringContent($"countryCode={countryCode}&harborCode={harborCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getHarborName", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public static async Task<string?> GetTaxRate(string itemId)
        {
            try
            {
                var content = new StringContent($"itemId={itemId}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getTaxRate", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public static async Task<string?> GetBarangDetail(string hsCode)
        {
            try
            {
                var content = new StringContent($"hsCode={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getBarangDetail", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public static async Task<string?> GetTaxRatePercent(string hsCode)
        {
            try
            {
                var content = new StringContent($"hsCode={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getTaxRatePercent", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public static async Task<string?> GetTaxRateRupiah(string hsCode)
        {
            try
            {
                var content = new StringContent($"hsCode={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = await client.PostAsync("https://api.example.com/getTaxRateRupiah", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }
    }
}
