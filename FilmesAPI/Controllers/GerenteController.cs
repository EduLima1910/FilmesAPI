﻿using AutoMapper;
using FilmesApi.Data;
using FilmesAPI.Data.Dtos.Gerente;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class GerenteController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        [HttpPost]

        public IActionResult AdicionarGerente(CreateGerenteDto dto)
        {

            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { id = gerente.Id }, gerente);

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {

            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);

            if (gerente != null)
            {

                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(gerenteDto);

            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public IActionResult DelataGerente(int id)
        {

            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);

            if (gerente == null)
            {

                return NotFound();

            }
            _context.Remove(gerente);
            _context.SaveChanges();
            return NoContent();

        }

    }
}
