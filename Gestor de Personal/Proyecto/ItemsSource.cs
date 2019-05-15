using Proyecto;
using System.Collections.Generic;

namespace ListaEmpleados
{
    class ItemsSource
    {

        // Bind ArrayList with the ListBox    
        List<Empleados> listE;
        List<Empleados> itemsList;
        private List<Empleados> LoadListBoxData()
        {
            Add ventanaAñadir = new Add();
           itemsList = new List<Empleados>();
            itemsList.Add(ventanaAñadir.DevolverEmpleado());
            return itemsList;
        }

      

       
    }
}