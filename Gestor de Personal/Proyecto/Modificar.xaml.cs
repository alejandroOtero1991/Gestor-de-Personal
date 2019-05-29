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

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {

        Empleados e1;
        public Modificar()
        {
            InitializeComponent();
            gridTablaModificar.ItemsSource = conexionDb.GetTable("Select * from [dbo].[Table]").DefaultView;
        }
        public Empleados DevolverEmpleado()
        {

            
            e1 = new Empleados();
         
               
                e1.Nombre = txtNombreM.Text;
                e1.Apellidos = txtApellidosM.Text; 
                e1.Dni = txtDniM.Text;
                e1.Antiguedad = int.Parse(txtAntiguedadM.Text);
                e1.Edad = int.Parse(txtEdadM.Text);
                e1.Baja = (bool)chkBajaM.IsChecked;
                e1.Vacaciones = (bool)chkVacacionesM.IsChecked;
                e1.Activo = (bool)chkActivoM.IsChecked;
            
            return e1;


        }

        private void BtnCrearM_Click(object sender, RoutedEventArgs e)
        {
            
            string vDNI;
            string vNombre;
            string vApellidos;
            int vEdad;
            int vAntiguedad;
            int vIdSeleccionar;
            
            if (!(txtIdSeleccionar.Text.Length <= 0))
            {
                vIdSeleccionar = int.Parse(txtIdSeleccionar.Text);
            }
            else {
                vIdSeleccionar=0;
            }
            
            if (!(txtDniM.Text.Length <=0)) {
                 vDNI = txtDniM.Text;
            }else
            {
                vDNI = "null";
            }
            if (!(txtNombreM.Text.Length <=0))
            {
                vNombre = txtNombreM.Text;
            }
            else {
                vNombre = "null";
            }
            if (!(txtApellidosM.Text.Length <=0))
            {
                 vApellidos = txtApellidosM.Text;
            }
            else{
                vApellidos = "null";
            }
            if (!(txtEdadM.Text.Length <=0))
            {
                if (!(txtEdadM.Text.Equals("")))
                {
                    
                    vEdad = int.Parse(txtEdadM.Text);
                }
                else {
                    vEdad = 0;
                }
            }
            else {
                vEdad = 0;
            }
            if (!(txtAntiguedadM.Text.Length <=0))
            {
                 vAntiguedad = int.Parse(txtAntiguedadM.Text);
            }
            else
            {
                vAntiguedad = 0;
            }
            if (!(txtAntiguedadM.Text.Length <= 0 || txtApellidosM.Text.Length <= 0 || txtDniM.Text.Length <= 0 || txtEdadM.Text.Length <= 0 || txtNombreM.Text.Length <= 0 || txtIdSeleccionar.Text.Length <= 0))
            {
                conexionDb.GetSqlConexion();
                string query = "update [dbo].[Table] set DNI='" + vDNI + "'," +
               "Nombre='" + vNombre + "',Apellidos='" + vApellidos + "',Edad='" + vEdad + "',Antiguedad='" + vAntiguedad + "',Activo='" + (bool)chkActivoM.IsChecked + "'," +
               "Baja='" + (bool)chkBajaM.IsChecked + "',Vacaciones='" + (bool)chkVacacionesM.IsChecked + "'where id='" + vIdSeleccionar + "'";
                conexionDb.ejecutarSql(query);
                conexionDb.CerrarConexionDB();
                this.Close();
            }
            else {
                this.Close();
            }
            

        }

        private void TxtIdM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int asci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (e.Text != "." && isNumber(e.Text) == false ||e.Text==null)
            {

                e.Handled = true;
            }
           
          
            if (!(asci >= 48 && asci <= 57))
            {
                e.Handled = true;
            }


        }
        public bool isNumber(string cadena)
        {

            int output;
            return int.TryParse(cadena, out output);



        }

      
        
    }
}
