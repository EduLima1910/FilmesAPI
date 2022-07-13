﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FilmeController : ControllerBase
    {

        private static List<Filme> filmes = new List<Filme>();

        private static int id = 1;

        [HttpPost]

        public void Adicionafilme([FromBody]Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {

            return filmes;

        }

    }
}
