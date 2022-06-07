using Newtonsoft.Json;
using System;
using System.Xml;
//to convert JSON to XML using Newtonsoft.Json's method
namespace XMLtoJSONAndJSONToXML
{
    class Program
    {
        static string jan()
        {
            string json = @"{
  '?xml': {
    '@version': '1.0',
    '@standalone': 'no'
  },
  'books': {
    'book': [
      {
        'Name' :'Chris Jordan',
        'Age' :'25',
        'Nationality':'US'
      },
      {
        'Name' :'Hari Haran',
        'Age' :'55',
        'Nationality':'IN'
      },
      {
        'Name' :'Roshan Rao',
        'Age' :'25',
        'Nationality':'IN'
      }
    ]
  }
}";
            return json;
        }
        static void Main(string[] args)
        {
            
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(jan());

            Console.WriteLine(doc.OuterXml);
        }
    }
}