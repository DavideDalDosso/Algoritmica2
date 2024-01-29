using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GroundVehicle : Vehicle
{
    public override string GetDepartText()
    {
        return name + " is ready to dash on the roads!";
    }
}
