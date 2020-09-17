using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain {
    public class Livro {
        public int Id { get; set; } 
        [Required]
        public String Titulo { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        public string Ano { get; set; }
        [JsonIgnore]
        public virtual Autor Autor { get; set; }
    }
    public class LivroResponse {
        public int Id { get; set; }
        [Required]
        public String Titulo { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        public string Ano { get; set; }
        public virtual Autor Autor { get; set; }
    }

}
