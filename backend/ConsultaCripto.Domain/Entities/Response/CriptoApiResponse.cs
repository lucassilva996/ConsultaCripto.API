using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCripto.Domain.Entities.Response
{
    public class CriptoApiResponse
    {
        public CriptoInfo data { get; set; }
        public List<CriptoInfo> dataList { get; set; }

    }
}