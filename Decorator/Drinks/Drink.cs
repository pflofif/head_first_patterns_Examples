using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    public abstract class Drink
    {
        public string Description { get; protected set; } = "Unknown Drink";
        public abstract double Cost();
    }
}
