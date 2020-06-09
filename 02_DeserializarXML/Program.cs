using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Serializar-Deserializar\Arquivos\01_SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario) serializador.Deserialize(stream);

            Console.WriteLine("Usuario Nome: {0}, CPF: {1} e Email: {2} ", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
