using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain {
    public class Livro {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String ISBN { get; set; }
        public string Ano { get; set; }

        [JsonIgnore]
        public virtual Autor Autor { get; set; }
    }
}
