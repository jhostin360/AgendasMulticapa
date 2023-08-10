using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidad;
using Capa_datos;

namespace Capa_negocios
{
    public class N_Agenda
    {

        D_Agenda objDato = new D_Agenda();
        public List<E_Agenda> ListarAgenda(string buscar) {
        
            return objDato.ListarAgenda(buscar);

        }

        public void Insertar(E_Agenda agenda) {
            
            objDato.Insertar(agenda);

        }

        public void Editar(E_Agenda agenda) {

            objDato.Editar(agenda);

        }

        public void Eliminar(E_Agenda agenda) {
        
            objDato.Eliminar(agenda);
        
        }
    }
}
