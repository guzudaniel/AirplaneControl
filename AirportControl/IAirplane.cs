using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportControl
{
    public interface IAirplane
    {
        string Name { get; set; }
        bool RequestTakeOff();
        bool CompleteTakeOff();
        bool RequestLanding();
        bool CompleteLanding();
    }
}
