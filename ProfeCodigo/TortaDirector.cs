using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfeCodigo
{
    internal class TortaDirector
    {
        public void constructTortaSencilla(Builder builder)
        {
            builder.setPan("Telera");
            builder.setFrijoles("Bayos");
            builder.setQueso("Panela");
            builder.setIngredientes(new string[]{ "Sin ingredientes extra"});
        }
        public void constructTortaDeMilanesa(Builder builder)
        {
            builder.setPan("Telera");
            builder.setFrijoles("Bayos");
            builder.setQueso("Panela");
            builder.setIngredientes(new string[] { "Milanesa" });
        }

        public void constructTortaTapaAerterias(Builder builder)
        {
            builder.setPan("Telera");
            builder.setFrijoles("Bayos");
            builder.setQueso("Panela");
            builder.setIngredientes(new string[] { "Milanesa Empanizada", "Jamon", "Tocino", "Chorizo", "Salami", "Lechiga", "Salsa Verde", "Salsa Roja"});
        }

        public void constructTortaPerzonalizada(Builder builder, string pan, string frijoles, string queso, string [] extras)
        {
            builder.setPan(pan);
            builder.setFrijoles(frijoles);
            builder.setQueso(queso);
            builder.setIngredientes(extras);
        }
    }
}
