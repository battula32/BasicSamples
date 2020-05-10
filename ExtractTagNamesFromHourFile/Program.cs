using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Linq;

namespace ExtractTagNamesFromHourFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtractHourTags();
            FileStream fileStream = new FileStream("HourlyTags.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fileStream);
            sr.ReadLine();
            List<string> tagList = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                string[] values = line.Split('\t');
                if (values.Length > 0)
                {
                    tagList.Add(values[0]);
                }
            }

            FileStream filePointsStream = new FileStream("PEPointConfig_Def.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader srPoint = new StreamReader(filePointsStream);
            srPoint.ReadLine();
            List<string> pointList = new List<string>();
            while (!srPoint.EndOfStream)
            {
                string line = srPoint.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                line = line.Replace("\0", "");

                string[] values = line.Split('\t');
                if (values.Length <= 1)
                {
                    continue;
                }

                pointList.Add(values[1]);
            }

            List<string> matchingTags = new List<string>();
            foreach (var item in pointList)
            {
                if (tagList.Contains(item))
                {
                    matchingTags.Add(item);
                }
            }

            Console.Read();
        }

        private static void ExtractHourTags()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("HourQuery 2015-02-12 07.00.00Z 4.xml");
            XmlNode root = doc.FirstChild;
            XmlNodeList tagsList = doc.GetElementsByTagName("Tag");
            int count = 0;
            using (StreamWriter sw = new StreamWriter("HourlyTags.csv", true, Encoding.Unicode))
            {
                foreach (XmlNode tagNode in tagsList)
                {
                    XmlNode tagChild = tagNode.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.LocalName == "Designation");

                    if (tagChild == null)
                    {
                        sw.WriteLine();
                        count++;
                        continue;
                    }

                    sw.Write(tagChild.InnerXml);
                    sw.Write('\t');
                    XmlNode tenSecondNode = tagNode.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.LocalName == "TenSeconds");
                    bool isValueNodeNull = false;
                    if (tenSecondNode != null)
                    {
                        if (tenSecondNode.HasChildNodes)
                        {
                            foreach (XmlNode tenSecondChild in tenSecondNode.ChildNodes)
                            {
                                XmlNode valueNode = tenSecondChild.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.LocalName.Equals("Value"));

                                if (valueNode == null)
                                {
                                    isValueNodeNull = true;
                                }
                                else
                                {
                                    if (valueNode.InnerXml.Equals("NaN", StringComparison.OrdinalIgnoreCase))
                                    {
                                        isValueNodeNull = true;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        sw.Write("Ten soconds node is null");
                    }

                    if (isValueNodeNull)
                    {
                        sw.Write("Values are null");
                    }

                    sw.WriteLine();
                }
            }
        }
    }
}
