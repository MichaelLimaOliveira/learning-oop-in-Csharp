using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4.Exemplo.Override.AnimalNamespace
{
    internal class Bird : Animal
    {
        public Bird(int weight, int height, int  wingHeight, string name) : base(weight, height, name)
        {
            WingHeight = wingHeight;
        }

        public int WingHeight { get; }

        public override string NameToString()
        {
            return $"Bird name is: {Name}";
        }

        public override string Noise()
        {
            return " tweet";
        }
        public override string WalkMode()
        {
            return "Fly";
        }
    }
}
