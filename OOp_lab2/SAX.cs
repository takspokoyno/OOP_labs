using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOp_lab2
{
    class SAX: IStrategy
    {
        private List<JDM> info = new List<JDM>();
        XmlDocument doc = new XmlDocument();
        public SAX(string path)
        {
            doc.Load(path);
        }

        public List<JDM> Algorithm(JDM car, string path)
        {
            info.Clear();
            XmlReader BestReader = XmlReader.Create(path);
            List<JDM> result = new List<JDM>();
            JDM jdm = null;
            string _drive_unit = "aboba";

            while (BestReader.Read())
            {
                if (BestReader.Name == "drive_unit")
                {
                    while (BestReader.MoveToNextAttribute())
                    {
                        if (BestReader.Name == "DRIVE_UNIT")
                        {
                            _drive_unit = BestReader.Value;
                        }
                    }
                }
                if (BestReader.Name == "masterpiece")
                {
                    jdm = new JDM();
                    jdm.Drive_unit = _drive_unit;

                    if (BestReader.HasAttributes)
                    {
                        while (BestReader.MoveToNextAttribute())
                        {
                            if (BestReader.Name == "BRAND")
                            {
                                jdm.Brand = BestReader.Value;
                            }
                            if (BestReader.Name == "MODEL")
                            {
                                jdm.Model = BestReader.Value;
                            }
                            if (BestReader.Name == "ENGINE")
                            {
                                jdm.Engine = BestReader.Value;
                            }
                            if (BestReader.Name == "YEAR")
                            {
                                jdm.Year = BestReader.Value;
                            }
                            if (BestReader.Name == "MAX_SPEED")
                            {
                                jdm.Max_speed = BestReader.Value;
                            }
                            if (BestReader.Name == "PRICE")
                            {
                                jdm.Price = BestReader.Value;
                            }
                        }
                    }
                    if (jdm.Brand != null)
                    {
                        result.Add(jdm);
                    }
                }
            }
            info = Filtr(result, car);
            return info;
        }
        public List<JDM> Filtr(List<JDM> allCar, JDM param)
        {
            List<JDM> result = new List<JDM>();
            if (allCar != null)
            {
                foreach (JDM e in allCar)
                {
                    try
                    {
                        if (
                            (e.Drive_unit == param.Drive_unit || param.Drive_unit == null) &&
                            (e.Brand == param.Brand || param.Brand == null) &&
                            (e.Model == param.Model || param.Model == null) &&
                            (e.Engine == param.Engine || param.Engine == null) &&
                            (e.Year == param.Year || param.Year == null) &&
                            (e.Max_speed == param.Max_speed || param.Max_speed == null) &&
                            (e.Price == param.Price || param.Price == null)
                           )
                        {
                            result.Add(e);
                        }
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}

