using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Alice Freitas Santana", CPF = "333.333.333-33", Email = "alicesantana@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Serializar-Deserializar\Arquivos\02_SerializarJSON.json");
            sw.WriteLine(stringObjSerializado);
            sw.Close();
        }
    }
}
