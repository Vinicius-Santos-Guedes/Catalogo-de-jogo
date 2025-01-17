﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaodeDependencia.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength (100, MinimumLength = 3,ErrorMessage ="O nome do jogo deve conter entre 3 a 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 a 100 caracteres")]

        public string Produtora { get; set; }
        [Required]
        [Range(1,1000, ErrorMessage = "O nome do jogo deve conter entre 3 a 100 caracteres preço deve ser no minimo 1 real e no maximp 1000 reais")]

        public double Preco { get; set; }
    }
}
