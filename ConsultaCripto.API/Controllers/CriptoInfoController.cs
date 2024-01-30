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
        public async Task<CriptoApiResponse> GetAllCriptoInfo()
        {
            var criptoInfoResponse = _criptoRepository.ConsultaAllCriptos();
            return await criptoInfoResponse;
        }
    }
}