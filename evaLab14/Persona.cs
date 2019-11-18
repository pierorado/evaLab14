using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace evaLab14
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha { get; set; }
        public bool Done { get; set; }
    }
}
