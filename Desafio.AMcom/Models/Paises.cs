using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.AMcom.Models
{
    public class Paises
    {
        public string gentilico { get; set; }
        public string nome_pais { get; set; }
        public string nome_pais_int { get; set; }
        public string sigla { get; set; }

        public List<Paises> PaisesAll()
        {
           using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory()+@"\paises.json"))
           {
                var json = r.ReadToEnd();
                List<Paises> ListaPaises = JsonConvert.DeserializeObject<List<Paises>>(json);
                return ListaPaises;
           }
        }
    }
}
