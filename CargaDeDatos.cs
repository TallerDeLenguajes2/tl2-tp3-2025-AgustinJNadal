using espacioCadeteria;
using espacioCadete;

namespace espacioDatos
{
    public class CargaDeDatos
    {
        public CargaDeDatos(){}
        public Cadeteria CargarCadeteriaDesdeCSV(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);

            // Creamos un objeto vacío
            Cadeteria cad = new Cadeteria();

            // Saltamos el encabezado y tomamos solo la primera fila de datos
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] columnas = lineas[i].Split(',');

                string nombre = columnas[0];
                string telefono = columnas[1];

                // Usamos el constructor con parámetros
                cad = new Cadeteria(nombre, telefono);

                break; // solo necesitamos una fila
            }

            return cad;
        }

        public List<Cadete> CargarCadetesDesdeCSV(string ruta){

        string[] lineas = File.ReadAllLines(ruta);
        //Creo la lista
        var listaCadetes = new List<Cadete>();
        for (int i = 1; i < lineas.Length; i++){
            string[] columnas = lineas[i].Split(',');
            int id = int.Parse(columnas[0]); 
            string nombre = columnas[1];
            string direccion = columnas[2];
            string telefono = columnas[3];

            Cadete nuevoCadete = new Cadete(id,nombre,direccion,telefono);
            listaCadetes.Add(nuevoCadete);
        }

        return listaCadetes;
    }
    }

    
}
