using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aul209.Model.Entities
{
    class Retangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }


        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {

            return "Retangle color: "
                    + Color
                    + ", width = "
                    + Width.ToString("F2", CultureInfo.InvariantCulture)
                    + ", height = "
                    + Height.ToString("F2", CultureInfo.InvariantCulture)
                    + ", area = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
