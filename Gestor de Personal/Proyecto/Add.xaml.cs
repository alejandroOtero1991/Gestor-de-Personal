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
            e1.IdEmpresa = int.Parse(txtId.Text);
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
            conexionDb.GetSqlConexion();
            string query = "insert into [dbo].[Table] (id,DNI,Nombre,Apellidos,Edad,Antiguedad,Activo,Baja,Vacaciones) values('" + int.Parse(txtId.Text) + "','" + txtDni.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + int.Parse(txtEdad.Text) + "','" + int.Parse(txtAntiguedad.Text) + "','" + (bool)chkActivo.IsChecked + "','" + (bool)chkBaja.IsChecked + "','" + (bool)chkVacaciones.IsChecked + "')";
            conexionDb.ejecutarSql(query);
            conexionDb.CerrarConexionDB();

            DevolverEmpleado();
            this.Close() ;
            
        }

        
    }
}
