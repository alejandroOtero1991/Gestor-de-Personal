using Proyecto;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListaEmpleados
{
    class ItemsSource
    {

        // Bind ArrayList with the ListBox    
    

        ObservableCollection<Empleados> itemsList; 

        private ObservableCollection<Empleados> LoadListBoxData()
        {
            Add ventanaAñadir = new Add();
           itemsList = new ObservableCollection<Empleados>();
            itemsList.Add(ventanaAñadir.DevolverEmpleado());
            return itemsList;
        }

     

    }
}