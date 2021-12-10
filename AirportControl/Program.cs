using System;

namespace AirportControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlTower = new ControlTower();
            var tarom = new Airplane();
            var wizzAir = new Airplane();
            var internationalAir = new Airplane();

            controlTower.Register(tarom);
            controlTower.Register(wizzAir);
            controlTower.Register(internationalAir);

            tarom.RequestTakeOff();
            tarom.CompleteTakeOff();
            wizzAir.RequestTakeOff();
            internationalAir.RequestLanding();
            controlTower.CanLanding(tarom);
            controlTower.CanLanding(wizzAir);
            controlTower.HasLanded(tarom);


        }
    }
}
