using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokemonDomain.Entities.Business
{
    public class Trainer
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

    }
}
