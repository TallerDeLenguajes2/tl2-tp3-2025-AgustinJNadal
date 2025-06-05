using System.Data.Common;

namespace espacioCadete
{
    public class Cadete
    {
        private int id;
        string nombre;
        string direccion;
        string telefono;

        public Cadete(){}

        public Cadete(int id, string nombre, string dir, string tel){
            this.id = id;
            this.nombre = nombre;
            this.direccion = dir;
            this.telefono = tel;
        }

        public int Id { get => id; set => id = value; }

        public string infoCadete(){
            return $"ID: {this.id}, Nombre: {this.nombre}, Direccion: {this.direccion}, Telefono: {this.telefono}";
        }
    }

}