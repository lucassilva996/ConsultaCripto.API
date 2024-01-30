using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultaCripto.Domain.Entities;
using ConsultaCripto.Domain.Entities.Response;
namespace ConsultaCripto.Application.Interfaces.Repositories
{
    public interface ICriptoRepository
    {
        Task<CriptoApiResponse> ConsultaAllCriptos();
    }
}