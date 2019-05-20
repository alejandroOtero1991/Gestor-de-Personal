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
        }
        public Empleados DevolverEmpleado()
        {


            e1 = new Empleados();
            if (txtIdM.Text.Length < 1)
            {
                e1.IdEmpresa = 0;
            }
            else
            {
                e1.IdEmpresa = int.Parse(txtIdM.Text);
            }
            if (txtNombreM.Text.Length < 1)
            {

                e1.Nombre = "";
            }
            else
            {
                e1.Nombre = txtNombreM.Text;
            }
            if (txtApellidosM.Text.Length < 1)
            {

                e1.Apellidos = "";
            }
            else
            {
                e1.Apellidos = txtApellidosM.Text;
            }
            if (txtDniM.Text.Length < 1)
            {
                e1.Dni = "";
            }
            else
            {
                e1.Dni = txtDniM.Text;
            }
            if (txtAntiguedadM.Text.Length < 1)
            {
                e1.Antiguedad = 0;
            }
            else
            {
                e1.Antiguedad = int.Parse(txtAntiguedadM.Text);
            }

            if (txtEdadM.Text.Length < 1)
            {
                e1.Edad = 0;
            }
            else
            {
                e1.Edad = int.Parse(txtEdadM.Text);
            }
            if (btnCrearM.IsEnabled)
            {
                e1.Baja = (bool)chkBajaM.IsChecked;
                e1.Vacaciones = (bool)chkVacacionesM.IsChecked;
                e1.Activo = (bool)chkActivoM.IsChecked;
            }
            return e1;


        }

        private void BtnCrearM_Click(object sender, RoutedEventArgs e)
        {
            conexionDb.GetSqlConexion();
            string query = "update [dbo].[Table] set id='" + int.Parse(txtIdM.Text) + "',DNI='" + txtDniM.Text + "'," +
           "Nombre='"+txtNombreM.Text+"',Apellidos='"+txtApellidosM.Text+"',Edad='"+ int.Parse(txtEdadM.Text)+"',Antiguedad='"+ int.Parse(txtAntiguedadM.Text)+"',Activo='"+ (bool)chkActivoM.IsChecked + "'," +
           "Baja='"+ (bool)chkBajaM.IsChecked + "',Vacaciones='"+ (bool)chkVacacionesM.IsChecked + "'where id='"+int.Parse(txtIdSeleccionar.Text)+"'";
            conexionDb.ejecutarSql(query);
            conexionDb.CerrarConexionDB();

            this.Close();

        }

        private void TxtIdM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "." && isNumber(e.Text) == false)
            {

                e.Handled = true;
            }
            else if (e.Text == ".")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }

            }

        }
        public bool isNumber(string cadena)
        {

            int output;
            return int.TryParse(cadena, out output);



        }

        private void LoadTableModficar_Click(object sender, RoutedEventArgs e)
        {

            conexionDb.GetSqlConexion();
            gridTablaModificar.ItemsSource = conexionDb.GetTable("Select * from [dbo].[Table]").DefaultView;
            conexionDb.CerrarConexionDB();
        }
    }
}
