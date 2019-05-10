using Proyecto;
using System.Collections.Generic;

namespace ListaEmpleados
{
    class ItemsSource
    {
        
        // Bind ArrayList with the ListBox    
        private List<Empleados> LoadListBoxData()
        {
            Add ventanaAñadir = new Add();
            List<Empleados> itemsList = new List<Empleados>();
            itemsList.Add(ventanaAñadir.DevolverEmpleado());
            return itemsList;
        }
    }
}