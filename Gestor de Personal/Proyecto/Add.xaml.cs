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
            if (txtId.Text.Length < 1)
            {
                e1.IdEmpresa = 0;
            }
            else {
                e1.IdEmpresa = int.Parse(txtId.Text);
            }
            if (txtNombre.Text.Length < 1)
            {

                e1.Nombre = "";
            }
            else {
                e1.Nombre = txtNombre.Text;
            }
            if (txtApellidos.Text.Length <1) {

                e1.Apellidos = "";
            }
            else {
                e1.Apellidos = txtApellidos.Text;
            }
            if (txtDni.Text.Length <1) {
                e1.Dni = "";
            }
            else {
                e1.Dni = txtDni.Text;
            }
            if (txtAntiguedad.Text.Length <1) {
                e1.Antiguedad = 0;
            }
            else {
                e1.Antiguedad = int.Parse(txtAntiguedad.Text);
            }

            if (txtEdad.Text.Length <1) {
                e1.Edad = 0;
            }
            else {
                e1.Edad = int.Parse(txtEdad.Text);
            }
            if (btnCrear.IsEnabled)
            {
                e1.Baja = (bool)chkBaja.IsChecked;
                e1.Vacaciones = (bool)chkVacaciones.IsChecked;
                e1.Activo = (bool)chkActivo.IsChecked;
            }
                return e1;
            
            
        }

      
        public void Añadir(object sender, RoutedEventArgs e)
        {
            
           
            conexionDb.GetSqlConexion();
            string query = "insert into [dbo].[Table] (id,DNI,Nombre,Apellidos,Edad,Antiguedad,Activo,Baja,Vacaciones) values('" + int.Parse(txtId.Text) + "','" + txtDni.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + int.Parse(txtEdad.Text) + "','" + int.Parse(txtAntiguedad.Text) + "','" + (bool)chkActivo.IsChecked + "','" + (bool)chkBaja.IsChecked + "','" + (bool)chkVacaciones.IsChecked + "')";
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
