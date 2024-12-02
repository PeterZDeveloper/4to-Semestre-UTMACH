using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerdemaquinaria.Entidades
{
    public class Socio
    {
        private int id;
        private String contratoAfilacion;

        public Socio(int id, String ContratoAfilacion)
        {
            this.id = id;
            this.contratoAfilacion = ContratoAfilacion;
        }

        public int Id { get => id; set => id = value; }
        public String ContratoAfilacion { get => contratoAfilacion; set => contratoAfilacion = value; }
   
        
    
    }
}
