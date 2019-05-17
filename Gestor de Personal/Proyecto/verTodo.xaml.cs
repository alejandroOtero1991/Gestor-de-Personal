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
using System.Data.SqlClient;
using System.Data;


namespace Proyecto
{
    /// <summary>
    /// Interaction logic for verTodo.xaml
    /// </summary>
    public partial class verTodo : Window
    {
        public verTodo()
        {
            InitializeComponent();
        }

        private void LoadTable_Click(object sender, RoutedEventArgs e)
        {
            conexionDb.GetSqlConexion();
            gridTabla.ItemsSource = conexionDb.GetTable("Select * from [dbo].[Table]").DefaultView;
            conexionDb.CerrarConexionDB();
           
        }
    }
}
