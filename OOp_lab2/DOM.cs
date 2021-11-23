using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOp_lab2
{
    class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);
        }

        public List<JDM> Algorithm(JDM car, string path)
        {
            List<List<JDM>> info = new List<List<JDM>>();
            try
            {
                if (car.Drive_unit != null) info.Add(SearchByParam("drive_unit", "DRIVE_UNIT", car.Drive_unit, doc, 0));
                if (car.Brand != null) info.Add(SearchByParam("masterpiece", "BRAND", car.Brand, doc, 1));
                if (car.Model != null) info.Add(SearchByParam("masterpiece", "MODEL", car.Model, doc, 1));
                if (car.Engine != null) info.Add(SearchByParam("masterpiece", "ENGINE", car.Engine, doc, 1));
                if (car.Year != null) info.Add(SearchByParam("masterpiece", "YEAR", car.Year, doc, 1));
                if (car.Max_speed != null) info.Add(SearchByParam("masterpiece", "MAX_SPEED", car.Max_speed, doc, 1));
                if (car.Price != null) info.Add(SearchByParam("masterpiece", "PRICE", car.Price, doc, 1));
            }
            catch { }
            return Cross(info);
        }

        public static JDM Info(XmlNode node)
        {
            JDM nw = new JDM();
            nw.Drive_unit = node.ParentNode.Attributes.GetNamedItem("DRIVE_UNIT").Value;
            nw.Brand = node.Attributes.GetNamedItem("BRAND").Value;
            nw.Model = node.Attributes.GetNamedItem("MODEL").Value;
            nw.Engine = node.Attributes.GetNamedItem("ENGINE").Value;
            nw.Year = node.Attributes.GetNamedItem("YEAR").Value;
            nw.Max_speed = node.Attributes.GetNamedItem("MAX_SPEED").Value;
            nw.Price = node.Attributes.GetNamedItem("PRICE").Value;
            return nw;
        }
        public static List<JDM> AllCars(XmlDocument doc)
        {
            List<JDM> data2 = new List<JDM>();
            XmlNodeList elem = doc.SelectNodes("//JDM");
            try
            {
                foreach (XmlNode el in elem)
                {
                    data2.Add(Info(el));
                }
            }
            catch { }
            return data2;
        }
        public static List<JDM> SearchByParam(string nodename, string val, string param, XmlDocument doc, int n)
        {
            List<JDM> cars = new List<JDM>();
            if (param != String.Empty && param != null)
            {
                switch (n)
                {
                    case 0:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                        XmlNodeList list2 = e.ChildNodes;
                                        foreach (XmlNode ell in list2)
                                        {
                                            cars.Add(Info(ell));
                                        }
                                }
                            }
                            catch { }
                            return cars;
                        }
                    case 1:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                    cars.Add(Info(e));
                                }
                            }
                            catch { }
                            return cars;

                        }
                    default: break;
                }
            }
            return cars;
        }
        private static List<JDM> Cross(List<List<JDM>> list)
        {
            List<JDM> result = new List<JDM>();
            try
            {
                if (list != null)
                {
                    JDM[] jdm = list[0].ToArray();
                    if (jdm != null)
                    {
                        foreach (JDM elem in jdm)
                        {
                            bool IsIn = true;
                            foreach (List<JDM> t in list)
                            {
                                if (t.Count <= 0) return new List<JDM>();
                                foreach (JDM s in t)
                                {
                                    IsIn = false;
                                    if (elem.Comparing(s))
                                    {
                                        IsIn = true;
                                        break;
                                    }
                                }
                                if (!IsIn) break;
                            }
                            if (IsIn)
                            {
                                result.Add(elem);
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}

