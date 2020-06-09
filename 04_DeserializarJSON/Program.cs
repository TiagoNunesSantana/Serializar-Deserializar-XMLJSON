using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Web.Script.Serialization;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Serializar-Deserializar\Arquivos\02_SerializarJSON.json");
            string linhasDoArquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoArquivo, typeof(Usuario));

            Console.WriteLine("Usuario Nome: {0}, CPF: {1} e Email: {2} ", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
