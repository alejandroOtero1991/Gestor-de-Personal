using System;
using System.Collections.Generic;
using System.Collections;
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
        private int edad, antiguedad,idEmpresa;
        private bool activo, baja, vacaciones;
       

        public string Nombre {

            get { return nombre; }
            set {
                nombre = value;
                if (String.IsNullOrEmpty(value)) {
                    value = "nombre incorrecto";
                    
                    //   throw new ApplicationException("Campo nombre necesario");
                }

            }

        }

        public int Edad {

            get { return edad; }

            set {
                
                if (!Int32.TryParse(value.ToString(),out edad)) {
                    value=0;
                    //  throw new ApplicationException("Numero introducido no valido"); 
                }

            }
        }

        public int IdEmpresa
        {

            get { return idEmpresa; }

            set
            {

                if (!Int32.TryParse(value.ToString(), out idEmpresa))
                {
                    value = 0;
                    //  throw new ApplicationException("Numero introducido no valido"); 
                }

            }
        }

        public string Dni {
            get { return dni; }

            set {
                dni = value;
                if (value.Length <= 0 || value.Length > 9) {
                     value="cadena no valida";
                   // throw new ApplicationException("Dni introducido no valido");
                }
            }
        }
      
        public string Apellidos
        {

            get { return apellidos; }
            set
            {
                apellidos = value;
                if (String.IsNullOrEmpty(value))
                {
                    value = "cadena no valida";

                    //   throw new ApplicationException("Campo apellidos necesario");
                }

            }

        }

    

        public int Antiguedad
        {

            get { return antiguedad; }

            set
            {

                if (!Int32.TryParse(value.ToString(), out antiguedad))
                {

                    value = 0;
                   // throw new ApplicationException("Numero introducido no valido");
                }

            }
        }

        public bool Activo { get => activo; set => activo = value; }
        public bool Baja { get => baja; set => baja = value; }
        public bool Vacaciones { get => vacaciones; set => vacaciones = value; }

        public Empleados( String nombre, String apellidos, String dni, int edad, int antiguedad)
        {
            
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.apellidos = dni;
            this.antiguedad = antiguedad;
        }
        public Empleados()
        {
            this.idEmpresa = 1;
            this.nombre = "";
            this.apellidos = "";
            this.dni = "";
            this.edad = 0;
            this.antiguedad = 0;
        }

       
    }
}
