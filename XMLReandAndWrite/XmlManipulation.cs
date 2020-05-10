using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows;

namespace XMLReandAndWrite
{
    class XmlManipulation
    {
        public void WriteToXml()
        {
            using (XmlTextWriter textWriter = new XmlTextWriter("test.xml", null))
            {
                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("Hello", "");
                textWriter.WriteString("Hello Battula");
                textWriter.WriteEndElement();

                ////textWriter.WriteElementString("Ravi","Hello Ravi");            

                textWriter.WriteEndDocument();
                textWriter.Close();
            }
        }

        /// <summary>
        /// Reads from XML.
        /// </summary>
        public void ReadFromXml()
        {
            using (XmlTextReader textReader = new XmlTextReader("test.xml"))
            {
                while (textReader.Read())
                {
                    MessageBox.Show(textReader.Name);
                }

                textReader.Close();
            }
        }

        public void ReadXmlFile()
        {
            using (XmlTextReader reader = new XmlTextReader("HourQuery 2014-01-03 12.00.01Z 1.xml"))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("<" + reader.Name);
                            Console.WriteLine(">");
                            if (reader.Name == "Tags")
                            {
                                Console.WriteLine(reader.NamespaceURI);
                            }

                            if (reader.Name == "EndTime")
                            {
                                Console.WriteLine(reader.NamespaceURI);
                            }

                            break;

                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;

                        case XmlNodeType.EndElement:
                            Console.WriteLine("</" + reader.Name);
                            Console.WriteLine(">");
                            if (reader.Name == "StartTime")
                            {
                                return;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void WriteXML()
        {
            System.IO.StreamReader stream = new System.IO.StreamReader("analysen.xml");
            XmlTextReader reader = new XmlTextReader(stream);
            using (XmlTextWriter writer = new XmlTextWriter("analysenNew.xml", null))
            {
                writer.WriteStartDocument();
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("<" + reader.Name);
                            Console.WriteLine(">");
                            writer.WriteStartElement(reader.Name);
                            break;

                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            writer.WriteString(reader.Value);
                            break;

                        case XmlNodeType.EndElement:
                            Console.WriteLine("</" + reader.Name);
                            Console.WriteLine(">");
                            writer.WriteEndElement();
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}
