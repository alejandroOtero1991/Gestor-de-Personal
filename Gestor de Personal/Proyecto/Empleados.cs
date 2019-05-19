using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Proyecto
{
  public  class Empleados : System.ComponentModel.INotifyPropertyChanged
    {

        private String nombre;
        private String apellidos;
        private String dni;
        private int edad, antiguedad,idEmpresa;
        private bool activo, baja, vacaciones;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nombre {

            get { return nombre; }
            set {
                nombre = value;
                if (String.IsNullOrEmpty(value))
                {
                    nombre = "nombre incorrecto";


                }
                else {
                    nombre = value;
                    OnPropertyChanged("Nombre");
                }

            }

        }

        public int Edad {

            get { return edad; }

            set {

                if (!Int32.TryParse(value.ToString(), out edad))
                {
                    edad = 0;
                }
                else {
                    edad = value;
                    OnPropertyChanged("Edad");

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
                    idEmpresa = 0;

                }
                else {
                    idEmpresa = value;
                    OnPropertyChanged("IdEmpresa");
                }

            }
        }

        public string Dni {
            get { return dni; }

            set {
                dni = value;
                if (value.Length <= 0 || value.Length > 9)
                {
                    dni = "cadena no valida";
                }
                else {
                    dni = value;
                    OnPropertyChanged("Dni");
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
                    apellidos = "cadena no valida";


                }
                else {
                    apellidos = value;
                    OnPropertyChanged("Apellidos");

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

                    antiguedad = 0;

                }
                else {
                    antiguedad = value;
                    OnPropertyChanged("Antiguedad");
                }

            }
        }

        public bool Activo { get => activo; set => activo = value; }
        public bool Baja { get => baja; set => baja = value; }
        public bool Vacaciones { get => vacaciones; set => vacaciones = value; }

        protected void OnPropertyChanged(String propiedad) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler!=null) {
                handler(this, new PropertyChangedEventArgs(propiedad));
            }

        }

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
