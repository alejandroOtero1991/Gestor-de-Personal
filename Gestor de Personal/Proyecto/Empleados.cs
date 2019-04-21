using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
  public  class Empleados 
    {

        private String nombre;
        private String apellidos;
        private String dni;
        private int edad, antiguedad;
        private bool activo, baja, vacaciones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public bool Activo { get => activo; set => activo = value; }
        public bool Baja { get => baja; set => baja = value; }
        public bool Vacaciones { get => vacaciones; set => vacaciones = value; }

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
