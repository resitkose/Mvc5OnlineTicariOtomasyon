using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5OnlineTicariOtomasyon.Models.Siniflar
{
    public class DinamikFaturalarClass
    {
        public IEnumerable<Fatura> fatura { get; set; }
        public IEnumerable<FaturaKalem> faturaKalem { get; set; }
    }
}