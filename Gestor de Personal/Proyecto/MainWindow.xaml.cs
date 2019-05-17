﻿using System;
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
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {



        
        
        public MainWindow()
        {

            InitializeComponent();
           
            conexionDb.GetSqlConexion();
            DataTable dt = conexionDb.GetTable("select Nombre from [dbo].[Table]");
            ListaEmpleados.ItemsSource = dt.AsDataView();
            dt.AcceptChanges();
            conexionDb.CerrarConexionDB();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        Add ventanaAñadir;
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ventanaAñadir = new Add();
            ventanaAñadir.ShowDialog();
            
        
          
        }
      
        

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {

            if (ListaEmpleados.SelectedIndex > -1) {

                ListaEmpleados.Items.RemoveAt(ListaEmpleados.SelectedIndex);
            }
        }



       

        private void VerTodo_Click(object sender, RoutedEventArgs e)
        {
            verTodo vt = new verTodo();
            vt.ShowDialog();
        }
    }
}
