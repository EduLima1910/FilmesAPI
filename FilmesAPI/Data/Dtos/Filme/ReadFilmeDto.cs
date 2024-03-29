﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Filme
{
    public class ReadFilmeDto
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode ter mais de 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deveter de 1 a 600 minutos.")]
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
        public DateTime HoraDaConsulta { get; set; }

    }
}
