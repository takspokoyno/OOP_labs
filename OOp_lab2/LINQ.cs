using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOp_lab2
{
    class LINQ : IStrategy
    {
        List<JDM> info = new List<JDM>();
        XDocument doc = new XDocument();
        public LINQ(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<JDM> Algorithm(JDM car, string path)
        {
            List<XElement> match = (from val in doc.Descendants("masterpiece")
                                   where
                                   ((car.Drive_unit == null || car.Drive_unit == val.Parent.Attribute("DRIVE_UNIT").Value) &&
                                   (car.Brand == null || car.Brand == val.Attribute("BRAND").Value) &&
                                   (car.Model == null || car.Model == val.Attribute("MODEL").Value) &&
                                   (car.Engine == null || car.Engine == val.Attribute("ENGINE").Value) &&
                                   (car.Year == null || car.Year == val.Attribute("YEAR").Value) &&
                                   (car.Max_speed == null || car.Max_speed == val.Attribute("MAX_SPEED").Value) &&
                                   (car.Price == null || car.Price == val.Attribute("PRICE").Value))
                                   select val).ToList();
            foreach (XElement obj in match)
            {
                JDM car1 = new JDM();
                car1.Drive_unit = obj.Parent.Attribute("DRIVE_UNIT").Value;
                car1.Brand = obj.Attribute("BRAND").Value;
                car1.Model = obj.Attribute("MODEL").Value;
                car1.Engine = obj.Attribute("ENGINE").Value;
                car1.Year = obj.Attribute("YEAR").Value;
                car1.Max_speed = obj.Attribute("MAX_SPEED").Value;
                car1.Price = obj.Attribute("PRICE").Value;
                info.Add(car1);
            }
            return info;
        }
    }
}

