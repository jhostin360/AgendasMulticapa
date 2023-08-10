using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class E_Agenda
    {
        //props

        private int _Id_agenda;
        private String _Nombre_agenda;
        private String _Apellido_agenda;
        private String _Fecha_agenda;
        private String _Direccion_agenda;
        private String _Genero_agenda;
        private String _EstadoCivil_agenda;
        private String _Movil_agenda;
        private String _Telefono_agenda;
        private String _Correo_agenda;

        //gets y sets

        public int Id_agenda { get => _Id_agenda; set => _Id_agenda = value; }
        public string Nombre_agenda { get => _Nombre_agenda; set => _Nombre_agenda = value; }
        public string Apellido_agenda { get => _Apellido_agenda; set => _Apellido_agenda = value; }
        public string Fecha_agenda { get => _Fecha_agenda; set => _Fecha_agenda = value; }
        public string Direccion_agenda { get => _Direccion_agenda; set => _Direccion_agenda = value; }
        public string Genero_agenda { get => _Genero_agenda; set => _Genero_agenda = value; }
        public string EstadoCivil_agenda { get => _EstadoCivil_agenda; set => _EstadoCivil_agenda = value; }
        public string Movil_agenda { get => _Movil_agenda; set => _Movil_agenda = value; }
        public string Telefono_agenda { get => _Telefono_agenda; set => _Telefono_agenda = value; }
        public string Correo_agenda { get => _Correo_agenda; set => _Correo_agenda = value; }
    }
}
