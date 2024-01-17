using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Fuel
{
    public class AddFuelRequests
    {
        public string Name { get; set; }

        public AddFuelRequests(string name)
        {
            Name = name;
        }
    }
}
