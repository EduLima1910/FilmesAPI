﻿using AutoMapper;
using FilmesApi.Data;
using FilmesAPI.Data.Dtos.Sessao;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoController(AppDbContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;

        }

        [HttpPost]

        public IActionResult AdicionarSessao(CreateSessaoDto dto)
        {

            Sessao sessao = _mapper.Map<Sessao>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { id = sessao.Id }, sessao);

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {

            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);

            if (sessao != null)
            {

                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return Ok(sessaoDto);

            }
            return NotFound();

        }

    }
}
