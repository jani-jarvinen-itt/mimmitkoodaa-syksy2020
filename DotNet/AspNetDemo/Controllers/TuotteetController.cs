using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDemo.Controllers
{
    public class Tuote
    {
        public int Id { get; set; }

        public string Nimi { get; set; }

        public double Hinta { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class TuotteetController : ControllerBase
    {
        public List<Tuote> KaikkiTuotteet()
        {
            List<Tuote> tuotteet = new List<Tuote>()
            {
                new Tuote()
                {
                    Id = 1000,
                    Nimi = "Punainen omena",
                    Hinta = 2.5
                },
                new Tuote()
                {
                    Id = 1010,
                    Nimi = "Mandariini",
                    Hinta = 1.8
                }
            };

            return tuotteet;
        }


        /*
        public int Luku()
        {
            return 123;
        }
        */
    }
}
