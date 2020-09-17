using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain {
    public class Autor {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Email { get; set; }
        public DateTime Birth { get; set; }
        public virtual IList<Livro> Livros { get; set; }
    }
    public class AutorResponse {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Sobrenome { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        public virtual IList<Livro> Livros { get; set; }
    }
}
