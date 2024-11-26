using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desain_Rahma
{
    internal class koneksi
    {
        public static string conn = "Data Source = DESKTOP-GK90TOH\\SQLEXPRESS; Initial Catalog = rahma_perpusdb; Integrated Security = true; TrustServerCertificate = True;";
    }
    public class Model
    {
        public static string name { get; set; }
    }
}