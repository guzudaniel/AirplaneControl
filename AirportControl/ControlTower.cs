using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportControl
{
    public class ControlTower : IControlTower
    {
        private List<IAirplane> _airplanes = new List<IAirplane>();
        private bool _landing = false;
        private bool _takeOff = false;
        public void Register(IAirplane airplane)
        {
            if (!_airplanes.Contains(airplane))
            {
                 _airplanes.Add(airplane);
            }
        }
        public bool CanLanding(IAirplane airplane)
        {
            if (airplane.RequestLanding() && _landing == false)
            {
                Console.WriteLine($"{airplane.Name} request landing");
                return true;
                _landing = true;
            }
            else
            {
                Console.WriteLine($"{airplane.Name} request landing but cannot");
                return false;
            }
        }

        public bool CanTakeOff(IAirplane airplane)
        {
            if (airplane.RequestTakeOff() && _takeOff == false)
            {
                Console.WriteLine($"{airplane.Name} request takeOff");
                return true;
                _takeOff = true;
            }
            else
            {
                Console.WriteLine($"{airplane.Name} request takeoff but cannot");
                return false;
            }
        }

        public bool HasLanded(IAirplane airplane)
        {
            if (airplane.CompleteLanding())
            {
                Console.WriteLine($"{airplane.Name} complete landing");
                return true;
                _landing = false;
            }
            else
            
              return false;
            
        }

        public bool HasTakeOff(IAirplane airplane)
        {
            if (airplane.CompleteTakeOff())
            {
                Console.WriteLine($"{airplane.Name} complete takeOff");
                return true;
                _takeOff = false;
            }
            else
                return false;
        }
    }
}
