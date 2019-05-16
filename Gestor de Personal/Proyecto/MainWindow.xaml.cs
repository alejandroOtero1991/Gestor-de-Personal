using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        String dbConectionString = "@Data Source= Database1.mdf";
        public MainWindow()
        {
            InitializeComponent();
        }

        Add ventanaAñadir;

       

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ventanaAñadir = new Add();
            ventanaAñadir.ShowDialog();

            ListaEmpleados.Items.Add(ventanaAñadir.DevolverEmpleado());

        }
      
        

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (ListaEmpleados.SelectedIndex > -1)
            {
                ListaEmpleados.Items.RemoveAt(ListaEmpleados.SelectedIndex);
            }
        }


        private void ListaEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            var item = (ListBox)sender;
            Empleados e1 = (Empleados)item.SelectedItem;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
