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
            DevolverEmpleado();
            this.Close() ;
            
        }





    }
}
