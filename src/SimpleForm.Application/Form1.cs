using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleForm
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async void generateResult_Click(object sender, EventArgs e)
        {
            string countryCode = countryInput.Text.Substring(0, 3).ToUpper();
            string harborCode = harborOrigin.Text.Substring(0, 3).ToUpper();

            if (!itemId.Text.All(char.IsDigit) || !priceInput.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please input only numbers for Item ID and Price!");
                return;
            }

            int itemIdValue = int.Parse(itemId.Text);
            int itemPrice = int.Parse(priceInput.Text);

            try
            {
                string countryName = await GetCountryName(countryCode);
                string harborName = await GetHarborName(countryCode, harborCode);

                string barangKode = this.barangKode.Text; 
                string barangJenis = this.barangJenis.Text;

                string taxRatePercent = await GetTaxRatePercent("10079000");
                string taxRateRupiah = await GetTaxRateRupiah("10079000");

                ShowResults(countryName, harborName, itemIdValue, itemPrice, barangKode, barangJenis, taxRatePercent, taxRateRupiah);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task<string> GetCountryName(string countryCode)
        {
            var content = new StringContent($"ur_negara={countryCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.PostAsync("https://insw-dev.ilcs.co.id/n/negara", content);
            response.EnsureSuccessStatusCode();
            string countryName = await response.Content.ReadAsStringAsync();
            return countryName;
        }

        private async Task<string> GetHarborName(string countryCode, string harborCode)
        {
            var content = new StringContent($"kd_negara={countryCode}&ur_pelabuhan={harborCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.PostAsync("https://insw-dev.ilcs.co.id/n/pelabuhan", content);
            response.EnsureSuccessStatusCode();
            string harborName = await response.Content.ReadAsStringAsync();
            return harborName;
        }

        private async Task<string> GetBarangDetail(string hsCode)
        {
            var content = new StringContent($"hs_code={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.PostAsync("https://insw-dev.ilcs.co.id/n/barang", content);
            response.EnsureSuccessStatusCode();
            string barangDetail = await response.Content.ReadAsStringAsync();
            return barangDetail;
        }

        private async Task<string> GetTaxRatePercent(string hsCode)
        {
            var content = new StringContent($"hs_code={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.PostAsync("https://insw-dev.ilcs.co.id/n/tarif", content);
            response.EnsureSuccessStatusCode();
            string taxRateJson = await response.Content.ReadAsStringAsync();

            string taxRatePercent = taxRateJson.Split(',')[2].Split(':')[1].Trim().Trim('"');
            return taxRatePercent;
        }

        private async Task<string> GetTaxRateRupiah(string hsCode)
        {
            var content = new StringContent($"hs_code={hsCode}", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.PostAsync("https://insw-dev.ilcs.co.id/n/tarif", content);
            response.EnsureSuccessStatusCode();
            string taxRateJson = await response.Content.ReadAsStringAsync();

            string taxRateRupiah = taxRateJson.Split(',')[3].Split(':')[1].Trim().Trim('"');
            return taxRateRupiah;
        }

        private void ShowResults(string countryName, string harborName, int itemId, int itemPrice, string barangKode, string barangJenis, string taxRatePercent, string taxRateRupiah)
        {
            negaraLabel.Text = countryName;
            pelabuhanLabel.Text = harborName;
            barangKodeLabel.Text = barangKode;
            barangJenisLabel.Text = barangJenis;
            hargaLabel.Text = itemPrice.ToString();
            tarifBeaMasuk1Label.Text = taxRatePercent;
            tarifBeaMasuk2Label.Text = taxRateRupiah;

            resultLabel.Visible = true;
            negaraLabel.Visible = true;
            pelabuhanLabel.Visible = true;
            barangKodeLabel.Visible = true;
            barangJenisLabel.Visible = true;
            hargaLabel.Visible = true;
            tarifBeaMasuk1Label.Visible = true;
            tarifBeaMasuk2Label.Visible = true;
        }
    }
}
