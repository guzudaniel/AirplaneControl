using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportControl
{
    class Airplane : IAirplane
    {
        public string Name { get; set; }
        public bool CompleteLanding()
        {
            return true;
        }

        public bool CompleteTakeOff()
        {
            return true;
        }

        public bool RequestLanding()
        {
            return true;
        }

        public bool RequestTakeOff()
        {
            return true;
        }
    }
}
