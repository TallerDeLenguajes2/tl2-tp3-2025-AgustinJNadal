using espacioDatos;
using espacioCadete;

namespace espacioCadeteria
{
    public class Cadeteria 
    {
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListadoCadetes;

        public Cadeteria(){}
        public Cadeteria( string nombre, string tel){
            this.Nombre = nombre;
            this.Telefono = tel;
            CargaDeDatos MiCargaDeDatos = new CargaDeDatos();
            this.ListadoCadetes = MiCargaDeDatos.CargarCadetesDesdeCSV("InfoCadetes.csv");
        }

        public string infoCadeteria(){
            return "CADETERIA\n, Nombre:" + this.Nombre + "\n, Telefono:" + this.Telefono + "\n LISTADO DE CADETES: ";
            
            /**Console.WriteLine("CADETERIA");
            Console.WriteLine("Nombre: "  + this.Nombre);
            Console.WriteLine("Telefono: "  + this.Telefono);
            //MostrarCadetes
            Console.WriteLine("LISTADO DE CADETES");*/
        }  

        public string ListaCadetes(){  
            foreach (var cadete in this.ListadoCadetes)
            {
                return cadete.infoCadete();
            }
            return "";
        }
    }
}

