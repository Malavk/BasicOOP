using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_DZ6
{
    class Vehicle
    {
        private int _speed;
        public int Speed
        {
            get { return _speed; }
        }

        public void Accelerate(int mph)
        {
            _speed += mph;
        }

        public void Decelerate(int mph)
        {
            _speed -= mph;
        }

    }
}
