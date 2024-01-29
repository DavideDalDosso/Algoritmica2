using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Vehicle
{
    public string name { get; set; }
    public string description { get; set; }
    abstract public string GetDepartText();
}
