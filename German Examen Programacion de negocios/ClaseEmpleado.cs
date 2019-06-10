using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace German_Examen_Programacion_de_negocios
{
    class Clase_Empleado
    {
        string nombreempleado;
        string identidad;
        int horastrabajadas;
        decimal pagoporhoranormaldeltrabajo;
        int horasextrastrabajadas;
        decimal pagoporhoradetrabajoextra;

        //constructor por defecto
        public Clase_Empleado()
        {
            nombreempleado = "German Antonelli";
            identidad = "0318199901720";
            horastrabajadas = 8;
            pagoporhoranormaldeltrabajo = 1500;
            horasextrastrabajadas = 6;
            pagoporhoradetrabajoextra = 1500;
        }

        public string NombreEmpleado
        {
            get
            {
                return nombreempleado;
            }
            set
            {
                nombreempleado = value;
            }
        }

        public string Identidad
        {
            get
            {
                return identidad;
            }
            set
            {
                identidad = value;
            }
        }

        public int HorasTrabajadas
        {
            get
            {
                return horastrabajadas;
            }
            set
            {
                horastrabajadas = value;
            }
        }

        public decimal PagoPorHoraNormalDelTrabajo
        {
            get
            {
                return pagoporhoranormaldeltrabajo;
            }
            set
            {
                pagoporhoranormaldeltrabajo = value;
            }
        }

        public int HorasExtrasTrabajadas
        {
            get
            {
                return horasextrastrabajadas;
            }
            set
            {
                horasextrastrabajadas = value;
            }
        }

        public decimal PagoPorHoraDeTrabajoExtra
        {
            get
            {
                return pagoporhoradetrabajoextra;
            }
            set
            {
                pagoporhoradetrabajoextra = value;
            }
        }


        public void empleado()
        {
            string.Format(Nombre_Empleado);
        }

        public void ID()
        {
            string.Format(Identidad);
        }
    }
}

