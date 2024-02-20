using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ConsultaCripto.Application.Interfaces.Repositories;
using ConsultaCripto.Domain.Entities;
using ConsultaCripto.Domain.Entities.Response;

namespace ConsultaCripto.Application.Repositories
{
    public class CriptoRepository : ICriptoRepository
    {
        public async Task<List<CriptoInfo>> ConsultaAllCriptos()
        {
            var httpClient = new HttpClient();
            string url = "http://api.coincap.io/v2/assets";
            HttpResponseMessage response = await httpClient.GetAsync(url);

            string jsonString = await response.Content.ReadAsStringAsync();
            var cryptoApiResponse = JsonSerializer.Deserialize<CriptoApiResponse>(jsonString);
            return cryptoApiResponse.dataList;
        }

        public async Task<CriptoInfo> ConsultaCriptosById(string id)
        {
            var httpClient = new HttpClient();
            string url = "http://api.coincap.io/v2/assets/"+id;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            
            string jsonString = await response.Content.ReadAsStringAsync();
            var cryptoApiResponse = JsonSerializer.Deserialize<CriptoApiResponse>(jsonString);
            
            return cryptoApiResponse.data;
        }
    }
}