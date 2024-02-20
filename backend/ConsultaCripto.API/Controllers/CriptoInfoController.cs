using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultaCripto.Application.Interfaces.Repositories;
using ConsultaCripto.Domain.Entities;
using ConsultaCripto.Domain.Entities.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCripto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CriptoInfoController : ControllerBase
    {
        private readonly ICriptoRepository _criptoRepository;

        public CriptoInfoController(ICriptoRepository criptoRepository)
        {
            _criptoRepository = criptoRepository;
        }


        [HttpGet("GetAllCriptoInfo")]
        public async Task<List<CriptoInfo>> GetAllCriptoInfo()
        {
            var criptoInfoResponse = await _criptoRepository.ConsultaAllCriptos();
            return criptoInfoResponse;
        }

        [HttpGet("GetCriptoById")]
        public async Task<CriptoInfo> GetCriptoById(string id)
        {
            var criptoInfoResponse = await _criptoRepository.ConsultaCriptosById(id);
            return criptoInfoResponse;
        }
    }
}