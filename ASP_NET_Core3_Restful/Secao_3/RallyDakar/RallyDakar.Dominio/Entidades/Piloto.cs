using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyDakar.Dominio.Entidades
{
    public class Piloto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EquipeId { get; set; }

        public virtual Equipe Equipe { get; set; }
    }
}
