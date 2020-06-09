using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Tiago Nunes Santana", CPF = "777.777.777-77", Email = "tiagosantana@gmail.com" };

            //XmlSerializer serializador = new XmlSerializer(usuario.GetType()); ou
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = new StreamWriter(@"C:\Serializar-Deserializar\Arquivos\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
