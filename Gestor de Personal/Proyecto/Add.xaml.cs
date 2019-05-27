using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        
        Empleados e1;
        public Add()
        {
            InitializeComponent();
        }

        
        public Empleados DevolverEmpleado()
        {
            e1 = new Empleados();    
               
                e1.Nombre = txtNombre.Text;  
                e1.Apellidos = txtApellidos.Text;
                e1.Dni = txtDni.Text;
                e1.Antiguedad = int.Parse(txtAntiguedad.Text);
                e1.Edad = int.Parse(txtEdad.Text);
                e1.Baja = (bool)chkBaja.IsChecked;
                e1.Vacaciones = (bool)chkVacaciones.IsChecked;
                e1.Activo = (bool)chkActivo.IsChecked;
          
                return e1;
            
            
        }

      
        public void Añadir(object sender, RoutedEventArgs e)
        {
            string varDNI;
            string varNombre;
            string varApellidos;
            int varEdad;
            int varAntiguedad;
            

           

            if (!(txtDni.Text.Length <= 0))
            {
                varDNI = txtDni.Text;
            }
            else
            {
                varDNI = "null";
            }
            if (!(txtNombre.Text.Length <= 0))
            {
                varNombre = txtNombre.Text;
            }
            else
            {
                varNombre = "null";
            }
            if (!(txtApellidos.Text.Length <= 0))
            {
                varApellidos = txtApellidos.Text;
            }
            else
            {
                varApellidos = "null";
            }
            if (!(txtEdad.Text.Length <= 0))
            {
                if (!(txtEdad.Text.Equals("")))
                {

                    varEdad = int.Parse(txtEdad.Text);
                }
                else
                {
                    varEdad = 0;
                }
            }
            else
            {
                varEdad = 0;
            }
            if (!(txtAntiguedad.Text.Length <= 0))
            {
                varAntiguedad = int.Parse(txtAntiguedad.Text);
            }
            else
            {
                varAntiguedad = 0;
            }

            conexionDb.GetSqlConexion();
            string query = "insert into [dbo].[Table] (DNI,Nombre,Apellidos,Edad,Antiguedad,Activo,Baja,Vacaciones) values('" +varDNI+ "','" +varNombre+"','"+varApellidos+"','"+varEdad+"','"+varAntiguedad+"','"+(bool)chkActivo.IsChecked + "','" + (bool)chkBaja.IsChecked + "','" + (bool)chkVacaciones.IsChecked + "')";
            conexionDb.ejecutarSql(query);
            conexionDb.CerrarConexionDB();
          
            this.Close() ;
          
        }

      

        private void TxtId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "." && isNumber(e.Text) == false) {

                e.Handled = true;
            }
            else if (e.Text==".") {
                if (((TextBox)sender).Text.IndexOf(e.Text) >-1) {
                    e.Handled = true;
                }

            }

        }
        public bool isNumber(string cadena) {

            int output;
            return int.TryParse(cadena, out output);

            

        }

     
    }
}
