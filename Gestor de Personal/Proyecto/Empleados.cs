using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Empleados
    {

        private String nombre;
        private String apellidos;
        private String dni;
        private int edad, antiguedad;
        private bool activo, baja, vacaciones;


        public Empleados(String nombre, String apellidos, String dni, int edad, int antiguedad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.apellidos = dni;
            this.antiguedad = antiguedad;
        }
        public Empleados()
        {
            this.nombre = "";
            this.apellidos = "";
            this.dni = "";
            this.edad = 0;
            this.antiguedad = 0;
        }

    }
}
