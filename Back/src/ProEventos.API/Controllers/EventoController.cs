using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase 
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 dotnet 5",
                    Local ="Sergipe",
                    Lote = "1 Lote",
                    QtdPessoas = 250                
                },
                 new Evento() {
                    EventoId = 2,
                    Tema = "Angular 11 dotnet 5",
                    Local ="Brasil",
                    Lote = "1 Lote",
                    QtdPessoas = 250                
                }
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        

        [HttpPost]
        public string Post()
        {
            return "value Post";
        }

        
         [HttpPut("{id}")]
        public string Put( int id)
        {
            return $"value Put com id = {id}";
        }

       [HttpDelete("{id}")]
        public string Delete( int id)
        {
            return $"value Delete com id = {id}";
        }

    }
}
