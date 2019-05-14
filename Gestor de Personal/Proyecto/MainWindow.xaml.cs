using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();    
        }
    

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            Add ventanaAñadir = new Add();
            ventanaAñadir.ShowDialog();
            ListaEmpleados.Items.Add(ventanaAñadir.DevolverEmpleado().Nombre);

        }

        private void ListBoxItem_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
