using Proyecto;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListaEmpleados
{
    class ItemsSource2
    {
        
        // Bind ArrayList with the ListBox    
        private ObservableCollection<Empleados> LoadListBoxData2()
        {
            Add ventanaAñadir = new Add();
            ObservableCollection<Empleados> listacompleta = new ObservableCollection<Empleados>();
            listacompleta.Add(ventanaAñadir.DevolverEmpleado());
            return listacompleta;
        }
        
    }
}