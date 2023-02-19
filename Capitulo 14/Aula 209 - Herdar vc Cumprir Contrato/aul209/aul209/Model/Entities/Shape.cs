using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aul209.Model.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }

        public abstract double Area();

    }
}
