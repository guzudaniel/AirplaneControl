using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportControl
{
    public interface IControlTower
    {
        void Register(IAirplane airplane);
        bool CanTakeOff(IAirplane airplane);
        bool CanLanding(IAirplane airplane);
        bool HasLanded(IAirplane airplane);
        bool HasTakeOff(IAirplane airplane);
    }
}
