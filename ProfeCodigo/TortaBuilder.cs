using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfeCodigo
{
    internal class TortaBuilder : Builder
    {
        private string pan;
        private string frijoles;
        private string queso;
        private string[] ingredientes;

        public void setFrijoles(string frijoles)
        {
            this.frijoles = frijoles;
        }

        public void setIngredientes(string[] ingredientes)
        {
            this.ingredientes = ingredientes;
        }

        public void setPan(string pan)
        {
            this.pan = pan;
        }

        public void setQueso(string queso)
        {
            this.queso = queso;
        }

        public Torta getResult()
        {
            return new Torta(pan, frijoles, queso, ingredientes);
        }
    }
}
