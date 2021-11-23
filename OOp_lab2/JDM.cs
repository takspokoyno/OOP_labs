using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_lab2
{
    class JDM
    {
        public string Drive_unit = null;
        public string Brand = null;
        public string Model = null;
        public string Engine = null;
        public string Year = null;
        public string Max_speed = null;
        public string Price = null;

        public JDM() { }

        public JDM(string[] data)
        {
         Drive_unit = data[0];
         Brand = data[1];
         Model = data[2];
         Engine = data[3];
         Year = data[4];
         Max_speed = data[5];
         Price = data[6];
        }
        public JDM(IStrategy algo)
        {
            Drive_unit = String.Empty;
            Brand = String.Empty;
            Model = String.Empty;
            Engine = String.Empty;
            Year = String.Empty;
            Max_speed = String.Empty;
            Price = String.Empty;
        }
        public bool Comparing(JDM car)
        {
            if ((this.Drive_unit == car.Drive_unit) &&
                (this.Brand == car.Brand) &&
                (this.Model == car.Model) &&
                (this.Engine == car.Engine) &&
                (this.Year == car.Year) &&
                (this.Max_speed == car.Max_speed) &&
                (this.Price == car.Price)) 
                return true;
            else return false;
        }
        public IStrategy Algo { get; set; }
        public List<JDM> Algorithm(JDM car, string path)
        {
            return Algo.Algorithm(car, path);
        }
    }
}
