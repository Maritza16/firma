using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace firma.Models
{
    public class firma
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public string name { get; set; }

        [MaxLength(250)]
        public string descripcion { get; set; }

        //public byte[]  MiImagen { get; set; }

        public byte[] MiImagen { get; set; }
    }
}
