using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AirVehicle : Vehicle
{
    public override string GetDepartText()
    {
        return name + " is ready to soar the skies!";
    }
}
