using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyDakar.Dominio.Entidades
{
    public class Temporada
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public virtual ICollection<Equipe> Equipes { get; set; }

        public Temporada()
        {
            Equipes = new List<Equipe>();
        }

        public void AdicionarEquipe(Equipe equipe)
        {
            if (equipe != null)
                if (!String.IsNullOrEmpty(equipe.Nome))
                    Equipes.Add(equipe);
        }
    }
}
