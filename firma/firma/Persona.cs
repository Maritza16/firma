using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace firma
{
    class Persona
    {
        
            [PrimaryKey, AutoIncrement]
            public int codigo { get; set; }

            [MaxLength(70)]
            public String nombre { get; set; }
            [MaxLength(70)]
            public String apellido { get; set; }
            public int edad { get; set; }
            [MaxLength(70)]
            public String correo { get; set; }
            [MaxLength(100)]
            public String dirreccion { get; set; }
        
    }
}
