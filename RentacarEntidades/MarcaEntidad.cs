using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
   public class MarcaEntidad
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public List<AutoEntidad> ListaAutos { get => listaAutos; set => listaAutos = value; }

        private List<AutoEntidad> listaAutos;



        /*
           public List<Materia> listaMaterias 
        {
            get 
            {
                if (listaMaterias == null)
                {
                    listaMaterias = new List<Materia>();
                }
                return listaMaterias;
            }
            set 
            {
                listaMaterias = value;
            }
        }
         * */
    }
}
