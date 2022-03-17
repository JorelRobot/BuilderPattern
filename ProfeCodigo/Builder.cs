using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfeCodigo
{
    internal interface Builder
    {

        public void setPan(string pan);
        public void setFrijoles(string frijoles);
        public void setQueso(string queso);
        public void setIngredientes(string[] ingredientes);
    }
}
